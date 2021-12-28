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
            toolStripLabel1.Text = $"Online:  {listView1.Items.Count}" + Environment.NewLine + "Sent:  "+ temp;
            toolStripLabel2.Text = $"Selected:  {listView1.SelectedItems.Count}" + Environment.NewLine + "Received:  "+ temp;
        }
    }
}
