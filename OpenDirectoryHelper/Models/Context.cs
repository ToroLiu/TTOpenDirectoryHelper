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
        public const string FileFilter = "Setting Files (*.odh)|*.odh";

        #region Settings
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
            using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
            {
                string json = sr.ReadToEnd();
                this.DirItemList = JsonConvert.DeserializeObject<List<DirItem>>(json);
            }

            Settings.Default.CurrentSettingFile = filePath;
            Settings.Default.Save();

            this.HasSettingFile = true;
        }

        public void SaveSetting(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8)) {
                string json = JsonConvert.SerializeObject(this.DirItemList);
                sw.Write(json);
            }

            Settings.Default.CurrentSettingFile = filePath;
            Settings.Default.Save();

            this.HasSettingFile = true;
        }

        public string GetLastLoadPath() {
            string path = Settings.Default.LastLoadPath;
            if (string.IsNullOrEmpty(path)) {
                path = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
                Settings.Default.LastLoadPath = path;
                Settings.Default.Save();
            }

            return path;
        }
        public void SetLastLoadPath(string loadPath)
        {
            string path = Path.GetDirectoryName(loadPath);
            Settings.Default.LastLoadPath = path;
            Settings.Default.Save();
        }

        public string GetLastSavePath() {
            string path = Settings.Default.LastSavePath;
            if (string.IsNullOrEmpty(path))
            {
                path = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
                Settings.Default.LastSavePath = path;
                Settings.Default.Save();
            }
            return path;
        }

        public void SetLastSavePath(string savePath)
        {
            string path = Path.GetDirectoryName(savePath);
            Settings.Default.LastSavePath = path;
            Settings.Default.Save();
        }

        #endregion

        #region Properties
        public List<DirItem> DirItemList { get; private set; }
        public bool HasSettingFile { get; private set; }
        public bool IsDirty { get; private set; }
        #endregion

        #region Ctor
        private static readonly Lazy<Context> _lazy = new Lazy<Context>(() => {
            var item = new Context();
            return item;
        });
        public static Context Current { get { return _lazy.Value; } }
        private Context()
        {
            HasSettingFile = false;
            IsDirty = false;
            DirItemList = new List<DirItem>();
        }
        #endregion

        #region Utility Functions
        public void OpenDirItem(DirItem item)
        {
            // Get path from item
            string path = item.GetPath();

            bool exist = Directory.Exists(path);
            if (!exist)
                return;

            Process.Start(path);
        }
        #endregion

        #region List Management
        public void AddDirItem(DirItem item)
        {
            this.DirItemList.Add(item);

            SetDirty();
        }

        public void RemoveDirItem(DirItem item)
        {
            // TODO
            this.DirItemList.Remove(item);

            SetDirty();
        }
        public void SetDirty() {
            this.IsDirty = true;
        }
        #endregion
    }
}
