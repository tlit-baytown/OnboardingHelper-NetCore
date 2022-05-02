namespace Zest_Script.utility
{
    /// <summary>
    /// Class borrowed from StackOverflow: https://stackoverflow.com/questions/552579/how-to-hide-tabpage-from-tabcontrol
    /// <para>Used as an extension for the Tab Control to faciliate hiding and showing tabs.</para>
    /// <para><c>Modified to fix some bugs.</c></para>
    /// </summary>
    public class TabControlHelper
    {
        private TabControl _tabControl;
        private List<KeyValuePair<TabPage, int>> _pagesIndexed;

        /// <summary>
        /// Create a new instance with the specified <paramref name="tabControl"/>.
        /// </summary>
        /// <param name="tabControl"></param>
        public TabControlHelper(TabControl tabControl)
        {
            _tabControl = tabControl;
            _pagesIndexed = new List<KeyValuePair<TabPage, int>>();

            for (int i = 0; i < tabControl.TabPages.Count; i++)
            {
                _pagesIndexed.Add(new KeyValuePair<TabPage, int>(tabControl.TabPages[i], i));
            }
        }

        /// <summary>
        /// Hide all of the tabs in the <see cref="TabControl.TabPages"/> except the required <c>basic tab</c> and <c>accounts tab</c>.
        /// </summary>
        public void HideAllPages()
        {
            for (int i = 0; i < _pagesIndexed.Count; i++)
            {
                if (_pagesIndexed[i].Key.Name.Equals("basicTab") || _pagesIndexed[i].Key.Name.Equals("accountsTab"))
                    continue;
                if (_tabControl.TabPages.Contains(_pagesIndexed[i].Key))
                    _tabControl.TabPages.Remove(_pagesIndexed[i].Key);
            }
        }

        /// <summary>
        /// Show all of the tabs present in the tab page index.
        /// </summary>
        public void ShowAllPages()
        {
            for (int i = 0; i < _pagesIndexed.Count; i++)
            {
                if (_pagesIndexed[i].Key.Name.Equals("basicTab") || _pagesIndexed[i].Key.Name.Equals("accountsTab"))
                    continue;
                if (!_tabControl.TabPages.Contains(_pagesIndexed[i].Key))
                    _tabControl.TabPages.Add(_pagesIndexed[i].Key);
            }
        }

        /// <summary>
        /// Hide the specified tab page from the tab control.
        /// </summary>
        /// <param name="tabpage"></param>
        public void HidePage(TabPage? tabpage)
        {
            if (tabpage == null)
                return;

            if (!_tabControl.TabPages.Contains(tabpage)) return;
            _tabControl.TabPages.Remove(tabpage);
        }

        /// <summary>
        /// Show the specified tab page in its original position on the tab control.
        /// </summary>
        /// <param name="tabpage"></param>
        public void ShowPage(TabPage? tabpage)
        {
            if (tabpage == null)
                return;

            if (_tabControl.TabPages.Contains(tabpage)) return;
            InsertTabPage(GetTabPage(tabpage).Key, GetTabPage(tabpage).Value);
            //TODO: Fix ^^^ so that the page is still inserted even if an exception occurs.
        }

        private void InsertTabPage(TabPage tabpage, int index)
        {
            if (index < 0 || index > _tabControl.TabCount)
                throw new ArgumentException("Index out of Range.");
            _tabControl.TabPages.Add(tabpage);
            if (index < _tabControl.TabCount - 1)
                do
                {
                    SwapTabPages(tabpage, (_tabControl.TabPages[_tabControl.TabPages.IndexOf(tabpage) - 1]));
                }
                while (_tabControl.TabPages.IndexOf(tabpage) != index);
            _tabControl.SelectedTab = tabpage;
        }

        private void SwapTabPages(TabPage tp1, TabPage tp2)
        {
            if (_tabControl.TabPages.Contains(tp1) == false || _tabControl.TabPages.Contains(tp2) == false)
                throw new ArgumentException("TabPages must be in the TabControls TabPageCollection.");

            int Index1 = _tabControl.TabPages.IndexOf(tp1);
            int Index2 = _tabControl.TabPages.IndexOf(tp2);
            _tabControl.TabPages[Index1] = tp2;
            _tabControl.TabPages[Index2] = tp1;

            //Uncomment the following section to overcome bugs in the Compact Framework
            //tabControl1.SelectedIndex = tabControl1.SelectedIndex; 
            //string tp1Text, tp2Text;
            //tp1Text = tp1.Text;
            //tp2Text = tp2.Text;
            //tp1.Text=tp2Text;
            //tp2.Text=tp1Text;

        }

        private KeyValuePair<TabPage, int> GetTabPage(TabPage tabpage)
        {
            return _pagesIndexed.Where(p => p.Key == tabpage).First();
        }

        /// <summary>
        /// Get a tab page by name.
        /// </summary>
        /// <param name="tabName"></param>
        /// <returns>The <see cref="TabPage"/> with the specified name or <c>null</c> if the page was not found or an error occured.</returns>
        public TabPage? GetPage(string tabName)
        {
            try
            {
                return _pagesIndexed.Where(p => p.Key.Name.Equals(tabName)).First().Key;
            }
            catch (Exception ex) when (ex is ArgumentNullException || ex is InvalidOperationException)
            {
                System.Diagnostics.EventLog.WriteEntry("Application",
                    $"Exception occured in Zest Script while attempting to get a tab page from page index: {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                return null;
            }
        }
    }
}
