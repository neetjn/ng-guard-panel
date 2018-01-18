namespace Panel
{
    partial class Validation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Validation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Timer(this.components);
            this.Exit_Button = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Login = new System.Windows.Forms.PictureBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Fade = new System.ComponentModel.BackgroundWorker();
            this.Main = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login)).BeginInit();
            this.Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 16);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(2, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel . Validation";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bar_MouseDown);
            // 
            // Exit
            // 
            this.Exit.Interval = 10;
            this.Exit.Tick += new System.EventHandler(this.Exit_Tick);
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackColor = System.Drawing.Color.Brown;
            this.Exit_Button.Location = new System.Drawing.Point(279, -6);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(29, 17);
            this.Exit_Button.TabIndex = 7;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.SlateGray;
            this.Minimize.Location = new System.Drawing.Point(244, -6);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(29, 17);
            this.Minimize.TabIndex = 8;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Logo
            // 
            this.Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(7, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(276, 58);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 9;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // Login
            // 
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.Image = ((System.Drawing.Image)(resources.GetObject("Login.Image")));
            this.Login.Location = new System.Drawing.Point(99, 105);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(45, 45);
            this.Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Login.TabIndex = 9;
            this.Login.TabStop = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Password
            // 
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.Location = new System.Drawing.Point(14, 131);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(79, 20);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            this.Password.UseSystemPasswordChar = true;
            this.Password.Click += new System.EventHandler(this.Password_Click);
            this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // Username
            // 
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Username.Location = new System.Drawing.Point(14, 92);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(79, 20);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            this.Username.Click += new System.EventHandler(this.Username_Click);
            this.Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Tip";
            // 
            // Fade
            // 
            this.Fade.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Fade_DoWork);
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.GhostWhite;
            this.Main.Controls.Add(this.linkLabel2);
            this.Main.Controls.Add(this.panel3);
            this.Main.Controls.Add(this.label4);
            this.Main.Controls.Add(this.label3);
            this.Main.Controls.Add(this.Login);
            this.Main.Controls.Add(this.Register);
            this.Main.Controls.Add(this.Password);
            this.Main.Controls.Add(this.label2);
            this.Main.Controls.Add(this.Username);
            this.Main.Controls.Add(this.Logo);
            this.Main.Location = new System.Drawing.Point(11, 26);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(291, 162);
            this.Main.TabIndex = 13;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkLabel2.Location = new System.Drawing.Point(212, 142);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(74, 15);
            this.linkLabel2.TabIndex = 18;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Forgot Login?";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(14, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 1);
            this.panel3.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Guard Username";
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Register.LinkColor = System.Drawing.Color.Gray;
            this.Register.Location = new System.Drawing.Point(174, 108);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(79, 16);
            this.Register.TabIndex = 14;
            this.Register.TabStop = true;
            this.Register.Text = "Sign up now!";
            this.Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Register_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(147, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Don\'t have an account?";
            // 
            // Validation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(313, 199);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Validation";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel . Validation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Validation_FormClosed);
            this.Load += new System.EventHandler(this.Validation_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Validation_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login)).EndInit();
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Exit;
        private System.Windows.Forms.Panel Exit_Button;
        private System.Windows.Forms.Panel Minimize;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker Fade;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.PictureBox Login;
        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel Register;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

