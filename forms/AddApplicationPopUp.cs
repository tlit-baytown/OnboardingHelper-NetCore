using Zest_Script.settings;
using Application = Zest_Script.wrappers.Application;

namespace Zest_Script
{
    public partial class AddApplicationPopUp : Form
    {
        public EventHandler? ApplicationAdded;

        private readonly Application application = new Application();

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
            if (application.Name.Length <= 0)
            {
                Utility.ShowToolTip("Application must have a name.", txtName, toolTip);
                return false;
            }

            if (application.Path.Length <= 0)
            {
                Utility.ShowToolTip("No path specified!", btnOpen, toolTip);
                return false;
            }

            if (application.Path.EndsWith(".msi"))
                application.IsWindowsInstaller = true;
            else if (application.Path.EndsWith(".exe"))
                application.IsWindowsInstaller = false;
            else if (application.Path.EndsWith(".iso"))
            {
                application.IsWindowsInstaller = false;
                application.IsISOImage = true;
            }

            EnumHelper.ReturnCodes error = Configuration.Instance.AddApplication(application);
            return error == EnumHelper.ReturnCodes.NO_ERROR;
        }

        private bool AddAndClear()
        {
            if (Add())
            {
                ApplicationAdded?.Invoke(this, new CEventArgs.ApplicationAddedEventArgs(application));
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
                application.Path = dlgOpenFile.FileName;
                lblFilePath.Text = application.Path;
                lblFilePath.ForeColor = Color.Green;
            }
        }

        private void btnAddAndClear_Click(object sender, EventArgs e)
        {
            AddAndClear();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            application.Name = txtName.Text;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            application.Description = txtDescription.Text;
        }

        private void txtArguments_TextChanged(object sender, EventArgs e)
        {
            application.InstallArguments = txtArguments.Text;
        }
    }
}
