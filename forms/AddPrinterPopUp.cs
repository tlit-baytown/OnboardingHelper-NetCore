using Zest_Script.settings;
using Zest_Script.wrappers;

namespace Zest_Script.forms
{
    public partial class AddPrinterPopUp : Form
    {
        public EventHandler? PrinterAdded;

        private readonly Printer printer = new Printer();
        private List<string> printerDrivers = new List<string>();

        public AddPrinterPopUp()
        {
            InitializeComponent();
        }

        private void AddPrinterPopUp_Load(object sender, EventArgs e)
        {
            if (!bgGetDrivers.IsBusy)
            {
                cmbDriverNames.Enabled = false;
                bgGetDrivers.RunWorkerAsync();
            }
        }

        private void bgGetDrivers_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            bgGetDrivers.ReportProgress(50);
            printerDrivers = PowershellHelper.GetPrinterDriversInstalled();
            bgGetDrivers.ReportProgress(100);
        }

        private void bgGetDrivers_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            cmbDriverNames.Text = "Getting available printer drivers. Please wait...";
        }

        private void bgGetDrivers_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            cmbDriverNames.Enabled = true;
            cmbDriverNames.DataSource = printerDrivers;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Add())
            {
                PrinterAdded?.Invoke(this, new CEventArgs.PrinterAddedEventArgs(printer));
                Close();
            }
        }

        private void btnAddAndClear_Click(object sender, EventArgs e)
        {
            AddAndClear();
        }

        private bool Add()
        {
            if (chkIsNetworkSharedPrinter.Checked)
            {
                if (!printer.ConnectionName.StartsWith("\\\\"))
                {
                    Utility.ShowToolTip("The connection path should be a valid UNC path starting with: \\\\", txtConnectionName, toolTip);
                    return false;
                }
            }

            EnumHelper.ErrorCodes error = Configuration.Instance.AddPrinter(printer);
            return error == EnumHelper.ErrorCodes.NO_ERROR;
        }

        private bool AddAndClear()
        {
            if (Add())
            {
                PrinterAdded?.Invoke(this, new CEventArgs.PrinterAddedEventArgs(printer));
                Clear();
                return true;
            }
            return false;
        }

        private void Clear()
        {
            txtPrinterName.Text = string.Empty;
            txtComment.Text = string.Empty;
            if (cmbDriverNames.Items.Count > 0)
            {
                cmbDriverNames.SelectedIndex = 0;
                chkCreateNewDriver.Checked = false;
            }
            else
                chkCreateNewDriver.Checked = true;

            printer.INFPath = string.Empty;
            txtHostname.Text = string.Empty;
            txtPortName.Text = string.Empty;
            chkIsNetworkSharedPrinter.Checked = false;
            chkShouldShare.Checked = false;
            txtConnectionName.Text = string.Empty;
            txtShareName.Text = string.Empty;
        }

        private void txtPrinterName_TextChanged(object sender, EventArgs e)
        {
            printer.Name = txtPrinterName.Text;
        }

        private void txtComment_TextChanged(object sender, EventArgs e)
        {
            printer.Comment = txtComment.Text;
        }

        private void cmbDriverNames_TextChanged(object sender, EventArgs e)
        {
            if (!cmbDriverNames.Items.Contains(cmbDriverNames.Text))
            {
                chkCreateNewDriver.Checked = true;
                chkCreateNewDriver.Enabled = true;
            }
            else
            {
                chkCreateNewDriver.Checked = false;
                chkCreateNewDriver.Enabled = false;
            }
        }

        private void cmbDriverNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            printer.DriverName = (string)cmbDriverNames.SelectedItem;
        }

        private void chkCreateNewDriver_CheckedChanged(object sender, EventArgs e)
        {
            printer.ShouldCreateDriver = chkCreateNewDriver.Checked;
            flpINFPath.Visible = printer.ShouldCreateDriver;
            lblInfPath.Visible = printer.ShouldCreateDriver;

            if (!printer.ShouldCreateDriver)
            {
                printer.INFPath = string.Empty;
                lblPath.Text = "<path>";
                lblPath.ForeColor = Color.Black;

                if (cmbDriverNames.Items.Count > 0)
                    cmbDriverNames.SelectedIndex = 0;
            }
        }

        private void btnOpenINF_Click(object sender, EventArgs e)
        {
            if (dlgOpenINF.ShowDialog() == DialogResult.OK)
            {
                printer.INFPath = dlgOpenINF.FileName;
                printer.ShouldCreateDriver = true;
                lblPath.Text = printer.INFPath;
                lblPath.ForeColor = Color.Green;
            }
        }

        private void chkIsNetworkSharedPrinter_CheckedChanged(object sender, EventArgs e)
        {
            txtConnectionName.Visible = chkIsNetworkSharedPrinter.Checked;
            tableLayoutPanel3.Visible = !chkIsNetworkSharedPrinter.Checked;
        }

        private void txtConnectionName_TextChanged(object sender, EventArgs e)
        {
            printer.ConnectionName = txtConnectionName.Text;
        }

        private void chkShouldShare_CheckedChanged(object sender, EventArgs e)
        {
            txtShareName.Visible = chkShouldShare.Checked;
            printer.IsShared = chkShouldShare.Checked;
        }

        private void txtShareName_TextChanged(object sender, EventArgs e)
        {
            printer.ShareName = txtShareName.Text;
        }

        private void txtHostname_TextChanged(object sender, EventArgs e)
        {
            printer.Hostname = txtHostname.Text;
        }

        private void txtPortName_TextChanged(object sender, EventArgs e)
        {
            printer.PortName = txtPortName.Text;
        }
    }
}
