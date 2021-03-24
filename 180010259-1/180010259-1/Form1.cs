using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _180010259_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnProses_Click(object sender, EventArgs e)
        {
            if (int.Parse(TxtNilaiAngka.Text) >= 80)
                LblNilaiHuruf.Text = "A";
            else if ((int.Parse(TxtNilaiAngka.Text) >= 60) && (int.Parse(TxtNilaiAngka.Text) <= 79))
                LblNilaiHuruf.Text = "B";
            else if ((int.Parse(TxtNilaiAngka.Text) >= 40) && (int.Parse(TxtNilaiAngka.Text) <= 59))
                LblNilaiHuruf.Text = "C";
            else if ((int.Parse(TxtNilaiAngka.Text) >= 20) && (int.Parse(TxtNilaiAngka.Text) <= 39))
                LblNilaiHuruf.Text = "D";
            else if (int.Parse(TxtNilaiAngka.Text) < 20)
                LblNilaiHuruf.Text = "E";


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
