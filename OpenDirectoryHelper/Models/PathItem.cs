using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDirectoryHelper.Models
{
    public class PathItem
    {
        public bool UseSpecialFolder { get; set; }
        public Environment.SpecialFolder SpecialFolder { get; set; }
        public string PathStr { get; set; }

        public PathItem()
        {
            UseSpecialFolder = false;
            SpecialFolder = Environment.SpecialFolder.MyDocuments;
            PathStr = null;
        }
    }
}
