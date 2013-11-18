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
        }
        private void InitializeListView() { 
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Save & Load Settings
        private void btnLoad_Click(object sender, EventArgs e)
        {
            // load settings
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // save setting to files.
        }
        #endregion

        #region Operators
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // add dir item
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // edit selected dir item
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // remove selected dir item.
        }
        #endregion
    }
}
