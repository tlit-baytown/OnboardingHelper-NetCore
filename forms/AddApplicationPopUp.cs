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
using Application = OnboardingHelper_NetCore.wrappers.Application;

namespace OnboardingHelper_NetCore
{
    public partial class AddApplicationPopUp : Form
    {
        public EventHandler ApplicationAdded;

        private Application application = new Application();
        private string path = "";
        private string name = "";
        private string description = "";
        private string arguments = "";


        public AddApplicationPopUp()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Add())
            {
                ApplicationAdded?.Invoke(this, new CEventArgs.ApplicationAddedEventArgs(application));
                Close();
            }
        }

        private bool Add()
        {
            if (name.Length <= 0)
                return false;
            if (path.Length <= 0)
                return false;

            bool isWindowsInstaller = false;
            bool isISOImage = false;

            if (path.EndsWith(".msi"))
                isWindowsInstaller = true;
            else if (path.EndsWith(".exe"))
                isWindowsInstaller = false;
            else if (path.EndsWith(".iso"))
            {
                isWindowsInstaller = false;
                isISOImage = true;
            }

            application = new Application(name, description, path, arguments, isWindowsInstaller, isISOImage);
            EnumHelper.ErrorCodes error = ApplicationWrapper.AddApplication(application);
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
            txtName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            
            lblFilePath.Text = "No File Selected";
            lblFilePath.ForeColor = Color.Red;

            txtArguments.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                path = dlgOpenFile.FileName;
                lblFilePath.Text = path;
                lblFilePath.ForeColor = Color.Green;
            }
        }

        private void btnAddAndClear_Click(object sender, EventArgs e)
        {
            if (AddAndClear())
                ApplicationAdded?.Invoke(this, new CEventArgs.ApplicationAddedEventArgs(application));
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            name = txtName.Text;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            description = txtDescription.Text;
        }

        private void txtArguments_TextChanged(object sender, EventArgs e)
        {
            arguments = txtArguments.Text;
        }
    }
}
