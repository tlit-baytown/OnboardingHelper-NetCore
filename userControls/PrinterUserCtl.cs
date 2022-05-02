using Zest_Script.forms;
using Zest_Script.settings;
using Zest_Script.wrappers;

namespace Zest_Script.userControls
{
    public partial class PrinterUserCtl : UserControl, IUpdatable
    {
        public PrinterUserCtl()
        {
            InitializeComponent();
        }

        public bool UpdateValues()
        {
            dgPrinters.Rows.Clear();
            dgPrinters.Update();

            foreach (Printer printer in Configuration.Instance.Printers)
                UpdateGrid(this, new CEventArgs.PrinterAddedEventArgs(printer));
            return true;
        }

        private void btnAddPrinter_Click(object sender, EventArgs e)
        {
            AddPrinterPopUp popUp = new AddPrinterPopUp();
            popUp.PrinterAdded += UpdateGrid;

            popUp.ShowDialog();
        }

        private void btnDeletePrinter_Click(object sender, EventArgs e)
        {
            if (dgPrinters.SelectedRows.Count <= 0)
            {
                MessageBox.Show(this, "No rows were selected to delete. Please select at least 1 row and try again.", "Empty Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"Are you sure you wish to delete {dgPrinters.SelectedRows.Count} printers?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.No || result == DialogResult.Cancel)
                return;

            foreach (DataGridViewRow row in dgPrinters.SelectedRows)
                Configuration.Instance.RemovePrinter((Printer)row.Tag);

            dgPrinters.Rows.Clear();
            dgPrinters.Update();
            foreach (Printer printer in Configuration.Instance.Printers)
            {
                UpdateGrid(this, new CEventArgs.PrinterAddedEventArgs(printer));
            }
        }

        private void UpdateGrid(object sender, EventArgs e)
        {
            if (e is CEventArgs.PrinterAddedEventArgs p)
            {
                Printer printer = p.Printer;

                foreach (DataGridViewRow r in dgPrinters.Rows)
                    if (r.Tag != null)
                        if (((Printer)r.Tag).Name.Equals(printer.Name))
                            return;

                int rowID = dgPrinters.Rows.Add();

                DataGridViewRow row = dgPrinters.Rows[rowID];
                row.Tag = printer;

                row.Cells[0].Value = printer.Name;
                row.Cells[1].Value = printer.Hostname;
                row.Cells[2].Value = printer.PortName;
                row.Cells[3].Value = printer.DriverName;
                row.Cells[4].Value = printer.IsShared;
                row.Cells[5].Value = printer.IsShared ? printer.ShareName : "<Printer is not shared>";
            }
        }
    }
}
