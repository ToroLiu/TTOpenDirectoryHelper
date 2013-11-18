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

        public DirItemConfigureForm() : this(null) {}
        public DirItemConfigureForm(DirItem item) 
        {
            this.TheItem = item;

            InitializeComponent();
            InitializeComboItems();
            InitializeModel();
        }

        private static readonly List<ComboItem> _itemlist = new List<ComboItem>() { 
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
                new ComboItem(ES.MyDocuments, "MyDocuments"),   ///< Default
                new ComboItem(ES.ProgramFiles, "ProgramFiles"),
                new ComboItem(ES.ProgramFilesX86, "ProgramFilesX86"),
                new ComboItem(ES.Programs, "Programs"),
                new ComboItem(ES.System, "System"),
                new ComboItem(ES.SystemX86, "SystemX86"),
                new ComboItem(ES.Windows, "Windows"),
            };

        private void InitializeComboItems() {
            List<ComboItem> itemList = _itemlist;

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

            UpdateTheItemToUI();
        }

        private void UpdateTheItemToUI() {
            this.txtProjectName.Text = TheItem.ProjectName;
            this.txtTitle.Text = TheItem.Title;
            this.txtDescription.Text = TheItem.Description;
            this.txtPathName.Text = TheItem.Path.PathStr;

            this.chkEnableSpecialFolder.Checked = TheItem.Path.UseSpecialFolder;

            int selIndex = GetSelectedIndex(TheItem.Path.SpecialFolder);
            if (selIndex != -1)
            {
                this.cboSpecialFolder.SelectedIndex = selIndex;
            } 
        }
        private void UpdateTheItemFromUI() {
            TheItem.ProjectName = this.txtProjectName.Text;
            TheItem.Title = this.txtTitle.Text;
            TheItem.Description = this.txtDescription.Text;

            TheItem.Path.PathStr = this.txtPathName.Text;

            bool enableSF = TheItem.Path.UseSpecialFolder = this.chkEnableSpecialFolder.Checked;
            if (enableSF)
            {
                int selIndex = this.cboSpecialFolder.SelectedIndex;
                if (selIndex != -1)
                {
                    var item = this.cboSpecialFolder.SelectedItem as ComboItem;
                    TheItem.Path.SpecialFolder = item.Value;
                }
                else
                {
                    TheItem.Path.SpecialFolder = PathItem.DefaultSpecialFolder;
                }
            }
        }


        private int GetSelectedIndex(Environment.SpecialFolder value)
        {
            int count = _itemlist.Count();
            for (int i = 0; i < count; ++i)
            {
                ComboItem itm = _itemlist[i];
                if (itm.Value != value)
                    continue;

                return i;
            }
            return -1;
        }

        private void chkEnableSpecialFolder_CheckedChanged(object sender, EventArgs e)
        {
            cboSpecialFolder.Enabled = chkEnableSpecialFolder.Checked;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            UpdateTheItemFromUI();

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
