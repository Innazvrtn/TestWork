using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ViewFile.Models
{
    [DataContract]
    public class ExpModel
    {
        [DataMember]
        List<DirModel> dirs;
        [DataMember]
        List<FileModel> files;
        public ExpModel(List<DirModel> _dirs, List<FileModel> _files)
        {
            dirs = _dirs;
            files = _files;
        }
    }
}