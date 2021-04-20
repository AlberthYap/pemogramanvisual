using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS_180010259
{
 
    // Nama : Alberth Yaputra
    // NIM : 180010259
    public partial class Biasa : Form
    {
        public Biasa()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            if (int.Parse(nu.Text) < 5)
            {
                listBox1.Items.Clear();
                MessageBox.Show("Jumlah Berat Kurang Dari 5 KG");
            }
            else
            {
                listBox1.Items.Clear();
                biayaTujuan();
                jasaLayanan();
                fasilitas();
                totalHarga();
                
            }
               
        }

        int total, biayaKota = 0, berat, hargaCepat, asuransi, delivery, sms ;

        private void Biasa_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void biayaTujuan()
        {
            int beratSisa, hargaKota; 
            switch (cmbKota.Text)
            {
                
                case "Denpasar":
                   
                    hargaKota = 25000;
                    berat = int.Parse(nu.Text);
                    beratSisa = berat - 5;
                    biayaKota = (beratSisa * 5000) + hargaKota;
                    listBox1.Items.Add("Jumlah Ongkir Biasa : " + biayaKota);

                    break;
                case "Surabaya":
                   
                    hargaKota = 30000;
                    berat = int.Parse(nu.Text);
                    beratSisa = berat - 5;
                    biayaKota = (beratSisa * 6000) + hargaKota;
                    listBox1.Items.Add("Jumlah Ongkir Biasa : " + biayaKota);
                    
                    break;
                case "Jakarta":
                    
                    hargaKota = 50000;
                    berat = int.Parse(nu.Text);
                    beratSisa = berat - 5;
                    biayaKota = (beratSisa * 10000) + hargaKota;
                    listBox1.Items.Add("Jumlah Ongkir Biasa : " + biayaKota);
                    
                    break;
                case "Semarang":
                    
                    hargaKota = 35000;
                    berat = int.Parse(nu.Text);
                    beratSisa = berat - 5;
                    biayaKota = (beratSisa * 7000) + hargaKota;
                    listBox1.Items.Add("Jumlah Ongkir Biasa : " + biayaKota);
                    
                    break;
                case "Bandung":
                    
                    hargaKota = 40000;
                    berat = int.Parse(nu.Text);
                    beratSisa = berat - 5;
                    biayaKota = (beratSisa * 9000) + hargaKota;
                    listBox1.Items.Add("Jumlah Ongkir Biasa : " + biayaKota);
                    
                    break;
            }
        }

        public void jasaLayanan()
        {
            if (rbBiasa.Checked == true)
            {
                hargaCepat = 0;
                listBox1.Items.Add("Biaya Jenis Kecepatan : " + hargaCepat);

            }
            else if (rbKilat.Checked == true)
            {
                hargaCepat = biayaKota * 20 / 100;
                listBox1.Items.Add("Biaya Jenis Kecepatan: " + hargaCepat);

            }
            else
            {
                listBox1.Items.Add("Tidak Memilih Jenis Kecepatan");
            }
        }

        public void fasilitas()
        {
            if (cbAsuransi.Checked == true)
            {
                asuransi = 5000;
                listBox1.Items.Add("Biaya Fasilitas Asuransi: " + asuransi);
            }
            else
            {
                asuransi = 0;
                listBox1.Items.Add("Biaya Fasilitas Asuransi: " + asuransi);
            }

            if (cbDelivery.Checked == true)
            {
                delivery = 3000;
                listBox1.Items.Add("Biaya Fasilitas Delivery: " + delivery);
            }
            else
            {
                delivery = 0;
                listBox1.Items.Add("Biaya Fasilitas Delivery: " + delivery);

            }

            if (cbSms.Checked == true)
            {
                sms = 4000;
                listBox1.Items.Add("Biaya Fasilitas SMS Tracking: " + sms);
            }
            else
            {
                sms = 0;
                listBox1.Items.Add("Biaya Fasilitas SMS Tracking: " + sms);
            }
        }
        
        public void totalHarga()
        {
            total = biayaKota + hargaCepat + asuransi + delivery + sms;
            listBox1.Items.Add("Total Harga : " + total);
            label1.Text = total.ToString();
        }

    }
}
