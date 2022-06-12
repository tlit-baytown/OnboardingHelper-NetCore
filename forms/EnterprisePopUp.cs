using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zest_Script.forms
{
    public partial class EnterprisePopUp : Form
    {
        public EnterprisePopUp()
        {
            InitializeComponent();
        }

        private void chkDontShowAgain_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ShowEnterpriseWifiPopUp = chkDontShowAgain.Checked;

            if (!Debugger.IsAttached)
                Properties.Settings.Default.Save(); //save settings if we are not running in development mode.
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EnterprisePopUp_Load(object sender, EventArgs e)
        {
            iconBox.Image = SystemIcons.Exclamation.ToBitmap();
            System.Media.SystemSounds.Asterisk.Play();
        }
    }
}
