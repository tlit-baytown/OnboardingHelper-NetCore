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
    public partial class AddVPNPopUp : Form
    {
        public EventHandler VPNAdded;

        private VPN vpn = new VPN();
        private string password = string.Empty;
        private string psk = string.Empty;
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
            if (AddAndClear())
                VPNAdded?.Invoke(this, new CEventArgs.VPNAddedEventArgs(vpn));
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
                return false;
            if (txtServerAddress.Text.Length <= 0)
                return false;
            if (grpCredentials.Visible)
            {
                if (isUsingPSK)
                {
                    if (txtUsername.Text.Length <= 0)
                        return false;
                    vpn.PreSharedKey = new NetworkCredential("", psk).SecurePassword;
                }
                else
                {
                    vpn.Password = new NetworkCredential("", password).SecurePassword;
                }
            }

            vpn.SetBase64Passwords();
            EnumHelper.ErrorCodes error = Configuration.Instance.AddVPN(vpn);
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
            vpn = new VPN();
            psk = string.Empty;
            password = string.Empty;

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

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (isUsingPSK)
                psk = txtUsername.Text;
            else
                vpn.Username = txtUsername.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!isUsingPSK)
                password = txtPassword.Text;
        }

        private void txtConnectionName_TextChanged(object sender, EventArgs e)
        {
            vpn.ConnectionName = txtConnectionName.Text;
        }

        private void txtServerAddress_TextChanged(object sender, EventArgs e)
        {
            vpn.ServerAddress = txtServerAddress.Text;
        }

        /// <summary>
        /// Switches the input from a username and password to a pre-shared key.
        /// </summary>
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

        /// <summary>
        /// Switches the input from pre-shared key to a username and password.
        /// </summary>
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
