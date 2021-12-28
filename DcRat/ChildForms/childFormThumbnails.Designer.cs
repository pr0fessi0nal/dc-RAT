
namespace DcRat.ChildForms
{
    partial class childFormThumbnails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(childFormThumbnails));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelBlank = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonOff = new System.Windows.Forms.ToolStripButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOn,
            this.toolStripLabelBlank,
            this.toolStripButtonOff});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 43);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonOn
            // 
            this.toolStripButtonOn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOn.Image")));
            this.toolStripButtonOn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonOn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOn.Name = "toolStripButtonOn";
            this.toolStripButtonOn.Size = new System.Drawing.Size(59, 40);
            this.toolStripButtonOn.Text = "On";
            // 
            // toolStripLabelBlank
            // 
            this.toolStripLabelBlank.Name = "toolStripLabelBlank";
            this.toolStripLabelBlank.Size = new System.Drawing.Size(37, 40);
            this.toolStripLabelBlank.Text = "          ";
            // 
            // toolStripButtonOff
            // 
            this.toolStripButtonOff.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOff.Image")));
            this.toolStripButtonOff.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonOff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOff.Name = "toolStripButtonOff";
            this.toolStripButtonOff.Size = new System.Drawing.Size(60, 40);
            this.toolStripButtonOff.Text = "Off";
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 43);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 407);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // childFormThumbnails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "childFormThumbnails";
            this.Text = "childFormThumbnails";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonOn;
        private System.Windows.Forms.ToolStripLabel toolStripLabelBlank;
        private System.Windows.Forms.ToolStripButton toolStripButtonOff;
        private System.Windows.Forms.ListView listView1;
    }
}