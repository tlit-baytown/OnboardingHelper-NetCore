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

namespace OnboardingHelper_NetCore.userControls
{
    public partial class ProgramsUserCtl : UserControl
    {
        public ProgramsUserCtl()
        {
            InitializeComponent();
        }

        private void btnAddApplication_Click(object sender, EventArgs e)
        {
            AddApplicationPopUp popUp = new AddApplicationPopUp();
            popUp.ApplicationAdded += UpdateGrid;

            popUp.ShowDialog();
        }

        private void btnDeleteApplications_Click(object sender, EventArgs e)
        {
            if (dgApplications.SelectedRows.Count <= 0)
            {
                MessageBox.Show(this, "No rows were selected to delete. Please select at least 1 row and try again.", "Empty Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"Are you sure you wish to delete {dgApplications.SelectedRows.Count} programs?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.No || result == DialogResult.Cancel)
                return;

            foreach (DataGridViewRow row in dgApplications.SelectedRows)
                ApplicationWrapper.RemoveApplication((wrappers.Application)row.Tag);

            dgApplications.Rows.Clear();
            dgApplications.Update();
            foreach (wrappers.Application app in ApplicationWrapper.Applications)
            {
                UpdateGrid(this, new CEventArgs.ApplicationAddedEventArgs(app));
            }
        }

        private void UpdateGrid(object o, EventArgs e)
        {
            if (e is CEventArgs.ApplicationAddedEventArgs a)
            {
                wrappers.Application app = a.AddedApplication;

                foreach (DataGridViewRow r in dgApplications.Rows)
                    if (r.Tag != null)
                        if (((wrappers.Application)r.Tag).Name.Equals(app.Name))
                            return;

                int rowID = dgApplications.Rows.Add();

                DataGridViewRow row = dgApplications.Rows[rowID];
                row.Tag = app;

                row.Cells[0].Value = app.Name;
                row.Cells[1].Value = app.InstallArguments;
                row.Cells[2].Value = app.Path;
                row.Cells[3].Value = app.IsWindowsInstaller;
                row.Cells[4].Value = app.IsISOImage;
            }
        }
    }
}
