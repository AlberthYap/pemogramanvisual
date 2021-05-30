using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_180010259_BENGKEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void stockMasukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form DaftarItem = new DaftarItem();
            DaftarItem.Show();
        }
    }
}
