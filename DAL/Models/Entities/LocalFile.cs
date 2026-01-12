using DAL.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Entities
{
    public class LocalFile : BaseModel
    {
        public string FileName { get; set; }
        public FilesTypes FileType { get; set; }
        public int LessonId { get; set; }

        public Lesson Lesson { get; set; }
    }

}
