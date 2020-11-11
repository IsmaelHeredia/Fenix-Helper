// Fenix Helper 1.0
// Copyright © Ismael Heredia 2020

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using FenixHelper.Data;

namespace FenixHelper
{
    public partial class FormTask : Telerik.WinControls.UI.RadForm
    {
        public string program_title;
        public FormHome formHome;
        public int key_id;
        public int task_id = 0;
        public bool dropdown_control = false;
        public bool new_task = false;
        public int last_key = 0;

        public FormTask(FormHome send_formHome, int send_key_id)
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
            program_title = System.Configuration.ConfigurationManager.AppSettings["program_title"];
            formHome = send_formHome;
            key_id = send_key_id;
        }

        private void listArguments()
        {
            lvArguments.Items.Clear();

            DataArgument dataArgument = new DataArgument();

            ArrayList arguments = dataArgument.List(task_id);

            foreach (Argument argument in arguments)
            {
                int argument_id = argument.Id;
                string argument_name = argument.Name;
                string argument_value = argument.Value;
                ListViewDataItem add = new ListViewDataItem();
                add.SubItems.Add(argument_id);
                add.SubItems.Add(argument_name);
                add.SubItems.Add(argument_value);
                lvArguments.Items.Add(add);
            }
        }

        private void FormTask_Load(object sender, EventArgs e)
        {
            ddlWindowStyle.SelectedIndex = 0;

            ddlWindowStyle.Items.Clear();
            ddlWindowStyle.Items.Insert(0, new RadListDataItem("Hidden", 1));
            ddlWindowStyle.Items.Insert(1, new RadListDataItem("Maximized", 2));
            ddlWindowStyle.Items.Insert(2, new RadListDataItem("Minimized", 3));
            ddlWindowStyle.Items.Insert(3, new RadListDataItem("Normal", 4));

            DataKey dataKey = new DataKey();

            ArrayList keys = dataKey.List();

            foreach (Key key in keys)
            {
                RadListDataItem item = new RadListDataItem();
                item.Text = key.Name;
                item.Value = key.Id;
                ddlKeys.Items.Add(item);
            }

            DataTask dataTask = new DataTask();

            Task task = null;

            if (key_id != 0)
            {
                task = dataTask.GetByKeyId(key_id);
            }

            if (task != null)
            {
                dropdown_control = true;

                ddlKeys.SelectedValue = key_id;

                task_id = task.Id;

                string name = task.Name;
                string working_directory = task.Working_directory;
                string filename = task.Filename;

                txtName.Text = name;
                txtWorkingDirectory.Text = working_directory;
                txtFilename.Text = filename;
                ddlWindowStyle.SelectedValue = task.Window_style;

                if (task.Terminate == 1)
                {
                    cbTerminate.Checked = true;
                }

                if (task.Admin == 1)
                {
                    cbAdmin.Checked = true;
                }

                listArguments();

                dropdown_control = false;
            }
            else
            {
                ddlKeys.SelectedValue = key_id;
                new_task = true;
            }
        }

        private void btnAddArgument_Click(object sender, EventArgs e)
        {
            if (new_task == true)
            {
                string name = RadInputBox.Show("Enter name", program_title, "");
                string value = RadInputBox.Show("Enter value (Type None, Ask, AskFile or enter value)", program_title, "");
                ListViewDataItem item = new ListViewDataItem();
                item.SubItems.Add(0);
                item.SubItems.Add(name);
                item.SubItems.Add(value);
                lvArguments.Items.Add(item);
            }
            else
            {
                string name = RadInputBox.Show("Enter name", program_title, "");
                string value = RadInputBox.Show("Enter value (Type None, Ask, AskFile or enter value)", program_title, "");
                Argument argument = new Argument();
                argument.Task_id = task_id;
                argument.Name = name;
                argument.Value = value;
                DataArgument dataArgument = new DataArgument();
                if (dataArgument.Add(argument))
                {
                    RadMessageBox.Show("Argument created", program_title, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    RadMessageBox.Show("Error making argument", program_title, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                }
                listArguments();
            }
        }

        private void btnEditArgument_Click(object sender, EventArgs e)
        {
            if (lvArguments.SelectedItems.Count > 0)
            {
                if (new_task == true)
                {
                    string name = lvArguments.SelectedItem[1].ToString();
                    string value = lvArguments.SelectedItem[2].ToString();
                    string new_name = RadInputBox.Show("Enter name", program_title, name);
                    string new_value = RadInputBox.Show("Enter value (Type None, Ask, AskFile or enter value)", program_title, value);
                    lvArguments.SelectedItem[1] = new_name;
                    lvArguments.SelectedItem[2] = new_value;
                }
                else
                {
                    int id = Convert.ToInt32(lvArguments.SelectedItem[0]);
                    string name = lvArguments.SelectedItem[1].ToString();
                    string value = lvArguments.SelectedItem[2].ToString();
                    string new_name = RadInputBox.Show("Enter name", program_title, name);
                    string new_value = RadInputBox.Show("Enter value (Type None, Ask, AskFile or enter value)", program_title, value);
                    Argument argument = new Argument();
                    argument.Id = id;
                    argument.Task_id = task_id;
                    argument.Name = new_name;
                    argument.Value = new_value;
                    DataArgument dataArgument = new DataArgument();
                    if (dataArgument.Update(argument))
                    {
                        RadMessageBox.Show("Argument updated", program_title, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        RadMessageBox.Show("Error updating argument", program_title, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    listArguments();
                }
            }
        }

        private void btnDeleteArgument_Click(object sender, EventArgs e)
        {
            if (lvArguments.SelectedItems.Count > 0)
            {
                if (new_task == true)
                {
                    List<ListViewDataItem> selected_items = new List<ListViewDataItem>();

                    foreach (ListViewDataItem item in lvArguments.SelectedItems)
                    {
                        selected_items.Add(item);
                    }

                    foreach (ListViewDataItem item in selected_items)
                    {
                        lvArguments.Items.Remove(item);
                    }
                }
                else
                {
                    int id = Convert.ToInt32(lvArguments.SelectedItem[0]);
                    DataArgument dataArgument = new DataArgument();
                    if (dataArgument.Delete(id))
                    {
                        RadMessageBox.Show("Argument deleted", program_title, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        RadMessageBox.Show("Error deleting argument", program_title, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    listArguments();
                }
            }
        }

        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            DataTask dataTask = new DataTask();

            int key_id = Convert.ToInt32(ddlKeys.SelectedValue);
            string name = txtName.Text;
            string working_directory = txtWorkingDirectory.Text;
            string filename = txtFilename.Text;
            int window_style = Convert.ToInt32(ddlWindowStyle.SelectedValue);
            int terminate = 0;
            int admin = 0;

            if (cbTerminate.Checked)
            {
                terminate = 1;
            }

            if (cbAdmin.Checked)
            {
                admin = 1;
            }

            if (key_id != 0 && name != "" && working_directory != "" && filename != "" && window_style != 0)
            {
                if (new_task == true)
                {
                    Task task = new Task();
                    task.Key_id = key_id;
                    task.Name = name;
                    task.Working_directory = working_directory;
                    task.Filename = filename;
                    task.Window_style = window_style;
                    task.Terminate = terminate;
                    task.Admin = admin;

                    int new_task_id = dataTask.Add(task);

                    if (new_task_id != 0)
                    {
                        if (lvArguments.Items.Count > 0)
                        {
                            DataArgument dataArgument = new DataArgument();
                            foreach (ListViewDataItem item in lvArguments.Items)
                            {
                                string item_name = item[1].ToString();
                                string item_value = item[2].ToString();
                                Argument argument = new Argument();
                                argument.Task_id = new_task_id;
                                argument.Name = item_name;
                                argument.Value = item_value;
                                dataArgument.Add(argument);
                            }
                        }
                        RadMessageBox.Show("Task created", program_title, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        RadMessageBox.Show("Error making task", program_title, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                    }

                    formHome.loadKeys();
                    this.Close();
                }
                else
                {
                    Task task = new Task();
                    task.Id = task_id;
                    task.Key_id = key_id;
                    task.Name = name;
                    task.Working_directory = working_directory;
                    task.Filename = filename;
                    task.Window_style = window_style;
                    task.Terminate = terminate;
                    task.Admin = admin;

                    if (dataTask.Update(task))
                    {
                        RadMessageBox.Show("Task updated", program_title, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        RadMessageBox.Show("Error updating task", program_title, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                    }

                    formHome.loadKeys();
                    this.Close();
                }
            }
            else
            {
                RadMessageBox.Show("Complete data", program_title, MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (new_task == false)
            {
                DataTask dataTask = new DataTask();
                DataArgument dataArgument = new DataArgument();
                if (dataTask.Delete(task_id))
                {
                    dataArgument.DeleteByTask(task_id);
                    RadMessageBox.Show("Task deleted", program_title, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    RadMessageBox.Show("Error deleting task", program_title, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                }

                formHome.loadKeys();
                this.Close();
            }
            else
            {
                RadMessageBox.Show("Task not created", program_title, MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void ddlKeys_SelectedValueChanged(object sender, EventArgs e)
        {
            if (dropdown_control == false && ddlKeys.SelectedIndex != -1)
            {
                int key_id = Convert.ToInt32(ddlKeys.SelectedValue);
                string key = ddlKeys.Text;

                DataTask dataTask = new DataTask();
                if (new_task == true)
                {
                    if (dataTask.GetByKey(key) != null)
                    {
                        RadMessageBox.Show("Key not available", program_title, MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        ddlKeys.SelectedValue = last_key;
                    }
                }
                else
                {
                    Task task = dataTask.Get(task_id);
                    if (task.Key_id != key_id)
                    {
                        if (dataTask.GetByKey(key) != null)
                        {
                            RadMessageBox.Show("Key not available", program_title, MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1);
                            ddlKeys.SelectedValue = last_key;
                        }
                    }
                }
            }
        }

        private void ddlKeys_Enter(object sender, EventArgs e)
        {
            last_key = Convert.ToInt32(ddlKeys.SelectedValue);
        }
    }
}
