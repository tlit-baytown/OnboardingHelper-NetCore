using OnboardingHelper_NetCore.forms;
using OnboardingHelper_NetCore.settings;
using OnboardingHelper_NetCore.wrappers;

namespace OnboardingHelper_NetCore.userControls
{
    public partial class DriveUserCtl : UserControl, IUpdatable
    {
        public DriveUserCtl()
        {
            InitializeComponent();
        }

        public bool UpdateValues()
        {
            dgDrives.Rows.Clear();
            dgDrives.Update();

            foreach (MappedDrive drive in Configuration.Instance.MappedDrives)
            {
                drive.SetPasswordFromBase64();
                UpdateGrid(this, new CEventArgs.MappedDriveAdddedEventArgs(drive));
            }
            return true;
        }

        private void btnAddDrive_Click(object sender, EventArgs e)
        {
            AddMappedDrivePopUp popUp = new AddMappedDrivePopUp();
            popUp.MappedDriveAdded += UpdateGrid;

            popUp.ShowDialog();
        }

        private void btnDeleteDrive_Click(object sender, EventArgs e)
        {
            if (dgDrives.SelectedRows.Count <= 0)
            {
                MessageBox.Show(this, "No rows were selected to delete. Please select at least 1 row and try again.", "Empty Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"Are you sure you wish to delete {dgDrives.SelectedRows.Count} drives?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.No || result == DialogResult.Cancel)
                return;

            foreach (DataGridViewRow row in dgDrives.SelectedRows)
                Configuration.Instance.RemoveMappedDrive((MappedDrive)row.Tag);

            dgDrives.Rows.Clear();
            dgDrives.Update();
            foreach (MappedDrive drive in Configuration.Instance.MappedDrives)
            {
                UpdateGrid(this, new CEventArgs.MappedDriveAdddedEventArgs(drive));
            }
        }

        private void UpdateGrid(object o, EventArgs e)
        {
            if (e is CEventArgs.MappedDriveAdddedEventArgs d)
            {
                MappedDrive drive = d.Drive;

                foreach (DataGridViewRow r in dgDrives.Rows)
                    if (r.Tag != null)
                        if (((MappedDrive)r.Tag).DriveLetter == drive.DriveLetter)
                            return;

                int rowID = dgDrives.Rows.Add();

                DataGridViewRow row = dgDrives.Rows[rowID];
                row.Tag = drive;

                row.Cells[0].Value = drive.DriveLetter;
                row.Cells[1].Value = drive.Path;
                row.Cells[2].Value = drive.ReconnectAtSignIn;
                row.Cells[3].Value = drive.ConnectUsingDifferentCredentials;
            }
        }
    }
}
