using OnboardingHelper_NetCore.settings;
using OnboardingHelper_NetCore.wrappers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnboardingHelper_NetCore.forms
{
    public partial class AddMappedDrivePopUp : Form
    {
        public EventHandler? MappedDriveAdded;

        private MappedDrive drive = new MappedDrive();

        public AddMappedDrivePopUp()
        {
            InitializeComponent();
        }

        private void AddMappedDrivePopUp_Load(object sender, EventArgs e)
        {
            cmbDriveLetters.DataSource = Enum.GetValues(typeof(DriveLetter));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Add())
            {
                MappedDriveAdded?.Invoke(this, new CEventArgs.MappedDriveAdddedEventArgs(drive));
                Close();
            }
        }

        private void btnAddAndClear_Click(object sender, EventArgs e)
        {
            if (AddAndClear())
                MappedDriveAdded?.Invoke(this, new CEventArgs.MappedDriveAdddedEventArgs(drive));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool Add()
        {
            if (!drive.Path.StartsWith("\\\\"))
                return false;
            if (drive.ConnectUsingDifferentCredentials)
            {
                drive.Password = new NetworkCredential("", pw).SecurePassword;
                drive.SetBase64Password();
            }

            EnumHelper.ErrorCodes error = Configuration.Instance.AddMappedDrive(drive);
            return error == EnumHelper.ErrorCodes.NO_ERROR;
        }

        private bool AddAndClear()
        {
            if (Add())
            {
                Clear();
                return true;
            }
            return false;
        }

        private void Clear()
        {
            cmbDriveLetters.SelectedItem = DriveLetter.Z;
            txtPath.Text = string.Empty;

            chkReconnect.Checked = true;
            chkDifferentCreds.Checked = false;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            pw = string.Empty;
        }

        private void cmbDriveLetters_SelectedIndexChanged(object sender, EventArgs e)
        {
            drive.DriveLetter = (DriveLetter) cmbDriveLetters.SelectedItem;
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            drive.Path = txtPath.Text;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            drive.Username = txtUsername.Text;
        }

        string pw = string.Empty;
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            pw = txtPassword.Text;
        }

        private void chkReconnect_CheckedChanged(object sender, EventArgs e)
        {
            drive.ReconnectAtSignIn = chkReconnect.Checked;
        }

        private void chkDifferentCreds_CheckedChanged(object sender, EventArgs e)
        {
            drive.ConnectUsingDifferentCredentials = chkDifferentCreds.Checked;

            tlpCredentials.Visible = chkDifferentCreds.Checked;
        }
    }
}
