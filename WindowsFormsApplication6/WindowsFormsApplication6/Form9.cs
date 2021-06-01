using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void dataPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frmtrs = new Form3();
            frmtrs.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form3 frmtrs = new Form3();
            frmtrs.ShowDialog();
        }

        private void trsPendaftaranToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
