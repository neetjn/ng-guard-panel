using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using Guard;

namespace Panel
{
    static class Program
    {

        // panel guard vars
            private static string version = "7.0.0.0";
            public static Project _Panel;
            public static User _User;
        // check os compatibility nt6+
            private static bool Compatible()
            {

                OperatingSystem OS = Environment.OSVersion;
                return (OS.Platform == PlatformID.Win32NT) && (OS.Version.Major >= 6);
            }
        // check program instances using mutex
            static Mutex mutex;
            static bool SingleInstance()
            {
                try
                {

                    Mutex.OpenExisting("NPanel");
                }
                catch
                {

                    mutex = new Mutex(true, "NPanel");
                    return true;
                }
                return false;
            }
        // check for installed custom fonts
            static string fontName = "Arial Narrow";
            static float fontSize = 12;
            static bool hFont()
            {

                using (Font fontTester = new Font(fontName, fontSize, FontStyle.Regular, GraphicsUnit.Pixel))
                {
                    if (fontTester.Name != fontName)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }

            [STAThread]
            static void Main()
            {

                if (!SingleInstance())
                {

                    MessageBox.Show("An Instance Of Panel Is Already Running", "Panel . Dialog", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Environment.Exit(0);
                }

                if (User.Blacklisted())
                {

                    MessageBox.Show("You Have Been Blacklisted From Guard", "Panel . Dialog", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Environment.Exit(0);
                }

                // specify developer key
                    Configuration.Key = "guard_neet";    

                // instantiate panel project
                    _Panel = new Project("panel", "secret_panel");

                if (!_Panel.Data.available)
                {

                    MessageBox.Show("Panel Currently Unavailable", "Panel . Dialog", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Environment.Exit(0);
                }

                //Util.Initialize(true, true, true);

                if (_Panel.oQuery.Update(version))
                {

                    try
                    {

                        string[] uArgs = { "panel", version, "secret_panel" };
                        string bFile = Application.StartupPath + "\\" + "Patch.exe";
                        if (File.Exists(bFile))
                            File.Delete(bFile);
                        File.WriteAllBytes(bFile, Properties.Resources.Patch);
                        Process.Start(bFile, string.Join(" ", uArgs));
                    }
                    catch (Exception) { }
                    Environment.Exit(0);
                }

                if (!Compatible())
                {
                    MessageBox.Show("Panel Does Not Support This Operating System", "Panel . Dialog", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Environment.Exit(0);
                }

                if (!hFont())
                {

                    if ((MessageBox.Show("A Necessary Font Style Was Not Found\nWould You Like To Continue With Use?", "Panel . Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) != DialogResult.Yes)
                    {
                        try
                        {
                            System.Diagnostics.Process.Start("http://forum.neetgroup.net/index.php?/topic/2007-funky-looking-ui-read-here/");
                        }
                        catch (Exception) { }

                        Environment.Exit(0);
                    }

                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Validation());
            }
    }
}
