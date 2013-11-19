using OpenDirectoryHelper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenDirectoryHelper
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            ResetListView();
        }
        private void ResetListView() {
            this.olvDirItems.SetObjects(Context.Current.DirItemList);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Save current settings....
            Context.Current.SaveCurrentSetting();

            Application.Exit();
        }

        #region Save & Load Settings
        private void btnLoad_Click(object sender, EventArgs e)
        {
            // load settings
            string loadDir = Context.Current.GetLastLoadPath();

            var dlg = new OpenFileDialog();
            dlg.Filter = Context.FileFilter;
            dlg.InitialDirectory = loadDir;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string path = dlg.FileName;
                Context.Current.LoadSetting(path);
                Context.Current.SetLastLoadPath(path);

                ResetListView();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // save setting to files.
            string saveDir = Context.Current.GetLastSavePath();
            var dlg = new SaveFileDialog();
            dlg.Filter = Context.FileFilter;
            dlg.InitialDirectory = saveDir;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string path = dlg.FileName;
                Context.Current.SaveSetting(path);
                Context.Current.SetLastSavePath(path);
            }
            
        }
        #endregion

        #region Operators
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // add dir item
            DirItemConfigureForm child = new DirItemConfigureForm();
            if (child.ShowDialog() != DialogResult.OK)
                return;
            
            var item = child.TheItem;
            Context.Current.AddDirItem(item);
            ResetListView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // edit selected dir item
            DirItem selItem = this.olvDirItems.SelectedObject as DirItem;
            if (selItem == null)
                return;

            DirItemConfigureForm child = new DirItemConfigureForm(selItem);
            if (child.ShowDialog() != DialogResult.OK)
                return;

            ResetListView();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // remove selected dir item.
            DirItem selItem = this.olvDirItems.SelectedObject as DirItem;
            if (selItem == null)
                return;
            
            Context.Current.RemoveDirItem(selItem);
            ResetListView();
        }
        #endregion

        private void olvDirItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DirItem selItem = this.olvDirItems.SelectedObject as DirItem;
            if (selItem == null)
                return;

            bool done = Context.Current.OpenDirItem(selItem);
            if (!done)
            {
                MessageBox.Show("Failed to open the directory. It is non-existed.");
            }
        }
    }
}
