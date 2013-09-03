using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FSAircraftRepositoryFactory
{
    class VersionChecker
    {
        public static int buildVersion = 9;
        public static string status;

        public static void CheckVersion()
        {
            int remoteVersion = System.Convert.ToInt16(Connector.CheckVersion());
            if (remoteVersion > buildVersion)
            {
                status = "New version of FSARF (version " + remoteVersion.ToString() + ") is available to download.\n";
                status += "Upgrade is highly recommended.\n\n";
                status += "Open download page now?";
                DialogResult result = MessageBox.Show(status, "Version Checker", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("http://new.csav.cz/upload/fsarf/aktualni/fsarf.zip");
                }
            }
        }

    }
}
