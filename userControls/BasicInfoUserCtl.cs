using System.Net;
using System.Text;
using Zest_Script.settings;

namespace Zest_Script.userControls
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

            if (SystemInfo.Instance.OSName != null)
            {
                if (SystemInfo.Instance.OSName.Contains("Home"))
                {
                    txtDomain.Enabled = false;
                    txtDomain.PlaceholderText = "Domain is not available in 'Home' versions of Windows!";
                }
            }
        }

        /// <summary>
        /// Update values in this control based on the values in <see cref="Configuration"/>.
        /// </summary>
        /// <returns></returns>
        public bool UpdateValues()
        {
            txtComputerName.Text = Configuration.Instance.BasicInfo.ComputerName;
            if (txtDomain.Enabled)
            {
                txtDomain.Text = Configuration.Instance.BasicInfo.Domain;
                txtDomainUsername.Text = Configuration.Instance.BasicInfo.DomainUsername;
                txtDomainPassword.Text = Encoding.UTF8.GetString(Convert.FromBase64String(Configuration.Instance.BasicInfo.Base64DomainPassword));
            }

            cmbTimeZones.SelectedItem = Configuration.Instance.BasicInfo.TimeZone;
            if (cmbNTPServers.Items.Contains(Configuration.Instance.BasicInfo.PrimaryNTPServer))
                cmbNTPServers.SelectedItem = Configuration.Instance.BasicInfo.PrimaryNTPServer;
            else
                cmbNTPServers.Text = Configuration.Instance.BasicInfo.PrimaryNTPServer;

            chkPerformTZSync.Checked = Configuration.Instance.BasicInfo.PerformTimeSync;

            return true;
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

            Configuration.Instance.BasicInfo.Domain = txtDomain.Text;
        }

        private void txtComputerName_TextChanged(object sender, EventArgs e)
        {
            Configuration.Instance.BasicInfo.ComputerName = txtComputerName.Text;
        }

        private void cmbTimeZones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Configuration.Instance.BasicInfo.TimeZone = (TimeZoneInfo)cmbTimeZones.SelectedItem;
            Configuration.Instance.BasicInfo.TimeZoneString = Configuration.Instance.BasicInfo.TimeZone.ToSerializedString();
        }

        private void cmbNTPServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Configuration.Instance.BasicInfo.PrimaryNTPServer = (string)cmbNTPServers.SelectedItem;
        }

        private void cmbNTPServers_TextChanged(object sender, EventArgs e)
        {
            Configuration.Instance.BasicInfo.PrimaryNTPServer = cmbNTPServers.Text;
        }

        private void chkPerformTZSync_CheckedChanged(object sender, EventArgs e)
        {
            Configuration.Instance.BasicInfo.PerformTimeSync = chkPerformTZSync.Checked;
        }

        private void txtDomainUsername_TextChanged(object sender, EventArgs e)
        {
            Configuration.Instance.BasicInfo.DomainUsername = txtDomainUsername.Text;
        }

        string pw = string.Empty;
        private void txtDomainPassword_TextChanged(object sender, EventArgs e)
        {
            pw = txtDomainPassword.Text;
        }

        private void txtDomainPassword_Leave(object sender, EventArgs e)
        {
            Configuration.Instance.BasicInfo.DomainPassword = new NetworkCredential("", pw).SecurePassword;
            Configuration.Instance.BasicInfo.SetBase64FromPassword();
        }
        #endregion
    }
}
