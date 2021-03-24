using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _180010259_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LstData.Items.Clear();
            for (int n =1; n <= 5; n++)
            {
                LstData.Items.Add("Item ke - " + n);

            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            LstData.Items.Clear();
            int hitung = 0;
            while (hitung < 10)
            {
                hitung++;
                LstData.Items.Add(hitung);
            }    
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            LstData.Items.Clear();
            Random bilRandom = new Random();
            int angka = 0;
            do
            {
                angka = bilRandom.Next(15);
                LstData.Items.Add(angka);
            }
            while (angka != 10);

        }
    }
}
