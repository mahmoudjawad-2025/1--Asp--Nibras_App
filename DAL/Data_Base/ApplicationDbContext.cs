using DAL.Models.Entities;
using DAL.Models.Entities.HadithEntities;
using DAL.Models.Entities.QuizEntities;
using DAL.Models.Entities.QuranEntities;
using DAL.Models.Entities.Thikr;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace D_A_L.Data_Base
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        //-------------------------------------------------------------------------- DbSet
        public DbSet<Category> Categories { get; set; }
        public DbSet<Surah> Surahs { get; set; }
        public DbSet<Ayah> Ayahs { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Quiz> Quizes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Hadith> Hadiths { get; set; }
        public DbSet<HadithChapter> HadithChapters { get; set; }
        public DbSet<HadithBook> HadithBooks { get; set; }
        public DbSet<ThikrCategory> ThikrCategories { get; set; }
        public DbSet<ThikrItem> ThikrItems { get; set; }
        public DbSet<UserProgress> UserProgresses { get; set; }
        public DbSet<UserToken> UserTokens { get; set; }
        public DbSet<LocalFile> LocalFiles { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //-------------------------------------------------------------------------- onModelCreating
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().ToTable("Users");
            builder.Entity<IdentityRole>().ToTable("Roles");
            builder.Entity<IdentityUserRole<string>>().ToTable("UsersRoles").HasKey(r => new { r.UserId, r.RoleId });
            // ignore
            builder.Ignore<IdentityUserClaim<string>>();
            builder.Ignore<IdentityUserLogin<string>>();
            builder.Ignore<IdentityUserToken<string>>();
            builder.Ignore<IdentityRoleClaim<string>>();

            builder.Entity<Surah>(b =>
            {
                b.HasKey(s => s.Id);
                b.HasIndex(s => s.Number).IsUnique();
                b.Property(s => s.Name).HasMaxLength(250);
            });

            builder.Entity<Ayah>((Action<Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Ayah>>)(b =>
            {
                b.HasKey(a => a.Id);
                b.HasIndex(a => new { a.SurahNumber, a.NumberInSurah }).IsUnique();
                b.Property(a => a.Text).IsRequired();
                b.HasOne(a => a.Surah).WithMany((System.Linq.Expressions.Expression<Func<Surah, IEnumerable<Ayah>?>>?)(s => s.Ayahs)).HasForeignKey(a => a.SurahId).OnDelete(DeleteBehavior.Cascade);
            }));


            builder.Entity<Hadith>(b =>
            {
                b.HasOne(h => h.HadithBook)
                 .WithMany(bk => bk.Hadiths)
                 .HasForeignKey(h => h.HadithBookId) 
                 .OnDelete(DeleteBehavior.NoAction);
            });

            builder.Entity<HadithChapter>(b =>
            {
                b.HasOne(c => c.HadithBook)
                 .WithMany(bk => bk.Chapters)
                 .HasForeignKey(c => c.HadithBookId); 
            });


            builder.Entity<Lesson>()
            .HasMany(l => l.Files)
            .WithOne(f => f.Lesson)
            .HasForeignKey(f => f.LessonId)
            .OnDelete(DeleteBehavior.Cascade);



            base.OnModelCreating(builder);
        }
    }
}
