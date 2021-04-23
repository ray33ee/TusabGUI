using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUSABgui
{
    public partial class dlgUpload : Form
    {
        private FolderBrowserDialog dlgFolder;
        private OpenFileDialog dlgFile;

        public string title
        {
            get
            {
                return txtTitle.Text;
            }
        }

        public string args
        {
            get
            {
                string result = "";

                foreach (ListViewItem item in lstFolders.Items)
                    result += "\"" + item.Text + "\" ";

                foreach (ListViewItem item in lstFiles.Items)
                    result += "\"" + item.Text + "\" ";

                return result;
            }
        }

        public string password
        {
            get
            {
                return txtPassword.Text;
            }
        }

        public dlgUpload()
        {
            InitializeComponent();

            dlgFolder = new FolderBrowserDialog();
            dlgFile = new OpenFileDialog();

            dlgFile.CheckFileExists = true;
            dlgFile.CheckPathExists = true;
            dlgFile.Multiselect = true;
        }

        private void dlgUpload_Load(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            lstFiles.Clear();
            lstFolders.Clear();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lstFolders.Items.Count == 0 && lstFiles.Items.Count == 0 || txtTitle.Text == "")
            {
                // Inform user they must select at least one file or folder

            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgFolder.ShowDialog();

            if (result == DialogResult.OK)
                lstFolders.Items.Add(dlgFolder.SelectedPath);
        }

        private void btnRemoveFolder_Click(object sender, EventArgs e)
        {
            lstFolders.Items.RemoveAt(lstFolders.SelectedIndices[0]);
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgFile.ShowDialog();

            if (result == DialogResult.OK)
                foreach (string file in dlgFile.FileNames)
                {
                    if (lstFiles.FindItemWithText(file) == null)
                        lstFiles.Items.Add(file);
                }

        }

        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            lstFiles.Items.RemoveAt(lstFiles.SelectedIndices[0]);
        }
    }
}
