namespace FenixHelper
{
    partial class FormHome
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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "ID");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Key");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Task");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.telerikMetroTheme = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.gbTasks = new Telerik.WinControls.UI.RadGroupBox();
            this.btnNewTask = new Telerik.WinControls.UI.RadButton();
            this.lvTasks = new Telerik.WinControls.UI.RadListView();
            this.btnStart = new Telerik.WinControls.UI.RadButton();
            this.btnStop = new Telerik.WinControls.UI.RadButton();
            this.tmCaptureKeys = new System.Windows.Forms.Timer(this.components);
            this.ssStatus = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblStatus = new Telerik.WinControls.UI.RadLabelElement();
            this.cbShowHelp = new Telerik.WinControls.UI.RadCheckBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gbTasks)).BeginInit();
            this.gbTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbShowHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTasks
            // 
            this.gbTasks.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbTasks.Controls.Add(this.btnNewTask);
            this.gbTasks.Controls.Add(this.lvTasks);
            this.gbTasks.HeaderText = "Tasks";
            this.gbTasks.Location = new System.Drawing.Point(12, 12);
            this.gbTasks.Name = "gbTasks";
            this.gbTasks.Size = new System.Drawing.Size(414, 361);
            this.gbTasks.TabIndex = 2;
            this.gbTasks.Text = "Tasks";
            this.gbTasks.ThemeName = "TelerikMetro";
            // 
            // btnNewTask
            // 
            this.btnNewTask.Location = new System.Drawing.Point(17, 319);
            this.btnNewTask.Name = "btnNewTask";
            this.btnNewTask.Size = new System.Drawing.Size(110, 24);
            this.btnNewTask.TabIndex = 1;
            this.btnNewTask.Text = "New task";
            this.btnNewTask.ThemeName = "TelerikMetro";
            this.btnNewTask.Click += new System.EventHandler(this.btnNewTask_Click);
            // 
            // lvTasks
            // 
            listViewDetailColumn1.HeaderText = "ID";
            listViewDetailColumn1.Visible = false;
            listViewDetailColumn2.HeaderText = "Key";
            listViewDetailColumn3.HeaderText = "Task";
            this.lvTasks.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3});
            this.lvTasks.ItemSpacing = -1;
            this.lvTasks.Location = new System.Drawing.Point(17, 34);
            this.lvTasks.Name = "lvTasks";
            this.lvTasks.Size = new System.Drawing.Size(376, 267);
            this.lvTasks.TabIndex = 0;
            this.lvTasks.Text = "radListView1";
            this.lvTasks.ThemeName = "TelerikMetro";
            this.lvTasks.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.lvTasks.ItemMouseDoubleClick += new Telerik.WinControls.UI.ListViewItemEventHandler(this.lvTasks_ItemMouseDoubleClick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(79, 444);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 24);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.ThemeName = "TelerikMetro";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(243, 444);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(110, 24);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.ThemeName = "TelerikMetro";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tmCaptureKeys
            // 
            this.tmCaptureKeys.Interval = 50;
            this.tmCaptureKeys.Tick += new System.EventHandler(this.tmCaptureKeys_Tick);
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblStatus});
            this.ssStatus.Location = new System.Drawing.Point(0, 491);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(438, 25);
            this.ssStatus.TabIndex = 5;
            this.ssStatus.Text = "radStatusStrip1";
            this.ssStatus.ThemeName = "TelerikMetro";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.ssStatus.SetSpring(this.lblStatus, false);
            this.lblStatus.Text = "Done";
            this.lblStatus.TextWrap = true;
            // 
            // cbShowHelp
            // 
            this.cbShowHelp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowHelp.Location = new System.Drawing.Point(12, 392);
            this.cbShowHelp.Name = "cbShowHelp";
            this.cbShowHelp.Size = new System.Drawing.Size(164, 19);
            this.cbShowHelp.TabIndex = 6;
            this.cbShowHelp.Text = "Show help with home key";
            this.cbShowHelp.ThemeName = "TelerikMetro";
            this.cbShowHelp.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 516);
            this.Controls.Add(this.cbShowHelp);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gbTasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormHome";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Fenix Helper 1.0 - Copyright © Ismael Heredia 2020";
            this.ThemeName = "TelerikMetro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHome_FormClosing);
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.Resize += new System.EventHandler(this.FormHome_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.gbTasks)).EndInit();
            this.gbTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnNewTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbShowHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme;
        private Telerik.WinControls.UI.RadGroupBox gbTasks;
        private Telerik.WinControls.UI.RadButton btnStart;
        private Telerik.WinControls.UI.RadButton btnStop;
        private Telerik.WinControls.UI.RadListView lvTasks;
        private Telerik.WinControls.UI.RadButton btnNewTask;
        private System.Windows.Forms.Timer tmCaptureKeys;
        private Telerik.WinControls.UI.RadStatusStrip ssStatus;
        private Telerik.WinControls.UI.RadLabelElement lblStatus;
        private Telerik.WinControls.UI.RadCheckBox cbShowHelp;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}