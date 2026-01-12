using DAL.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.DTO.Responses
{
    public class FileResponse
    {
        public string Url { get; set; } = null!;
        public FilesTypes FileType { get; set; }
    }
}
