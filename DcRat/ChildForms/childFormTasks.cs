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
    public partial class childFormTasks : Form
    {
        public childFormTasks()
        {
            InitializeComponent();
        }

        private void listViewtasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewtasks.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listViewtasks.Items)
                {
                    item.ForeColor = Color.Black;
                    item.BackColor = Color.White;
                }
                foreach (ListViewItem item in listViewtasks.SelectedItems)
                {
                    item.ForeColor = Color.White;
                    item.BackColor = ColorTranslator.FromHtml("#758B98");
                }
                listViewtasks.Tag = listViewtasks.FocusedItem;
                listViewtasks.FocusedItem.Selected = false;
            }
        }
        ListViewItem lvHoveredItem;
        private void listViewtasks_MouseMove(object sender, MouseEventArgs e)
        {
            Color oItemColor = Color.Lavender;
            Color oOriginalColor = Color.White; //Your original color

            ListViewItem lvCurrentItem = listViewtasks.GetItemAt(e.X, e.Y);


            if ((lvCurrentItem != null) && (lvCurrentItem != lvHoveredItem))
            {
                if (lvCurrentItem != listViewtasks.Tag)
                {
                    lvCurrentItem.BackColor = oItemColor;

                    if ((lvHoveredItem != null) && (lvHoveredItem != listViewtasks.Tag))
                    {
                        lvHoveredItem.BackColor = oOriginalColor;
                    }

                    lvHoveredItem = lvCurrentItem;
                    return;
                }
                else
                {
                    if ((lvHoveredItem != null) && (lvHoveredItem != listViewtasks.Tag))
                    {
                        lvHoveredItem.BackColor = oOriginalColor;
                    }

                    lvHoveredItem = lvCurrentItem;
                    return;
                }
            }


            if (lvCurrentItem == null)
            {
                if ((lvHoveredItem != null) && (lvHoveredItem != listViewtasks.Tag))
                {
                    lvHoveredItem.BackColor = oOriginalColor;
                    lvHoveredItem = null;
                }

            }
        }

        private void listViewtasks_MouseLeave(object sender, EventArgs e)
        {
            Color oOriginalColor = Color.White; //Your original color

            //When the mouse leave the control. If a ListViewItem was highlighted then set it's original color back
            if ((lvHoveredItem != null) && (lvHoveredItem != listViewtasks.Tag))
            {
                lvHoveredItem.BackColor = oOriginalColor;
            }

            lvHoveredItem = null;
        }

        private void listViewtasks_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                return;
            }
            if (listViewtasks.SelectedIndices.Count == 0)
            {
                foreach (ListViewItem item in listViewtasks.Items)
                {
                    item.ForeColor = Color.Black;
                    item.BackColor = Color.White;
                }
                listViewtasks.Tag = null;
            }
        }
    }
}
