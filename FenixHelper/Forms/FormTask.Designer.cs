namespace FenixHelper
{
    partial class FormTask
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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "ID");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Name");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Value");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTask));
            this.gbWorkingDirectory = new Telerik.WinControls.UI.RadGroupBox();
            this.txtWorkingDirectory = new Telerik.WinControls.UI.RadTextBox();
            this.gbFilename = new Telerik.WinControls.UI.RadGroupBox();
            this.txtFilename = new Telerik.WinControls.UI.RadTextBox();
            this.gbArguments = new Telerik.WinControls.UI.RadGroupBox();
            this.btnDeleteArgument = new Telerik.WinControls.UI.RadButton();
            this.btnEditArgument = new Telerik.WinControls.UI.RadButton();
            this.btnAddArgument = new Telerik.WinControls.UI.RadButton();
            this.lvArguments = new Telerik.WinControls.UI.RadListView();
            this.gbWindowStyle = new Telerik.WinControls.UI.RadGroupBox();
            this.ddlWindowStyle = new Telerik.WinControls.UI.RadDropDownList();
            this.cbTerminate = new Telerik.WinControls.UI.RadCheckBox();
            this.btnSaveTask = new Telerik.WinControls.UI.RadButton();
            this.btnDeleteTask = new Telerik.WinControls.UI.RadButton();
            this.gbKey = new Telerik.WinControls.UI.RadGroupBox();
            this.ddlKeys = new Telerik.WinControls.UI.RadDropDownList();
            this.gbName = new Telerik.WinControls.UI.RadGroupBox();
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.cbAdmin = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gbWorkingDirectory)).BeginInit();
            this.gbWorkingDirectory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkingDirectory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbFilename)).BeginInit();
            this.gbFilename.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilename)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbArguments)).BeginInit();
            this.gbArguments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteArgument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditArgument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddArgument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvArguments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbWindowStyle)).BeginInit();
            this.gbWindowStyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlWindowStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTerminate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbKey)).BeginInit();
            this.gbKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlKeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbName)).BeginInit();
            this.gbName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gbWorkingDirectory
            // 
            this.gbWorkingDirectory.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbWorkingDirectory.Controls.Add(this.txtWorkingDirectory);
            this.gbWorkingDirectory.HeaderText = "Enter working directory";
            this.gbWorkingDirectory.Location = new System.Drawing.Point(12, 94);
            this.gbWorkingDirectory.Name = "gbWorkingDirectory";
            this.gbWorkingDirectory.Size = new System.Drawing.Size(404, 71);
            this.gbWorkingDirectory.TabIndex = 3;
            this.gbWorkingDirectory.Text = "Enter working directory";
            this.gbWorkingDirectory.ThemeName = "TelerikMetro";
            // 
            // txtWorkingDirectory
            // 
            this.txtWorkingDirectory.Location = new System.Drawing.Point(15, 30);
            this.txtWorkingDirectory.Name = "txtWorkingDirectory";
            this.txtWorkingDirectory.Size = new System.Drawing.Size(369, 24);
            this.txtWorkingDirectory.TabIndex = 0;
            this.txtWorkingDirectory.ThemeName = "TelerikMetro";
            // 
            // gbFilename
            // 
            this.gbFilename.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbFilename.Controls.Add(this.txtFilename);
            this.gbFilename.HeaderText = "Enter filename";
            this.gbFilename.Location = new System.Drawing.Point(12, 171);
            this.gbFilename.Name = "gbFilename";
            this.gbFilename.Size = new System.Drawing.Size(404, 68);
            this.gbFilename.TabIndex = 4;
            this.gbFilename.Text = "Enter filename";
            this.gbFilename.ThemeName = "TelerikMetro";
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(15, 32);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(369, 24);
            this.txtFilename.TabIndex = 0;
            this.txtFilename.ThemeName = "TelerikMetro";
            // 
            // gbArguments
            // 
            this.gbArguments.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbArguments.Controls.Add(this.btnDeleteArgument);
            this.gbArguments.Controls.Add(this.btnEditArgument);
            this.gbArguments.Controls.Add(this.btnAddArgument);
            this.gbArguments.Controls.Add(this.lvArguments);
            this.gbArguments.HeaderText = "Arguments";
            this.gbArguments.Location = new System.Drawing.Point(12, 245);
            this.gbArguments.Name = "gbArguments";
            this.gbArguments.Size = new System.Drawing.Size(404, 192);
            this.gbArguments.TabIndex = 5;
            this.gbArguments.Text = "Arguments";
            this.gbArguments.ThemeName = "TelerikMetro";
            // 
            // btnDeleteArgument
            // 
            this.btnDeleteArgument.Location = new System.Drawing.Point(240, 149);
            this.btnDeleteArgument.Name = "btnDeleteArgument";
            this.btnDeleteArgument.Size = new System.Drawing.Size(86, 24);
            this.btnDeleteArgument.TabIndex = 3;
            this.btnDeleteArgument.Text = "Delete";
            this.btnDeleteArgument.ThemeName = "TelerikMetro";
            this.btnDeleteArgument.Click += new System.EventHandler(this.btnDeleteArgument_Click);
            // 
            // btnEditArgument
            // 
            this.btnEditArgument.Location = new System.Drawing.Point(151, 149);
            this.btnEditArgument.Name = "btnEditArgument";
            this.btnEditArgument.Size = new System.Drawing.Size(86, 24);
            this.btnEditArgument.TabIndex = 2;
            this.btnEditArgument.Text = "Edit";
            this.btnEditArgument.ThemeName = "TelerikMetro";
            this.btnEditArgument.Click += new System.EventHandler(this.btnEditArgument_Click);
            // 
            // btnAddArgument
            // 
            this.btnAddArgument.Location = new System.Drawing.Point(59, 149);
            this.btnAddArgument.Name = "btnAddArgument";
            this.btnAddArgument.Size = new System.Drawing.Size(86, 24);
            this.btnAddArgument.TabIndex = 1;
            this.btnAddArgument.Text = "Add";
            this.btnAddArgument.ThemeName = "TelerikMetro";
            this.btnAddArgument.Click += new System.EventHandler(this.btnAddArgument_Click);
            // 
            // lvArguments
            // 
            this.lvArguments.AllowEdit = false;
            listViewDetailColumn1.HeaderText = "ID";
            listViewDetailColumn1.Visible = false;
            listViewDetailColumn2.HeaderText = "Name";
            listViewDetailColumn3.HeaderText = "Value";
            this.lvArguments.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3});
            this.lvArguments.ItemSpacing = -1;
            this.lvArguments.Location = new System.Drawing.Point(15, 29);
            this.lvArguments.Name = "lvArguments";
            this.lvArguments.Size = new System.Drawing.Size(369, 95);
            this.lvArguments.TabIndex = 0;
            this.lvArguments.Text = "radListView1";
            this.lvArguments.ThemeName = "TelerikMetro";
            this.lvArguments.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            // 
            // gbWindowStyle
            // 
            this.gbWindowStyle.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbWindowStyle.Controls.Add(this.ddlWindowStyle);
            this.gbWindowStyle.HeaderText = "Select window style";
            this.gbWindowStyle.Location = new System.Drawing.Point(12, 443);
            this.gbWindowStyle.Name = "gbWindowStyle";
            this.gbWindowStyle.Size = new System.Drawing.Size(404, 67);
            this.gbWindowStyle.TabIndex = 6;
            this.gbWindowStyle.Text = "Select window style";
            this.gbWindowStyle.ThemeName = "TelerikMetro";
            // 
            // ddlWindowStyle
            // 
            this.ddlWindowStyle.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlWindowStyle.Location = new System.Drawing.Point(25, 29);
            this.ddlWindowStyle.Name = "ddlWindowStyle";
            this.ddlWindowStyle.Size = new System.Drawing.Size(359, 24);
            this.ddlWindowStyle.TabIndex = 0;
            this.ddlWindowStyle.ThemeName = "TelerikMetro";
            // 
            // cbTerminate
            // 
            this.cbTerminate.Location = new System.Drawing.Point(12, 525);
            this.cbTerminate.Name = "cbTerminate";
            this.cbTerminate.Size = new System.Drawing.Size(178, 19);
            this.cbTerminate.TabIndex = 7;
            this.cbTerminate.Text = "Run task and then terminate";
            this.cbTerminate.ThemeName = "TelerikMetro";
            // 
            // btnSaveTask
            // 
            this.btnSaveTask.Location = new System.Drawing.Point(37, 604);
            this.btnSaveTask.Name = "btnSaveTask";
            this.btnSaveTask.Size = new System.Drawing.Size(168, 24);
            this.btnSaveTask.TabIndex = 8;
            this.btnSaveTask.Text = "Save";
            this.btnSaveTask.ThemeName = "TelerikMetro";
            this.btnSaveTask.Click += new System.EventHandler(this.btnSaveTask_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(224, 604);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(168, 24);
            this.btnDeleteTask.TabIndex = 9;
            this.btnDeleteTask.Text = "Delete";
            this.btnDeleteTask.ThemeName = "TelerikMetro";
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // gbKey
            // 
            this.gbKey.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbKey.Controls.Add(this.ddlKeys);
            this.gbKey.HeaderText = "Select key";
            this.gbKey.Location = new System.Drawing.Point(12, 12);
            this.gbKey.Name = "gbKey";
            this.gbKey.Size = new System.Drawing.Size(163, 65);
            this.gbKey.TabIndex = 10;
            this.gbKey.Text = "Select key";
            this.gbKey.ThemeName = "TelerikMetro";
            // 
            // ddlKeys
            // 
            this.ddlKeys.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlKeys.Location = new System.Drawing.Point(15, 30);
            this.ddlKeys.Name = "ddlKeys";
            this.ddlKeys.Size = new System.Drawing.Size(130, 24);
            this.ddlKeys.TabIndex = 0;
            this.ddlKeys.ThemeName = "TelerikMetro";
            this.ddlKeys.SelectedValueChanged += new System.EventHandler(this.ddlKeys_SelectedValueChanged);
            this.ddlKeys.Enter += new System.EventHandler(this.ddlKeys_Enter);
            // 
            // gbName
            // 
            this.gbName.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbName.Controls.Add(this.txtName);
            this.gbName.HeaderText = "Enter task name";
            this.gbName.Location = new System.Drawing.Point(192, 12);
            this.gbName.Name = "gbName";
            this.gbName.Size = new System.Drawing.Size(224, 65);
            this.gbName.TabIndex = 11;
            this.gbName.Text = "Enter task name";
            this.gbName.ThemeName = "TelerikMetro";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(17, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 24);
            this.txtName.TabIndex = 0;
            this.txtName.ThemeName = "TelerikMetro";
            // 
            // cbAdmin
            // 
            this.cbAdmin.Location = new System.Drawing.Point(12, 559);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(166, 19);
            this.cbAdmin.TabIndex = 12;
            this.cbAdmin.Text = "Start task as administrator";
            this.cbAdmin.ThemeName = "TelerikMetro";
            // 
            // FormTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 651);
            this.Controls.Add(this.cbAdmin);
            this.Controls.Add(this.gbName);
            this.Controls.Add(this.gbKey);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnSaveTask);
            this.Controls.Add(this.cbTerminate);
            this.Controls.Add(this.gbWindowStyle);
            this.Controls.Add(this.gbArguments);
            this.Controls.Add(this.gbFilename);
            this.Controls.Add(this.gbWorkingDirectory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormTask";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Task";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.FormTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbWorkingDirectory)).EndInit();
            this.gbWorkingDirectory.ResumeLayout(false);
            this.gbWorkingDirectory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkingDirectory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbFilename)).EndInit();
            this.gbFilename.ResumeLayout(false);
            this.gbFilename.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilename)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbArguments)).EndInit();
            this.gbArguments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteArgument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditArgument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddArgument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvArguments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbWindowStyle)).EndInit();
            this.gbWindowStyle.ResumeLayout(false);
            this.gbWindowStyle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlWindowStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTerminate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbKey)).EndInit();
            this.gbKey.ResumeLayout(false);
            this.gbKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlKeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbName)).EndInit();
            this.gbName.ResumeLayout(false);
            this.gbName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadGroupBox gbWorkingDirectory;
        private Telerik.WinControls.UI.RadTextBox txtWorkingDirectory;
        private Telerik.WinControls.UI.RadGroupBox gbFilename;
        private Telerik.WinControls.UI.RadTextBox txtFilename;
        private Telerik.WinControls.UI.RadGroupBox gbArguments;
        private Telerik.WinControls.UI.RadListView lvArguments;
        private Telerik.WinControls.UI.RadButton btnDeleteArgument;
        private Telerik.WinControls.UI.RadButton btnEditArgument;
        private Telerik.WinControls.UI.RadButton btnAddArgument;
        private Telerik.WinControls.UI.RadGroupBox gbWindowStyle;
        private Telerik.WinControls.UI.RadDropDownList ddlWindowStyle;
        private Telerik.WinControls.UI.RadCheckBox cbTerminate;
        private Telerik.WinControls.UI.RadButton btnSaveTask;
        private Telerik.WinControls.UI.RadButton btnDeleteTask;
        private Telerik.WinControls.UI.RadGroupBox gbKey;
        private Telerik.WinControls.UI.RadDropDownList ddlKeys;
        private Telerik.WinControls.UI.RadGroupBox gbName;
        private Telerik.WinControls.UI.RadTextBox txtName;
        private Telerik.WinControls.UI.RadCheckBox cbAdmin;
    }
}
