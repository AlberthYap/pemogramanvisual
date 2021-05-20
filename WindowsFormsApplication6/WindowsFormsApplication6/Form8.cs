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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataKategoriBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frmA = new Form1();
            frmA.ShowDialog();
        }

        private void dataSatuanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frmB = new Form2();
            frmB.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 frmA = new Form1();
            frmA.ShowDialog();
        }

        private void aAAAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frmTrsJual = new Form3();
            frmTrsJual.ShowDialog();
        }
    }
}
