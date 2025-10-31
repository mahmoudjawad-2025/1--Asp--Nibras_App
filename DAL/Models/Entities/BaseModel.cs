using DAL.Models.Enums;

namespace DAL.Models.Entities
{
    
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime createAt { get; set; } = DateTime.Now;
        public Status status { get; set; }=Status.active;

    }
}
