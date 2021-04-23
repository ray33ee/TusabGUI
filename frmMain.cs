using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Text.Json;
using System.Reflection;
using System.Xml;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Resources;

using System.Collections;

namespace TUSABgui
{
    public partial class frmMain : Form
    {
        Dictionary<string, ImageData> imageData;

        Stack<Structure> directoryList;

        dlgUpload upload;
        private dlgDownload dlgDownload;
        private dlgOutput dlgProgress;

        private string jsonMessage;

        

        public frmMain()
        {
            InitializeComponent();

            upload = new dlgUpload();
            upload.Owner = this;

            dlgDownload = new dlgDownload();
            dlgDownload.Owner = this;

            dlgProgress = new dlgOutput();
            dlgProgress.Owner = this;

            ImageList lst = new ImageList();
            
            lst.Images.Add(Properties.Resources.collection);
            lst.Images.Add(Properties.Resources.folder);
            lst.Images.Add(Properties.Resources.file);

            lstExplorer.LargeImageList = lst;
            lstExplorer.SmallImageList = lst;

            directoryList = new Stack<Structure>();
            imageData = null;
        }

        private int tusabCall(string command, string title, string paths)
        {
            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "tusab",
                    Arguments = command + " " + title + " " + paths,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    RedirectStandardError = true
                }
            };

            proc.OutputDataReceived += SortOutputHandler;

            dlgProgress.Show();


            proc.Start();

            proc.BeginOutputReadLine();

            proc.WaitForExit();

            //Console.WriteLine("Call '" + command + " " + title + " " + paths + "' - '" + stderr + "', " + proc.ExitCode);

            if (proc.ExitCode == 0)
            {
                dlgProgress.AppendText("Operation was successful.");
            }
            else if (proc.ExitCode == -14)
            {
                dlgProgress.AppendText("Cannot upload, Title already exists.");
            }
            else if (proc.ExitCode == -17)
            {
                dlgProgress.AppendText("Invalid password.");
            }
            else if (proc.ExitCode == -16)
            {
                dlgProgress.AppendText("Password is required for this operation.");
            }
            else if (proc.ExitCode == -15)
            {
                dlgProgress.AppendText("Could not download, output file(s)/folder(s) already exist.");
            }
            else
            {
                //Console.WriteLine("Error in in call '" + command + " " + title + " " + paths +  "' - '" + stderr + "'");
                return proc.ExitCode;
            }

            dlgProgress.Finished();

            return proc.ExitCode;
        }

        private void SortOutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            // Collect the sort command output.
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                // If the output contains a '{' then it is a json object
                if (outLine.Data.Contains("{"))
                {
                    jsonMessage = outLine.Data;
                }
                else
                {
                    dlgProgress.AppendText(outLine.Data);
                }
            }
        }

        // Call this function on startup to get metadata
        private void setImageData()
        {
            imageData = dlgProgress.TusabList();
            //int res = tusabCall("-l", "", "");

            if (dlgProgress.ErrorCode != 0)
            {
                // If the initial list call fails, we should bail
                Application.Exit();
            }

            //Console.WriteLine("{ \"groups\": " + jsonMessage + " }");

            //imageData = JsonSerializer.Deserialize<ImageListData>("{ \"groups\": " + jsonMessage + " }").groups;

        }

        private void populateListview()
        {
            lstExplorer.Clear();

            if (directoryList.Count == 0)
            {
                foreach (KeyValuePair<string, ImageData> pair in imageData)
                    lstExplorer.Items.Add(pair.Key, 0);
            }
            else
            {
                var structure = directoryList.Peek();

                foreach (KeyValuePair<string, Structure> pair in structure.folders)
                    lstExplorer.Items.Add(pair.Key, 1);
                foreach (string file in structure.files)
                    lstExplorer.Items.Add(file, 2);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Look into config.json. If the 'user-credentials' entry is null then warn the user that a browser window will appear asking the user to login with their Google account

            setImageData();

            populateListview();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            upload.ShowDialog();

            if (upload.DialogResult != DialogResult.OK)
            {
                return;
            }

            Console.WriteLine("Args:  " + upload.args);
            Console.WriteLine("Title: " + upload.title);

            int res = 0;

            Structure struc;

            if (upload.password == "")
                struc = dlgProgress.TusabUpload(upload.title, upload.args);
            else
                struc = dlgProgress.TusabUpload(upload.title, "-p" + upload.password + " " + upload.args);

            if (res != 0)
            {
                return;
            }

            imageData.Add(upload.title, new ImageData
                {
                    images = null,
                    structure = struc,
                    size = null,
                    encryption = null
                }
            );

            if (directoryList.Count == 0)
                populateListview();


        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (directoryList.Count == 0 && lstExplorer.SelectedIndices.Count != 0)
            {
                string title = lstExplorer.SelectedItems[0].Text;

                DialogResult res = dlgDownload.ShowDialog();

                if (res != DialogResult.OK)
                {
                    return;
                }

                Console.WriteLine("Path:  " + dlgDownload.path);

                if (imageData[title].encryption != null)
                    dlgProgress.TusabDownload(title, "-p" + dlgDownload.password + " \"" + dlgDownload.path + "\"");
                else
                    dlgProgress.TusabDownload(title, "\"" + dlgDownload.path + "\"");
            }            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Make sure the list displays groups, as we cannot delete individual files/folders
            if (directoryList.Count == 0 && lstExplorer.SelectedIndices.Count != 0)
            {
                string title = lstExplorer.SelectedItems[0].Text;

                dlgProgress.TusabRemove(title);

                //If the delete failed, do not remove entry
                if (dlgProgress.ErrorCode != 0)
                {
                    return;
                }

                imageData.Remove(title);

                populateListview();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (directoryList.Count != 0)
                directoryList.Pop();

            populateListview();
        }

        private void lstExplorer_DoubleClick(object sender, EventArgs e)
        {
            Structure structure;

            string txt = "";

            if (lstExplorer.SelectedItems.Count == 1)
                txt = lstExplorer.SelectedItems[0].Text;
            else
                return;

            if (directoryList.Count == 0)
            {
                structure = imageData[txt].structure;
            }
            else
            {
                structure = directoryList.Peek();

                if (structure.folders.ContainsKey(txt))
                    structure = structure.folders[txt];
                else
                    return;
            }

            directoryList.Push(structure);

            populateListview();
        }

        private void lstExplorer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDrive_Click(object sender, EventArgs e)
        {
            //Opens url to Google Drive in default browser
        }

        private void btnPhotos_Click(object sender, EventArgs e)
        {

            //Opens url to Google Photos in default browser
        }

        private void btnUsage_Click(object sender, EventArgs e)
        {

            //Opens url to Google Drive quota page in default browser
        }

        private void grpMenu_Enter(object sender, EventArgs e)
        {

        }
    }
}
