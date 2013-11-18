using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenDirectoryHelper.Models;
using ES = System.Environment.SpecialFolder;

namespace OpenDirectoryHelper
{
    public partial class DirItemConfigureForm : Form
    {
        public DirItem TheItem { get; set; }        

        public DirItemConfigureForm()
        {
            InitializeComponent();
            InitializeComboItems();
            InitializeModel();
        }

        private void InitializeComboItems() {
            List<ComboItem> itemList = new List<ComboItem>() { 
                new ComboItem(ES.CommonApplicationData, "CommonApplicationData"),
                new ComboItem(ES.CommonDesktopDirectory, "CommonDesktopDirectory"),
                new ComboItem(ES.CommonDocuments, "CommonDocuments"),
                new ComboItem(ES.CommonPictures, "CommonPicture"),
                new ComboItem(ES.CommonProgramFiles, "CommonProgramFiles"),
                new ComboItem(ES.CommonProgramFilesX86, "CommonProgramFilesX86"),
                new ComboItem(ES.CommonPrograms, "CommonPrograms"),
                new ComboItem(ES.CommonStartMenu, "CommonStartMenu"),
                new ComboItem(ES.CommonStartup, "CommonStartup"),
                new ComboItem(ES.Desktop, "Desktop"),
                new ComboItem(ES.DesktopDirectory, "DesktopDirectory"),
                new ComboItem(ES.Favorites, "Favorites"),
                new ComboItem(ES.LocalApplicationData, "LocalApplicationData"),
                new ComboItem(ES.MyComputer, "MyComputer"),
                new ComboItem(ES.MyDocuments, "MyDocuments"),
                new ComboItem(ES.ProgramFiles, "ProgramFiles"),
                new ComboItem(ES.ProgramFilesX86, "ProgramFilesX86"),
                new ComboItem(ES.Programs, "Programs"),
                new ComboItem(ES.System, "System"),
                new ComboItem(ES.SystemX86, "SystemX86"),
                new ComboItem(ES.Windows, "Windows"),
            };

            cboSpecialFolder.Items.Clear();
            foreach (var item in itemList)
            {
                cboSpecialFolder.Items.Add(item);
            }
        }
        private void InitializeModel() {
            if (TheItem == null)
            {
                TheItem = new DirItem();
            }

            this.txtProjectName.Text = TheItem.ProjectName;
            this.txtTitle.Text = TheItem.Title;
            this.txtDescription.Text = TheItem.Description;
            this.chkEnableSpecialFolder.Checked = TheItem.Path.UseSpecialFolder;
            //this.cboSpecialFolder.SelectedValue
            this.txtPathName.Text = TheItem.Path.PathStr;
        }

        private void chkEnableSpecialFolder_CheckedChanged(object sender, EventArgs e)
        {
            cboSpecialFolder.Enabled = chkEnableSpecialFolder.Checked;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }

    public class ComboItem {
        public string Title { get; set; }
        
        public ES Value { get; set; }

        public ComboItem() {}
        public ComboItem(ES value, string title)
        {
            this.Title = title;
            this.Value = value;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
