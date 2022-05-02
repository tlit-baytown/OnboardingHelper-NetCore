using System.Net;
using Zest_Script.settings;
using Zest_Script.wrappers;

namespace Zest_Script
{
    public partial class AddAccountPopUp : Form
    {
        /// <summary>
        /// Occurs when a new account is added.
        /// </summary>
        public EventHandler? AccountAdded;

        private readonly Account account = new Account();

        public AddAccountPopUp()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Add())
            {
                AccountAdded?.Invoke(this, new CEventArgs.AccountAddedEventArgs(account));
                Close();
            }
        }

        private bool Add()
        {
            if (account.Username.Length <= 0)
            {
                Utility.ShowToolTip("Username cannot be empty!", txtUsername, toolTip);
                return false;
            }

            if (pw.Length <= 0)
            {
                DialogResult r = MessageBox.Show(this, "Password is empty. Continue anyway?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.No)
                    return false;
            }

            account.Password = new NetworkCredential("", pw).SecurePassword;
            account.SetBase64FromPassword();

            EnumHelper.ReturnCodes error = Configuration.Instance.AddAccount(account);
            return error == EnumHelper.ReturnCodes.NO_ERROR;
        }

        private bool AddAndClear()
        {
            if (Add())
            {
                AccountAdded?.Invoke(this, new CEventArgs.AccountAddedEventArgs(account));
                Clear();
                return true;
            }
            return false;
        }

        private void Clear()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtComment.Text = string.Empty;
            cmbAccountType.SelectedIndex = 0;
            chkPasswordExpires.Checked = false;
            chkRequirePasswordChange.Checked = false;
            pw = string.Empty;
        }

        private void btnAddAndClear_Click(object sender, EventArgs e)
        {
            AddAndClear();
        }

        private void chkPasswordExpires_CheckedChanged(object sender, EventArgs e)
        {
            account.DoesPasswordExpire = chkPasswordExpires.Checked;
        }

        private void chkRequirePasswordChange_CheckedChanged(object sender, EventArgs e)
        {
            account.RequirePasswordChange = chkRequirePasswordChange.Checked;
        }

        private void cmbAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = (string)cmbAccountType.SelectedItem;
            if (selected != null)
            {
                if (selected.Equals("Standard User"))
                    account.AccountType = AccountType.STANDARD_USER;
                else if (selected.Equals("Administrator"))
                    account.AccountType = AccountType.ADMINISTRATOR;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            account.Username = txtUsername.Text;
        }

        string pw = string.Empty;
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            pw = txtPassword.Text;
        }

        private void txtComment_TextChanged(object sender, EventArgs e)
        {
            account.Comment = txtComment.Text;
        }

        private void AddAccountPopUp_Load(object sender, EventArgs e)
        {
            cmbAccountType.SelectedIndex = 0;
        }
    }
}
