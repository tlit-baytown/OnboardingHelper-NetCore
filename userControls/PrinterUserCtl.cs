using OnboardingHelper_NetCore.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnboardingHelper_NetCore.userControls
{
    public partial class PrinterUserCtl : UserControl, IUpdatable
    {
        public PrinterUserCtl()
        {
            InitializeComponent();
        }

        public bool UpdateValues()
        {
            throw new NotImplementedException();
        }

        private void btnAddPrinter_Click(object sender, EventArgs e)
        {
            AddPrinterPopUp popUp = new AddPrinterPopUp();
            popUp.PrinterAdded += UpdateGrid;

            popUp.ShowDialog();
        }

        private void btnDeletePrinter_Click(object sender, EventArgs e)
        {

        }

        private void UpdateGrid(object sender, EventArgs e)
        {

        }
    }
}
