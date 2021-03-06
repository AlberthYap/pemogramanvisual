using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Nama : Alberth Yaputra
//NIM : 180010259
namespace QuisUTS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtIsi_TextChanged(object sender, EventArgs e)
        {

        }
        int gaji, anak, golongan = 0, asuransi = 0, zakat = 0, pph = 0,  total;

        public void tunjanganAnak(int gaji)
        {
            if (rb1.Checked == true)
            {
                anak = 1000;
                lbox.Items.Add("Jumlah Tunjangan Anak : " + anak);

            }
            else if (rb2.Checked == true)
            {
                anak = 1500;
                lbox.Items.Add("Jumlah Tunjangan Anak : " + anak);

            }
            else if (rb3.Checked == true)
            {
                anak = 2000;
                lbox.Items.Add("Jumlah Tunjangan Anak : " + anak);

            }
            else
            {
                anak = 3000;
                lbox.Items.Add("Jumlah Tunjangan Anak : " + anak);

            }
        }

        public void tunjunganGolongan()
        {
            switch (cmb.Text)
            {
                case "Gol IA":
                    golongan = 5000;
                    lbox.Items.Add("Jumlah Tunjangan Golongan : " + golongan);

                    break;
                case "Gol IB":
                    golongan = 6000;
                    lbox.Items.Add("Jumlah Tunjangan Golongan : " + golongan);

                    break;
                case "Gol IC":
                    golongan = 7000;
                    lbox.Items.Add("Jumlah Tunjangan Golongan : " + golongan);

                    break;
                case "Gol IIA":
                    golongan = 10000;
                    lbox.Items.Add("Jumlah Tunjangan Golongan : " + golongan);

                    break;
                case "Gol IIB":
                    golongan = 11000;
                    lbox.Items.Add("Jumlah Tunjangan Golongan : " + golongan);

                    break;
                case "Gol IIC":
                    golongan = 12000;
                    lbox.Items.Add("Jumlah Tunjangan Golongan : " + golongan);

                    break;
            }

        }

        public void potongan()
        {

            if (cbAsuransi.Checked == false)
            {
                asuransi = 0;
            }
            else 
            {
                asuransi = (gaji + anak + golongan) * 5 / 100;
                lbox.Items.Add("Jumlah Potongan Asuransi : " + asuransi);

            }
            if (cbZakat.Checked == false)
            {
                zakat = 0;
            }
            else 
            {
                zakat = gaji * 5 / 100;
                lbox.Items.Add("Jumlah Potongan Zakat : " + zakat);

            }
            if (cbPPH.Checked == false)
            {
                pph = 0;
            }
            else
            {
                pph = (gaji + anak + golongan) * 10 / 100;
                lbox.Items.Add("Jumlah Potongan Golongan : " + pph);
            }

        }

        public void totalSemua(int gaji)
        {
            total = (gaji + anak + golongan) - (asuransi + zakat + pph);
            lbox.Items.Add("Total Gaji adalah : " + total);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gaji = int.Parse(txtIsi.Text);

            lbox.Items.Clear();
            lbox.Items.Add("Gaji adalah : "+gaji);
            tunjanganAnak(gaji);
            tunjunganGolongan();
            potongan();
            totalSemua(gaji);

        }

    }
}
