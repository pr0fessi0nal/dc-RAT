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
            toolStripLabel1.Text = $"Online:  {listView1.Items.Count}" + Environment.NewLine + "Sent:  " + temp;
            toolStripLabel2.Text = $"Selected:  {listView1.SelectedItems.Count}" + Environment.NewLine + "Received:  " + temp;
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
    }
}
