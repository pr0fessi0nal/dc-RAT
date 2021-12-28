
namespace DcRat.SingleForms
{
    partial class singleFormProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(singleFormProcess));
            this.paneltop = new System.Windows.Forms.Panel();
            this.labelDcRat = new System.Windows.Forms.Label();
            this.buttonmin = new System.Windows.Forms.Button();
            this.buttonmax = new System.Windows.Forms.Button();
            this.buttonclose = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeadername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadercpu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadermemory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderpid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderdescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadercompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.killToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMinidumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createFullDumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeadertype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderhandlename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeaderdllname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderpath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.paneltop.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.paneltop.Controls.Add(this.labelDcRat);
            this.paneltop.Controls.Add(this.buttonmin);
            this.paneltop.Controls.Add(this.buttonmax);
            this.paneltop.Controls.Add(this.buttonclose);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Margin = new System.Windows.Forms.Padding(0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(933, 45);
            this.paneltop.TabIndex = 2;
            this.paneltop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltop_MouseDown);
            // 
            // labelDcRat
            // 
            this.labelDcRat.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDcRat.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDcRat.Location = new System.Drawing.Point(50, 0);
            this.labelDcRat.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.labelDcRat.Name = "labelDcRat";
            this.labelDcRat.Size = new System.Drawing.Size(745, 45);
            this.labelDcRat.TabIndex = 1;
            this.labelDcRat.Text = "DcRat - Process - ";
            this.labelDcRat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelDcRat_MouseDown);
            // 
            // buttonmin
            // 
            this.buttonmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.buttonmin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonmin.FlatAppearance.BorderSize = 0;
            this.buttonmin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonmin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonmin.Image = ((System.Drawing.Image)(resources.GetObject("buttonmin.Image")));
            this.buttonmin.Location = new System.Drawing.Point(801, 3);
            this.buttonmin.Name = "buttonmin";
            this.buttonmin.Size = new System.Drawing.Size(39, 39);
            this.buttonmin.TabIndex = 0;
            this.buttonmin.UseVisualStyleBackColor = false;
            this.buttonmin.Click += new System.EventHandler(this.buttonmin_Click);
            // 
            // buttonmax
            // 
            this.buttonmax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonmax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.buttonmax.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonmax.FlatAppearance.BorderSize = 0;
            this.buttonmax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonmax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmax.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmax.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonmax.Image = ((System.Drawing.Image)(resources.GetObject("buttonmax.Image")));
            this.buttonmax.Location = new System.Drawing.Point(846, 3);
            this.buttonmax.Name = "buttonmax";
            this.buttonmax.Size = new System.Drawing.Size(39, 39);
            this.buttonmax.TabIndex = 0;
            this.buttonmax.UseVisualStyleBackColor = false;
            this.buttonmax.Click += new System.EventHandler(this.buttonmax_Click);
            // 
            // buttonclose
            // 
            this.buttonclose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.buttonclose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonclose.FlatAppearance.BorderSize = 0;
            this.buttonclose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonclose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonclose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclose.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonclose.Image = ((System.Drawing.Image)(resources.GetObject("buttonclose.Image")));
            this.buttonclose.Location = new System.Drawing.Point(891, 3);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(39, 39);
            this.buttonclose.TabIndex = 0;
            this.buttonclose.UseVisualStyleBackColor = false;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeadername,
            this.columnHeadercpu,
            this.columnHeadermemory,
            this.columnHeaderpid,
            this.columnHeaderdescription,
            this.columnHeadercompany});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(933, 258);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeadername
            // 
            this.columnHeadername.Text = "Process Name";
            this.columnHeadername.Width = 183;
            // 
            // columnHeadercpu
            // 
            this.columnHeadercpu.Text = "CPU";
            // 
            // columnHeadermemory
            // 
            this.columnHeadermemory.Text = "Memory";
            this.columnHeadermemory.Width = 93;
            // 
            // columnHeaderpid
            // 
            this.columnHeaderpid.Text = "PID";
            this.columnHeaderpid.Width = 72;
            // 
            // columnHeaderdescription
            // 
            this.columnHeaderdescription.Text = "Description";
            this.columnHeaderdescription.Width = 248;
            // 
            // columnHeadercompany
            // 
            this.columnHeadercompany.Text = "Company Name";
            this.columnHeadercompany.Width = 255;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.killToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.createDumpToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 118);
            // 
            // killToolStripMenuItem
            // 
            this.killToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("killToolStripMenuItem.Image")));
            this.killToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.killToolStripMenuItem.Name = "killToolStripMenuItem";
            this.killToolStripMenuItem.Size = new System.Drawing.Size(160, 38);
            this.killToolStripMenuItem.Text = "Kill";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolStripMenuItem.Image")));
            this.refreshToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(160, 38);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // createDumpToolStripMenuItem
            // 
            this.createDumpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createMinidumpToolStripMenuItem,
            this.createFullDumpToolStripMenuItem});
            this.createDumpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createDumpToolStripMenuItem.Image")));
            this.createDumpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.createDumpToolStripMenuItem.Name = "createDumpToolStripMenuItem";
            this.createDumpToolStripMenuItem.Size = new System.Drawing.Size(160, 38);
            this.createDumpToolStripMenuItem.Text = "Create Dump";
            // 
            // createMinidumpToolStripMenuItem
            // 
            this.createMinidumpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createMinidumpToolStripMenuItem.Image")));
            this.createMinidumpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.createMinidumpToolStripMenuItem.Name = "createMinidumpToolStripMenuItem";
            this.createMinidumpToolStripMenuItem.Size = new System.Drawing.Size(183, 38);
            this.createMinidumpToolStripMenuItem.Text = "Create Minidump";
            // 
            // createFullDumpToolStripMenuItem
            // 
            this.createFullDumpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createFullDumpToolStripMenuItem.Image")));
            this.createFullDumpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.createFullDumpToolStripMenuItem.Name = "createFullDumpToolStripMenuItem";
            this.createFullDumpToolStripMenuItem.Size = new System.Drawing.Size(183, 38);
            this.createFullDumpToolStripMenuItem.Text = "Create Full Dump";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 45);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(933, 517);
            this.splitContainer1.SplitterDistance = 258;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listView3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listView2);
            this.splitContainer2.Size = new System.Drawing.Size(933, 255);
            this.splitContainer2.SplitterDistance = 457;
            this.splitContainer2.TabIndex = 1;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeadertype,
            this.columnHeaderhandlename});
            this.listView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView3.GridLines = true;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(0, 0);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(457, 255);
            this.listView3.TabIndex = 1;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeadertype
            // 
            this.columnHeadertype.Text = "Type";
            this.columnHeadertype.Width = 86;
            // 
            // columnHeaderhandlename
            // 
            this.columnHeaderhandlename.Text = "Name";
            this.columnHeaderhandlename.Width = 329;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderdllname,
            this.columnHeaderpath});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(472, 255);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderdllname
            // 
            this.columnHeaderdllname.Text = "Name";
            this.columnHeaderdllname.Width = 85;
            // 
            // columnHeaderpath
            // 
            this.columnHeaderpath.Text = "Path";
            this.columnHeaderpath.Width = 375;
            // 
            // singleFormProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 562);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.paneltop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "singleFormProcess";
            this.Text = "singleFormProcess";
            this.paneltop.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label labelDcRat;
        private System.Windows.Forms.Button buttonmin;
        private System.Windows.Forms.Button buttonmax;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeadername;
        private System.Windows.Forms.ColumnHeader columnHeadercpu;
        private System.Windows.Forms.ColumnHeader columnHeadermemory;
        private System.Windows.Forms.ColumnHeader columnHeaderpid;
        private System.Windows.Forms.ColumnHeader columnHeaderdescription;
        private System.Windows.Forms.ColumnHeader columnHeadercompany;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem killToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDumpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMinidumpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createFullDumpToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeadertype;
        private System.Windows.Forms.ColumnHeader columnHeaderhandlename;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeaderdllname;
        private System.Windows.Forms.ColumnHeader columnHeaderpath;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}