
namespace DcRat.ChildForms
{
    partial class childFormTasks
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeadertaskname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderstatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadertrigger = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderexecutiontimes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListblank = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeadertaskname,
            this.columnHeaderstatus,
            this.columnHeadertrigger,
            this.columnHeaderexecutiontimes});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 450);
            this.listView1.SmallImageList = this.imageListblank;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeadertaskname
            // 
            this.columnHeadertaskname.Text = "TaskName";
            this.columnHeadertaskname.Width = 107;
            // 
            // columnHeaderstatus
            // 
            this.columnHeaderstatus.Text = "Status";
            this.columnHeaderstatus.Width = 86;
            // 
            // columnHeadertrigger
            // 
            this.columnHeadertrigger.Text = "Trigger";
            this.columnHeadertrigger.Width = 343;
            // 
            // columnHeaderexecutiontimes
            // 
            this.columnHeaderexecutiontimes.Text = "Execution Times";
            this.columnHeaderexecutiontimes.Width = 242;
            // 
            // imageListblank
            // 
            this.imageListblank.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListblank.ImageSize = new System.Drawing.Size(32, 32);
            this.imageListblank.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // childFormTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "childFormTasks";
            this.Text = "childFormTasks";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeadertaskname;
        private System.Windows.Forms.ColumnHeader columnHeaderstatus;
        private System.Windows.Forms.ColumnHeader columnHeadertrigger;
        private System.Windows.Forms.ColumnHeader columnHeaderexecutiontimes;
        private System.Windows.Forms.ImageList imageListblank;
    }
}