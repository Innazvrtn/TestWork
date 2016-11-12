using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ViewFile.Models;

namespace ViewFile.Controllers
{
    public class FileController : ApiController
    {
        public ExpModel Get()
        {
            var dir = new DirectoryInfo(@"E:\");
            var files = new List<string>();  
            List<FileModel> browsee = new List<FileModel>();
            List<DirModel> browseeDir = new List<DirModel>();
            foreach (FileInfo file in dir.GetFiles()) 
            {
                FileModel h = new FileModel();
                h.FileName = file.Name;
                h.FileSize = file.Length.ToString();
                h.FullName =  file.FullName;
                browsee.Add(h); 
            }
            foreach (DirectoryInfo file in dir.GetDirectories())
            {
                DirModel h = new DirModel();
                h.DirName = file.Name;
                browseeDir.Add(h);
            }
            ExpModel browses = new ExpModel(browseeDir, browsee);
        
            return browses;
        }
    }
}
