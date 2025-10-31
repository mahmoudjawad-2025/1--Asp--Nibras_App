
using B_L_L.Services.Classes;
using B_L_L.Services.Interfaces;
using BLL.Services.Classes;
using BLL.Services.Interfaces;
using D_A_L.Data_Base;
using D_A_L.Repositories.Classes;
using D_A_L.Repositories.Interfaces;
using D_A_L.Utils;
using DAL.Models.Entities;
using DAL.Repositories.Classes;
using DAL.Repositories.Interfaces;
using DAL.Utils;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Scalar.AspNetCore;
using System.Text;
using System.Text.Json;
using System.Text.Unicode;

namespace P_L
{
    public class Program
    {
        public static async Task Main(string[] args)
        {

            //-------------------------------------------------------------------------- MAIN 
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(UnicodeRanges.All);
                options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            });
            builder.Services.AddOpenApi();
            var userPolicy = "userPolicy";
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: userPolicy, policy =>
                {
                    policy.AllowAnyOrigin();
                });
            });



            //-------------------------------------------------------------------------- database
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));



            //--------------------------------------------------------------------------  Dependency Injection Setup
            builder.Services.AddScoped<ICategoryRepository,CategoryRepository>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<IFileService, B_L_L.Services.Classes.FileService>();
            builder.Services.AddScoped<ISeedData, SeedData>();
            builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
            builder.Services.AddScoped<IEmailSender, EmailSending>();
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();

            builder.Services.AddMemoryCache();
            builder.Services.AddScoped<IQuranRepository, QuranRepository>();
            builder.Services.AddScoped<IQuranService, QuranService>();
            builder.Services.AddScoped<ICourseRepository, CourseRepository>();
            builder.Services.AddScoped<ICourseService, CourseService>();
            builder.Services.AddScoped<ILessonRepository, LessonRepository>();
            builder.Services.AddScoped<ILessonService, LessonService>();
            builder.Services.AddScoped<IQuizRepository, QuizRepository>();
            builder.Services.AddScoped<IQuizService, QuizService>();

            builder.Services.AddScoped<IHadithRepository, HadithRepository>();
            builder.Services.AddScoped<IHadithService, HadithService>();
            builder.Services.AddScoped<IHadithChapterRepository, HadithChapterRepository>();
            builder.Services.AddScoped<IHadithChapterService, HadithChapterService>();
            builder.Services.AddScoped<IHadithBookRepository, HadithBookRepository>();
            builder.Services.AddScoped<IHadithBookService, HadithBookService>();

            builder.Services.AddScoped<IThikrCategoryRepository, ThikrCategoryRepository>();
            builder.Services.AddScoped<IThikrCategoryService, ThikrCategoryService>();
            builder.Services.AddScoped<IThikrItemRepository, ThikrItemRepository>();
            builder.Services.AddScoped<IThikrItemService, ThikrItemService>();
            builder.Services.AddScoped<IUserProgressRepository, UserProgressRepository>();
            builder.Services.AddScoped<IUserProgressService, UserProgressService>();
            builder.Services.AddScoped<IUtilsService, UtilsService>();
            builder.Services.AddScoped<IAuthRepository, AuthRepository>();


            builder.Services.AddHttpContextAccessor();


            //-------------------------------------------------------------------------- identity 
            // settings
            builder.Services.AddIdentity<User,IdentityRole>(options =>
            {
                options.Password.RequiredLength = 4;
                options.Password.RequireDigit = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = true;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);
                options.Lockout.MaxFailedAccessAttempts = 5;
            }
            ).AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

            //identity - auth
            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(builder.Configuration.GetSection("jwtOptions")["SecretKey"]))
                };
            });



            //--------------------------------------------------------------------------  app
            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.MapScalarApiReference();
            }



            //--------------------------------------------------------------------------  seedData 
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                // Get all required services
                var db = services.GetRequiredService<ApplicationDbContext>();
                var seedDataObject = services.GetRequiredService<ISeedData>();
                var env = services.GetRequiredService<IWebHostEnvironment>();
                var logger = services.GetService<ILoggerFactory>()?.CreateLogger("DbInitializer");

                // Run migrations first
                db.Database.Migrate();

                // Then run your seed data operations
                var quranPath = Path.Combine(env.WebRootPath, "data/quran.json");
                await seedDataObject.SeedQuranIfEmptyAsync(db, quranPath, logger);

                // Hadith 
                var hadithPath = Path.Combine(env.WebRootPath, "data/hadith/");
                await seedDataObject.SeedHadithIfEmptyAsync(db, hadithPath, logger);

                // Thikr 
                var thikrPath = Path.Combine(env.WebRootPath, "data/thikr/hisn_with_audio.json");
                await seedDataObject.SeedAdhkarIfEmptyAsync(db, thikrPath, logger);

                // others
                await seedDataObject.DataSeedingAsync();
                await seedDataObject.IdentityDataSeedingAsync();
            }



            //--------------------------------------------------------------------------  last part
            app.UseHttpsRedirection();
            app.UseAuthentication();
            // midlware
            app.Use(async (context, next) =>
            {
                var authHeader = context.Request.Headers["Authorization"].FirstOrDefault();
                if (authHeader?.StartsWith("Bearer ") == true)
                {
                    var token = authHeader.Substring("Bearer ".Length).Trim();

                    // Check if token is in revoked list
                    if (AuthenticationService.IsTokenRevoked(token))
                    {
                        context.Response.StatusCode = 401;
                        await context.Response.WriteAsync("Token has been revoked");
                        return;
                    }
                }
                await next();
            });
            
            app.UseCors(userPolicy);
            app.UseAuthorization();
            app.UseStaticFiles();
            app.MapControllers();
            app.Run();
        }
    }
}
