using Zest_Script.settings;
using Zest_Script.wrappers;

namespace Zest_Script.userControls
{
    public partial class AccountsUserCtl : UserControl, IUpdatable
    {
        public AccountsUserCtl()
        {
            InitializeComponent();
        }

        public bool UpdateValues()
        {
            dgAccounts.Rows.Clear();
            dgAccounts.Update();
            foreach (Account a in Configuration.Instance.Accounts)
            {
                a.SetPasswordFromBase64();
                UpdateGrid(this, new CEventArgs.AccountAddedEventArgs(a));
            }
            return true;
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            AddAccountPopUp popUp = new AddAccountPopUp();
            popUp.AccountAdded += UpdateGrid;

            popUp.ShowDialog();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (dgAccounts.SelectedRows.Count <= 0)
            {
                MessageBox.Show(this, "No rows were selected to delete. Please select at least 1 row and try again.", "Empty Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"Are you sure you wish to delete {dgAccounts.SelectedRows.Count} accounts?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.No || result == DialogResult.Cancel)
                return;

            foreach (DataGridViewRow row in dgAccounts.SelectedRows)
                if (row.Tag != null)
                    Configuration.Instance.RemoveAccount((Account)row.Tag);

            dgAccounts.Rows.Clear();
            dgAccounts.Update();
            foreach (Account acct in Configuration.Instance.Accounts)
            {
                UpdateGrid(this, new CEventArgs.AccountAddedEventArgs(acct));
            }
        }

        private void UpdateGrid(object? o, EventArgs e)
        {
            if (e is CEventArgs.AccountAddedEventArgs a)
            {
                Account account = a.AddedAccount;

                foreach (DataGridViewRow r in dgAccounts.Rows)
                    if (r.Tag != null)
                        if (((Account)r.Tag).Username.Equals(account.Username))
                            return;

                int rowID = dgAccounts.Rows.Add();

                DataGridViewRow row = dgAccounts.Rows[rowID];
                row.Tag = account;

                row.Cells[0].Value = account.Username;
                row.Cells[1].Value = Utility.ConvertToUnsecureString(account.Password);
                row.Cells[2].Value = account.Comment;
                row.Cells[3].Value = account.AccountType.ToString();
                row.Cells[4].Value = account.DoesPasswordExpire;
                row.Cells[5].Value = account.RequirePasswordChange;
            }
        }
    }
}
