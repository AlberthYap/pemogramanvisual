using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _180010259_2._1
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        byte i; int Total; int Std; byte N;
        int[] A;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            if (txtX.Text.Trim() == "")
            {
                MessageBox.Show("X harus diisi");
            }
            else
            {
                MessageBox.Show("Array harus diurutkan terlebih dahulu supaya " + "hasil pencarian biner berhasil.");

                int Pos = Array.BinarySearch(A, int.Parse(txtX.Text));

                if(Pos < 0)
                {
                    MessageBox.Show(txtX.Text + " tidak ditemukan. ");
                }
                else
                {
                    MessageBox.Show(txtX.Text + " ditemukan pada indeks ke- " + Pos);
                }

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAcak_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtN.Text) > 0)
            {
                N = byte.Parse(txtN.Text);
                Array.Resize(ref A, N);
                Random bilrandom = new Random();

                lstAcak.Items.Clear();
                Total = 0;
                for (i=0; i <= N - 1; i++)
                {
                    A.SetValue(bilrandom.Next(100), i);

                    lstAcak.Items.Add(A.GetValue(i));
                    Total = Total + (int)A.GetValue(i);
                }

                lblRata.Text = (Total / N).ToString();
                Std = 0;
                for (i = 0; i <= N-1;i++)
                {
                    Std = Std + ((int)A.GetValue(i) - int.Parse(lblRata.Text)) ^ 2;
                }
                Std = Std / (N - 1);
                lblStd.Text = Std.ToString();
                lblLength.Text = A.Length.ToString();
                lblRank.Text = A.Rank.ToString();
                lblLowerBound.Text = A.GetLowerBound(0).ToString();
                lblUpperBound.Text = A.GetUpperBound(0).ToString();
            }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            Array.Reverse(A);
            lstAcak.Items.Clear();
            for (i=0; i <= N -1; i++)
            {
                lstAcak.Items.Add(A[i]);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Array.Sort(A);
            lstAcak.Items.Clear();
            for (i=0; i <= N-1; i++)
            {
                lstAcak.Items.Add(A[i]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            lstAcak.Items.Clear();
            lblRata.Text = "";
            lblStd.Text = "";
            lblLength.Text = "";
            lblRank.Text = "";
            lblLowerBound.Text = "";
            lblUpperBound.Text = "";
            txtX.Clear();
            txtN.Focus();
        }
    }
}
