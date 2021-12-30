using DcRat.SingleForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DcRat.ChildForms
{
    public partial class childFormHome : Form
    {
        public childFormHome()
        {
            InitializeComponent();
        }

        private void updateUI_Tick(object sender, EventArgs e)
        {
            string temp = "0 kb";
            toolStripLabel1.Text = $"Online:  {listViewHome.Items.Count}" + Environment.NewLine + "Sent:  " + temp;
            toolStripLabel2.Text = $"Selected:  {listViewHome.SelectedItems.Count}" + Environment.NewLine + "Received:  " + temp;
        }

        private void toolStripButtonfile_Click(object sender, EventArgs e)
        {
            singleFormFile formFile = new singleFormFile();
            formFile.Show();
        }

        private void toolStripButtonscreen_Click(object sender, EventArgs e)
        {
            singleFormScreen formScreen = new singleFormScreen();
            formScreen.Show();
        }

        private void toolStripButtoncamera_Click(object sender, EventArgs e)
        {
            singleFormCamera formCamera = new singleFormCamera();
            formCamera.Show();
        }

        private void toolStripButtoncmd_Click(object sender, EventArgs e)
        {
            singleFormCmd formCmd = new singleFormCmd();
            formCmd.Show();
        }

        private void toolStripButtonpowershell_Click(object sender, EventArgs e)
        {
            singleFormPowershell formPowershell = new singleFormPowershell();
            formPowershell.Show();
        }

        private void toolStripButtonprocess_Click(object sender, EventArgs e)
        {
            singleFormProcess formProcess = new singleFormProcess();
            formProcess.Show();
        }
        ListViewItem lvHoveredItem;
        private void listViewHome_MouseMove(object sender, MouseEventArgs e)
        {
            Color oItemColor = Color.Lavender;
            Color oOriginalColor = Color.White; //Your original color

            ListViewItem lvCurrentItem = listViewHome.GetItemAt(e.X, e.Y);


            if ((lvCurrentItem != null) && (lvCurrentItem != lvHoveredItem))
            {
                if (lvCurrentItem != listViewHome.Tag)
                {
                    lvCurrentItem.BackColor = oItemColor;

                    if ((lvHoveredItem != null) && (lvHoveredItem != listViewHome.Tag))
                    {
                        lvHoveredItem.BackColor = oOriginalColor;
                    }

                    lvHoveredItem = lvCurrentItem;
                    return;
                }
                else
                {
                    if ((lvHoveredItem != null) && (lvHoveredItem != listViewHome.Tag))
                    {
                        lvHoveredItem.BackColor = oOriginalColor;
                    }

                    lvHoveredItem = lvCurrentItem;
                    return;
                }
            }


            if (lvCurrentItem == null)
            {
                if ((lvHoveredItem != null) && (lvHoveredItem != listViewHome.Tag))
                {
                    lvHoveredItem.BackColor = oOriginalColor;
                    lvHoveredItem = null;
                }

            }
        }

        private void toolStripButtondetails_Click(object sender, EventArgs e)
        {
            toolStripButtonicon.Enabled = true;
            toolStripButtondetails.Enabled = false;
            listViewHome.View = View.Details;
        }

        private void toolStripButtonicon_Click(object sender, EventArgs e)
        {
            toolStripButtonicon.Enabled = false;
            toolStripButtondetails.Enabled = true;
            listViewHome.View = View.LargeIcon;
            if (listViewHome.Items.Count == 0) return;
            foreach (ListViewItem itm in listViewHome.Items)
            {
                itm.ImageIndex = 0;
            }
        }

        private void listViewHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewHome.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listViewHome.Items)
                {
                    item.ForeColor = Color.Black;
                    item.BackColor = Color.White;
                }
                foreach (ListViewItem item in listViewHome.SelectedItems)
                {
                    item.ForeColor = Color.White;
                    item.BackColor = ColorTranslator.FromHtml("#758B98");
                }
                listViewHome.Tag = listViewHome.FocusedItem;
                listViewHome.FocusedItem.Selected = false;
            }
        }

        private void listViewHome_MouseLeave(object sender, EventArgs e)
        {
            Color oOriginalColor = Color.White; //Your original color

            //When the mouse leave the control. If a ListViewItem was highlighted then set it's original color back
            if ((lvHoveredItem != null) &&(lvHoveredItem!= listViewHome.Tag))
            {
                lvHoveredItem.BackColor = oOriginalColor;
            }

            lvHoveredItem = null;
        }

        private void listViewHome_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button== MouseButtons.Right)
            {
                return;
            }
            if (listViewHome.SelectedIndices.Count == 0)
            {
                foreach (ListViewItem item in listViewHome.Items)
                {
                    item.ForeColor = Color.Black;
                    item.BackColor = Color.White;
                }
                listViewHome.Tag = null;
            }
        }

        private void loadShellcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
