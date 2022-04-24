﻿namespace OnboardingHelper_NetCore.userControls
{
    partial class ProgramsUserCtl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeleteApplications = new System.Windows.Forms.Button();
            this.btnAddApplication = new System.Windows.Forms.Button();
            this.dgApplications = new System.Windows.Forms.DataGridView();
            this.appName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appArguments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appIsWindowsInstaller = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.appIsISOImage = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgApplications)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteApplications
            // 
            this.btnDeleteApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteApplications.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteApplications.Location = new System.Drawing.Point(589, 386);
            this.btnDeleteApplications.Name = "btnDeleteApplications";
            this.btnDeleteApplications.Size = new System.Drawing.Size(142, 23);
            this.btnDeleteApplications.TabIndex = 5;
            this.btnDeleteApplications.Text = "Delete Selected";
            this.btnDeleteApplications.UseVisualStyleBackColor = false;
            this.btnDeleteApplications.Click += new System.EventHandler(this.btnDeleteApplications_Click);
            // 
            // btnAddApplication
            // 
            this.btnAddApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddApplication.Location = new System.Drawing.Point(14, 386);
            this.btnAddApplication.Name = "btnAddApplication";
            this.btnAddApplication.Size = new System.Drawing.Size(142, 23);
            this.btnAddApplication.TabIndex = 4;
            this.btnAddApplication.Text = "Add Application...";
            this.btnAddApplication.UseVisualStyleBackColor = false;
            this.btnAddApplication.Click += new System.EventHandler(this.btnAddApplication_Click);
            // 
            // dgApplications
            // 
            this.dgApplications.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgApplications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appName,
            this.appArguments,
            this.appPath,
            this.appIsWindowsInstaller,
            this.appIsISOImage});
            this.dgApplications.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgApplications.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgApplications.Location = new System.Drawing.Point(0, 0);
            this.dgApplications.Name = "dgApplications";
            this.dgApplications.ReadOnly = true;
            this.dgApplications.RowTemplate.Height = 25;
            this.dgApplications.ShowEditingIcon = false;
            this.dgApplications.Size = new System.Drawing.Size(746, 380);
            this.dgApplications.TabIndex = 3;
            // 
            // appName
            // 
            this.appName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.appName.HeaderText = "Name";
            this.appName.Name = "appName";
            this.appName.ReadOnly = true;
            this.appName.Width = 62;
            // 
            // appArguments
            // 
            this.appArguments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.appArguments.HeaderText = "Install Arguments";
            this.appArguments.Name = "appArguments";
            this.appArguments.ReadOnly = true;
            this.appArguments.Width = 113;
            // 
            // appPath
            // 
            this.appPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.appPath.HeaderText = "Path To Installer";
            this.appPath.Name = "appPath";
            this.appPath.ReadOnly = true;
            // 
            // appIsWindowsInstaller
            // 
            this.appIsWindowsInstaller.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.appIsWindowsInstaller.HeaderText = "Is Windows Installer?";
            this.appIsWindowsInstaller.Name = "appIsWindowsInstaller";
            this.appIsWindowsInstaller.ReadOnly = true;
            this.appIsWindowsInstaller.Width = 108;
            // 
            // appIsISOImage
            // 
            this.appIsISOImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.appIsISOImage.HeaderText = "Is ISO Image?";
            this.appIsISOImage.Name = "appIsISOImage";
            this.appIsISOImage.ReadOnly = true;
            this.appIsISOImage.Width = 73;
            // 
            // ProgramsUserCtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteApplications);
            this.Controls.Add(this.btnAddApplication);
            this.Controls.Add(this.dgApplications);
            this.Name = "ProgramsUserCtl";
            this.Size = new System.Drawing.Size(746, 417);
            ((System.ComponentModel.ISupportInitialize)(this.dgApplications)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnDeleteApplications;
        private Button btnAddApplication;
        private DataGridView dgApplications;
        private DataGridViewTextBoxColumn appName;
        private DataGridViewTextBoxColumn appArguments;
        private DataGridViewTextBoxColumn appPath;
        private DataGridViewCheckBoxColumn appIsWindowsInstaller;
        private DataGridViewCheckBoxColumn appIsISOImage;
    }
}
