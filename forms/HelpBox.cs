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
    public partial class HelpBox : Form
    {
        public HelpBox()
        {
            InitializeComponent();

            webView.EnsureCoreWebView2Async();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPages.FocusedItem.Text.Contains("Basic"))
            {
                webView.NavigateToString(File.ReadAllText("helpControls\\Basic.html"));
            }
            else if (lvPages.FocusedItem.Text.Contains("Accounts"))
                webView.NavigateToString(File.ReadAllText("helpControls\\Accounts.html"));
        }

        private void HelpBox_Load(object sender, EventArgs e)
        {
            
        }
    }
}
