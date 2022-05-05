using Microsoft.Web.WebView2.Core;

namespace Zest_Script
{
    public partial class HelpBox : Form
    {
        public HelpBox()
        {
            InitializeComponent();

            webView.EnsureCoreWebView2Async();
            webView.CoreWebView2InitializationCompleted += LoadPage;
        }

        private void LoadPage(object? sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            if (e.IsSuccess)
                webView.CoreWebView2.Navigate("https://zestscript.readthedocs.io/");
        }
    }
}
