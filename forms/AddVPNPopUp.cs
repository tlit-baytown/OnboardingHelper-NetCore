using System.Net;
using Zest_Script.settings;
using Zest_Script.wrappers;

namespace Zest_Script.forms
{
    public partial class AddVPNPopUp : Form
    {
        public EventHandler? VPNAdded;

        private readonly VPN vpn = new VPN();
        private bool isUsingPSK = false;

        public AddVPNPopUp()
        {
            InitializeComponent();
        }

        private void AddVPNPopUp_Load(object sender, EventArgs e)
        {
            cmbTunnelType.SelectedIndex = 1; //Select SSTP by default
            cmbEncryptionLevel.SelectedIndex = 2; //Select Required by default
            cmbAuthMethod.SelectedIndex = 2; //Select MSChapV2 by default
        }

        private void btnAddAndClear_Click(object sender, EventArgs e)
        {
            AddAndClear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Add())
            {
                VPNAdded?.Invoke(this, new CEventArgs.VPNAddedEventArgs(vpn));
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool Add()
        {
            if (txtConnectionName.Text.Length <= 0 || txtConnectionName.Text.Length >= 256)
            {
                Utility.ShowToolTip("Connection name cannot be empty.", txtConnectionName, toolTip);
                return false;
            }
            if (txtServerAddress.Text.Length <= 0)
            {
                Utility.ShowToolTip("Server address cannot be empty.", txtServerAddress, toolTip);
                return false;
            }
            if (grpCredentials.Visible)
            {
                if (isUsingPSK)
                {
                    if (txtUsername.Text.Length <= 0)
                    {
                        Utility.ShowToolTip("Pre-Shared Key cannot be empty.", txtUsername, toolTip);
                        return false;
                    }

                    vpn.PreSharedKey = new NetworkCredential("", pw).SecurePassword;
                }
                else
                {
                    vpn.Password = new NetworkCredential("", pw).SecurePassword;
                }
            }

            vpn.SetBase64Passwords();
            EnumHelper.ReturnCodes error = Configuration.Instance.AddVPN(vpn);
            return error == EnumHelper.ReturnCodes.NO_ERROR;
        }

        private bool AddAndClear()
        {
            if (Add())
            {
                VPNAdded?.Invoke(this, new CEventArgs.VPNAddedEventArgs(vpn));
                Clear();
                return true;
            }
            return false;
        }

        private void Clear()
        {
            txtConnectionName.Text = string.Empty;
            txtServerAddress.Text = string.Empty;

            cmbTunnelType.SelectedIndex = 1; //Select SSTP by default
            cmbEncryptionLevel.SelectedIndex = 2; //Select Required by default
            cmbAuthMethod.SelectedIndex = 2; //Select MSChapV2 by default

            chkRememberCredentials.Checked = false;
            chkSplitTunneling.Checked = false;
            chkAutoReconnect.Checked = false;

            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;

            pw = string.Empty;
        }

        private void cmbTunnelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTunnelType.SelectedIndex)
            {
                case 0:
                    vpn.TunnelType = TunnelType.IKEv2;
                    SwitchToPresharedKey();
                    break;
                case 1:
                    vpn.TunnelType = TunnelType.SSTP;
                    SwitchToUsernamePassword();
                    break;
                case 2:
                    vpn.TunnelType = TunnelType.L2TP_IPSEC_WITH_CERTIFICATE;
                    grpCredentials.Visible = false;
                    break;
                case 3:
                    vpn.TunnelType = TunnelType.L2TP_IPSEC_WITH_PSK;
                    SwitchToPresharedKey();
                    break;
                case 4:
                    vpn.TunnelType = TunnelType.PPTP;
                    SwitchToPresharedKey();
                    break;
                default:
                    vpn.TunnelType = TunnelType.SSTP;
                    SwitchToUsernamePassword();
                    break;
            }
        }

        private void cmbEncryptionLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbEncryptionLevel.SelectedIndex)
            {
                case 0:
                    vpn.EncryptionLevel = EncryptionLevel.NO_ENCRYPTION;
                    break;
                case 1:
                    vpn.EncryptionLevel = EncryptionLevel.OPTIONAL;
                    break;
                case 2:
                    vpn.EncryptionLevel = EncryptionLevel.REQUIRED;
                    break;
                case 3:
                    vpn.EncryptionLevel = EncryptionLevel.MAXIMUM;
                    break;
                case 4:
                    vpn.EncryptionLevel = EncryptionLevel.CUSTOM;
                    break;
                default:
                    vpn.EncryptionLevel = EncryptionLevel.REQUIRED;
                    break;
            }
        }

        private void cmbAuthMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbAuthMethod.SelectedIndex)
            {
                case 0:
                    vpn.AuthenticationMethod = AuthenticationMethod.PAP;
                    break;
                case 1:
                    vpn.AuthenticationMethod = AuthenticationMethod.CHAP;
                    break;
                case 2:
                    vpn.AuthenticationMethod = AuthenticationMethod.MSCHAPv2;
                    break;
                case 4:
                    vpn.AuthenticationMethod = AuthenticationMethod.EAP;
                    break;
                case 5:
                    vpn.AuthenticationMethod = AuthenticationMethod.MACHINE_CERTIFICATE;
                    break;
                default:
                    vpn.AuthenticationMethod = AuthenticationMethod.MSCHAPv2;
                    break;
            }
        }

        private void chkRememberCredentials_CheckedChanged(object sender, EventArgs e)
        {
            vpn.RememberCredentials = chkRememberCredentials.Checked;
        }

        private void chkSplitTunneling_CheckedChanged(object sender, EventArgs e)
        {
            vpn.EnableSplitTunneling = chkSplitTunneling.Checked;
        }

        private void chkAutoReconnect_CheckedChanged(object sender, EventArgs e)
        {
            vpn.AutoReconnect = chkAutoReconnect.Checked;
        }

        string pw = string.Empty;
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (isUsingPSK)
                pw = txtUsername.Text;
            else
                vpn.Username = txtUsername.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            pw = txtPassword.Text;
        }

        private void txtConnectionName_TextChanged(object sender, EventArgs e)
        {
            vpn.ConnectionName = txtConnectionName.Text;
        }

        private void txtServerAddress_TextChanged(object sender, EventArgs e)
        {
            vpn.ServerAddress = txtServerAddress.Text;
        }

        private void SwitchToPresharedKey()
        {
            grpCredentials.Visible = true;

            lblUsername.Text = "Pre-Shared Key: ";
            txtUsername.UseSystemPasswordChar = true;
            lblPassword.Visible = false;
            txtPassword.Visible = false;
            txtUsername.Clear();
            txtPassword.Clear();
            isUsingPSK = true;
        }

        private void SwitchToUsernamePassword()
        {
            grpCredentials.Visible = true;

            lblUsername.Text = "Username (optional): ";
            txtUsername.UseSystemPasswordChar = false;
            lblPassword.Visible = true;
            txtPassword.Visible = true;
            txtUsername.Clear();
            txtPassword.Clear();
            isUsingPSK = false;
        }

        private void nudIdleDisconnect_ValueChanged(object sender, EventArgs e)
        {
            if (int.TryParse(nudIdleDisconnect.Value.ToString(), out int disconnect))
                vpn.IdleDisconnectSeconds = disconnect;
            else
                nudIdleDisconnect.Value = 0;
        }

        private void btnSetDisconnectToZero_Click(object sender, EventArgs e)
        {
            nudIdleDisconnect.Value = 0;
        }
    }
}
