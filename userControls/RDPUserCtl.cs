using OnboardingHelper_NetCore.settings;
using OnboardingHelper_NetCore.wrappers;

namespace OnboardingHelper_NetCore.userControls
{
    public partial class RDPUserCtl : UserControl, IUpdatable
    {
        private ListViewGroup defaultGroup = new ListViewGroup("Default", HorizontalAlignment.Left);

        public RDPUserCtl()
        {
            InitializeComponent();
        }

        public bool UpdateValues()
        {
            lvRDPPaths.BeginUpdate();
            lvRDPPaths.Items.Clear();
            lvRDPPaths.EndUpdate();

            int filesCreated = 0;
            foreach (RDPFile f in Configuration.Instance.RDPFiles)
                if (f.CreateIfNotExists())
                    filesCreated++;

            UpdateListView();

            if (filesCreated > 0)
            {
                MessageBox.Show(this, $"Re-created {filesCreated} missing RDP files.\n" +
                $"Refer to the Remote Desktop(s) tab for full paths to files.",
                "Files Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return true;
        }

        private void btnAddRDPFile_Click(object sender, EventArgs e)
        {
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                foreach (string path in dlgOpenFile.FileNames)
                {
                    RDPFile file = new RDPFile(path);
                    Configuration.Instance.AddRDPFile(file);
                }

                UpdateListView();
            }
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (lvRDPPaths.SelectedItems.Count <= 0)
            {
                MessageBox.Show(this, "No paths were selected. Select at least one path and try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"Are you sure you wish to remove {lvRDPPaths.SelectedItems.Count} paths?",
                "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                foreach (ListViewItem item in lvRDPPaths.SelectedItems)
                {
                    if (item.Tag != null)
                    {
                        RDPFile? file = item.Tag as RDPFile;
                        if (file != null)
                            Configuration.Instance.RemoveRDPFile(file);
                    }
                }
                UpdateListView();
            }
        }

        private void UpdateListView()
        {
            lvRDPPaths.BeginUpdate();
            lvRDPPaths.Items.Clear();
            ListViewItem item;

            foreach (RDPFile f in Configuration.Instance.RDPFiles)
            {
                item = new ListViewItem(new[] { f.ComputerName, f.FilePath }, defaultGroup);
                item.Tag = f;

                lvRDPPaths.Items.Add(item);
            }
            lvRDPPaths.EndUpdate();
        }

        private void RDPUserCtl_Load(object sender, EventArgs e)
        {
            lvRDPPaths.BeginUpdate();
            lvRDPPaths.Groups.Add(defaultGroup);
            lvRDPPaths.EndUpdate();
        }
    }
}
