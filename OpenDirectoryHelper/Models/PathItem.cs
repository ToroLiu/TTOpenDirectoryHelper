using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ES = System.Environment.SpecialFolder;

namespace OpenDirectoryHelper.Models
{
    public class PathItem
    {
        public static readonly ES DefaultSpecialFolder = ES.MyDocuments;

        public bool UseSpecialFolder { get; set; }
        public ES SpecialFolder { get; set; }
        public string PathStr { get; set; }

        public PathItem()
        {
            UseSpecialFolder = true;
            SpecialFolder = DefaultSpecialFolder;
            PathStr = string.Empty; 
        }

        public string GetPath() {
            string path = PathStr;
            if (UseSpecialFolder)
            {
                string dir = Environment.GetFolderPath(this.SpecialFolder);
                path = System.IO.Path.Combine(dir, PathStr);
            } 

            return path;
        }
    }
}
