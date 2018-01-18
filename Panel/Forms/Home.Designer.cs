namespace Panel
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit_Button = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Fade = new System.ComponentModel.BackgroundWorker();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Main = new System.Windows.Forms.Panel();
            this.Profile_Panel = new System.Windows.Forms.Panel();
            this.profileTable = new System.Windows.Forms.DataGridView();
            this.vars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.values = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Projects_Panel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.projectList = new System.Windows.Forms.ComboBox();
            this.Profile_Tab = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Subscribe_Panel = new System.Windows.Forms.Panel();
            this.Subscribe = new System.Windows.Forms.PictureBox();
            this.sTag = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sUser = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.subscriptionList = new System.Windows.Forms.ComboBox();
            this.Projects_Tab = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Subscribe_Tab = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.homeIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.homeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projctMnger = new System.ComponentModel.BackgroundWorker();
            this.profileMnger = new System.ComponentModel.BackgroundWorker();
            this.availCheck = new System.ComponentModel.BackgroundWorker();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.InfoTab = new System.Windows.Forms.Panel();
            this.Key = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.Main.SuspendLayout();
            this.Profile_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileTable)).BeginInit();
            this.Projects_Panel.SuspendLayout();
            this.Profile_Tab.SuspendLayout();
            this.Subscribe_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Subscribe)).BeginInit();
            this.Projects_Tab.SuspendLayout();
            this.Subscribe_Tab.SuspendLayout();
            this.homeMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.panel3.SuspendLayout();
            this.InfoTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 16);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(2, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel . Home";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bar_MouseDown);
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackColor = System.Drawing.Color.Brown;
            this.Exit_Button.Location = new System.Drawing.Point(279, -6);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(29, 17);
            this.Exit_Button.TabIndex = 11;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.SlateGray;
            this.Minimize.Location = new System.Drawing.Point(244, -6);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(29, 17);
            this.Minimize.TabIndex = 12;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Exit
            // 
            this.Exit.Interval = 10;
            this.Exit.Tick += new System.EventHandler(this.Exit_Tick);
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
            // Logo
            // 
            this.Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(3, 9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(212, 49);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 15;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            this.Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main.Controls.Add(this.Profile_Panel);
            this.Main.Controls.Add(this.Projects_Panel);
            this.Main.Controls.Add(this.Profile_Tab);
            this.Main.Controls.Add(this.Subscribe_Panel);
            this.Main.Controls.Add(this.Projects_Tab);
            this.Main.Controls.Add(this.Subscribe_Tab);
            this.Main.Controls.Add(this.panel2);
            this.Main.Location = new System.Drawing.Point(4, 67);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(280, 122);
            this.Main.TabIndex = 16;
            // 
            // Profile_Panel
            // 
            this.Profile_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Profile_Panel.Controls.Add(this.profileTable);
            this.Profile_Panel.Location = new System.Drawing.Point(380, 30);
            this.Profile_Panel.Name = "Profile_Panel";
            this.Profile_Panel.Size = new System.Drawing.Size(280, 92);
            this.Profile_Panel.TabIndex = 19;
            // 
            // profileTable
            // 
            this.profileTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.profileTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profileTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vars,
            this.values});
            this.profileTable.Location = new System.Drawing.Point(0, 0);
            this.profileTable.Name = "profileTable";
            this.profileTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.profileTable.Size = new System.Drawing.Size(280, 92);
            this.profileTable.TabIndex = 0;
            // 
            // vars
            // 
            this.vars.HeaderText = "Field";
            this.vars.Name = "vars";
            this.vars.ReadOnly = true;
            this.vars.Width = 125;
            // 
            // values
            // 
            this.values.HeaderText = "Returned";
            this.values.Name = "values";
            this.values.ReadOnly = true;
            this.values.Width = 150;
            // 
            // Projects_Panel
            // 
            this.Projects_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Projects_Panel.Controls.Add(this.label10);
            this.Projects_Panel.Controls.Add(this.label6);
            this.Projects_Panel.Controls.Add(this.projectList);
            this.Projects_Panel.Location = new System.Drawing.Point(0, 30);
            this.Projects_Panel.Name = "Projects_Panel";
            this.Projects_Panel.Size = new System.Drawing.Size(280, 92);
            this.Projects_Panel.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(33, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 43);
            this.label10.TabIndex = 2;
            this.label10.Text = "Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(11, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Projects (Published)";
            // 
            // projectList
            // 
            this.projectList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectList.Enabled = false;
            this.projectList.FormattingEnabled = true;
            this.projectList.Location = new System.Drawing.Point(12, 22);
            this.projectList.Name = "projectList";
            this.projectList.Size = new System.Drawing.Size(96, 23);
            this.projectList.TabIndex = 0;
            this.projectList.SelectedIndexChanged += new System.EventHandler(this.projectList_SelectedIndexChanged);
            // 
            // Profile_Tab
            // 
            this.Profile_Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.Profile_Tab.Controls.Add(this.label5);
            this.Profile_Tab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Profile_Tab.Location = new System.Drawing.Point(140, 5);
            this.Profile_Tab.Name = "Profile_Tab";
            this.Profile_Tab.Size = new System.Drawing.Size(63, 23);
            this.Profile_Tab.TabIndex = 6;
            this.Profile_Tab.Click += new System.EventHandler(this.Profile_Tab_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.GhostWhite;
            this.label5.Location = new System.Drawing.Point(13, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Profile";
            this.label5.Click += new System.EventHandler(this.Profile_Tab_Click);
            // 
            // Subscribe_Panel
            // 
            this.Subscribe_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Subscribe_Panel.Controls.Add(this.Subscribe);
            this.Subscribe_Panel.Controls.Add(this.sTag);
            this.Subscribe_Panel.Controls.Add(this.label9);
            this.Subscribe_Panel.Controls.Add(this.sUser);
            this.Subscribe_Panel.Controls.Add(this.label8);
            this.Subscribe_Panel.Controls.Add(this.label7);
            this.Subscribe_Panel.Controls.Add(this.subscriptionList);
            this.Subscribe_Panel.Location = new System.Drawing.Point(380, 30);
            this.Subscribe_Panel.Name = "Subscribe_Panel";
            this.Subscribe_Panel.Size = new System.Drawing.Size(280, 92);
            this.Subscribe_Panel.TabIndex = 17;
            // 
            // Subscribe
            // 
            this.Subscribe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Subscribe.Image = ((System.Drawing.Image)(resources.GetObject("Subscribe.Image")));
            this.Subscribe.Location = new System.Drawing.Point(149, 56);
            this.Subscribe.Name = "Subscribe";
            this.Subscribe.Size = new System.Drawing.Size(109, 30);
            this.Subscribe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Subscribe.TabIndex = 18;
            this.Subscribe.TabStop = false;
            this.Subscribe.Click += new System.EventHandler(this.Subscribe_Click);
            // 
            // sTag
            // 
            this.sTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sTag.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTag.Location = new System.Drawing.Point(26, 23);
            this.sTag.Name = "sTag";
            this.sTag.Size = new System.Drawing.Size(94, 20);
            this.sTag.TabIndex = 7;
            this.sTag.TabStop = false;
            this.sTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(33, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Exclusive Tag *";
            // 
            // sUser
            // 
            this.sUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.sUser.Location = new System.Drawing.Point(26, 67);
            this.sUser.Name = "sUser";
            this.sUser.ReadOnly = true;
            this.sUser.Size = new System.Drawing.Size(94, 20);
            this.sUser.TabIndex = 5;
            this.sUser.TabStop = false;
            this.sUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.GhostWhite;
            this.label8.Location = new System.Drawing.Point(33, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Guard Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.GhostWhite;
            this.label7.Location = new System.Drawing.Point(156, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Subscription";
            // 
            // subscriptionList
            // 
            this.subscriptionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subscriptionList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subscriptionList.FormattingEnabled = true;
            this.subscriptionList.Items.AddRange(new object[] {
            "TyE",
            "PyE",
            "DyE"});
            this.subscriptionList.Location = new System.Drawing.Point(149, 24);
            this.subscriptionList.Name = "subscriptionList";
            this.subscriptionList.Size = new System.Drawing.Size(109, 23);
            this.subscriptionList.TabIndex = 0;
            // 
            // Projects_Tab
            // 
            this.Projects_Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Projects_Tab.Controls.Add(this.label3);
            this.Projects_Tab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Projects_Tab.Location = new System.Drawing.Point(12, 5);
            this.Projects_Tab.Name = "Projects_Tab";
            this.Projects_Tab.Size = new System.Drawing.Size(63, 23);
            this.Projects_Tab.TabIndex = 2;
            this.Projects_Tab.Click += new System.EventHandler(this.Projects_Tab_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(10, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Projects";
            this.label3.Click += new System.EventHandler(this.Projects_Tab_Click);
            // 
            // Subscribe_Tab
            // 
            this.Subscribe_Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.Subscribe_Tab.Controls.Add(this.label4);
            this.Subscribe_Tab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Subscribe_Tab.Location = new System.Drawing.Point(76, 5);
            this.Subscribe_Tab.Name = "Subscribe_Tab";
            this.Subscribe_Tab.Size = new System.Drawing.Size(63, 23);
            this.Subscribe_Tab.TabIndex = 3;
            this.Subscribe_Tab.Click += new System.EventHandler(this.Subscribe_Tab_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.GhostWhite;
            this.label4.Location = new System.Drawing.Point(5, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Subscribe";
            this.label4.Click += new System.EventHandler(this.Subscribe_Tab_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 2);
            this.panel2.TabIndex = 1;
            // 
            // homeIcon
            // 
            this.homeIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.homeIcon.BalloonTipTitle = "Panel";
            this.homeIcon.ContextMenuStrip = this.homeMenu;
            this.homeIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("homeIcon.Icon")));
            this.homeIcon.Text = "Panel";
            this.homeIcon.Visible = true;
            this.homeIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.homeIcon_MouseDoubleClick);
            // 
            // homeMenu
            // 
            this.homeMenu.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreMenuItem,
            this.exitMenuItem,
            this.feedMenuItem,
            this.versionMenuItem});
            this.homeMenu.Name = "homeMenu";
            this.homeMenu.Size = new System.Drawing.Size(113, 92);
            // 
            // restoreMenuItem
            // 
            this.restoreMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("restoreMenuItem.Image")));
            this.restoreMenuItem.Name = "restoreMenuItem";
            this.restoreMenuItem.Size = new System.Drawing.Size(112, 22);
            this.restoreMenuItem.Text = "Sleep";
            this.restoreMenuItem.Click += new System.EventHandler(this.restoreMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitMenuItem.Image")));
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // feedMenuItem
            // 
            this.feedMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("feedMenuItem.Image")));
            this.feedMenuItem.Name = "feedMenuItem";
            this.feedMenuItem.Size = new System.Drawing.Size(112, 22);
            this.feedMenuItem.Text = "Feed";
            this.feedMenuItem.Click += new System.EventHandler(this.feedMenuItem_Click);
            // 
            // versionMenuItem
            // 
            this.versionMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("versionMenuItem.Image")));
            this.versionMenuItem.Name = "versionMenuItem";
            this.versionMenuItem.Size = new System.Drawing.Size(112, 22);
            this.versionMenuItem.Text = "Version";
            this.versionMenuItem.Click += new System.EventHandler(this.versionMenuItem_Click);
            // 
            // projctMnger
            // 
            this.projctMnger.DoWork += new System.ComponentModel.DoWorkEventHandler(this.projctMnger_DoWork);
            // 
            // profileMnger
            // 
            this.profileMnger.DoWork += new System.ComponentModel.DoWorkEventHandler(this.profileMnger_DoWork);
            // 
            // availCheck
            // 
            this.availCheck.DoWork += new System.ComponentModel.DoWorkEventHandler(this.availCheck_DoWork);
            // 
            // Avatar
            // 
            this.Avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Avatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Avatar.Image = ((System.Drawing.Image)(resources.GetObject("Avatar.Image")));
            this.Avatar.Location = new System.Drawing.Point(218, 3);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(66, 60);
            this.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avatar.TabIndex = 17;
            this.Avatar.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.GhostWhite;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Controls.Add(this.linkLabel2);
            this.panel3.Controls.Add(this.InfoTab);
            this.panel3.Controls.Add(this.Logo);
            this.panel3.Controls.Add(this.Avatar);
            this.panel3.Controls.Add(this.Main);
            this.panel3.Location = new System.Drawing.Point(11, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 213);
            this.panel3.TabIndex = 18;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkLabel1.Location = new System.Drawing.Point(59, 194);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(54, 15);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Byte Shop";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkLabel2.Location = new System.Drawing.Point(6, 194);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(47, 15);
            this.linkLabel2.TabIndex = 20;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "GP Shop";
            // 
            // InfoTab
            // 
            this.InfoTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.InfoTab.Controls.Add(this.Key);
            this.InfoTab.Controls.Add(this.label2);
            this.InfoTab.Location = new System.Drawing.Point(123, 193);
            this.InfoTab.Name = "InfoTab";
            this.InfoTab.Size = new System.Drawing.Size(160, 18);
            this.InfoTab.TabIndex = 19;
            // 
            // Key
            // 
            this.Key.AutoSize = true;
            this.Key.Cursor = System.Windows.Forms.Cursors.Help;
            this.Key.ForeColor = System.Drawing.Color.White;
            this.Key.Location = new System.Drawing.Point(59, 1);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(94, 15);
            this.Key.TabIndex = 1;
            this.Key.Text = "Copy To Clipboard";
            this.Key.Click += new System.EventHandler(this.Key_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(7, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "NEET Key: ";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(313, 250);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel . Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Home_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.Main.ResumeLayout(false);
            this.Profile_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profileTable)).EndInit();
            this.Projects_Panel.ResumeLayout(false);
            this.Projects_Panel.PerformLayout();
            this.Profile_Tab.ResumeLayout(false);
            this.Profile_Tab.PerformLayout();
            this.Subscribe_Panel.ResumeLayout(false);
            this.Subscribe_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Subscribe)).EndInit();
            this.Projects_Tab.ResumeLayout(false);
            this.Projects_Tab.PerformLayout();
            this.Subscribe_Tab.ResumeLayout(false);
            this.Subscribe_Tab.PerformLayout();
            this.homeMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.InfoTab.ResumeLayout(false);
            this.InfoTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Exit_Button;
        private System.Windows.Forms.Panel Minimize;
        private System.Windows.Forms.Timer Exit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker Fade;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Panel Subscribe_Tab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Projects_Tab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Profile_Tab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NotifyIcon homeIcon;
        private System.Windows.Forms.ContextMenuStrip homeMenu;
        private System.Windows.Forms.ToolStripMenuItem restoreMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionMenuItem;
        private System.Windows.Forms.Panel Projects_Panel;
        private System.Windows.Forms.ComboBox projectList;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker projctMnger;
        private System.ComponentModel.BackgroundWorker profileMnger;
        private System.Windows.Forms.Panel Subscribe_Panel;
        private System.Windows.Forms.TextBox sTag;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox subscriptionList;
        private System.Windows.Forms.PictureBox Subscribe;
        private System.Windows.Forms.Panel Profile_Panel;
        private System.Windows.Forms.DataGridView profileTable;
        private System.ComponentModel.BackgroundWorker availCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn vars;
        private System.Windows.Forms.DataGridViewTextBoxColumn values;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel InfoTab;
        private System.Windows.Forms.Label Key;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}