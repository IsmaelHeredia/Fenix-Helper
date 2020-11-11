// Fenix Helper 1.0
// Copyright © Ismael Heredia 2020

using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SQLite;
using System.IO;
using System.Configuration;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using FenixHelper.Data;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Speech.Synthesis;

namespace FenixHelper
{
    public partial class FormHome : Telerik.WinControls.UI.RadForm
    {
        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(Keys keys);
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(Int32 i);
        [DllImport("user32.dll")]
        private static extern short GetKeyState(Keys keys);
        [DllImport("user32.dll")]
        private static extern short GetKeyState(Int32 i);

        public string database_name;
        public string program_title;

        SpeechSynthesizer speechSynthesizerObj;

        DataKey dataKey = new DataKey();
        DataTask dataTask = new DataTask();
        DataArgument dataArgument = new DataArgument();

        public ArrayList keys;

        FormTask formTask = new FormTask(null, 0);

        public FormHome()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
            database_name = System.Configuration.ConfigurationManager.AppSettings["database_name"];
            program_title = System.Configuration.ConfigurationManager.AppSettings["program_title"];
            speechSynthesizerObj = new SpeechSynthesizer();
        }

        private void generate_help()
        {
            string text = "";

            foreach (Key key in keys)
            {
                Task task = dataTask.GetByKey(key.Name);

                if (task != null)
                {
                    ArrayList arguments = dataArgument.List(task.Id);

                    string command = "";
                    string args = "";

                    if (arguments.Count > 0)
                    {
                        foreach (Argument argument in arguments)
                        {
                            string name = argument.Name;
                            string value = argument.Value;
                            if (value == "None")
                            {
                                args += name + " ";
                            }
                            else if (value == "Ask")
                            {
                                string arg = "<enter value>";
                                args += name + " " + arg + " ";
                            }
                            else if (value == "AskFile")
                            {
                                string arg = "<enter file>";
                                args += name + " " + arg + " ";
                            }
                            else
                            {
                                args += name + " \"" + value + "\" ";
                            }
                        }
                    }

                    command = task.Filename + " " + args;
                    command = Regex.Replace(command, @"\s$", "");

                    if (args != "")
                    {
                        text += key.Name + " : " + task.Name + " -> " + command + Environment.NewLine + Environment.NewLine;
                    }
                    else
                    {
                        text += key.Name + " : " + task.Name + Environment.NewLine + Environment.NewLine;
                    }
                }
                else
                {
                    text += key.Name + " : Unassigned" + Environment.NewLine + Environment.NewLine;
                }
            }

            speechSynthesizerObj.SpeakAsync("Help loaded");

            lblStatus.Text = "Help loaded";

            RadMessageBox.Show(text, "Help", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
        }

        private void execute(Task task)
        {
            ArrayList arguments = dataArgument.List(task.Id);

            string directory = task.Working_directory;
            string filename = task.Filename;

            string command = "";
            string args = "";

            if (arguments.Count > 0)
            {
                foreach (Argument argument in arguments)
                {
                    string name = argument.Name;
                    string value = argument.Value;
                    if (value == "None")
                    {
                        args += name + " ";
                    }
                    else if (value == "Ask")
                    {
                        string arg = RadInputBox.Show("Enter value for " + name, program_title, "");
                        args += name + " \"" + arg + "\" ";
                    }
                    else if (value == "AskFile")
                    {
                        string arg = "";
                        OpenFileDialog openFileDialog = new OpenFileDialog();
                        openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                        openFileDialog.Title = "Select file";
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            arg = openFileDialog.FileName;
                        }
                        args += name + " \"" + arg + "\" ";
                    }
                    else
                    {
                        args += name + " \"" + value + "\" ";
                    }
                }
            }

            command = filename + " " + args;
            command = Regex.Replace(command, @"\s$", "");

            command = command.Replace(">", "");

            string text = "echo. & echo [!] Fenix Helper 1.0 & echo. & echo [+] Directory : " + directory + " & echo. & echo [+] Command : " + command + " & echo. & echo [?] Executing ...";

            Process p = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.WorkingDirectory = directory;
            info.FileName = "cmd.exe";

            if (task.Terminate == 1)
            {
                info.Arguments = "/C " + text + " & " + command;
            }
            else
            {
                info.Arguments = "/K " + text + " & " + command;
            }

            if (System.Environment.OSVersion.Version.Major >= 6)
            {
                if (task.Admin == 1)
                {
                    p.StartInfo.Verb = "runas";
                }
            }

            info.UseShellExecute = false;

            if (task.Window_style == 1)
            {
                info.CreateNoWindow = true;
            }

            int window_style = task.Window_style;

            if (window_style == 1)
            {
                info.WindowStyle = ProcessWindowStyle.Hidden;
            }
            else if (window_style == 2)
            {
                info.WindowStyle = ProcessWindowStyle.Maximized;
            }
            else if (window_style == 3)
            {
                info.WindowStyle = ProcessWindowStyle.Minimized;
            }
            else if (window_style == 4)
            {
                info.WindowStyle = ProcessWindowStyle.Normal;
            }

            p.StartInfo = info;
            p.Start();

            speechSynthesizerObj.SpeakAsync("Task executed");

            lblStatus.Text = "Task : " + task.Name + " executed !";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmCaptureKeys.Enabled = true;
            lblStatus.Text = "Working ...";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmCaptureKeys.Enabled = false;
            lblStatus.Text = "Stopped !";
        }

        public void loadKeys()
        {
            lvTasks.Items.Clear();
            if (File.Exists(Path.GetFullPath(database_name)))
            {
                ArrayList keys = dataKey.List();

                foreach (Key key in keys)
                {
                    int id = key.Id;
                    string key_name = key.Name;
                    string task_name = "Unassigned";

                    Task task = dataTask.GetByKeyId(id);

                    if (task != null)
                    {
                        task_name = task.Name;
                    }

                    ListViewDataItem item = new ListViewDataItem();
                    item.SubItems.Add(id);
                    item.SubItems.Add(key_name);
                    item.SubItems.Add(task_name);
                    lvTasks.Items.Add(item);
                }
            }
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            notifyIcon.Text = program_title;

            DataAccess dataAccess = new DataAccess();

            if (!File.Exists(Path.GetFullPath(database_name)))
            {
                dataAccess.createDB();
                RadMessageBox.Show("Database created", program_title, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
            }

            loadKeys();

            DataKey dataKey = new DataKey();
            keys = dataKey.List();
        }

        private void btnNewTask_Click(object sender, EventArgs e)
        {
            if (!formTask.Visible)
            {
                formTask = new FormTask(this, 0);
                formTask.Show();
            }
        }

        private void lvTasks_ItemMouseDoubleClick(object sender, ListViewItemEventArgs e)
        {
            DataTask dataTask = new DataTask();
            int key_id = Convert.ToInt32(lvTasks.SelectedItem[0]);
            if (!formTask.Visible)
            {
                formTask = new FormTask(this, key_id);
                formTask.Show();
            }
        }

        private void tmCaptureKeys_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 255; i++)
            {
                int keyState = GetAsyncKeyState(i);
                if (keyState == -32767)
                {
                    if (i == 36 && cbShowHelp.Enabled == true)
                    {
                        generate_help();
                    }
                    foreach (Key key in keys)
                    {
                        if (i == key.Code)
                        {
                            Task task = dataTask.GetByKey(key.Name);
                            if (task != null)
                            {
                                execute(task);
                            }
                        }
                    }
                }
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void FormHome_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;

                if (formTask.Visible)
                {
                    formTask.Visible = false;
                }

                notifyIcon.Visible = true;
            }
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ds = RadMessageBox.Show(this, "Are you sure ?", program_title, MessageBoxButtons.YesNo, RadMessageIcon.Question);
            if (ds.ToString() != "Yes")
            {
                e.Cancel = true;
                this.Activate();
            }
        }
    }
}
