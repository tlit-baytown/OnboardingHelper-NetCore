using OnboardingHelper_NetCore.settings;
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
    public partial class BasicInfoUserCtl : UserControl, IUpdatable
    {
        public BasicInfoUserCtl()
        {
            InitializeComponent();
        }

        private void BasicInfoUserCtl_Load(object sender, EventArgs e)
        {
            cmbTimeZones.DataSource = Utility.GetTimezones();
            cmbNTPServers.DataSource = Utility.GetPossibleNTPServers();

            if (SystemInfo.Instance.OSName.Contains("Home"))
            {
                txtDomain.Enabled = false;
                txtDomain.PlaceholderText = "Domain is not available in 'Home' versions of Windows!";
            }
        }

        public void UpdateValues()
        {
            txtComputerName.Text = Configuration.Instance.ComputerName;
            if (txtDomain.Enabled)
            {
                txtDomain.Text = Configuration.Instance.Domain;
                txtDomainUsername.Text = Configuration.Instance.DomainUsername;
                txtDomainPassword.Text = Encoding.UTF8.GetString(Convert.FromBase64String(Configuration.Instance.Base64DomainPassword));
            }

            cmbTimeZones.SelectedItem = Configuration.Instance.TimeZone;
            if (cmbNTPServers.Items.Contains(Configuration.Instance.PrimaryNTPServer))
                cmbNTPServers.SelectedItem = Configuration.Instance.PrimaryNTPServer;
            else
                cmbNTPServers.Text = Configuration.Instance.PrimaryNTPServer;

            chkPerformTZSync.Checked = Configuration.Instance.PerformTimeSync;
        }

        #region Event Handlers
        private void btnShowDomainPassword_MouseEnter(object sender, EventArgs e)
        {
            txtDomainPassword.UseSystemPasswordChar = false;
        }

        private void btnShowDomainPassword_MouseLeave(object sender, EventArgs e)
        {
            txtDomainPassword.UseSystemPasswordChar = true;
        }

        private void txtDomain_TextChanged(object sender, EventArgs e)
        {
            if (txtDomain.Text.Length > 0)
                grpDomainCredentials.Visible = true;
            else
                grpDomainCredentials.Visible = false;

            Configuration.Instance.Domain = txtDomain.Text;
        }

        private void txtComputerName_TextChanged(object sender, EventArgs e)
        {
            Configuration.Instance.ComputerName = txtComputerName.Text;
        }

        private void cmbTimeZones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Configuration.Instance.TimeZone = (TimeZoneInfo)cmbTimeZones.SelectedItem;
            Configuration.Instance.TimeZoneString = Configuration.Instance.TimeZone.ToSerializedString();
        }

        private void cmbNTPServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Configuration.Instance.PrimaryNTPServer = (string)cmbNTPServers.SelectedItem;
        }

        private void cmbNTPServers_TextChanged(object sender, EventArgs e)
        {
            Configuration.Instance.PrimaryNTPServer = cmbNTPServers.Text;
        }

        private void chkPerformTZSync_CheckedChanged(object sender, EventArgs e)
        {
            Configuration.Instance.PerformTimeSync = chkPerformTZSync.Checked;
        }

        private void txtDomainUsername_TextChanged(object sender, EventArgs e)
        {
            Configuration.Instance.DomainUsername = txtDomainUsername.Text;
        }

        string pw = string.Empty;
        private void txtDomainPassword_TextChanged(object sender, EventArgs e)
        {
            pw = txtDomainPassword.Text;
        }

        private void txtDomainPassword_Leave(object sender, EventArgs e)
        {
            Configuration.Instance.Base64DomainPassword = Convert.ToBase64String(Encoding.UTF8.GetBytes(pw));
        }
        #endregion
    }
}
