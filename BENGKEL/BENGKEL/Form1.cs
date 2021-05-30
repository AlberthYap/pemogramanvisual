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

        private void tambahStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form StockMasuk = new pembelian();
            StockMasuk.Show();
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

        private void penjualanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Penjualan = new penjualan();
            Penjualan.Show();
        }
    }
}
