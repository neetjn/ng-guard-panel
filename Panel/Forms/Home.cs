using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using Microsoft.Win32;
using System.Net;
using Guard;

namespace Panel
{
    public partial class Home : Form
    {

        /*
         *  CONSTRUCTOR
         */
            public Home()
            {

                InitializeComponent();
            }

        /*
         *  PROJECTS
         */
            internal class Projects
            {

                // class/struct vars
                    public static string[] List;
                    public static int Index;

                // update project list and index
                    public static void Refresh()
                    {

                        List = Guard.Project.published_list();
                        Index = List.Length;
                    }

            }
            private void projctMnger_DoWork(object sender, DoWorkEventArgs e)
            {


                // threaded recursive project scan
                    while (true)
                    {

                        Projects.Refresh();
                        for (int i = 0; i < Projects.Index; i++)
                        {
                            if (!projectList.Items.Contains(Projects.List[i]))
                                projectList.Items.Add(Projects.List[i]);
                        }
                        if (!projectList.Enabled)
                            projectList.Enabled = true;

                        if (projectList.SelectedIndex < 0)
                        {

                            projectList.SelectedIndex = 0;
                        }
                        Thread.Sleep(6500);
                    }
            }
            private void projectList_SelectedIndexChanged(object sender, EventArgs e)
            {

                int index = projectList.SelectedIndex;
                for (int i = 0; i < Projects.Index; i++)
                {

                    if (Projects.List[i].Equals(projectList.Items[index]))
                    {

                        // 
                        return;
                    }
                }
            }
            private string bPath = Application.StartupPath + "\\Projects\\";

        //DECLARATIONS
            public const int WM_NCLBUTTONDOWN = 0xA1;
            public const int HT_CAPTION = 0x2;
            [DllImportAttribute("user32.dll")]
            public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
            [DllImportAttribute("user32.dll")]
            public static extern bool ReleaseCapture();

        // check if neet key is identified
            private void check_identified()
            {

                if (!Program._User.oQuery.Identified())
                {

                    if ((MessageBox.Show("This System Has Not Been Identified By Guard\nPlease Update Your Profile Info. At This Time", "Panel . Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
                    {

                        try
                        {

                            Process.Start("http://guard.neetgroup.net/?app=cpanel");
                        }
                        catch (Exception) { }
                    }
                    else
                        MessageBox.Show("Operation Cancelled", "Panel . Dialog", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }

        // initialize home form > main thread
            private void Home_Load(object sender, EventArgs e)
            {

                // set control tool tips
                    toolTip1.SetToolTip(Key, "Click To Clipboard Key");
                    toolTip1.SetToolTip(Subscribe, "Execute Subscription Request");
                    toolTip1.SetToolTip(Exit_Button, "Exit Panel Form");
                    toolTip1.SetToolTip(Minimize, "Minimize Panel Form");

                // begin fade thread
                    Fade.RunWorkerAsync();

                // check if system is identified
                    check_identified();

                // begin recursive profile queries
                    profileTable.Rows.Insert(0, "User", Program._User.Profile.username);
                    profileTable.Rows.Insert(1, "NEET Key", Program._User.oQuery.Identified().ToString());
                    profileTable.Rows.Insert(2, "Banned", Program._User.Profile.banned.ToString());
                    //profileTable.Rows.Insert(3, "TyE Access", Program._User.Profile.tye.ToString());
                    //profileTable.Rows.Insert(4, "PyE Access", Program._User.Profile.pye.ToString());
                    //profileTable.Rows.Insert(5, "DyE Access", Program._User.Profile.dye.ToString());
                    profileMnger.RunWorkerAsync();

                // begin recursive panel availability check
                    availCheck.RunWorkerAsync();

                // grab user avatar
                    grab_avatar();

                // begin project list and query
                    projctMnger.RunWorkerAsync();
            }

        // panel availability recursive check
            private void availCheck_DoWork(object sender, DoWorkEventArgs e)
            {

                while (true)
                {

                    if (!Program._Panel.oQuery.Available())
                        Util.End("Panel Currently Unavailable");

                    Thread.Sleep(5000);
                }
            }

        // grab user avatar location
            private void grab_avatar()
            {

                Avatar.ImageLocation = Program._User.Profile.avatar_loc;
            }
        // update profile table info
            private void load_profile()
            {

                Program._User.fetch_data(); // causes crash
                profileTable[1, 1].Value = Program._User.oQuery.Identified() ? "Identified" : "Not Found";
                profileTable[1, 2].Value = Program._User.Profile.banned.ToString();
                //profileTable[1, 3].Value = Program._User.Profile.tye.ToString();
                //profileTable[1, 4].Value = Program._User.Profile.pye.ToString();
                //profileTable[1, 5].Value = Program._User.Profile.dye.ToString();
            }
        // recursive profile check
            private void profileMnger_DoWork(object sender, DoWorkEventArgs e)
            {

                while (true)
                {
                    // update profile table information
                        load_profile();

                    // check if user banned
                        if (Program._User.Profile.banned)
                            Util.End("User Has Been Banned");
                        else
                            Thread.Sleep(4250);
                }
            }

        //DRAGGING
            private void Drag(MouseEventArgs e)
            {

                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
            private void bar_MouseDown(object sender, MouseEventArgs e)
            {

                Drag(e);
            }

        //FADE_THREAD_CONTROL
            private void Fade_DoWork(object sender, DoWorkEventArgs e)
            {

                while (this.Opacity != 100)
                {

                    this.Opacity += 0.03;
                    Thread.Sleep(10);
                }
            }

        //DRAW_BORDERS
            private void Home_Paint(object sender, PaintEventArgs e)
            {

                //FORM_BORDER
                    Color colorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
                    Rectangle rect = new Rectangle(0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1);
                    e.Graphics.DrawRectangle(new Pen(new SolidBrush(colorBorder), 3), rect);

                //PANEL_BORDERS
                    //InfoBorder(e);
                    //MainBorder(e);
            }
        //INFO_BORDER
            private void InfoBorder(PaintEventArgs e)
            {

                //INFO_BORDER
                    GraphicsPath gP = new GraphicsPath();
                    Rectangle R = new Rectangle(InfoTab.Location, InfoTab.Size);
                    R.Inflate(2, 2);
                    gP.AddRectangle(R);
                    float Falloff = (R.Height + R.Width) / 10;
                    float Vdiff = Falloff / R.Height;
                    float Hdiff = Falloff / R.Width;
                    PathGradientBrush PGBrush = new PathGradientBrush(gP);
                    PGBrush.CenterColor = Color.Black;
                    PGBrush.SurroundColors = new Color[] { Color.Black };
                    PGBrush.SetSigmaBellShape(1);
                    PGBrush.FocusScales = new PointF(1.5F - Hdiff, 1.5F - Vdiff);
                    e.Graphics.FillRectangle(PGBrush, R);
            }
        //PROJECT_BORDER
            private void MainBorder(PaintEventArgs e)
            {

                //PROJECT_BORDER
                    GraphicsPath gP = new GraphicsPath();
                    Rectangle R = new Rectangle(Main.Location, Main.Size);
                    R.Inflate(1, 1);
                    gP.AddRectangle(R);
                    float Falloff = (R.Height + R.Width) / 10;
                    float Vdiff = Falloff / R.Height;
                    float Hdiff = Falloff / R.Width;
                    PathGradientBrush PGBrush = new PathGradientBrush(gP);
                    Color custom = new Color();
                    custom = Color.FromArgb(64, 64, 64);
                    PGBrush.CenterColor = custom;
                    PGBrush.SurroundColors = new Color[] { custom };
                    PGBrush.SetSigmaBellShape(1);
                    PGBrush.FocusScales = new PointF(1.5F - Hdiff, 1.5F - Vdiff);
                    e.Graphics.FillRectangle(PGBrush, R);
            }

        //EXIT_MINIMIZE
            private void Exit_Tick(object sender, EventArgs e)
            {

                this.Exit.Enabled = false;
                while (this.Opacity != 0)
                {

                    this.Opacity -= 0.03;
                    Thread.Sleep(20);
                }
                try
                {
                    Application.Exit();
                }
                catch (Exception) { }
            }
            private void Exit_Button_Click(object sender, EventArgs e)
            {

                if ((MessageBox.Show("Would You Like To Exit The Panel?", "Panel . Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                    Exit.Enabled = true;
            }
            private void Minimize_Click(object sender, EventArgs e)
            {

                this.WindowState = FormWindowState.Minimized; Hide();
                restoreMenuItem.Text = "Restore";
                homeIcon.BalloonTipText = "Panel Now Sleeping";
                homeIcon.ShowBalloonTip(250);
            }
            private bool Minimized()
            {

                if (FormWindowState.Minimized == this.WindowState)
                    return true;
                else
                    return false;
            }

        //EXIT_CHECK
            private void Home_FormClosed(object sender, FormClosedEventArgs e)
            {

                try
                {
                    Application.Exit();
                }
                catch (Exception) { }
            }

        //LOGO_LINK_LAUNCH
            private void Logo_Click(object sender, EventArgs e)
            {
                Process.Start("http://forum.neetgroup.net");
            }

        //KEY_CLIPBOARD_COPY
            private void Key_Click(object sender, EventArgs e)
            {

                try
                {

                    string key = User.neet_key;
                    Clipboard.SetText(key);
                    MessageBox.Show("NEET Key Successfully Copied To Clipboard", "Panel . Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception) { }
            }

        //HOME_TRAY_MENU
            private void homeIcon_MouseDoubleClick(object sender, MouseEventArgs e)
            {

                if (Minimized())
                {

                    Show(); this.WindowState = FormWindowState.Normal;
                    restoreMenuItem.Text = "Sleep";
                    homeIcon.BalloonTipText = "Panel Has Been Recovered";
                    homeIcon.ShowBalloonTip(250);
                }
            }
            private void restoreMenuItem_Click(object sender, EventArgs e)
            {

                if (Minimized())
                {

                    Show(); this.WindowState = FormWindowState.Normal;
                    restoreMenuItem.Text = "Sleep";
                    homeIcon.BalloonTipText = "Panel Has Been Recovered";
                    homeIcon.ShowBalloonTip(250);
                }
                else
                {

                    this.WindowState = FormWindowState.Minimized; Hide();
                    restoreMenuItem.Text = "Restore";
                    homeIcon.BalloonTipText = "Panel Now Sleeping";
                    homeIcon.ShowBalloonTip(250);
                }
            }
            private void exitMenuItem_Click(object sender, EventArgs e)
            {

                if ((MessageBox.Show("Would You Like To Exit The Panel?", "Panel . Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                    Exit.Enabled = true;
            }
            private void feedMenuItem_Click(object sender, EventArgs e)
            {

                MessageBox.Show("Panel Feed: " + Program._Panel.Data.feed, "Panel . Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            private void versionMenuItem_Click(object sender, EventArgs e)
            {

                MessageBox.Show("Server Returned: _", "Panel . Dialog", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        //TAB_CONTROL_PANEL
            private int tIndex = 1;
            private void Projects_Tab_Click(object sender, EventArgs e)
            {
                //CHECK_SET_INDEX
                    if (tIndex != 1)
                    {
                        tIndex = 1;

                        //MOVE_PANELS
                            Projects_Panel.Location = new Point(0, 30);
                            Subscribe_Panel.Location = new Point(380, 30);
                            Profile_Panel.Location = new Point(380, 30);

                        //COLOR_TABS
                            Projects_Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
                            label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                            Subscribe_Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
                            label4.ForeColor = Color.GhostWhite;
                            Profile_Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
                            label5.ForeColor = Color.GhostWhite;
                    }
            }
            private void Subscribe_Tab_Click(object sender, EventArgs e)
            {

                //CHECK_SET_INDEX
                    if (tIndex != 2)
                    {
                        tIndex = 2;

                        //MOVE_PANELS
                            Projects_Panel.Location = new Point(380, 30);
                            Subscribe_Panel.Location = new Point(0, 30);
                            Profile_Panel.Location = new Point(380, 30);

                        //COLOR_TABS
                            Projects_Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
                            label3.ForeColor = Color.GhostWhite;
                            Subscribe_Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
                            label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                            Profile_Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
                            label5.ForeColor = Color.GhostWhite;
                    }
            }
            private void Profile_Tab_Click(object sender, EventArgs e)
            {

                //CHECK_SET_INDEX
                    if (tIndex != 3)
                    {
                        tIndex = 3;

                        //MOVE_PANELS
                            Projects_Panel.Location = new Point(380, 30);
                            Subscribe_Panel.Location = new Point(380, 30);
                            Profile_Panel.Location = new Point(0, 30);

                        //COLOR_TABS
                            Projects_Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
                            label3.ForeColor = Color.GhostWhite;
                            Subscribe_Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
                            label4.ForeColor = Color.GhostWhite;
                            Profile_Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
                            label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                    }
            }

        //SUBSCRIBE
            private void Subscribe_Click(object sender, EventArgs e)
            {

                if (!string.IsNullOrEmpty(subscriptionList.Text))
                {

                    string package = subscriptionList.Items[subscriptionList.SelectedIndex].ToString();
                    string tag = sTag.Text;

                    if (sTag.TextLength >= 8)
                    {

                        Program._User.oQuery.Subscribe(tag);
                    }
                    else
                        MessageBox.Show("Please Input a Valid Tag", "Panel . Dialog", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                    MessageBox.Show("Please Select a Subscription", "Panel . Dialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }
}
