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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void trsPenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frmjual = new Form3();
            frmjual.ShowDialog();
        }

        private void dataBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
