using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using System.Diagnostics;
using System.Text.Json;
using System.Reflection;
using System.Xml;
using System.Threading;
using System.Runtime.CompilerServices;

namespace TUSABgui
{
    public partial class dlgOutput : Form
    {
        private delegate void SafeCallDelegate(string text);
        private delegate void SafeCallDelegate2();

        private string jsonMessage;

        public int ErrorCode;

        public dlgOutput()
        {
            InitializeComponent();
        }

        private void dlgOutput_Load(object sender, EventArgs e)
        {

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



            proc.Start();

            proc.BeginOutputReadLine();

            //if (command == "-u" || command == "-d" || command == "-r")
            {
                Show();
            }

            proc.WaitForExit();

            //Console.WriteLine("Call '" + command + " " + title + " " + paths + "' - '" + stderr + "', " + proc.ExitCode);

            if (proc.ExitCode == 0)
            {
                AppendText("Operation was successful.");
            }
            else if (proc.ExitCode == -14)
            {
                AppendText("Cannot upload, Title already exists.");
            }
            else if (proc.ExitCode == -17)
            {
                AppendText("Invalid password.");
            }
            else if (proc.ExitCode == -16)
            {
                AppendText("Password is required for this operation.");
            }
            else if (proc.ExitCode == -15)
            {
                AppendText("Could not download, output file(s)/folder(s) already exist.");
            }
            else
            {
                //Console.WriteLine("Error in in call '" + command + " " + title + " " + paths +  "' - '" + stderr + "'");
                return proc.ExitCode;
            }

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
                    if (outLine.Data.Equals("Finished."))
                    {
                        Enable();
                        Console.WriteLine("oioij");
                    }
                    AppendText(outLine.Data);
                }
            }
        }

        public Dictionary<string, ImageData> TusabList()
        {
            ErrorCode = tusabCall("-l", "", "");

            if (ErrorCode != 0)
            {
                // If the initial list call fails, we should bail
                Application.Exit();
            }

            Console.WriteLine("{ \"groups\": " + jsonMessage + " }");

            return JsonSerializer.Deserialize<ImageListData>("{ \"groups\": " + jsonMessage + " }").groups;
        }

        public Structure TusabUpload(string title, string args)
        {

            ErrorCode = tusabCall("-u", "\"" + title + "\"", args);

            if (ErrorCode != 0)
            {
                
            }

            return JsonSerializer.Deserialize<ImageData>("{ \"structure\": " + jsonMessage + " }").structure;
        }

        public void TusabDownload(string title, string args)
        {

            ErrorCode = tusabCall("-d", "\"" + title + "\"", args);
        }

        public void TusabRemove(string title)
        {
            ErrorCode = tusabCall("-r", "\"" + title + "\"", "");

            //If the delete failed, do not remove entry
            if (ErrorCode != 0)
            {
                return;
            }
        }

        public void AppendText(string message)
        {

            if (txtOutput.InvokeRequired)
            {
                var d = new SafeCallDelegate(AppendText);
                txtOutput.Invoke(d, new object[] { message });
            }
            else
            {
                txtOutput.AppendText(message + "\n");
            }
        }

        public void Enable()
        {
            if (txtOutput.InvokeRequired)
            {
                var d = new SafeCallDelegate2(Enable);
                btnOK.Invoke(d, new object[] {  });
            }
            else
            {
                btnOK.Enabled = true;
            }
        }

        public void Finished()
        {
            btnOK.Enabled = false;
        }

        public new DialogResult ShowDialog()
        {
            txtOutput.Clear();

            btnOK.Enabled = false;

            return base.ShowDialog();
        }

        public new void Show()
        {
            txtOutput.Clear();

            btnOK.Enabled = false;

            

            base.ShowDialog();
        }

    }
}
