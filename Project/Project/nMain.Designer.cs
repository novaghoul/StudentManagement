﻿namespace Project
{
    partial class nMain
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nMain));
            this.header = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStripLogin = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelsideMenu = new System.Windows.Forms.Panel();
            this.btnInfoApplication = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnManagement = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDebt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStaff = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.nMainElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.headerDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.sideMain = new System.Windows.Forms.Panel();
            this.infoHome = new Project.nHome();
            this.infoApplication = new Project.infoApplication();
            this.infochangePassword = new Project.changePassword();
            this.infoList = new Project.nList();
            this.infoDebt = new Project.nDebt();
            this.infoManagement = new Project.nManagement();
            this.infoStaff = new Project.nStaff();
            this.LogoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.sidePanel = new System.Windows.Forms.Panel();
            this.header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStripLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panelsideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfoApplication)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.sideMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.header.Controls.Add(this.panel1);
            this.header.Controls.Add(this.label2);
            this.header.Controls.Add(this.btnMenu);
            this.LogoTransition.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(803, 40);
            this.header.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStripLogin);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnExit);
            this.LogoTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(603, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 40);
            this.panel1.TabIndex = 3;
            // 
            // menuStripLogin
            // 
            this.menuStripLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.LogoTransition.SetDecoration(this.menuStripLogin, BunifuAnimatorNS.DecorationType.None);
            this.menuStripLogin.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStripLogin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripLogin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.menuStripLogin.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStripLogin.Location = new System.Drawing.Point(53, 4);
            this.menuStripLogin.Name = "menuStripLogin";
            this.menuStripLogin.Size = new System.Drawing.Size(87, 29);
            this.menuStripLogin.TabIndex = 6;
            this.menuStripLogin.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChangePassword,
            this.btnLogout});
            this.loginToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.loginToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loginToolStripMenuItem.Image")));
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.Image")));
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(177, 26);
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(177, 26);
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(142, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 20;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(168, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 5;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 20;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.LogoTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(38, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trung tâm anh ngữ";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(12, 10);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(20, 20);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 20;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelsideMenu
            // 
            this.panelsideMenu.BackColor = System.Drawing.Color.White;
            this.panelsideMenu.Controls.Add(this.sidePanel);
            this.panelsideMenu.Controls.Add(this.btnInfoApplication);
            this.panelsideMenu.Controls.Add(this.btnManagement);
            this.panelsideMenu.Controls.Add(this.btnList);
            this.panelsideMenu.Controls.Add(this.btnDebt);
            this.panelsideMenu.Controls.Add(this.btnHome);
            this.panelsideMenu.Controls.Add(this.btnStaff);
            this.panelsideMenu.Controls.Add(this.panel3);
            this.LogoTransition.SetDecoration(this.panelsideMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelsideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelsideMenu.Location = new System.Drawing.Point(0, 40);
            this.panelsideMenu.Name = "panelsideMenu";
            this.panelsideMenu.Size = new System.Drawing.Size(200, 452);
            this.panelsideMenu.TabIndex = 1;
            // 
            // btnInfoApplication
            // 
            this.btnInfoApplication.BackColor = System.Drawing.Color.White;
            this.btnInfoApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.btnInfoApplication, BunifuAnimatorNS.DecorationType.None);
            this.btnInfoApplication.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoApplication.Image")));
            this.btnInfoApplication.ImageActive = null;
            this.btnInfoApplication.Location = new System.Drawing.Point(170, 425);
            this.btnInfoApplication.Name = "btnInfoApplication";
            this.btnInfoApplication.Size = new System.Drawing.Size(25, 25);
            this.btnInfoApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInfoApplication.TabIndex = 2;
            this.btnInfoApplication.TabStop = false;
            this.btnInfoApplication.Tag = "";
            this.btnInfoApplication.Zoom = 20;
            this.btnInfoApplication.Click += new System.EventHandler(this.btnInfoApplication_Click);
            // 
            // btnManagement
            // 
            this.btnManagement.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnManagement.BackColor = System.Drawing.Color.White;
            this.btnManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManagement.BorderRadius = 0;
            this.btnManagement.ButtonText = "Quản lý";
            this.btnManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.btnManagement, BunifuAnimatorNS.DecorationType.None);
            this.btnManagement.DisabledColor = System.Drawing.Color.Gray;
            this.btnManagement.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnManagement.Iconcolor = System.Drawing.Color.Transparent;
            this.btnManagement.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnManagement.Iconimage")));
            this.btnManagement.Iconimage_right = null;
            this.btnManagement.Iconimage_right_Selected = null;
            this.btnManagement.Iconimage_Selected = null;
            this.btnManagement.IconMarginLeft = 0;
            this.btnManagement.IconMarginRight = 0;
            this.btnManagement.IconRightVisible = true;
            this.btnManagement.IconRightZoom = 0D;
            this.btnManagement.IconVisible = true;
            this.btnManagement.IconZoom = 50D;
            this.btnManagement.IsTab = true;
            this.btnManagement.Location = new System.Drawing.Point(0, 267);
            this.btnManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Normalcolor = System.Drawing.Color.White;
            this.btnManagement.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnManagement.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnManagement.selected = false;
            this.btnManagement.Size = new System.Drawing.Size(200, 48);
            this.btnManagement.TabIndex = 1;
            this.btnManagement.Text = "Quản lý";
            this.btnManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnManagement.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnManagement.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagement.Click += new System.EventHandler(this.btnManagement_Click);
            // 
            // btnList
            // 
            this.btnList.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnList.BackColor = System.Drawing.Color.White;
            this.btnList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnList.BorderRadius = 0;
            this.btnList.ButtonText = "Danh sách";
            this.btnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.btnList, BunifuAnimatorNS.DecorationType.None);
            this.btnList.DisabledColor = System.Drawing.Color.Gray;
            this.btnList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnList.Iconcolor = System.Drawing.Color.Transparent;
            this.btnList.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnList.Iconimage")));
            this.btnList.Iconimage_right = null;
            this.btnList.Iconimage_right_Selected = null;
            this.btnList.Iconimage_Selected = null;
            this.btnList.IconMarginLeft = 0;
            this.btnList.IconMarginRight = 0;
            this.btnList.IconRightVisible = true;
            this.btnList.IconRightZoom = 0D;
            this.btnList.IconVisible = true;
            this.btnList.IconZoom = 50D;
            this.btnList.IsTab = true;
            this.btnList.Location = new System.Drawing.Point(0, 375);
            this.btnList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnList.Name = "btnList";
            this.btnList.Normalcolor = System.Drawing.Color.White;
            this.btnList.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnList.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnList.selected = false;
            this.btnList.Size = new System.Drawing.Size(200, 48);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "Danh sách";
            this.btnList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnList.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnList.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnDebt
            // 
            this.btnDebt.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnDebt.BackColor = System.Drawing.Color.White;
            this.btnDebt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDebt.BorderRadius = 0;
            this.btnDebt.ButtonText = "Công nợ";
            this.btnDebt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.btnDebt, BunifuAnimatorNS.DecorationType.None);
            this.btnDebt.DisabledColor = System.Drawing.Color.Gray;
            this.btnDebt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDebt.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDebt.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDebt.Iconimage")));
            this.btnDebt.Iconimage_right = null;
            this.btnDebt.Iconimage_right_Selected = null;
            this.btnDebt.Iconimage_Selected = null;
            this.btnDebt.IconMarginLeft = 0;
            this.btnDebt.IconMarginRight = 0;
            this.btnDebt.IconRightVisible = true;
            this.btnDebt.IconRightZoom = 0D;
            this.btnDebt.IconVisible = true;
            this.btnDebt.IconZoom = 50D;
            this.btnDebt.IsTab = true;
            this.btnDebt.Location = new System.Drawing.Point(0, 321);
            this.btnDebt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDebt.Name = "btnDebt";
            this.btnDebt.Normalcolor = System.Drawing.Color.White;
            this.btnDebt.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDebt.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnDebt.selected = false;
            this.btnDebt.Size = new System.Drawing.Size(200, 48);
            this.btnDebt.TabIndex = 1;
            this.btnDebt.Text = "Công nợ";
            this.btnDebt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDebt.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnDebt.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebt.Click += new System.EventHandler(this.btnDebt_Click);
            // 
            // btnHome
            // 
            this.btnHome.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnHome.BackColor = System.Drawing.Color.Gainsboro;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = "Home";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHome.Iconimage")));
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 0;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 50D;
            this.btnHome.IsTab = true;
            this.btnHome.Location = new System.Drawing.Point(0, 164);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.White;
            this.btnHome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnHome.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnHome.selected = true;
            this.btnHome.Size = new System.Drawing.Size(200, 48);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHome.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnHome.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnStaff.BackColor = System.Drawing.Color.White;
            this.btnStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStaff.BorderRadius = 0;
            this.btnStaff.ButtonText = "Nhân viên";
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.btnStaff, BunifuAnimatorNS.DecorationType.None);
            this.btnStaff.DisabledColor = System.Drawing.Color.Gray;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnStaff.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStaff.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStaff.Iconimage")));
            this.btnStaff.Iconimage_right = null;
            this.btnStaff.Iconimage_right_Selected = null;
            this.btnStaff.Iconimage_Selected = null;
            this.btnStaff.IconMarginLeft = 0;
            this.btnStaff.IconMarginRight = 0;
            this.btnStaff.IconRightVisible = true;
            this.btnStaff.IconRightZoom = 0D;
            this.btnStaff.IconVisible = true;
            this.btnStaff.IconZoom = 50D;
            this.btnStaff.IsTab = true;
            this.btnStaff.Location = new System.Drawing.Point(0, 214);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Normalcolor = System.Drawing.Color.White;
            this.btnStaff.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnStaff.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnStaff.selected = false;
            this.btnStaff.Size = new System.Drawing.Size(200, 48);
            this.btnStaff.TabIndex = 1;
            this.btnStaff.Text = "Nhân viên";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStaff.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnStaff.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.panel3.Controls.Add(this.labelName);
            this.panel3.Controls.Add(this.logo);
            this.LogoTransition.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 149);
            this.panel3.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.LogoTransition.SetDecoration(this.labelName, BunifuAnimatorNS.DecorationType.None);
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Silver;
            this.labelName.Location = new System.Drawing.Point(23, 91);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(142, 21);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Trung tâm anh ngữ";
            // 
            // logo
            // 
            this.LogoTransition.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(48, 39);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(100, 50);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // nMainElipse
            // 
            this.nMainElipse.ElipseRadius = 5;
            this.nMainElipse.TargetControl = this;
            // 
            // headerDragControl
            // 
            this.headerDragControl.Fixed = true;
            this.headerDragControl.Horizontal = true;
            this.headerDragControl.TargetControl = this.header;
            this.headerDragControl.Vertical = true;
            // 
            // sideMain
            // 
            this.sideMain.Controls.Add(this.infoHome);
            this.sideMain.Controls.Add(this.infoApplication);
            this.sideMain.Controls.Add(this.infochangePassword);
            this.sideMain.Controls.Add(this.infoList);
            this.sideMain.Controls.Add(this.infoDebt);
            this.sideMain.Controls.Add(this.infoManagement);
            this.sideMain.Controls.Add(this.infoStaff);
            this.LogoTransition.SetDecoration(this.sideMain, BunifuAnimatorNS.DecorationType.None);
            this.sideMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideMain.Location = new System.Drawing.Point(200, 40);
            this.sideMain.Name = "sideMain";
            this.sideMain.Size = new System.Drawing.Size(603, 452);
            this.sideMain.TabIndex = 2;
            // 
            // infoHome
            // 
            this.LogoTransition.SetDecoration(this.infoHome, BunifuAnimatorNS.DecorationType.None);
            this.infoHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoHome.Location = new System.Drawing.Point(0, 0);
            this.infoHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.infoHome.Name = "infoHome";
            this.infoHome.Size = new System.Drawing.Size(603, 452);
            this.infoHome.TabIndex = 6;
            // 
            // infoApplication
            // 
            this.LogoTransition.SetDecoration(this.infoApplication, BunifuAnimatorNS.DecorationType.None);
            this.infoApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoApplication.Location = new System.Drawing.Point(0, 0);
            this.infoApplication.Margin = new System.Windows.Forms.Padding(4);
            this.infoApplication.Name = "infoApplication";
            this.infoApplication.Size = new System.Drawing.Size(603, 452);
            this.infoApplication.TabIndex = 5;
            // 
            // infochangePassword
            // 
            this.LogoTransition.SetDecoration(this.infochangePassword, BunifuAnimatorNS.DecorationType.None);
            this.infochangePassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infochangePassword.Location = new System.Drawing.Point(0, 0);
            this.infochangePassword.Margin = new System.Windows.Forms.Padding(4);
            this.infochangePassword.Name = "infochangePassword";
            this.infochangePassword.Size = new System.Drawing.Size(603, 452);
            this.infochangePassword.TabIndex = 4;
            // 
            // infoList
            // 
            this.LogoTransition.SetDecoration(this.infoList, BunifuAnimatorNS.DecorationType.None);
            this.infoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoList.Location = new System.Drawing.Point(0, 0);
            this.infoList.Margin = new System.Windows.Forms.Padding(4);
            this.infoList.Name = "infoList";
            this.infoList.Size = new System.Drawing.Size(603, 452);
            this.infoList.TabIndex = 3;
            // 
            // infoDebt
            // 
            this.LogoTransition.SetDecoration(this.infoDebt, BunifuAnimatorNS.DecorationType.None);
            this.infoDebt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoDebt.Location = new System.Drawing.Point(0, 0);
            this.infoDebt.Margin = new System.Windows.Forms.Padding(4);
            this.infoDebt.Name = "infoDebt";
            this.infoDebt.Size = new System.Drawing.Size(603, 452);
            this.infoDebt.TabIndex = 2;
            // 
            // infoManagement
            // 
            this.LogoTransition.SetDecoration(this.infoManagement, BunifuAnimatorNS.DecorationType.None);
            this.infoManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoManagement.Location = new System.Drawing.Point(0, 0);
            this.infoManagement.Margin = new System.Windows.Forms.Padding(4);
            this.infoManagement.Name = "infoManagement";
            this.infoManagement.Size = new System.Drawing.Size(603, 452);
            this.infoManagement.TabIndex = 1;
            // 
            // infoStaff
            // 
            this.infoStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LogoTransition.SetDecoration(this.infoStaff, BunifuAnimatorNS.DecorationType.None);
            this.infoStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoStaff.Location = new System.Drawing.Point(0, 0);
            this.infoStaff.Margin = new System.Windows.Forms.Padding(4);
            this.infoStaff.Name = "infoStaff";
            this.infoStaff.Size = new System.Drawing.Size(603, 452);
            this.infoStaff.TabIndex = 0;
            // 
            // LogoTransition
            // 
            this.LogoTransition.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.LogoTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.LogoTransition.DefaultAnimation = animation1;
            this.LogoTransition.TimeStep = 0.015F;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.LogoTransition.SetDecoration(this.sidePanel, BunifuAnimatorNS.DecorationType.None);
            this.sidePanel.Location = new System.Drawing.Point(0, 164);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(10, 48);
            this.sidePanel.TabIndex = 7;
            // 
            // nMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(803, 492);
            this.Controls.Add(this.sideMain);
            this.Controls.Add(this.panelsideMenu);
            this.Controls.Add(this.header);
            this.LogoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "nMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nMain";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStripLogin.ResumeLayout(false);
            this.menuStripLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panelsideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInfoApplication)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.sideMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel panelsideMenu;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnManagement;
        private Bunifu.Framework.UI.BunifuFlatButton btnDebt;
        private Bunifu.Framework.UI.BunifuFlatButton btnStaff;
        private Bunifu.Framework.UI.BunifuElipse nMainElipse;
        private Bunifu.Framework.UI.BunifuDragControl headerDragControl;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel sideMain;
        private nStaff infoStaff;
        private nManagement infoManagement;
        private Bunifu.Framework.UI.BunifuFlatButton btnList;
        private nDebt infoDebt;
        private nList infoList;
        private changePassword infochangePassword;
        private Bunifu.Framework.UI.BunifuImageButton btnInfoApplication;
        private infoApplication infoApplication;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
        private nHome infoHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStripLogin;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnChangePassword;
        private System.Windows.Forms.ToolStripMenuItem btnLogout;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private BunifuAnimatorNS.BunifuTransition LogoTransition;
        private System.Windows.Forms.Panel sidePanel;
    }
}