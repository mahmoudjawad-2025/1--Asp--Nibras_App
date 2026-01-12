using D_A_L.Data_Base;
using D_A_L.Repositories.Classes;
using DAL.Models.DTO.Requests.Quiz;
using DAL.Models.Entities.QuizEntities;
using DAL.Repositories.Interfaces;
using DAL.Utils;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Classes
{
    public class QuizRepository : GenericRepository<Quiz>, IQuizRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IUtilsService _utilsService;

        public QuizRepository(ApplicationDbContext db, IUtilsService utilsService) : base(db, utilsService)
        {
            _context = db;
            _utilsService = utilsService;
        }


        //-------------------------------------------------------------------------- CreateWithInclude
        public async Task<Quiz> CreateWithIncludeAsync(Quiz entity, List<QuestionRequest> newQuestions)
        {
            var lesson = await _context.Lessons.FirstOrDefaultAsync(l => l.Id == entity.LessonId);
            if (lesson == null)
                throw new Exception("Lesson not found.");

            foreach (var qReq in newQuestions)
            {
                var newQ = new Question
                {
                    Text = qReq.Text,
                    CorrectAnswer = qReq.CorrectAnswer,
                    Options = qReq.Options
                };
                entity.Questions.Add(newQ);
            }

            await _context.Quizes.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }


        //-------------------------------------------------------------------------- UpdateWithInclude
        public async Task<Quiz> UpdateWithIncludeAsync(int id, Quiz entity, List<QuestionRequest> newQuestions)
        {
            var quiz = await _context.Quizes
                .Include(q => q.Questions)
                .FirstOrDefaultAsync(q => q.Id == id);

            if (quiz == null)
                throw new Exception("Quiz not found.");

            var lesson = await _context.Lessons.FirstOrDefaultAsync(l => l.Id == entity.LessonId);
            if (lesson == null)
                throw new Exception("Lesson not found.");

            // Update quiz fields
            quiz.Title = entity.Title;
            quiz.LessonId = entity.LessonId;

            // Replace questions
            quiz.Questions.Clear();
            foreach (var qReq in newQuestions)
            {
                quiz.Questions.Add(new Question
                {
                    Text = qReq.Text,
                    CorrectAnswer = qReq.CorrectAnswer,
                    Options = qReq.Options
                });
            }

            await _context.SaveChangesAsync();
            return quiz;
        }



    }
}
