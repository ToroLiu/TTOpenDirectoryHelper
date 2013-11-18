using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using OpenDirectoryHelper.Properties;
using Newtonsoft.Json;
using System.Diagnostics;

namespace OpenDirectoryHelper.Models
{
    internal class Context
    {
        public void LoadCurrentSetting() {
            string curPath = Settings.Default.CurrentSettingFile;
            LoadSetting(curPath);
        }

        public void LoadSetting(string filePath) {
            bool isExist = File.Exists(filePath);
            if (!isExist)
            {
                return;
            }
            
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            using (StreamReader sr = new StreamReader(fs))
            {
                string json = sr.ReadToEnd();
                this.DirItemList = JsonConvert.DeserializeObject<List<DirItem>>(json);
            }

            Settings.Default.CurrentSettingFile = filePath;
            Settings.Default.Save();
        }

        public void SaveSetting(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            using (StreamWriter sw = new StreamWriter(fs)) {
                string json = JsonConvert.SerializeObject(this.DirItemList);
                sw.Write(json);
            }

            Settings.Default.CurrentSettingFile = filePath;
            Settings.Default.Save();
        }

        #region Properties
        public List<DirItem> DirItemList { get; private set; }
        #endregion

        public Context()
        {
            DirItemList = new List<DirItem>();
        }

        public void OpenPath(string path)
        {
            bool exist = Directory.Exists(path);
            if (!exist)
                return;

            Process.Start(path);
        }
    }
}
