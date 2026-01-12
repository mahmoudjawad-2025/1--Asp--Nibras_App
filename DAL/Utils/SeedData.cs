using D_A_L.Data_Base;
using DAL.Models.Entities;
using DAL.Models.Entities.HadithEntities;
using DAL.Models.Entities.QuizEntities;
using DAL.Models.Entities.QuranEntities;
using DAL.Models.Entities.Thikr;
using DAL.Models.Enums;
using DAL.Models.JsonModels;
using DAL.Utils;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Text;

namespace D_A_L.Utils
{
    public class SeedData : ISeedData
    {
        private readonly ApplicationDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManger;
        private readonly UserManager<User> _userManager;
        private readonly IUtilsService _utilsService;

        public SeedData(ApplicationDbContext context, RoleManager<IdentityRole> roleManger, UserManager<User> userManager, IUtilsService utilsService)
        {
            _context = context;
            _roleManger = roleManger;
            _userManager = userManager;
            _utilsService = utilsService;
        }


        //-------------------------------------------------------------------------- DataSeedingAsync
        public async Task DataSeedingAsync()
        {
            if ((await _context.Database.GetPendingMigrationsAsync()).Any())
                await _context.Database.MigrateAsync();

            // Categories
            if (!await _context.Categories.AnyAsync())
            {
                await _context.Categories.AddRangeAsync(
                    new Category { Name = "Ethics", MainImage = "sample1.jpg" },
                    new Category { Name = "Transfeer", MainImage = "sample2.jpg" }
                );
                await _context.SaveChangesAsync();
            }

            // Courses
            if (!await _context.Courses.AnyAsync())
            {
                var ethics = await _context.Categories.FirstAsync(c => c.Name == "Ethics");
                var transfer = await _context.Categories.FirstAsync(c => c.Name == "Transfeer");

                await _context.Courses.AddRangeAsync(
                    new Course
                    {
                        Title = "Course 1",
                        Description = "Temporary description for course 1.",
                        CategoryId = ethics.Id,
                        MainImage = "sample3.jpg"
                    },
                    new Course
                    {
                        Title = "Course 2",
                        Description = "Temporary description for course 2.",
                        CategoryId = transfer.Id,
                        MainImage = "sample1.jpg"
                    }
                );
                await _context.SaveChangesAsync();
            }

            // Lessons
            if (!await _context.Lessons.AnyAsync())
            {
                var course1 = await _context.Courses.FirstAsync(c => c.Title == "Course 1");
                var course2 = await _context.Courses.FirstAsync(c => c.Title == "Course 2");

                var lesson1 = new Lesson
                {
                    Title = "Lesson 1",
                    ContentText = "Sample text for lesson 1",
                    CourseId = course1.Id,
                    Files = new List<LocalFile>
                    {
                        new LocalFile { FileName = "sample1.m4a", FileType = FilesTypes.Audio },
                        new LocalFile { FileName = "sample1.mp4", FileType = FilesTypes.Video }
                    }
                };

                var lesson2 = new Lesson
                {
                    Title = "Lesson 2",
                    ContentText = "Sample text for lesson 2",
                    CourseId = course2.Id,
                    Files = new List<LocalFile>
            {
                new LocalFile { FileName = "sample3.mp3", FileType = FilesTypes.Audio },
                new LocalFile { FileName = "sample1.mp4", FileType = FilesTypes.Video }
            }
                };

                await _context.Lessons.AddRangeAsync(lesson1, lesson2);
                await _context.SaveChangesAsync();
            }

            // Quizes
            if (!await _context.Quizes.AnyAsync())
            {
                var lesson1 = await _context.Lessons.FirstAsync(l => l.Title == "Lesson 1");
                var lesson2 = await _context.Lessons.FirstAsync(l => l.Title == "Lesson 2");

                await _context.Quizes.AddRangeAsync(
                    new Quiz { Title = "Quize 1", LessonId = lesson1.Id },
                    new Quiz { Title = "Quize 2", LessonId = lesson2.Id }
                );
                await _context.SaveChangesAsync();
            }

            // Questions
            if (!await _context.Questions.AnyAsync())
            {
                var quiz1 = await _context.Quizes.FirstAsync(q => q.Title == "Quize 1");

                await _context.Questions.AddRangeAsync(
                    new Question
                    {
                        Text = "What is first surah name in Quran?",
                        CorrectAnswer = "a",
                        QuizId = quiz1.Id,
                        Options = new List<string>
                        {
                            "Al-Fatiha",
                            "Al-Baqarah",
                            "An-Nas",
                            "Al-Ikhlas"
                        }
                    },
                    new Question
                    {
                        Text = "How many pillars of Islam are there?",
                        CorrectAnswer = "c",
                        QuizId = quiz1.Id,
                        Options = new List<string>
                        {
                            "4",
                            "6",
                            "5",
                            "7"
                        }
                    }
                );
                await _context.SaveChangesAsync();
            }
        }



        //-------------------------------------------------------------------------- IdentityDataSeedingAsync
        public async Task IdentityDataSeedingAsync()
        {
            if (!await _roleManger.Roles.AnyAsync())
            {
                await _roleManger.CreateAsync(new IdentityRole("SuperAdmin"));
                await _roleManger.CreateAsync(new IdentityRole("Admin"));
                await _roleManger.CreateAsync(new IdentityRole("Student"));
            }

            if (!await _userManager.Users.AnyAsync())
            {
                var user1 = new User()
                {
                    FullName = "Mahmoud Jawad",
                    Email = "mahmoudjawad02025@gmail.com",
                    PhoneNumber = "0599777707",
                    UserName = "m.jawad",
                    EmailConfirmed = true,
                };
                var user2 = new User()
                {
                    FullName = "Omar Sameer",
                    Email = "o.sameer@outlook.com",
                    PhoneNumber = "0598123444",
                    UserName = "o.sameer",
                    EmailConfirmed = true,
                };
                var user3 = new User()
                {
                    FullName = "Zakaria Ahmad",
                    Email = "z.ahmad@outlook.com",
                    PhoneNumber = "0599778834",
                    UserName = "z.ahmad",
                    EmailConfirmed = true,
                };
                await _userManager.CreateAsync(user1, "mmmm");
                await _userManager.CreateAsync(user2, "Pass@2222");
                await _userManager.CreateAsync(user3, "Pass@3333");

                await _userManager.AddToRoleAsync(user1, "SuperAdmin");
                await _userManager.AddToRoleAsync(user2, "Admin");
                await _userManager.AddToRoleAsync(user3, "Student");
            }
        }



        //-------------------------------------------------------------------------- SeedQuranIfEmptyAsync
        public async Task SeedQuranIfEmptyAsync(ApplicationDbContext db, string quranJsonPath, ILogger logger = null)
        {
            if (db.Surahs.Any() || db.Ayahs.Any())
            {
                logger?.LogDebug("Quran tables already seeded.");
                return;
            }

            if (!File.Exists(quranJsonPath))
            {
                logger?.LogError($"Quran JSON not found at {quranJsonPath}");
                return;
            }

            var json = await File.ReadAllTextAsync(quranJsonPath, Encoding.UTF8);
            var surahs = JsonConvert.DeserializeObject<SurahJsonModel[]>(json);

            int globalCounter = 0;

            foreach (var s in surahs)
            {
                // Create Surah entity
                var surah = new Surah
                {
                    Number = s.Id,
                    Name = s.Name,
                    EnglishName = s.Transliteration,
                    EnglishNameTranslation = s.Transliteration, 
                    RevelationPlace = s.Type,
                    AyahCount = s.Total_Verses,
                    Ayahs = s.Verses.Select((v, index) =>
                    {
                        globalCounter++;
                        return new Ayah
                        {
                            SurahNumber = s.Id,
                            NumberInSurah = v.Id,
                            GlobalNumber = globalCounter,
                            Text = v.Text,
                            NormalizedText = _utilsService.NormalizeArabic(v.Text)
                        };
                    }).ToList()

                };

                db.Surahs.Add(surah);
            }

            await db.SaveChangesAsync();
            logger?.LogInformation("Seeded Quran data successfully.");
        }



        //-------------------------------------------------------------------------- SeedHadithIfEmptyAsync
        public async Task SeedHadithIfEmptyAsync(ApplicationDbContext db, string hadithDirPath, ILogger logger = null)
        {
            if (db.HadithBooks.Any())
            {
                logger?.LogDebug("Hadith data already seeded.");
                return;
            }

            if (!Directory.Exists(hadithDirPath))
            {
                logger?.LogError($"Hadith directory not found at {hadithDirPath}");
                return;
            }

            var files = Directory.GetFiles(hadithDirPath, "*.json", SearchOption.TopDirectoryOnly);

            foreach (var file in files)
            {
                var json = await File.ReadAllTextAsync(file, Encoding.UTF8);
                var hadithRoot = JsonConvert.DeserializeObject<HadithJsonRoot>(json);

                var book = new HadithBook
                {
                    ArabicTitle = hadithRoot.Metadata.Arabic.Title,
                    ArabicAuthor = hadithRoot.Metadata.Arabic.Author,
                    ArabicIntroduction = hadithRoot.Metadata.Arabic.Introduction,
                    EnglishTitle = hadithRoot.Metadata.English.Title,
                    EnglishAuthor = hadithRoot.Metadata.English.Author,
                    EnglishIntroduction = hadithRoot.Metadata.English.Introduction,
                    Chapters = new List<HadithChapter>(),
                    Hadiths = new List<Hadith>()
                };

                foreach (var c in hadithRoot.Chapters)
                {
                    var chapter = new HadithChapter
                    {
                        ArabicTitle = c.Arabic,
                        EnglishTitle = c.English,
                        Hadiths = new List<Hadith>()
                    };

                    foreach (var h in hadithRoot.Hadiths.Where(x => x.ChapterId == c.Id))
                    {
                        var hadith = new Hadith
                        {
                            IdInBook = (int)h.IdInBook,
                            ArabicText = h.Arabic,
                            NormalizedText = _utilsService.NormalizeArabic(h.Arabic),
                            EnglishNarrator = h.English.Narrator,
                            EnglishText = h.English.Text,
                            HadithChapter = chapter,
                            HadithBook = book
                        };

                        chapter.Hadiths.Add(hadith);
                        book.Hadiths.Add(hadith);
                    }

                    book.Chapters.Add(chapter);
                }

                db.HadithBooks.Add(book);
            }

            await db.SaveChangesAsync();
            logger?.LogInformation("Seeded multiple Hadith books successfully.");
        }


        //-------------------------------------------------------------------------- SeedAdhkarIfEmptyAsync
        public async Task SeedAdhkarIfEmptyAsync(ApplicationDbContext db, string adhkarJsonPath, ILogger logger = null)
        {
            if (db.ThikrCategories.Any())
            {
                logger?.LogDebug("Adhkar already seeded.");
                return;
            }

            if (!File.Exists(adhkarJsonPath))
            {
                logger?.LogError($"Adhkar JSON not found at {adhkarJsonPath}");
                return;
            }

            var json = await File.ReadAllTextAsync(adhkarJsonPath, Encoding.UTF8);
            var root = JsonConvert.DeserializeObject<Dictionary<string, ThikrJsonModel>>(json);

            foreach (var category in root)
            {
                var catEntity = new ThikrCategory
                {
                    Title = category.Key,
                    NormalizedText = _utilsService.NormalizeArabic(category.Key),
                    AudioUrl = category.Value.Audio,
                    ThikrItems = category.Value.Adhkar.Select(a => new ThikrItem
                    {
                        Text = a.Text,
                        NormalizedText = _utilsService.NormalizeArabic(a.Text),
                        Count = a.Count,
                        Reference = a.Reference
                    }).ToList()
                };

                db.ThikrCategories.Add(catEntity);
            }

            await db.SaveChangesAsync();
            logger?.LogInformation("Seeded Adhkar data successfully.");
        }

    }
}
