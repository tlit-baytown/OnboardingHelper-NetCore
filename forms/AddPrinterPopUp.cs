using OnboardingHelper_NetCore.wrappers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAndClear_Click(object sender, EventArgs e)
        {

        }

        private void txtPrinterName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtComment_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbDriverNames_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbDriverNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkCreateNewDriver_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnOpenINF_Click(object sender, EventArgs e)
        {

        }

        private void chkIsNetworkSharedPrinter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtConnectionName_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkShouldShare_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtShareName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
