using OnboardingHelper_NetCore.wrappers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnboardingHelper_NetCore
{
    public partial class AddAccountPopUp : Form
    {
        public EventHandler AccountAdded;

        private Account account = new Account();
        private string username = "";
        private string password = "";
        private string comment = "";
        private AccountType accountType = AccountType.STANDARD_USER;
        private bool passwordExpires = false;
        private bool requirePasswordChange = false;

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
            else
            {
                MessageBox.Show(this, "There was a problem with your input. Please make sure all required fields are filled and try again. Also, ensure the account doesn't already exists.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool Add()
        {
            if (username.Length <= 0)
                return false;
            if (password.Length <= 0)
                return false;

            account = new Account(username, password, comment, accountType, passwordExpires, requirePasswordChange);
            EnumHelper.ErrorCodes error = AccountWrapper.AddAccount(account);
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
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtComment.Text = string.Empty;
            cmbAccountType.SelectedIndex = 0;
            chkPasswordExpires.Checked = false;
            chkRequirePasswordChange.Checked = false;
        }

        private void btnAddAndClear_Click(object sender, EventArgs e)
        {
            if (AddAndClear())
            {
                AccountAdded?.Invoke(this, new CEventArgs.AccountAddedEventArgs(account));
            }
        }

        private void chkPasswordExpires_CheckedChanged(object sender, EventArgs e)
        {
            passwordExpires = chkPasswordExpires.Checked;
        }

        private void chkRequirePasswordChange_CheckedChanged(object sender, EventArgs e)
        {
            requirePasswordChange = chkRequirePasswordChange.Checked;
        }

        private void cmbAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = (string)cmbAccountType.SelectedItem;
            if (selected != null)
            {
                if (selected.Equals("Standard User"))
                    accountType = AccountType.STANDARD_USER;
                else if (selected.Equals("Administrator"))
                    accountType = AccountType.ADMINISTRATOR;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            username = txtUsername.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            password = txtPassword.Text;
        }

        private void txtComment_TextChanged(object sender, EventArgs e)
        {
            comment = txtComment.Text;
        }

        private void AddAccountPopUp_Load(object sender, EventArgs e)
        {
            cmbAccountType.SelectedIndex = 0;
        }
    }
}
