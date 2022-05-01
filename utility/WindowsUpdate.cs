using WUApiLib;

namespace OnboardingHelper_NetCore
{
    public class WindowsUpdate
    {
        private UpdateSession uSession;
        private IUpdateSearcher uSearcher;
        private ISearchResult uResult;

        public WindowsUpdate()
        {
            uSession = new UpdateSession();
            uSearcher = uSession.CreateUpdateSearcher();
        }

        public List<IUpdate> GetUpdates()
        {
            List<IUpdate> updates = new List<IUpdate>();

            //Utility.MainForm.UpdateWindowsUpdateLabel("Searching for updates...");
            uResult = uSearcher.Search("IsInstalled=0");
            //Utility.MainForm.UpdateWindowsUpdateChecker(20);

            int counter = 0;
            foreach (IUpdate update in uResult.Updates)
            {
                //Utility.MainForm.UpdateWindowsUpdateLabel("Found update: " + update.Title);
                //StringBuilder bldr = new StringBuilder();
                //foreach (string s in update.KBArticleIDs)
                //{
                //    bldr.Append(s).Append(", ");
                //}

                //updates.Add(new UpdateWrapper()
                //{
                //    KB = bldr.ToString(),
                //    Size = Utility.FormatSize((long) update.MaxDownloadSize),
                //    Title = update.Title
                //});
                updates.Add(update);
                counter++;
                //Utility.MainForm.UpdateWindowsUpdateChecker((counter * 100) / uResult.Updates.Count);
            }

            //Utility.MainForm.UpdateWindowsUpdateLabel($"Updates: {updates.Count}");
            return updates;
        }

        public void DownloadUpdates()
        {
            if (uResult == null)
                GetUpdates();

            UpdateDownloader downloader = uSession.CreateUpdateDownloader();
            downloader.Updates = uResult.Updates;

            if (downloader.Updates.Count > 0)
                downloader.Download();
        }

        //public IInstallationResult InstallSelectedUpdates(List<IUpdate> updates)
        //{
        //    if (updates == null)
        //        return null;

        //    UpdateCollection updatesToInstall = new UpdateCollection();
        //    List<IUpdate> updateList = new List<IUpdate>();

        //    foreach (IUpdate update in updates)
        //        updateList.Add(update);

        //    //foreach (IUpdate update in uResult.Updates)
        //    //    if (updates.Any(e => e.Title.Equals(update.Title)))
        //    //        updatesToInstall.Add(update);

        //    var _ = updateList.Except(updates);

        //    IUpdateInstaller installer = uSession.CreateUpdateInstaller();
        //    installer.Updates = updatesToInstall;
        //    return installer.Install();
        //}

        public void InstallAllUpdates()
        {
            if (uResult == null)
                GetUpdates();

            DownloadUpdates();
            UpdateCollection updatesToInstall = new UpdateCollection();
            foreach (IUpdate update in uResult.Updates)
            {
                if (update.IsDownloaded)
                    updatesToInstall.Add(update);
            }

            IUpdateInstaller installer = uSession.CreateUpdateInstaller();
            installer.Updates = updatesToInstall;
            installer.Install();
        }
    }
}
