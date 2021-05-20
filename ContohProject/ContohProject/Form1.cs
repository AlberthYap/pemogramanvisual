using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContohProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fPegawai = new FormPegawai();
            fPegawai.Show();
        }
    }
}
