using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDirectoryHelper.Models
{
    public class DirItem
    {
        public string ProjectName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public PathItem Path { get; set; }

        public DirItem()
        {
            ProjectName = "Sample Project";
            Title = "Sample Title";
            Description = "Sample Description";
            Path = new PathItem();
        }
    }
}
