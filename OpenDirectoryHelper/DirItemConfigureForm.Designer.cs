namespace OpenDirectoryHelper
{
    partial class DirItemConfigureForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.chkEnableSpecialFolder = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPathName = new System.Windows.Forms.TextBox();
            this.cboSpecialFolder = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Project Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Description";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(408, 241);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(311, 241);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(198, 25);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(277, 25);
            this.txtProjectName.TabIndex = 2;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(198, 61);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(277, 25);
            this.txtTitle.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(198, 100);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(277, 25);
            this.txtDescription.TabIndex = 2;
            // 
            // chkEnableSpecialFolder
            // 
            this.chkEnableSpecialFolder.AutoSize = true;
            this.chkEnableSpecialFolder.Location = new System.Drawing.Point(25, 154);
            this.chkEnableSpecialFolder.Name = "chkEnableSpecialFolder";
            this.chkEnableSpecialFolder.Size = new System.Drawing.Size(154, 19);
            this.chkEnableSpecialFolder.TabIndex = 3;
            this.chkEnableSpecialFolder.Text = "Enable Special Folder";
            this.chkEnableSpecialFolder.UseVisualStyleBackColor = true;
            this.chkEnableSpecialFolder.CheckedChanged += new System.EventHandler(this.chkEnableSpecialFolder_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "PathName";
            // 
            // txtPathName
            // 
            this.txtPathName.Location = new System.Drawing.Point(198, 190);
            this.txtPathName.Name = "txtPathName";
            this.txtPathName.Size = new System.Drawing.Size(277, 25);
            this.txtPathName.TabIndex = 6;
            // 
            // cboSpecialFolder
            // 
            this.cboSpecialFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSpecialFolder.FormattingEnabled = true;
            this.cboSpecialFolder.Location = new System.Drawing.Point(198, 150);
            this.cboSpecialFolder.Name = "cboSpecialFolder";
            this.cboSpecialFolder.Size = new System.Drawing.Size(121, 23);
            this.cboSpecialFolder.TabIndex = 7;
            // 
            // DirItemConfigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 276);
            this.Controls.Add(this.cboSpecialFolder);
            this.Controls.Add(this.txtPathName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkEnableSpecialFolder);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "DirItemConfigureForm";
            this.Text = "Item Configure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.CheckBox chkEnableSpecialFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPathName;
        private System.Windows.Forms.ComboBox cboSpecialFolder;
    }
}