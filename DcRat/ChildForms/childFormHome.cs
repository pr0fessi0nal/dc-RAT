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
            toolStripLabel1.Text = $"Online:  {listView1.Items.Count}" + Environment.NewLine + "Sent:  "+ temp;
            toolStripLabel2.Text = $"Selected:  {listView1.SelectedItems.Count}" + Environment.NewLine + "Received:  "+ temp;
        }

        private void toolStripButtonfile_Click(object sender, EventArgs e)
        {
            using (singleFormFile formFile = new singleFormFile())
            {
                formFile.ShowDialog();
            }
        }

        private void toolStripButtonscreen_Click(object sender, EventArgs e)
        {
            using (singleFormScreen formScreen = new singleFormScreen())
            {
                formScreen.ShowDialog();
            }
        }

        private void toolStripButtoncamera_Click(object sender, EventArgs e)
        {
            using (singleFormCamera formCamera = new singleFormCamera())
            {
                formCamera.ShowDialog();
            }
        }

        private void toolStripButtoncmd_Click(object sender, EventArgs e)
        {
            using (singleFormCmd formCmd = new singleFormCmd())
            {
                formCmd.ShowDialog();
            }
        }

        private void toolStripButtonpowershell_Click(object sender, EventArgs e)
        {
            using (singleFormPowershell formPowershell = new singleFormPowershell())
            {
                formPowershell.ShowDialog();
            }
        }

        private void toolStripButtonprocess_Click(object sender, EventArgs e)
        {
            using (singleFormProcess formProcess = new singleFormProcess())
            {
                formProcess.ShowDialog();
            }
        }
    }
}
