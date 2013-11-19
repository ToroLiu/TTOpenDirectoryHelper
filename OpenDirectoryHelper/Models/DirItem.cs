using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            ProjectName = "ProjectName";
            Title = "MyDocuments";
            Description = "Open MyDocuments.";
            Path = new PathItem();
        }

        /// <summary>
        /// 用來識別「唯一性」的pattern。
        /// </summary>
        /// <returns></returns>
        public string DistinctPattern() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ProjectName);
            sb.Append(Title);
            sb.Append(Description);
            sb.Append(Path.GetPath());
            return sb.ToString();
        }

        public string GetPath() {
            Debug.Assert(this.Path != null);

            return Path.GetPath();
        }
    }
}
