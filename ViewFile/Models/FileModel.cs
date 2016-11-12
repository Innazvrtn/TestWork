using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewFile.Models
{
    public class FileModel
    {
        private string filesize;
        public string FileName { get; set; }
        public string FullName { get; set; }
        public string FileSize { get { return (Convert.ToDouble(filesize) / 1048576).ToString(); } set { filesize = value; } }
    }
}