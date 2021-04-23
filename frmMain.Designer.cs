namespace TUSABgui
{
    partial class frmMain
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
            this.lstExplorer = new System.Windows.Forms.ListView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.btnDrive = new System.Windows.Forms.Button();
            this.btnUsage = new System.Windows.Forms.Button();
            this.btnPhotos = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.cboPathFolders = new System.Windows.Forms.ComboBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.grpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstExplorer
            // 
            this.lstExplorer.HideSelection = false;
            this.lstExplorer.Location = new System.Drawing.Point(229, 120);
            this.lstExplorer.MultiSelect = false;
            this.lstExplorer.Name = "lstExplorer";
            this.lstExplorer.Size = new System.Drawing.Size(940, 680);
            this.lstExplorer.TabIndex = 0;
            this.lstExplorer.UseCompatibleStateImageBehavior = false;
            this.lstExplorer.View = System.Windows.Forms.View.List;
            this.lstExplorer.SelectedIndexChanged += new System.EventHandler(this.lstExplorer_SelectedIndexChanged);
            this.lstExplorer.DoubleClick += new System.EventHandler(this.lstExplorer_DoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(11, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1159, 50);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnDrive);
            this.grpMenu.Controls.Add(this.btnUsage);
            this.grpMenu.Controls.Add(this.btnPhotos);
            this.grpMenu.Controls.Add(this.btnDelete);
            this.grpMenu.Controls.Add(this.btnDownload);
            this.grpMenu.Controls.Add(this.btnUpload);
            this.grpMenu.Location = new System.Drawing.Point(11, 65);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(200, 739);
            this.grpMenu.TabIndex = 3;
            this.grpMenu.TabStop = false;
            this.grpMenu.Enter += new System.EventHandler(this.grpMenu_Enter);
            // 
            // btnDrive
            // 
            this.btnDrive.Location = new System.Drawing.Point(7, 686);
            this.btnDrive.Name = "btnDrive";
            this.btnDrive.Size = new System.Drawing.Size(51, 47);
            this.btnDrive.TabIndex = 6;
            this.btnDrive.Text = "button3";
            this.btnDrive.UseVisualStyleBackColor = true;
            this.btnDrive.Click += new System.EventHandler(this.btnDrive_Click);
            // 
            // btnUsage
            // 
            this.btnUsage.Location = new System.Drawing.Point(143, 686);
            this.btnUsage.Name = "btnUsage";
            this.btnUsage.Size = new System.Drawing.Size(51, 47);
            this.btnUsage.TabIndex = 5;
            this.btnUsage.Text = "button1";
            this.btnUsage.UseVisualStyleBackColor = true;
            this.btnUsage.Click += new System.EventHandler(this.btnUsage_Click);
            // 
            // btnPhotos
            // 
            this.btnPhotos.Location = new System.Drawing.Point(76, 686);
            this.btnPhotos.Name = "btnPhotos";
            this.btnPhotos.Size = new System.Drawing.Size(51, 47);
            this.btnPhotos.TabIndex = 4;
            this.btnPhotos.Text = "button2";
            this.btnPhotos.UseVisualStyleBackColor = true;
            this.btnPhotos.Click += new System.EventHandler(this.btnPhotos_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(7, 151);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(187, 54);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(7, 91);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(187, 54);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(7, 31);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(187, 54);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // cboPathFolders
            // 
            this.cboPathFolders.FormattingEnabled = true;
            this.cboPathFolders.Location = new System.Drawing.Point(373, 75);
            this.cboPathFolders.Name = "cboPathFolders";
            this.cboPathFolders.Size = new System.Drawing.Size(796, 33);
            this.cboPathFolders.TabIndex = 4;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(229, 66);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(138, 48);
            this.btnUp.TabIndex = 5;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 817);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.cboPathFolders);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstExplorer);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstExplorer;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.ComboBox cboPathFolders;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDrive;
        private System.Windows.Forms.Button btnUsage;
        private System.Windows.Forms.Button btnPhotos;
    }
}

