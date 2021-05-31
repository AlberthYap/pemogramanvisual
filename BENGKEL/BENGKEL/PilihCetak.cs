using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BENGKEL
{
    public partial class PilihCetak : Form
    {
        public PilihCetak()
        {
            InitializeComponent();
        }

        private void txtRiwayat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                RiwayatPenjualan frmsearch_trs = new RiwayatPenjualan();
                frmsearch_trs.ShowDialog();
                txtRiwayat.Text = Program.id_jual;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtRiwayat.Text.Length != 0) && (txtRiwayat.Text != "PRESS"))
            {
                Program.id_faktur = txtRiwayat.Text;
                Form cetakFaktur = new CetakFaktur();
                cetakFaktur.Show();
                
            }
            else
            {
                string message = "Lengkapi Data Terlebih Dahulu";
                string title = "Data Tidak Lengkap";
                MessageBox.Show(message, title);
            }
               
        }
    }
}
