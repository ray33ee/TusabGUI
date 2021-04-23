using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUSABgui
{
    public partial class dlgDownload : Form
    {
        private FolderBrowserDialog dlgFolder;

        public List<string> imageData
        {
            get; set;
        }

        public string path
        {
            get
            {
                return txtPath.Text;
            }
        }
        public string password
        {
            get
            {
                return txtPassword.Text;
            }
        }

        public dlgDownload()
        {
            InitializeComponent();

            dlgFolder = new FolderBrowserDialog();
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgFolder.ShowDialog();

            if (result == DialogResult.OK)
                txtPath.Text = dlgFolder.SelectedPath;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtPath.Text == "")
            {
                //Warn user they must enter a title and select a path
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

        private void dlgDownload_Load(object sender, EventArgs e)
        {
            
        }
    }
}
