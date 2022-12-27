﻿namespace FreeControl
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ledTitle = new Sunny.UI.UILedDisplay();
            this.navImgList = new System.Windows.Forms.ImageList(this.components);
            this.navTab = new Sunny.UI.UITabControlMenu();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.linkIssues = new Sunny.UI.UILinkLabel();
            this.tbxPort = new Sunny.UI.UITextBox();
            this.cbxUseWireless = new Sunny.UI.UICheckBox();
            this.tbxAddress = new Sunny.UI.UITextBox();
            this.linkSetPort = new Sunny.UI.UILinkLabel();
            this.linkEnabledADB = new Sunny.UI.UILinkLabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.btnStart = new Sunny.UI.UISymbolButton();
            this.tabSetting = new System.Windows.Forms.TabPage();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.comboPx = new Sunny.UI.UIComboBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.comboMbps = new Sunny.UI.UIComboBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.comboMaxFPS = new Sunny.UI.UIComboBox();
            this.rbtnShortcuts = new Sunny.UI.UIRadioButtonGroup();
            this.lbAllShortcut = new Sunny.UI.UILabel();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.updownWidth = new Sunny.UI.UIIntegerUpDown();
            this.updownHeight = new Sunny.UI.UIIntegerUpDown();
            this.cbxOtherSetting = new Sunny.UI.UIGroupBox();
            this.cbxControllerEnabled = new Sunny.UI.UICheckBox();
            this.cbxShowTouches = new Sunny.UI.UICheckBox();
            this.cbxTopMost = new Sunny.UI.UICheckBox();
            this.cbxReadOnly = new Sunny.UI.UICheckBox();
            this.cbxFullScreen = new Sunny.UI.UICheckBox();
            this.cbxHideBorder = new Sunny.UI.UICheckBox();
            this.cbxUseLog = new Sunny.UI.UICheckBox();
            this.cbxKeepAwake = new Sunny.UI.UICheckBox();
            this.cbxCloseScreen = new Sunny.UI.UICheckBox();
            this.uDarkMode = new Sunny.UI.UILabel();
            this.switchDarkMode = new Sunny.UI.UISwitch();
            this.cbxAllFPS = new Sunny.UI.UICheckBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnClose = new Sunny.UI.UIButton();
            this.btnMini = new Sunny.UI.UIButton();
            this.navTab.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabSetting.SuspendLayout();
            this.rbtnShortcuts.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.cbxOtherSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // ledTitle
            // 
            this.ledTitle.BackColor = System.Drawing.Color.Transparent;
            this.ledTitle.BorderColor = System.Drawing.Color.Transparent;
            this.ledTitle.BorderInColor = System.Drawing.Color.Transparent;
            this.ledTitle.CharCount = 12;
            this.ledTitle.ForeColor = System.Drawing.Color.Linen;
            this.ledTitle.IntervalH = 0;
            this.ledTitle.IntervalV = 0;
            this.ledTitle.LedBackColor = System.Drawing.Color.Transparent;
            this.ledTitle.Location = new System.Drawing.Point(13, 35);
            this.ledTitle.Name = "ledTitle";
            this.ledTitle.Size = new System.Drawing.Size(222, 24);
            this.ledTitle.TabIndex = 0;
            this.ledTitle.Text = "Free Control";
            // 
            // navImgList
            // 
            this.navImgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.navImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("navImgList.ImageStream")));
            this.navImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.navImgList.Images.SetKeyName(0, "Home.png");
            this.navImgList.Images.SetKeyName(1, "Home_Dark.png");
            this.navImgList.Images.SetKeyName(2, "Setting.png");
            this.navImgList.Images.SetKeyName(3, "Setting_Dark.png");
            // 
            // navTab
            // 
            this.navTab.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.navTab.Controls.Add(this.tabHome);
            this.navTab.Controls.Add(this.tabSetting);
            this.navTab.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.navTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.navTab.ImageList = this.navImgList;
            this.navTab.ItemSize = new System.Drawing.Size(50, 50);
            this.navTab.Location = new System.Drawing.Point(0, 63);
            this.navTab.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.navTab.Multiline = true;
            this.navTab.Name = "navTab";
            this.navTab.SelectedIndex = 0;
            this.navTab.Size = new System.Drawing.Size(658, 278);
            this.navTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.navTab.Style = Sunny.UI.UIStyle.Custom;
            this.navTab.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.navTab.TabIndex = 6;
            this.navTab.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.navTab.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.navTab.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.Transparent;
            this.tabHome.Controls.Add(this.linkIssues);
            this.tabHome.Controls.Add(this.tbxPort);
            this.tabHome.Controls.Add(this.cbxUseWireless);
            this.tabHome.Controls.Add(this.tbxAddress);
            this.tabHome.Controls.Add(this.linkSetPort);
            this.tabHome.Controls.Add(this.linkEnabledADB);
            this.tabHome.Controls.Add(this.uiLabel1);
            this.tabHome.Controls.Add(this.btnStart);
            this.tabHome.ImageIndex = 0;
            this.tabHome.Location = new System.Drawing.Point(51, 0);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(607, 278);
            this.tabHome.TabIndex = 0;
            // 
            // linkIssues
            // 
            this.linkIssues.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.linkIssues.AutoSize = true;
            this.linkIssues.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkIssues.LinkArea = new System.Windows.Forms.LinkArea(0, 12);
            this.linkIssues.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkIssues.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.linkIssues.Location = new System.Drawing.Point(360, 200);
            this.linkIssues.Name = "linkIssues";
            this.linkIssues.Size = new System.Drawing.Size(37, 21);
            this.linkIssues.Style = Sunny.UI.UIStyle.Custom;
            this.linkIssues.TabIndex = 27;
            this.linkIssues.TabStop = true;
            this.linkIssues.Text = "issues";
            this.linkIssues.UseCompatibleTextRendering = true;
            this.linkIssues.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.linkIssues.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.linkIssues.Click += new System.EventHandler(this.linkIssues_Click);
            // 
            // tbxPort
            // 
            this.tbxPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPort.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPort.Location = new System.Drawing.Point(363, 229);
            this.tbxPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxPort.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Padding = new System.Windows.Forms.Padding(5);
            this.tbxPort.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tbxPort.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tbxPort.ShowText = false;
            this.tbxPort.Size = new System.Drawing.Size(67, 27);
            this.tbxPort.Style = Sunny.UI.UIStyle.Custom;
            this.tbxPort.StyleCustomMode = true;
            this.tbxPort.TabIndex = 26;
            this.tbxPort.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbxPort.Watermark = "port";
            this.tbxPort.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbxUseWireless
            // 
            this.cbxUseWireless.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.cbxUseWireless.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxUseWireless.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxUseWireless.Location = new System.Drawing.Point(118, 229);
            this.cbxUseWireless.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbxUseWireless.Name = "cbxUseWireless";
            this.cbxUseWireless.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cbxUseWireless.Size = new System.Drawing.Size(85, 29);
            this.cbxUseWireless.Style = Sunny.UI.UIStyle.Custom;
            this.cbxUseWireless.TabIndex = 25;
            this.cbxUseWireless.Text = "wireless ";
            this.cbxUseWireless.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tbxAddress
            // 
            this.tbxAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxAddress.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxAddress.Location = new System.Drawing.Point(210, 229);
            this.tbxAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxAddress.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Padding = new System.Windows.Forms.Padding(5);
            this.tbxAddress.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tbxAddress.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tbxAddress.ShowText = false;
            this.tbxAddress.Size = new System.Drawing.Size(145, 27);
            this.tbxAddress.Style = Sunny.UI.UIStyle.Custom;
            this.tbxAddress.StyleCustomMode = true;
            this.tbxAddress.TabIndex = 24;
            this.tbxAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbxAddress.Watermark = "IP address";
            this.tbxAddress.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // linkSetPort
            // 
            this.linkSetPort.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.linkSetPort.AutoSize = true;
            this.linkSetPort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkSetPort.LinkArea = new System.Windows.Forms.LinkArea(0, 12);
            this.linkSetPort.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkSetPort.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.linkSetPort.Location = new System.Drawing.Point(359, 181);
            this.linkSetPort.Name = "linkSetPort";
            this.linkSetPort.Size = new System.Drawing.Size(93, 21);
            this.linkSetPort.Style = Sunny.UI.UIStyle.Custom;
            this.linkSetPort.TabIndex = 4;
            this.linkSetPort.TabStop = true;
            this.linkSetPort.Text = "set port number";
            this.linkSetPort.UseCompatibleTextRendering = true;
            this.linkSetPort.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.linkSetPort.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.linkSetPort.Click += new System.EventHandler(this.linkSetPort_Click);
            // 
            // linkEnabledADB
            // 
            this.linkEnabledADB.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.linkEnabledADB.AutoSize = true;
            this.linkEnabledADB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkEnabledADB.LinkArea = new System.Windows.Forms.LinkArea(0, 12);
            this.linkEnabledADB.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkEnabledADB.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.linkEnabledADB.Location = new System.Drawing.Point(282, 81);
            this.linkEnabledADB.Name = "linkEnabledADB";
            this.linkEnabledADB.Size = new System.Drawing.Size(180, 21);
            this.linkEnabledADB.Style = Sunny.UI.UIStyle.Custom;
            this.linkEnabledADB.TabIndex = 2;
            this.linkEnabledADB.TabStop = true;
            this.linkEnabledADB.Text = "(How to enable USB debugging)";
            this.linkEnabledADB.UseCompatibleTextRendering = true;
            this.linkEnabledADB.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.linkEnabledADB.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.linkEnabledADB.Click += new System.EventHandler(this.linkEnabledADB_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.uiLabel1.Location = new System.Drawing.Point(142, 78);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(463, 133);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.StyleCustomMode = true;
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = resources.GetString("uiLabel1.Text");
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnStart.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnStart.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnStart.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnStart.Location = new System.Drawing.Point(203, 19);
            this.btnStart.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStart.Name = "btnStart";
            this.btnStart.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnStart.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnStart.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnStart.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnStart.Size = new System.Drawing.Size(145, 51);
            this.btnStart.Style = Sunny.UI.UIStyle.Custom;
            this.btnStart.Symbol = 61671;
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "start";
            this.btnStart.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tabSetting
            // 
            this.tabSetting.BackColor = System.Drawing.Color.Transparent;
            this.tabSetting.Controls.Add(this.uiLabel6);
            this.tabSetting.Controls.Add(this.comboPx);
            this.tabSetting.Controls.Add(this.uiLabel5);
            this.tabSetting.Controls.Add(this.comboMbps);
            this.tabSetting.Controls.Add(this.uiLabel2);
            this.tabSetting.Controls.Add(this.comboMaxFPS);
            this.tabSetting.Controls.Add(this.rbtnShortcuts);
            this.tabSetting.Controls.Add(this.uiGroupBox1);
            this.tabSetting.Controls.Add(this.cbxOtherSetting);
            this.tabSetting.Controls.Add(this.uDarkMode);
            this.tabSetting.Controls.Add(this.switchDarkMode);
            this.tabSetting.Controls.Add(this.cbxAllFPS);
            this.tabSetting.ImageIndex = 2;
            this.tabSetting.Location = new System.Drawing.Point(51, 0);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.Size = new System.Drawing.Size(607, 278);
            this.tabSetting.TabIndex = 1;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel6.Location = new System.Drawing.Point(402, 11);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(87, 29);
            this.uiLabel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel6.TabIndex = 32;
            this.uiLabel6.Text = "Resolution";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // comboPx
            // 
            this.comboPx.DataSource = null;
            this.comboPx.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.comboPx.FillColor = System.Drawing.Color.White;
            this.comboPx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboPx.Items.AddRange(new object[] {
            "默认",
            "1920",
            "1440",
            "1280",
            "960",
            "640"});
            this.comboPx.Location = new System.Drawing.Point(496, 11);
            this.comboPx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboPx.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboPx.Name = "comboPx";
            this.comboPx.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboPx.Size = new System.Drawing.Size(99, 29);
            this.comboPx.Style = Sunny.UI.UIStyle.Custom;
            this.comboPx.TabIndex = 31;
            this.comboPx.Text = "Resolution";
            this.comboPx.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboPx.Watermark = "";
            this.comboPx.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel5.Location = new System.Drawing.Point(402, 50);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(87, 29);
            this.uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel5.TabIndex = 30;
            this.uiLabel5.Text = "bit rate";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // comboMbps
            // 
            this.comboMbps.DataSource = null;
            this.comboMbps.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.comboMbps.FillColor = System.Drawing.Color.White;
            this.comboMbps.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboMbps.Items.AddRange(new object[] {
            "默认",
            "64Mbps",
            "32Mbps",
            "16Mbps",
            "8Mbps",
            "4Mbps"});
            this.comboMbps.Location = new System.Drawing.Point(496, 50);
            this.comboMbps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboMbps.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboMbps.Name = "comboMbps";
            this.comboMbps.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboMbps.Size = new System.Drawing.Size(99, 29);
            this.comboMbps.Style = Sunny.UI.UIStyle.Custom;
            this.comboMbps.TabIndex = 29;
            this.comboMbps.Text = "bit rate";
            this.comboMbps.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboMbps.Watermark = "";
            this.comboMbps.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel2.Location = new System.Drawing.Point(402, 89);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(87, 29);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 28;
            this.uiLabel2.Text = "frame limit";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // comboMaxFPS
            // 
            this.comboMaxFPS.DataSource = null;
            this.comboMaxFPS.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.comboMaxFPS.FillColor = System.Drawing.Color.White;
            this.comboMaxFPS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboMaxFPS.Items.AddRange(new object[] {
            "default",
            "144",
            "120",
            "90",
            "60",
            "30"});
            this.comboMaxFPS.Location = new System.Drawing.Point(496, 89);
            this.comboMaxFPS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboMaxFPS.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboMaxFPS.Name = "comboMaxFPS";
            this.comboMaxFPS.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboMaxFPS.Size = new System.Drawing.Size(99, 29);
            this.comboMaxFPS.Style = Sunny.UI.UIStyle.Custom;
            this.comboMaxFPS.TabIndex = 27;
            this.comboMaxFPS.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboMaxFPS.Watermark = "";
            this.comboMaxFPS.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // rbtnShortcuts
            // 
            this.rbtnShortcuts.BackColor = System.Drawing.Color.Transparent;
            this.rbtnShortcuts.Controls.Add(this.lbAllShortcut);
            this.rbtnShortcuts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.rbtnShortcuts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnShortcuts.Items.AddRange(new object[] {
            "Ctrl",
            "Ctrl + Alt",
            "Alt"});
            this.rbtnShortcuts.ItemSize = new System.Drawing.Size(100, 27);
            this.rbtnShortcuts.Location = new System.Drawing.Point(207, 5);
            this.rbtnShortcuts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnShortcuts.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbtnShortcuts.Name = "rbtnShortcuts";
            this.rbtnShortcuts.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.rbtnShortcuts.Radius = 10;
            this.rbtnShortcuts.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.rbtnShortcuts.Size = new System.Drawing.Size(190, 114);
            this.rbtnShortcuts.Style = Sunny.UI.UIStyle.Custom;
            this.rbtnShortcuts.TabIndex = 25;
            this.rbtnShortcuts.Text = "hot key（                ）";
            this.rbtnShortcuts.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnShortcuts.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // lbAllShortcut
            // 
            this.lbAllShortcut.AutoSize = true;
            this.lbAllShortcut.BackColor = System.Drawing.Color.Transparent;
            this.lbAllShortcut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbAllShortcut.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAllShortcut.Location = new System.Drawing.Point(70, 6);
            this.lbAllShortcut.Name = "lbAllShortcut";
            this.lbAllShortcut.Size = new System.Drawing.Size(59, 20);
            this.lbAllShortcut.Style = Sunny.UI.UIStyle.Custom;
            this.lbAllShortcut.TabIndex = 24;
            this.lbAllShortcut.Text = "view all";
            this.lbAllShortcut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbAllShortcut.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.lbAllShortcut.Click += new System.EventHandler(this.lbAllShortcut_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.uiLabel4);
            this.uiGroupBox1.Controls.Add(this.uiLabel3);
            this.uiGroupBox1.Controls.Add(this.updownWidth);
            this.uiGroupBox1.Controls.Add(this.updownHeight);
            this.uiGroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.uiGroupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiGroupBox1.Location = new System.Drawing.Point(9, 5);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.uiGroupBox1.Size = new System.Drawing.Size(190, 114);
            this.uiGroupBox1.Style = Sunny.UI.UIStyle.Custom;
            this.uiGroupBox1.TabIndex = 22;
            this.uiGroupBox1.Text = "window size";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel4.Location = new System.Drawing.Point(10, 35);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(46, 23);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 3;
            this.uiLabel4.Text = "high";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel3.Location = new System.Drawing.Point(10, 74);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(46, 23);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 2;
            this.uiLabel3.Text = "width";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // updownWidth
            // 
            this.updownWidth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updownWidth.HasMaximum = true;
            this.updownWidth.HasMinimum = true;
            this.updownWidth.Location = new System.Drawing.Point(60, 73);
            this.updownWidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updownWidth.Maximum = 5555;
            this.updownWidth.MaximumEnabled = true;
            this.updownWidth.Minimum = 0;
            this.updownWidth.MinimumEnabled = true;
            this.updownWidth.MinimumSize = new System.Drawing.Size(100, 0);
            this.updownWidth.Name = "updownWidth";
            this.updownWidth.ShowText = false;
            this.updownWidth.Size = new System.Drawing.Size(116, 29);
            this.updownWidth.Style = Sunny.UI.UIStyle.Custom;
            this.updownWidth.TabIndex = 1;
            this.updownWidth.Text = "uiIntegerUpDown2";
            this.updownWidth.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.updownWidth.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // updownHeight
            // 
            this.updownHeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updownHeight.HasMaximum = true;
            this.updownHeight.HasMinimum = true;
            this.updownHeight.Location = new System.Drawing.Point(60, 34);
            this.updownHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updownHeight.Maximum = 5555;
            this.updownHeight.MaximumEnabled = true;
            this.updownHeight.Minimum = 0;
            this.updownHeight.MinimumEnabled = true;
            this.updownHeight.MinimumSize = new System.Drawing.Size(100, 0);
            this.updownHeight.Name = "updownHeight";
            this.updownHeight.ShowText = false;
            this.updownHeight.Size = new System.Drawing.Size(116, 29);
            this.updownHeight.Style = Sunny.UI.UIStyle.Custom;
            this.updownHeight.TabIndex = 0;
            this.updownHeight.Text = "uiIntegerUpDown1";
            this.updownHeight.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.updownHeight.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbxOtherSetting
            // 
            this.cbxOtherSetting.Controls.Add(this.cbxControllerEnabled);
            this.cbxOtherSetting.Controls.Add(this.cbxShowTouches);
            this.cbxOtherSetting.Controls.Add(this.cbxTopMost);
            this.cbxOtherSetting.Controls.Add(this.cbxReadOnly);
            this.cbxOtherSetting.Controls.Add(this.cbxFullScreen);
            this.cbxOtherSetting.Controls.Add(this.cbxHideBorder);
            this.cbxOtherSetting.Controls.Add(this.cbxUseLog);
            this.cbxOtherSetting.Controls.Add(this.cbxKeepAwake);
            this.cbxOtherSetting.Controls.Add(this.cbxCloseScreen);
            this.cbxOtherSetting.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.cbxOtherSetting.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxOtherSetting.Location = new System.Drawing.Point(9, 130);
            this.cbxOtherSetting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxOtherSetting.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbxOtherSetting.Name = "cbxOtherSetting";
            this.cbxOtherSetting.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.cbxOtherSetting.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.cbxOtherSetting.Size = new System.Drawing.Size(586, 110);
            this.cbxOtherSetting.Style = Sunny.UI.UIStyle.Custom;
            this.cbxOtherSetting.TabIndex = 3;
            this.cbxOtherSetting.Text = "other settings";
            this.cbxOtherSetting.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxOtherSetting.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbxControllerEnabled
            // 
            this.cbxControllerEnabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxControllerEnabled.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxControllerEnabled.Location = new System.Drawing.Point(335, 70);
            this.cbxControllerEnabled.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbxControllerEnabled.Name = "cbxControllerEnabled";
            this.cbxControllerEnabled.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cbxControllerEnabled.Size = new System.Drawing.Size(102, 29);
            this.cbxControllerEnabled.Style = Sunny.UI.UIStyle.Custom;
            this.cbxControllerEnabled.TabIndex = 9;
            this.cbxControllerEnabled.Text = "enable controller";
            this.cbxControllerEnabled.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbxShowTouches
            // 
            this.cbxShowTouches.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxShowTouches.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxShowTouches.Location = new System.Drawing.Point(443, 35);
            this.cbxShowTouches.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbxShowTouches.Name = "cbxShowTouches";
            this.cbxShowTouches.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cbxShowTouches.Size = new System.Drawing.Size(102, 29);
            this.cbxShowTouches.Style = Sunny.UI.UIStyle.Custom;
            this.cbxShowTouches.TabIndex = 8;
            this.cbxShowTouches.Text = "show touch";
            this.cbxShowTouches.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbxTopMost
            // 
            this.cbxTopMost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxTopMost.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxTopMost.Location = new System.Drawing.Point(119, 67);
            this.cbxTopMost.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbxTopMost.Name = "cbxTopMost";
            this.cbxTopMost.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cbxTopMost.Size = new System.Drawing.Size(102, 29);
            this.cbxTopMost.Style = Sunny.UI.UIStyle.Custom;
            this.cbxTopMost.TabIndex = 6;
            this.cbxTopMost.Text = "on top";
            this.cbxTopMost.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbxReadOnly
            // 
            this.cbxReadOnly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxReadOnly.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxReadOnly.Location = new System.Drawing.Point(227, 67);
            this.cbxReadOnly.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbxReadOnly.Name = "cbxReadOnly";
            this.cbxReadOnly.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cbxReadOnly.Size = new System.Drawing.Size(102, 29);
            this.cbxReadOnly.Style = Sunny.UI.UIStyle.Custom;
            this.cbxReadOnly.TabIndex = 7;
            this.cbxReadOnly.Text = "read-only mode";
            this.cbxReadOnly.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbxFullScreen
            // 
            this.cbxFullScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxFullScreen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxFullScreen.Location = new System.Drawing.Point(11, 67);
            this.cbxFullScreen.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbxFullScreen.Name = "cbxFullScreen";
            this.cbxFullScreen.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cbxFullScreen.Size = new System.Drawing.Size(102, 29);
            this.cbxFullScreen.Style = Sunny.UI.UIStyle.Custom;
            this.cbxFullScreen.TabIndex = 5;
            this.cbxFullScreen.Text = "full-screen display";
            this.cbxFullScreen.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbxHideBorder
            // 
            this.cbxHideBorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxHideBorder.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxHideBorder.Location = new System.Drawing.Point(335, 35);
            this.cbxHideBorder.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbxHideBorder.Name = "cbxHideBorder";
            this.cbxHideBorder.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cbxHideBorder.Size = new System.Drawing.Size(102, 29);
            this.cbxHideBorder.Style = Sunny.UI.UIStyle.Custom;
            this.cbxHideBorder.TabIndex = 4;
            this.cbxHideBorder.Text = "hide border";
            this.cbxHideBorder.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbxUseLog
            // 
            this.cbxUseLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxUseLog.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxUseLog.Location = new System.Drawing.Point(227, 35);
            this.cbxUseLog.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbxUseLog.Name = "cbxUseLog";
            this.cbxUseLog.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cbxUseLog.Size = new System.Drawing.Size(102, 29);
            this.cbxUseLog.Style = Sunny.UI.UIStyle.Custom;
            this.cbxUseLog.TabIndex = 3;
            this.cbxUseLog.Text = "log";
            this.cbxUseLog.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbxKeepAwake
            // 
            this.cbxKeepAwake.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxKeepAwake.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxKeepAwake.Location = new System.Drawing.Point(119, 35);
            this.cbxKeepAwake.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbxKeepAwake.Name = "cbxKeepAwake";
            this.cbxKeepAwake.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cbxKeepAwake.Size = new System.Drawing.Size(102, 29);
            this.cbxKeepAwake.Style = Sunny.UI.UIStyle.Custom;
            this.cbxKeepAwake.TabIndex = 1;
            this.cbxKeepAwake.Text = "stay awake";
            this.cbxKeepAwake.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbxCloseScreen
            // 
            this.cbxCloseScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxCloseScreen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxCloseScreen.Location = new System.Drawing.Point(11, 35);
            this.cbxCloseScreen.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbxCloseScreen.Name = "cbxCloseScreen";
            this.cbxCloseScreen.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cbxCloseScreen.Size = new System.Drawing.Size(102, 29);
            this.cbxCloseScreen.Style = Sunny.UI.UIStyle.Custom;
            this.cbxCloseScreen.TabIndex = 0;
            this.cbxCloseScreen.Text = "turn off the screen";
            this.cbxCloseScreen.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uDarkMode
            // 
            this.uDarkMode.AutoSize = true;
            this.uDarkMode.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uDarkMode.Location = new System.Drawing.Point(435, 248);
            this.uDarkMode.Name = "uDarkMode";
            this.uDarkMode.Size = new System.Drawing.Size(81, 20);
            this.uDarkMode.Style = Sunny.UI.UIStyle.Custom;
            this.uDarkMode.TabIndex = 16;
            this.uDarkMode.Text = "dark mode";
            this.uDarkMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uDarkMode.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // switchDarkMode
            // 
            this.switchDarkMode.ActiveText = "ON";
            this.switchDarkMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchDarkMode.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.switchDarkMode.InActiveText = "OFF";
            this.switchDarkMode.Location = new System.Drawing.Point(515, 245);
            this.switchDarkMode.MinimumSize = new System.Drawing.Size(1, 1);
            this.switchDarkMode.Name = "switchDarkMode";
            this.switchDarkMode.Size = new System.Drawing.Size(75, 29);
            this.switchDarkMode.Style = Sunny.UI.UIStyle.Custom;
            this.switchDarkMode.TabIndex = 17;
            this.switchDarkMode.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbxAllFPS
            // 
            this.cbxAllFPS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxAllFPS.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxAllFPS.Location = new System.Drawing.Point(216, 246);
            this.cbxAllFPS.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbxAllFPS.Name = "cbxAllFPS";
            this.cbxAllFPS.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cbxAllFPS.Size = new System.Drawing.Size(131, 29);
            this.cbxAllFPS.Style = Sunny.UI.UIStyle.Custom;
            this.cbxAllFPS.TabIndex = 2;
            this.cbxAllFPS.Text = "full frame rendering";
            this.cbxAllFPS.Visible = false;
            this.cbxAllFPS.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(280, 35);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(174, 40);
            this.lbTitle.TabIndex = 8;
            this.lbTitle.Text = "Free Control";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(611, 35);
            this.btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.Style = Sunny.UI.UIStyle.Custom;
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "×";
            this.btnClose.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnMini
            // 
            this.btnMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMini.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMini.Location = new System.Drawing.Point(570, 35);
            this.btnMini.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(35, 35);
            this.btnMini.Style = Sunny.UI.UIStyle.Custom;
            this.btnMini.TabIndex = 10;
            this.btnMini.Text = "-";
            this.btnMini.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Main
            // 
            this.AllowShowTitle = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(658, 340);
            this.Controls.Add(this.btnMini);
            this.Controls.Add(this.ledTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.navTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.ShowRect = false;
            this.ShowTitle = false;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.TitleHeight = 63;
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 658, 340);
            this.navTab.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.tabSetting.ResumeLayout(false);
            this.tabSetting.PerformLayout();
            this.rbtnShortcuts.ResumeLayout(false);
            this.rbtnShortcuts.PerformLayout();
            this.uiGroupBox1.ResumeLayout(false);
            this.cbxOtherSetting.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UILedDisplay ledTitle;
        private System.Windows.Forms.ImageList navImgList;
        private Sunny.UI.UITabControlMenu navTab;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabSetting;
        private Sunny.UI.UISymbolButton btnStart;
        private Sunny.UI.UILabel uDarkMode;
        private Sunny.UI.UISwitch switchDarkMode;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILinkLabel linkEnabledADB;
        private Sunny.UI.UIGroupBox cbxOtherSetting;
        private Sunny.UI.UICheckBox cbxCloseScreen;
        private Sunny.UI.UICheckBox cbxAllFPS;
        private Sunny.UI.UICheckBox cbxKeepAwake;
        private Sunny.UI.UICheckBox cbxUseLog;
        private Sunny.UI.UICheckBox cbxHideBorder;
        private Sunny.UI.UICheckBox cbxFullScreen;
        private Sunny.UI.UICheckBox cbxTopMost;
        private Sunny.UI.UILinkLabel linkSetPort;
        private Sunny.UI.UITextBox tbxPort;
        private Sunny.UI.UICheckBox cbxUseWireless;
        private Sunny.UI.UITextBox tbxAddress;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIIntegerUpDown updownWidth;
        private Sunny.UI.UIIntegerUpDown updownHeight;
        private Sunny.UI.UICheckBox cbxReadOnly;
        private Sunny.UI.UICheckBox cbxShowTouches;
        private Sunny.UI.UILinkLabel linkIssues;
        private Sunny.UI.UIRadioButtonGroup rbtnShortcuts;
        private Sunny.UI.UILabel lbAllShortcut;
        private System.Windows.Forms.Label lbTitle;
        private Sunny.UI.UIButton btnClose;
        private Sunny.UI.UIButton btnMini;
        private Sunny.UI.UIComboBox comboMaxFPS;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIComboBox comboMbps;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIComboBox comboPx;
        private Sunny.UI.UICheckBox cbxControllerEnabled;
    }
}

