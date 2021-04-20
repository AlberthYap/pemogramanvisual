using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialog1
{
    public partial class frmColorDialog : Form
    {
        public frmColorDialog()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            colorDialog1.Color = lblTeks.ForeColor;
            colorDialog1.CustomColors = new int[]
            {
                6916092, 15195440, 16107657, 1836924, 3758726, 12566463, 7526079, 7405793, 6945974, 241502, 2296476, 5130294, 3102017, 7314121, 14993507, 11730944
            };

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                lblTeks.ForeColor = colorDialog1.Color;
            }
        }
    }
}
