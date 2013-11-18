namespace OpenDirectoryHelper
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.olvDirItems = new BrightIdeasSoftware.ObjectListView();
            this.colProjectName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colTitle = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colDesc = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.olvDirItems)).BeginInit();
            this.SuspendLayout();
            // 
            // olvDirItems
            // 
            this.olvDirItems.AllColumns.Add(this.colProjectName);
            this.olvDirItems.AllColumns.Add(this.colTitle);
            this.olvDirItems.AllColumns.Add(this.colDesc);
            this.olvDirItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProjectName,
            this.colTitle,
            this.colDesc});
            this.olvDirItems.FullRowSelect = true;
            this.olvDirItems.GridLines = true;
            this.olvDirItems.Location = new System.Drawing.Point(12, 27);
            this.olvDirItems.MultiSelect = false;
            this.olvDirItems.Name = "olvDirItems";
            this.olvDirItems.Size = new System.Drawing.Size(556, 281);
            this.olvDirItems.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.olvDirItems.TabIndex = 0;
            this.olvDirItems.UseCompatibleStateImageBehavior = false;
            this.olvDirItems.View = System.Windows.Forms.View.Details;
            this.olvDirItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvDirItems_MouseDoubleClick);
            // 
            // colProjectName
            // 
            this.colProjectName.AspectName = "ProjectName";
            this.colProjectName.CellPadding = null;
            this.colProjectName.IsEditable = false;
            this.colProjectName.MaximumWidth = 120;
            this.colProjectName.MinimumWidth = 120;
            this.colProjectName.Text = "Project";
            this.colProjectName.ToolTipText = "The project name";
            this.colProjectName.Width = 120;
            // 
            // colTitle
            // 
            this.colTitle.AspectName = "Title";
            this.colTitle.CellPadding = null;
            this.colTitle.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTitle.IsEditable = false;
            this.colTitle.MaximumWidth = 180;
            this.colTitle.MinimumWidth = 180;
            this.colTitle.Text = "Title";
            this.colTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTitle.Width = 180;
            // 
            // colDesc
            // 
            this.colDesc.AspectName = "Description";
            this.colDesc.CellPadding = null;
            this.colDesc.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDesc.IsEditable = false;
            this.colDesc.MaximumWidth = 260;
            this.colDesc.MinimumWidth = 260;
            this.colDesc.Text = "Description";
            this.colDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDesc.Width = 260;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(102, 324);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.myToolTip.SetToolTip(this.btnSave, "Save current settings");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(222, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&Add";
            this.myToolTip.SetToolTip(this.btnAdd, "Add a new item.");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(303, 324);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "&Edit";
            this.myToolTip.SetToolTip(this.btnEdit, "Edit selected item.");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(384, 324);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "&Remove";
            this.myToolTip.SetToolTip(this.btnRemove, "Remove selected item.");
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(493, 324);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "&Quit";
            this.myToolTip.SetToolTip(this.btnExit, "Quit the helper tool.");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 324);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 359);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.olvDirItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "mainForm";
            this.Text = "Directory Helper Tool";
            ((System.ComponentModel.ISupportInitialize)(this.olvDirItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvDirItems;
        private BrightIdeasSoftware.OLVColumn colProjectName;
        private BrightIdeasSoftware.OLVColumn colTitle;
        private BrightIdeasSoftware.OLVColumn colDesc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip myToolTip;
        private System.Windows.Forms.Button btnLoad;
    }
}

