using Zest_Script.forms;
using Zest_Script.settings;
using Zest_Script.wrappers;

namespace Zest_Script.userControls
{
    public partial class WiFiUserCtl : UserControl, IUpdatable
    {
        public WiFiUserCtl()
        {
            InitializeComponent();
        }

        public bool UpdateValues()
        {
            dgWifis.Rows.Clear();
            dgWifis.Update();

            foreach (WiFi w in Configuration.Instance.WiFiProfiles)
            {
                w.SetPasswordFromBase64();
                UpdateGrid(this, new CEventArgs.WiFiAddedEventArgs(w));
            }

            return true;
        }

        private void btnAddWiFi_Click(object sender, EventArgs e)
        {
            AddWiFiPopUp popUp = new AddWiFiPopUp();
            popUp.WiFiAdded += UpdateGrid;

            popUp.ShowDialog();
        }

        private void btnDeleteWiFi_Click(object sender, EventArgs e)
        {
            if (dgWifis.SelectedRows.Count <= 0)
            {
                MessageBox.Show(this, "No rows were selected to delete. Please select at least 1 row and try again.", "Empty Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"Are you sure you wish to delete {dgWifis.SelectedRows.Count} Wi-Fi Profiles?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.No || result == DialogResult.Cancel)
                return;

            foreach (DataGridViewRow row in dgWifis.SelectedRows)
            {
                if (row.Tag != null)
                    Configuration.Instance.RemoveWiFi((WiFi)row.Tag);
            }

            dgWifis.Rows.Clear();
            dgWifis.Update();
            foreach (WiFi wifi in Configuration.Instance.WiFiProfiles)
                UpdateGrid(this, new CEventArgs.WiFiAddedEventArgs(wifi));
        }

        private void UpdateGrid(object? o, EventArgs e)
        {
            if (e is CEventArgs.WiFiAddedEventArgs w)
            {
                WiFi wifi = w.WiFi;

                foreach (DataGridViewRow r in dgWifis.Rows)
                    if (r.Tag != null)
                        if (((WiFi)r.Tag).SSID.Equals(wifi.SSID))
                            return;

                int rowID = dgWifis.Rows.Add();

                DataGridViewRow row = dgWifis.Rows[rowID];
                row.Tag = wifi;

                row.Cells[0].Value = wifi.SSID;
                row.Cells[1].Value =
                    (wifi.WiFiType == WiFiType.WPA2_ENTERPRISE || wifi.WiFiType == WiFiType.WPA3_ENTERPRISE) ?
                    "<WPA Enterprise Selected; No PSK" : Utility.ConvertToUnsecureString(wifi.PreSharedKey);
                row.Cells[2].Value = wifi.WiFiType;
                row.Cells[3].Value = wifi.ConnectionType;
                row.Cells[4].Value = wifi.EncryptionSetting;
                row.Cells[5].Value = wifi.IsHiddenNetwork;
            }
        }
    }
}
