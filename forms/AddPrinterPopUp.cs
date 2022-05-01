using OnboardingHelper_NetCore.settings;
using OnboardingHelper_NetCore.wrappers;

namespace OnboardingHelper_NetCore.forms
{
    public partial class AddPrinterPopUp : Form
    {
        public EventHandler? PrinterAdded;

        private readonly Printer printer = new Printer();

        public AddPrinterPopUp()
        {
            InitializeComponent();
        }

        private void AddPrinterPopUp_Load(object sender, EventArgs e)
        {
            cmbDriverNames.DataSource = PowershellHelper.GetPrinterDriversInstalled();
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
                chkCreateNewDriver.Checked = true;
            else
                chkCreateNewDriver.Checked = false;
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
        }

        private void btnOpenINF_Click(object sender, EventArgs e)
        {
            if (dlgOpenINF.ShowDialog() == DialogResult.OK)
            {
                printer.INFPath = dlgOpenINF.FileName;
                printer.ShouldCreateDriver = true;
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
