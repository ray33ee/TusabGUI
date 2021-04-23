namespace TUSABgui
{
    partial class dlgUpload
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
            this.gbxFolders = new System.Windows.Forms.GroupBox();
            this.btnRemoveFolder = new System.Windows.Forms.Button();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.lstFolders = new System.Windows.Forms.ListView();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbxFiles = new System.Windows.Forms.GroupBox();
            this.btnRemoveFile = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.lstFiles = new System.Windows.Forms.ListView();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.gbxFolders.SuspendLayout();
            this.gbxFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFolders
            // 
            this.gbxFolders.Controls.Add(this.btnRemoveFolder);
            this.gbxFolders.Controls.Add(this.btnAddFolder);
            this.gbxFolders.Controls.Add(this.lstFolders);
            this.gbxFolders.Location = new System.Drawing.Point(32, 125);
            this.gbxFolders.Name = "gbxFolders";
            this.gbxFolders.Size = new System.Drawing.Size(699, 302);
            this.gbxFolders.TabIndex = 1;
            this.gbxFolders.TabStop = false;
            this.gbxFolders.Text = "Folders:";
            // 
            // btnRemoveFolder
            // 
            this.btnRemoveFolder.Location = new System.Drawing.Point(616, 102);
            this.btnRemoveFolder.Name = "btnRemoveFolder";
            this.btnRemoveFolder.Size = new System.Drawing.Size(60, 55);
            this.btnRemoveFolder.TabIndex = 2;
            this.btnRemoveFolder.Text = "-";
            this.btnRemoveFolder.UseVisualStyleBackColor = true;
            this.btnRemoveFolder.Click += new System.EventHandler(this.btnRemoveFolder_Click);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(616, 41);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(60, 55);
            this.btnAddFolder.TabIndex = 1;
            this.btnAddFolder.Text = "+";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // lstFolders
            // 
            this.lstFolders.HideSelection = false;
            this.lstFolders.Location = new System.Drawing.Point(24, 41);
            this.lstFolders.MultiSelect = false;
            this.lstFolders.Name = "lstFolders";
            this.lstFolders.Size = new System.Drawing.Size(574, 234);
            this.lstFolders.TabIndex = 0;
            this.lstFolders.UseCompatibleStateImageBehavior = false;
            this.lstFolders.View = System.Windows.Forms.View.List;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(145, 25);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(586, 31);
            this.txtTitle.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(80, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(59, 25);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title:";
            // 
            // gbxFiles
            // 
            this.gbxFiles.Controls.Add(this.btnRemoveFile);
            this.gbxFiles.Controls.Add(this.btnAddFile);
            this.gbxFiles.Controls.Add(this.lstFiles);
            this.gbxFiles.Location = new System.Drawing.Point(32, 446);
            this.gbxFiles.Name = "gbxFiles";
            this.gbxFiles.Size = new System.Drawing.Size(699, 302);
            this.gbxFiles.TabIndex = 3;
            this.gbxFiles.TabStop = false;
            this.gbxFiles.Text = "Files:";
            // 
            // btnRemoveFile
            // 
            this.btnRemoveFile.Location = new System.Drawing.Point(616, 102);
            this.btnRemoveFile.Name = "btnRemoveFile";
            this.btnRemoveFile.Size = new System.Drawing.Size(60, 55);
            this.btnRemoveFile.TabIndex = 2;
            this.btnRemoveFile.Text = "-";
            this.btnRemoveFile.UseVisualStyleBackColor = true;
            this.btnRemoveFile.Click += new System.EventHandler(this.btnRemoveFile_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(616, 41);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(60, 55);
            this.btnAddFile.TabIndex = 1;
            this.btnAddFile.Text = "+";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // lstFiles
            // 
            this.lstFiles.HideSelection = false;
            this.lstFiles.Location = new System.Drawing.Point(24, 41);
            this.lstFiles.MultiSelect = false;
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(574, 234);
            this.lstFiles.TabIndex = 0;
            this.lstFiles.UseCompatibleStateImageBehavior = false;
            this.lstFiles.View = System.Windows.Forms.View.List;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(343, 767);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(191, 54);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(540, 767);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(191, 54);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(27, 72);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(112, 25);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(145, 72);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(586, 31);
            this.txtPassword.TabIndex = 6;
            // 
            // dlgUpload
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(766, 845);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbxFiles);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.gbxFolders);
            this.Name = "dlgUpload";
            this.Text = "Choose uploads...";
            this.Load += new System.EventHandler(this.dlgUpload_Load);
            this.gbxFolders.ResumeLayout(false);
            this.gbxFiles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFolders;
        private System.Windows.Forms.Button btnRemoveFolder;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.ListView lstFolders;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbxFiles;
        private System.Windows.Forms.Button btnRemoveFile;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.ListView lstFiles;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
    }
}