

namespace DAL.Models.Entities
{
    public class Course : BaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        public ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();

        public int LessonsCount=> Lessons.Count;
        //img
        public string MainImage { get; set; }

    }
}
