using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BENGKEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void daftarBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form DaftarBarang = new barang();
            DaftarBarang.Show();
        }

        private void daftarJasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Jasa = new jasa();
            Jasa.Show();
        }

        private void mekanikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Mekanik = new mekanik();
            Mekanik.Show();
        }

        private void pengunjungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Pengunjung = new pengunjung();
            Pengunjung.Show();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void laporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form StockMasuk = new pembelian();
            StockMasuk.Show();
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form Pengunjung = new pengunjung();
            Pengunjung.Show();
        }
        
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Form Pengunjung = new pengunjung();
            Pengunjung.Show();
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form Penjualan = new penjualan();
            Penjualan.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form Penjualan = new penjualan();
            Penjualan.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form pilihCetak = new PilihCetak();
            pilihCetak.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form pilihCetak = new PilihCetak();
            pilihCetak.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void penjualanToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Form Penjualan = new penjualan();
            Penjualan.Show();
        }

        private void barangToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form formReportBarang = new formReportBarang();
            formReportBarang.Show();
        }

        private void cetakToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form pilihCetak = new PilihCetak();
            pilihCetak.Show();
        }

        private void allToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form formReportBarang = new formlistBarang();
            formReportBarang.Show();
        }
    }
}
