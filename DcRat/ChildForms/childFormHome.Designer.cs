﻿
namespace DcRat.ChildForms
{
    partial class childFormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(childFormHome));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "127.0.0.1",
            "China",
            "test",
            "1234567890",
            "qwqdanchun/Admin",
            "Windows 10 Pro",
            "True",
            "Type1 installer at 2021/12/29/12:44",
            "Windows Defender",
            "0ms",
            "Program"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("123");
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtoncmd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonpowershell = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonscreen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtoncamera = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonfile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonprocess = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonnetwork = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtondevice = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonicon = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtondetails = new System.Windows.Forms.ToolStripButton();
            this.splitContainerHome = new System.Windows.Forms.SplitContainer();
            this.listViewHome = new System.Windows.Forms.ListView();
            this.columnHeaderip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderaddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadergroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderhwid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderuser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadercamera = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderinstall = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderav = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderping = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderactive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListicon = new System.Windows.Forms.ImageList(this.components);
            this.imageListblank = new System.Windows.Forms.ImageList(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateUI = new System.Windows.Forms.Timer(this.components);
            this.loadShellcodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHome)).BeginInit();
            this.splitContainerHome.Panel1.SuspendLayout();
            this.splitContainerHome.Panel2.SuspendLayout();
            this.splitContainerHome.SuspendLayout();
            this.contextMenuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.AutoSize = false;
            this.toolStripMain.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtoncmd,
            this.toolStripButtonpowershell,
            this.toolStripButtonscreen,
            this.toolStripButtoncamera,
            this.toolStripButtonfile,
            this.toolStripButtonprocess,
            this.toolStripButtonnetwork,
            this.toolStripButtondevice,
            this.toolStripLabel2,
            this.toolStripLabel1,
            this.toolStripButtonicon,
            this.toolStripButtondetails});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(981, 45);
            this.toolStripMain.TabIndex = 0;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripButtoncmd
            // 
            this.toolStripButtoncmd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtoncmd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtoncmd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtoncmd.Image")));
            this.toolStripButtoncmd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtoncmd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtoncmd.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.toolStripButtoncmd.Name = "toolStripButtoncmd";
            this.toolStripButtoncmd.Size = new System.Drawing.Size(36, 42);
            this.toolStripButtoncmd.Text = "Cmd";
            this.toolStripButtoncmd.Click += new System.EventHandler(this.toolStripButtoncmd_Click);
            // 
            // toolStripButtonpowershell
            // 
            this.toolStripButtonpowershell.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonpowershell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonpowershell.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonpowershell.Image")));
            this.toolStripButtonpowershell.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonpowershell.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonpowershell.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.toolStripButtonpowershell.Name = "toolStripButtonpowershell";
            this.toolStripButtonpowershell.Size = new System.Drawing.Size(36, 42);
            this.toolStripButtonpowershell.Text = "Powershell";
            this.toolStripButtonpowershell.Click += new System.EventHandler(this.toolStripButtonpowershell_Click);
            // 
            // toolStripButtonscreen
            // 
            this.toolStripButtonscreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonscreen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonscreen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonscreen.Image")));
            this.toolStripButtonscreen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonscreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonscreen.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.toolStripButtonscreen.Name = "toolStripButtonscreen";
            this.toolStripButtonscreen.Size = new System.Drawing.Size(36, 42);
            this.toolStripButtonscreen.Text = "Screen";
            this.toolStripButtonscreen.Click += new System.EventHandler(this.toolStripButtonscreen_Click);
            // 
            // toolStripButtoncamera
            // 
            this.toolStripButtoncamera.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtoncamera.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtoncamera.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtoncamera.Image")));
            this.toolStripButtoncamera.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtoncamera.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtoncamera.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.toolStripButtoncamera.Name = "toolStripButtoncamera";
            this.toolStripButtoncamera.Size = new System.Drawing.Size(36, 42);
            this.toolStripButtoncamera.Text = "Camera";
            this.toolStripButtoncamera.Click += new System.EventHandler(this.toolStripButtoncamera_Click);
            // 
            // toolStripButtonfile
            // 
            this.toolStripButtonfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonfile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonfile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonfile.Image")));
            this.toolStripButtonfile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonfile.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.toolStripButtonfile.Name = "toolStripButtonfile";
            this.toolStripButtonfile.Size = new System.Drawing.Size(36, 42);
            this.toolStripButtonfile.Text = "File";
            this.toolStripButtonfile.Click += new System.EventHandler(this.toolStripButtonfile_Click);
            // 
            // toolStripButtonprocess
            // 
            this.toolStripButtonprocess.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonprocess.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonprocess.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonprocess.Image")));
            this.toolStripButtonprocess.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonprocess.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonprocess.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.toolStripButtonprocess.Name = "toolStripButtonprocess";
            this.toolStripButtonprocess.Size = new System.Drawing.Size(36, 42);
            this.toolStripButtonprocess.Text = "Process";
            this.toolStripButtonprocess.Click += new System.EventHandler(this.toolStripButtonprocess_Click);
            // 
            // toolStripButtonnetwork
            // 
            this.toolStripButtonnetwork.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonnetwork.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonnetwork.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonnetwork.Image")));
            this.toolStripButtonnetwork.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonnetwork.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonnetwork.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.toolStripButtonnetwork.Name = "toolStripButtonnetwork";
            this.toolStripButtonnetwork.Size = new System.Drawing.Size(36, 42);
            this.toolStripButtonnetwork.Text = "Network";
            // 
            // toolStripButtondevice
            // 
            this.toolStripButtondevice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtondevice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtondevice.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtondevice.Image")));
            this.toolStripButtondevice.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtondevice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtondevice.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.toolStripButtondevice.Name = "toolStripButtondevice";
            this.toolStripButtondevice.Size = new System.Drawing.Size(43, 42);
            this.toolStripButtondevice.Text = "Device";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.toolStripLabel2.Size = new System.Drawing.Size(96, 42);
            this.toolStripLabel2.Text = "toolStripLabel2";
            this.toolStripLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.toolStripLabel1.Size = new System.Drawing.Size(96, 42);
            this.toolStripLabel1.Text = "toolStripLabel1";
            this.toolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripButtonicon
            // 
            this.toolStripButtonicon.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonicon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonicon.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonicon.Image")));
            this.toolStripButtonicon.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonicon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonicon.Name = "toolStripButtonicon";
            this.toolStripButtonicon.Size = new System.Drawing.Size(36, 42);
            this.toolStripButtonicon.Text = "toolStripButton1";
            this.toolStripButtonicon.Click += new System.EventHandler(this.toolStripButtonicon_Click);
            // 
            // toolStripButtondetails
            // 
            this.toolStripButtondetails.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtondetails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtondetails.Enabled = false;
            this.toolStripButtondetails.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtondetails.Image")));
            this.toolStripButtondetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtondetails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtondetails.Name = "toolStripButtondetails";
            this.toolStripButtondetails.Size = new System.Drawing.Size(36, 42);
            this.toolStripButtondetails.Text = "toolStripButton2";
            this.toolStripButtondetails.Click += new System.EventHandler(this.toolStripButtondetails_Click);
            // 
            // splitContainerHome
            // 
            this.splitContainerHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerHome.Location = new System.Drawing.Point(0, 45);
            this.splitContainerHome.Name = "splitContainerHome";
            this.splitContainerHome.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerHome.Panel1
            // 
            this.splitContainerHome.Panel1.Controls.Add(this.listViewHome);
            // 
            // splitContainerHome.Panel2
            // 
            this.splitContainerHome.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainerHome.Size = new System.Drawing.Size(981, 511);
            this.splitContainerHome.SplitterDistance = 273;
            this.splitContainerHome.TabIndex = 1;
            // 
            // listViewHome
            // 
            this.listViewHome.BackColor = System.Drawing.SystemColors.Window;
            this.listViewHome.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderip,
            this.columnHeaderaddress,
            this.columnHeadergroup,
            this.columnHeaderhwid,
            this.columnHeaderuser,
            this.columnHeaderos,
            this.columnHeadercamera,
            this.columnHeaderinstall,
            this.columnHeaderav,
            this.columnHeaderping,
            this.columnHeaderactive});
            this.listViewHome.ContextMenuStrip = this.contextMenuStripMain;
            this.listViewHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewHome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listViewHome.FullRowSelect = true;
            this.listViewHome.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewHome.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.listViewHome.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listViewHome.LargeImageList = this.imageListicon;
            this.listViewHome.Location = new System.Drawing.Point(0, 0);
            this.listViewHome.MultiSelect = false;
            this.listViewHome.Name = "listViewHome";
            this.listViewHome.Size = new System.Drawing.Size(981, 273);
            this.listViewHome.SmallImageList = this.imageListblank;
            this.listViewHome.TabIndex = 0;
            this.listViewHome.UseCompatibleStateImageBehavior = false;
            this.listViewHome.View = System.Windows.Forms.View.Details;
            this.listViewHome.SelectedIndexChanged += new System.EventHandler(this.listViewHome_SelectedIndexChanged);
            this.listViewHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewHome_MouseDown);
            this.listViewHome.MouseLeave += new System.EventHandler(this.listViewHome_MouseLeave);
            this.listViewHome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listViewHome_MouseMove);
            // 
            // columnHeaderip
            // 
            this.columnHeaderip.Text = "IP";
            this.columnHeaderip.Width = 115;
            // 
            // columnHeaderaddress
            // 
            this.columnHeaderaddress.Text = "Address";
            this.columnHeaderaddress.Width = 111;
            // 
            // columnHeadergroup
            // 
            this.columnHeadergroup.Text = "Group";
            // 
            // columnHeaderhwid
            // 
            this.columnHeaderhwid.Text = "HWID";
            this.columnHeaderhwid.Width = 165;
            // 
            // columnHeaderuser
            // 
            this.columnHeaderuser.Text = "User Name/Permission";
            this.columnHeaderuser.Width = 158;
            // 
            // columnHeaderos
            // 
            this.columnHeaderos.Text = "OS Version";
            this.columnHeaderos.Width = 162;
            // 
            // columnHeadercamera
            // 
            this.columnHeadercamera.Text = "Camera";
            this.columnHeadercamera.Width = 59;
            // 
            // columnHeaderinstall
            // 
            this.columnHeaderinstall.Text = "Install Information";
            this.columnHeaderinstall.Width = 193;
            // 
            // columnHeaderav
            // 
            this.columnHeaderav.Text = "Anti-Virus Products";
            this.columnHeaderav.Width = 213;
            // 
            // columnHeaderping
            // 
            this.columnHeaderping.Text = "Ping";
            // 
            // columnHeaderactive
            // 
            this.columnHeaderactive.Text = "Active Window";
            this.columnHeaderactive.Width = 293;
            // 
            // imageListicon
            // 
            this.imageListicon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListicon.ImageStream")));
            this.imageListicon.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListicon.Images.SetKeyName(0, "sandgalss (1).png");
            // 
            // imageListblank
            // 
            this.imageListblank.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListblank.ImageSize = new System.Drawing.Size(1, 32);
            this.imageListblank.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(981, 234);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "DcRat - Dev Version\nCopyright (c) qwqdanchun 2021-2022. \n\nDcRat >>";
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadShellcodeToolStripMenuItem});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(182, 42);
            // 
            // updateUI
            // 
            this.updateUI.Enabled = true;
            this.updateUI.Interval = 500;
            this.updateUI.Tick += new System.EventHandler(this.updateUI_Tick);
            // 
            // loadShellcodeToolStripMenuItem
            // 
            this.loadShellcodeToolStripMenuItem.Image = global::DcRat.Properties.Resources.setting_dark;
            this.loadShellcodeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.loadShellcodeToolStripMenuItem.Name = "loadShellcodeToolStripMenuItem";
            this.loadShellcodeToolStripMenuItem.Size = new System.Drawing.Size(181, 38);
            this.loadShellcodeToolStripMenuItem.Text = "Load Shellcode";
            this.loadShellcodeToolStripMenuItem.Click += new System.EventHandler(this.loadShellcodeToolStripMenuItem_Click);
            // 
            // childFormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 556);
            this.Controls.Add(this.splitContainerHome);
            this.Controls.Add(this.toolStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "childFormHome";
            this.Text = "childFormMain";
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.splitContainerHome.Panel1.ResumeLayout(false);
            this.splitContainerHome.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHome)).EndInit();
            this.splitContainerHome.ResumeLayout(false);
            this.contextMenuStripMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtoncmd;
        private System.Windows.Forms.ToolStripButton toolStripButtonpowershell;
        private System.Windows.Forms.ToolStripButton toolStripButtonscreen;
        private System.Windows.Forms.ToolStripButton toolStripButtoncamera;
        private System.Windows.Forms.ToolStripButton toolStripButtonfile;
        private System.Windows.Forms.ToolStripButton toolStripButtonprocess;
        private System.Windows.Forms.SplitContainer splitContainerHome;
        private System.Windows.Forms.ListView listViewHome;
        private System.Windows.Forms.ColumnHeader columnHeaderip;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButtonnetwork;
        private System.Windows.Forms.ToolStripButton toolStripButtondevice;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Timer updateUI;
        private System.Windows.Forms.ImageList imageListblank;
        private System.Windows.Forms.ColumnHeader columnHeaderaddress;
        private System.Windows.Forms.ColumnHeader columnHeadergroup;
        private System.Windows.Forms.ColumnHeader columnHeaderhwid;
        private System.Windows.Forms.ColumnHeader columnHeaderuser;
        private System.Windows.Forms.ColumnHeader columnHeaderos;
        private System.Windows.Forms.ColumnHeader columnHeadercamera;
        private System.Windows.Forms.ColumnHeader columnHeaderinstall;
        private System.Windows.Forms.ColumnHeader columnHeaderav;
        private System.Windows.Forms.ColumnHeader columnHeaderping;
        private System.Windows.Forms.ColumnHeader columnHeaderactive;
        private System.Windows.Forms.ImageList imageListicon;
        private System.Windows.Forms.ToolStripButton toolStripButtonicon;
        private System.Windows.Forms.ToolStripButton toolStripButtondetails;
        private System.Windows.Forms.ToolStripMenuItem loadShellcodeToolStripMenuItem;
    }
}