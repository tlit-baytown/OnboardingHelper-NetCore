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
    public partial class AddWiFiPopUp : Form
    {
        public EventHandler WiFiAdded;

        private readonly WiFi wifi = new WiFi();

        public AddWiFiPopUp()
        {
            InitializeComponent();
        }

        private void AddWiFiPopUp_Load(object sender, EventArgs e)
        {
            cmbAuthenticationType.SelectedIndex = 3; //Set to WPA2: Pre-Shared Key by default
            cmbConnectionType.SelectedIndex = 0; //Set to ESS by default
            cmbEncryptionType.SelectedIndex = 3; //Set to AES by default
        }

        private void btnAddAndClear_Click(object sender, EventArgs e)
        {
            AddAndClear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Add())
            {
                WiFiAdded?.Invoke(this, new CEventArgs.WiFiAddedEventArgs(wifi));
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool Add()
        {
            if (txtSSID.Text.Length <= 0)
            {
                Utility.ShowToolTip("SSID cannot be empty.", txtSSID, toolTip);
                return false;
            }
            if (txtPSK.Visible && txtPSK.Text.Length <= 0)
            {
                if (wifi.WiFiType == WiFiType.WPA || wifi.WiFiType == WiFiType.WPA2PSK || 
                    wifi.WiFiType == WiFiType.WPA3PSK)
                {
                    Utility.ShowToolTip("Pre-Shared Key cannot be empty.", txtPSK, toolTip);
                    return false;
                }
            }
            if (grpEnterpriseCreds.Visible)
            {
                if (txtEnterpriseUsername.Text.Length <= 0)
                {
                    Utility.ShowToolTip("Username cannot be empty.", txtEnterpriseUsername, toolTip);
                    return false;
                }
                if (txtEnterprisePassword.Text.Length <= 0)
                {
                    DialogResult r = MessageBox.Show(this, "Password is empty. Continue anyway?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.No)
                        return false;
                }
            }

            if (grpEnterpriseCreds.Visible)
            {
                wifi.UserPassword = new NetworkCredential("", pw).SecurePassword;
            }
            else
            {
                wifi.PreSharedKey = new NetworkCredential("", pw).SecurePassword;
            }

            wifi.SetBase64Passwords();
            EnumHelper.ErrorCodes error = Configuration.Instance.AddWiFi(wifi);
            return error == EnumHelper.ErrorCodes.NO_ERROR;
        }

        private bool AddAndClear()
        {
            if (Add())
            {
                WiFiAdded?.Invoke(this, new CEventArgs.WiFiAddedEventArgs(wifi));
                Clear();
                return true;
            }
            return false;
        }

        private void Clear()
        {
            txtSSID.Text = string.Empty;
            txtPSK.Text = string.Empty;

            cmbAuthenticationType.SelectedIndex = 3; //Set to WPA2: Pre-Shared Key by default
            cmbConnectionType.SelectedIndex = 0; //Set to ESS by default
            cmbEncryptionType.SelectedIndex = 3; //Set to AES by default

            txtEnterpriseUsername.Text = string.Empty;
            txtEnterprisePassword.Text = string.Empty;
            chkIsHiddenNetwork.Checked = false;

            pw = string.Empty;
        }

        private void chkIsHiddenNetwork_CheckedChanged(object sender, EventArgs e)
        {
            wifi.IsHiddenNetwork = chkIsHiddenNetwork.Checked;
        }

        private void txtSSID_TextChanged(object sender, EventArgs e)
        {
            wifi.SSID = txtSSID.Text;
        }

        string pw = string.Empty;
        private void txtPSK_TextChanged(object sender, EventArgs e)
        {
            pw = txtPSK.Text;
        }

        private void txtEnterpriseUsername_TextChanged(object sender, EventArgs e)
        {
            wifi.Username = txtEnterpriseUsername.Text;
        }

        private void txtEnterprisePassword_TextChanged(object sender, EventArgs e)
        {
            pw = txtEnterprisePassword.Text;
        }

        private void cmbAuthenticationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbAuthenticationType.SelectedIndex)
            {
                case 0:
                    wifi.WiFiType = WiFiType.OPEN;
                    grpEnterpriseCreds.Visible = false;
                    lblPSK.Visible = false;
                    txtPSK.Visible = false;
                    break;
                case 1:
                    wifi.WiFiType = WiFiType.WEP;
                    grpEnterpriseCreds.Visible = false;
                    lblPSK.Visible = true;
                    txtPSK.Visible = true;
                    break;
                case 2:
                    wifi.WiFiType = WiFiType.WPA;
                    grpEnterpriseCreds.Visible = false;
                    lblPSK.Visible = true;
                    txtPSK.Visible = true;
                    break;
                case 3:
                    wifi.WiFiType = WiFiType.WPA2PSK;
                    grpEnterpriseCreds.Visible = false;
                    lblPSK.Visible = true;
                    txtPSK.Visible = true;
                    break;
                case 4:
                    wifi.WiFiType = WiFiType.WPA2_ENTERPRISE;
                    grpEnterpriseCreds.Visible = true;
                    lblPSK.Visible = false;
                    txtPSK.Visible = false;
                    break;
                case 5:
                    wifi.WiFiType = WiFiType.WPA3PSK;
                    grpEnterpriseCreds.Visible = false;
                    lblPSK.Visible = true;
                    txtPSK.Visible = true;
                    break;
                case 6:
                    wifi.WiFiType = WiFiType.WPA3_ENTERPRISE;
                    grpEnterpriseCreds.Visible = true;
                    lblPSK.Visible = false;
                    txtPSK.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void cmbConnectionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ( cmbConnectionType.SelectedIndex)
            {
                case 0:
                    wifi.ConnectionType = ConnectionType.ESS;
                    break;
                case 1:
                    wifi.ConnectionType = ConnectionType.IBSS;
                    break;
                default:
                    break;
            }
        }

        private void cmbEncryptionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbEncryptionType.SelectedIndex)
            {
                case 0:
                    wifi.EncryptionSetting = EncryptionSetting.NONE;
                    break;
                case 1:
                    wifi.EncryptionSetting = EncryptionSetting.WEP;
                    break;
                case 2:
                    wifi.EncryptionSetting = EncryptionSetting.TKIP;
                    break;
                case 3:
                    wifi.EncryptionSetting = EncryptionSetting.AES;
                    break;
                default:
                    break;
            }
        }
    }
}
