using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _180010259_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnIbuKota_Click(object sender, EventArgs e)
        {
            switch (CmbNegara.Text)
            {
                case "Indonesia":
                    MessageBox.Show("Jakarta");
                    break;
                case "India":
                    MessageBox.Show("New Delhi");
                    break;
                case "Amerika":
                    MessageBox.Show("New York");
                    break;
                case "Prancis":
                    MessageBox.Show("Paris");
                    break;
                case "Spanyol":
                    MessageBox.Show("Madrid");
                    break;
                default:
                    MessageBox.Show("Ända Tidak Memiliki diri daftar");
                    break;
                     
            }
        }
    }
}
