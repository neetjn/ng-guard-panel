using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using Microsoft.Win32;
using Guard;

namespace Panel
{
    public partial class Validation : Form
    {
        /*
         *  CONSTRUCTOR
         */
            public Validation()
            {

                InitializeComponent();
            }
        //DECLARATIONS
            public const int WM_NCLBUTTONDOWN = 0xA1;
            public const int HT_CAPTION = 0x2;
            [DllImportAttribute("user32.dll")]
            public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
            [DllImportAttribute("user32.dll")]
            public static extern bool ReleaseCapture();

        //CHECK_REGISTRY
            private void doProjects()
            {

                RegistryKey keyCheck = null;
                try
                {
                    keyCheck = Registry.CurrentUser.OpenSubKey(@"Software\NEET\Projects");
                }
                catch (Exception) { keyCheck = null; }
                if (keyCheck != null)
                    return;
                else
                {

                    Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\NEET\Projects");
                }
            }
            private string regUser()
            {

                string user = null;
                try
                {

                    user = Registry.GetValue(@"HKEY_CURRENT_USER\Software\NEET\Profile", "User", Microsoft.Win32.RegistryValueKind.String).ToString();
                }
                catch (Exception) { user = "null_user"; }

                return user;
            }

        //INITIALIZE_MAIN_THREAD
            private void Validation_Load(object sender, EventArgs e)
            {

                //REGISTRY_VARS
                    doProjects();
                    string user = regUser();
                    if (user != "null_user")
                        Username.Text = user;
                //TOOLTIP
                    toolTip1.SetToolTip(Username, "Username Field");
                    toolTip1.SetToolTip(Password, "Pass Phrase Field");
                    toolTip1.SetToolTip(Login, "Log Into Panel Portal");
                    toolTip1.SetToolTip(Exit_Button, "Exit Panel Form");
                    toolTip1.SetToolTip(Minimize, "Minimize Panel Form");
                //BEGIN_FADE
                    Fade.RunWorkerAsync();
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
            private void Validation_Paint(object sender, PaintEventArgs e)
            {

                //FORM_BORDER
                    Color colorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
                    Rectangle rect = new Rectangle(0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1);
                    e.Graphics.DrawRectangle(new Pen(new SolidBrush(colorBorder), 3), rect);
                //INNER_BORDER
                    InBorder(e);
            }
        //INNER_BORDER
            private void InBorder(PaintEventArgs e)
            {

                GraphicsPath gP = new GraphicsPath();
                Rectangle R = new Rectangle(Main.Location, Main.Size);
                R.Inflate(1, 1);
                gP.AddRectangle(R);
                float Falloff = (R.Height + R.Width) / 10;
                float Vdiff = Falloff / R.Height;
                float Hdiff = Falloff / R.Width;
                PathGradientBrush PGBrush = new PathGradientBrush(gP);
                PGBrush.CenterColor = Color.FromArgb(187,187,187);
                PGBrush.SurroundColors = new Color[] { Color.FromArgb(187,187,187) };
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

                this.WindowState = FormWindowState.Minimized;
            }

        //EXIT_CHECK
            private void Validation_FormClosed(object sender, FormClosedEventArgs e)
            {

                try
                {
                    Application.Exit();
                }
                catch (Exception) { }
            }

        //LOGO_LINK_CLICK
            private void Logo_Click(object sender, EventArgs e)
            {

                Process.Start("http://forum.neetgroup.net");
            }

        //USER_PASSWORD_FIELDS
            private void Username_Click(object sender, EventArgs e)
            {

                if (Username.Text.Equals("Username"))
                    Username.Text = "";
            }
            private void Password_Click(object sender, EventArgs e)
            {

                if (Password.Text.Equals("Password"))
                    Password.Text = "";
            }

        //GUARD_SERVER_LOGIN
            private void saveUser(string user)
            {

                RegistryKey keyCheck = null;
                try
                {

                    keyCheck = Registry.CurrentUser.OpenSubKey(@"Software\NEET\Profile");
                }
                catch (Exception) { keyCheck = null; }
                if (keyCheck != null) {

                    keyCheck.Close();
                    try
                    {

                        Registry.SetValue(@"HKEY_CURRENT_USER\Software\NEET\Profile", "User", user, Microsoft.Win32.RegistryValueKind.String);
                    }
                    catch (Exception) { }
                }
                else
                {

                    try
                    {
                        Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\NEET\Profile");
                        key.Close();
                        Registry.SetValue(@"HKEY_CURRENT_USER\Software\NEET\Profile", "User", user, Microsoft.Win32.RegistryValueKind.String);
                    }
                    catch (Exception) { }
                }
            }
            private void doLogin() {

                string user = Username.Text;
                string phrase = Password.Text;
                if (user.Length >= 3)
                {
                    Program._User = new User (user, phrase);
                    if (!string.IsNullOrEmpty(Program._User.Profile.username))
                    {

                        MessageBox.Show("Guard Login Successful", "Panel . Dialog", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saveUser(user);
                        Home home = new Home();
                        home.Show();
                        this.Hide();
                        return;
                    }
                }
                else
                    MessageBox.Show("Invalid Username Length", "Panel . Dialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
            {
                if (e.KeyChar == (char)13)
                {
                    doLogin();
                }
            }
            private void Login_Click(object sender, EventArgs e)
            {

                doLogin();
            }

        //MISC_PANEL_ACTIONS
            private void Shop_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {

                if ((MessageBox.Show("Proceed To Guard Shop?", "Panel . Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {

                    try
                    {

                        Process.Start("http://forum.neetgroup.net");
                    }
                    catch (Exception) { }
                }
                else
                    MessageBox.Show("Operation Cancelled", "Panel . Dialog", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            private void Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {

                if ((MessageBox.Show("Proceed To Guard Registration?", "Panel . Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {

                    try
                    {

                        Process.Start("http://guard.neetgroup.net/?app=register");
                    }
                    catch (Exception) { }
                }
                else
                    MessageBox.Show("Operation Cancelled", "Panel . Dialog", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
    }
}
