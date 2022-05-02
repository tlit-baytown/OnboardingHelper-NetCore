namespace Zest_Script
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
