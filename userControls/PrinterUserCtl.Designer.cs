namespace OnboardingHelper_NetCore.userControls
{
    partial class PrinterUserCtl
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
            this.dgPrinters = new System.Windows.Forms.DataGridView();
            this.btnAddPrinter = new System.Windows.Forms.Button();
            this.btnDeletePrinter = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.columnPrinterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHostname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnShouldShare = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnShareName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrinters)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgPrinters
            // 
            this.dgPrinters.AllowUserToAddRows = false;
            this.dgPrinters.AllowUserToDeleteRows = false;
            this.dgPrinters.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgPrinters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPrinters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnPrinterName,
            this.columnHostname,
            this.columnPort,
            this.columnDriverName,
            this.columnShouldShare,
            this.columnShareName});
            this.dgPrinters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPrinters.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgPrinters.Location = new System.Drawing.Point(0, 0);
            this.dgPrinters.Name = "dgPrinters";
            this.dgPrinters.ReadOnly = true;
            this.dgPrinters.RowTemplate.Height = 25;
            this.dgPrinters.Size = new System.Drawing.Size(765, 316);
            this.dgPrinters.TabIndex = 11;
            // 
            // btnAddPrinter
            // 
            this.btnAddPrinter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddPrinter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddPrinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPrinter.Location = new System.Drawing.Point(3, 8);
            this.btnAddPrinter.Name = "btnAddPrinter";
            this.btnAddPrinter.Size = new System.Drawing.Size(142, 23);
            this.btnAddPrinter.TabIndex = 6;
            this.btnAddPrinter.Text = "Add Printer...";
            this.btnAddPrinter.UseVisualStyleBackColor = false;
            this.btnAddPrinter.Click += new System.EventHandler(this.btnAddPrinter_Click);
            // 
            // btnDeletePrinter
            // 
            this.btnDeletePrinter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDeletePrinter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeletePrinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePrinter.ForeColor = System.Drawing.Color.Black;
            this.btnDeletePrinter.Location = new System.Drawing.Point(620, 8);
            this.btnDeletePrinter.Name = "btnDeletePrinter";
            this.btnDeletePrinter.Size = new System.Drawing.Size(142, 23);
            this.btnDeletePrinter.TabIndex = 7;
            this.btnDeletePrinter.Text = "Delete Selected";
            this.btnDeletePrinter.UseVisualStyleBackColor = false;
            this.btnDeletePrinter.Click += new System.EventHandler(this.btnDeletePrinter_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnAddPrinter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeletePrinter, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 316);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(765, 40);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // columnPrinterName
            // 
            this.columnPrinterName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnPrinterName.HeaderText = "Name";
            this.columnPrinterName.Name = "columnPrinterName";
            this.columnPrinterName.ReadOnly = true;
            // 
            // columnHostname
            // 
            this.columnHostname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnHostname.HeaderText = "Hostname/IP Address";
            this.columnHostname.Name = "columnHostname";
            this.columnHostname.ReadOnly = true;
            // 
            // columnPort
            // 
            this.columnPort.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnPort.HeaderText = "Port";
            this.columnPort.Name = "columnPort";
            this.columnPort.ReadOnly = true;
            // 
            // columnDriverName
            // 
            this.columnDriverName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnDriverName.HeaderText = "Driver Name";
            this.columnDriverName.Name = "columnDriverName";
            this.columnDriverName.ReadOnly = true;
            // 
            // columnShouldShare
            // 
            this.columnShouldShare.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnShouldShare.HeaderText = "Share Printer?";
            this.columnShouldShare.Name = "columnShouldShare";
            this.columnShouldShare.ReadOnly = true;
            // 
            // columnShareName
            // 
            this.columnShareName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnShareName.HeaderText = "Share Name";
            this.columnShareName.Name = "columnShareName";
            this.columnShareName.ReadOnly = true;
            // 
            // PrinterUserCtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgPrinters);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PrinterUserCtl";
            this.Size = new System.Drawing.Size(765, 356);
            ((System.ComponentModel.ISupportInitialize)(this.dgPrinters)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgPrinters;
        private Button btnAddPrinter;
        private Button btnDeletePrinter;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn columnPrinterName;
        private DataGridViewTextBoxColumn columnHostname;
        private DataGridViewTextBoxColumn columnPort;
        private DataGridViewTextBoxColumn columnDriverName;
        private DataGridViewCheckBoxColumn columnShouldShare;
        private DataGridViewTextBoxColumn columnShareName;
    }
}
