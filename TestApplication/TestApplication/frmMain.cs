using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using WiseOn.VideoConversion;

namespace TestApplication
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Guid fileId = FlvConversion.ConvertVideoToFlv(txtSource.Text, txtDestination.Text, Convert.ToInt16(txtOutputWidth.Text), Convert.ToInt16(txtOutputHeight.Text));
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            fbdFindFile.ShowDialog();
            txtSource.Text = fbdFindFile.SelectedPath;
        }

        private void btnDestination_Click(object sender, EventArgs e)
        {
            fbdFindFile.ShowDialog();
            txtDestination.Text = fbdFindFile.SelectedPath;
        }
    }
}
