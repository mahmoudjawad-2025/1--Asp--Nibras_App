

namespace DAL.Models.Entities
{
    public class Category : BaseModel
    {
        public string Name { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
        public int coursesCount => Courses.Count;
        //img
        public string MainImage { get; set; }
    }
}
