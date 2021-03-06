using Zest_Script.forms;
using Zest_Script.settings;
using Zest_Script.wrappers;

namespace Zest_Script.userControls
{
    public partial class VPNUserCtl : UserControl, IUpdatable
    {
        public VPNUserCtl()
        {
            InitializeComponent();
        }

        public bool UpdateValues()
        {
            dgVpns.Rows.Clear();
            dgVpns.Update();

            foreach (VPN v in Configuration.Instance.VPNProfiles)
            {
                v.SetPasswords();
                UpdateGrid(this, new CEventArgs.VPNAddedEventArgs(v));
            }
            return true;
        }

        private void btnAddVPN_Click(object sender, EventArgs e)
        {
            AddVPNPopUp popUp = new AddVPNPopUp();
            popUp.VPNAdded += UpdateGrid;

            popUp.ShowDialog();
        }

        private void btnDeleteWiFi_Click(object sender, EventArgs e)
        {
            if (dgVpns.SelectedRows.Count <= 0)
            {
                MessageBox.Show(this, "No rows were selected to delete. Please select at least 1 row and try again.", "Empty Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"Are you sure you wish to delete {dgVpns.SelectedRows.Count} VPN profiles?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.No || result == DialogResult.Cancel)
                return;

            foreach (DataGridViewRow row in dgVpns.SelectedRows)
                if (row.Tag != null)
                    Configuration.Instance.RemoveVPN((VPN)row.Tag);

            dgVpns.Rows.Clear();
            dgVpns.Update();
            foreach (VPN vpn in Configuration.Instance.VPNProfiles)
            {
                UpdateGrid(this, new CEventArgs.VPNAddedEventArgs(vpn));
            }
        }

        private void UpdateGrid(object? o, EventArgs e)
        {
            if (e is CEventArgs.VPNAddedEventArgs v)
            {
                VPN vpn = v.VPN;

                foreach (DataGridViewRow r in dgVpns.Rows)
                    if (r.Tag != null)
                        if (((VPN)r.Tag).ConnectionName.Equals(vpn.ConnectionName))
                            return;

                int rowID = dgVpns.Rows.Add();

                DataGridViewRow row = dgVpns.Rows[rowID];
                row.Tag = vpn;

                row.Cells[0].Value = vpn.ConnectionName;
                row.Cells[1].Value = vpn.ServerAddress;
                row.Cells[2].Value = vpn.TunnelType.ToString();
                row.Cells[3].Value = vpn.EncryptionLevel.ToString();
                row.Cells[4].Value = vpn.AuthenticationMethod.ToString();
                row.Cells[5].Value = vpn.RememberCredentials;
                row.Cells[6].Value = vpn.EnableSplitTunneling;
            }
        }
    }
}
