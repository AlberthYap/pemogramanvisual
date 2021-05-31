using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BENGKEL
{
    public partial class CetakFaktur : Form
    {

        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        //string kodeFaktur = "202105300001";
        public string kodeFaktur = Program.id_faktur;

        public CetakFaktur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cetak();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        Bitmap bitmap;
        private void Cetak()
        {
            //Add a Panel control.
            Panel panel = new Panel();
            this.Controls.Add(panel);

            //Create a Bitmap of size same as that of the Form.
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);

            //Copy screen area that that the Panel covers.
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);

            //Show the Print Preview Dialog.
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void CetakFaktur_Load(object sender, EventArgs e)
        {
            string connString = Properties.Settings.Default.DB;
            conn = new SqlConnection(connString);
            conn.Open();

            lsvFaktur.View = View.Details;
            lsvFaktur.Columns.Add("KODE");
            lsvFaktur.Columns.Add("NAMA ITEM");
            lsvFaktur.Columns.Add("HARGA");
            lsvFaktur.Columns.Add("QTY");
            lsvFaktur.Columns.Add("SUB TOTAL");
            lsvFaktur.Columns[0].Width = 60;
            lsvFaktur.Columns[1].Width = 200;
            lsvFaktur.Columns[2].Width = 200;
            lsvFaktur.Columns[3].Width = 100;
            lsvFaktur.Columns[4].Width = 100;

            lsvFaktur.FullRowSelect = true;

            isi();
            list();
        }

        private void isi()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string sql =
                "select * from penjualan1 inner join pengunjung on PENJUALAN1.pengunjung_id = pengunjung.id_pengunjung where kd_jual = '" +
                kodeFaktur + "'";
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();

                button1.Text = kodeFaktur;
                txt_tanggal.Text = reader["waktu_jual"].ToString();
                txt_idPengunjung.Text = reader["pengunjung_id"].ToString();
                txt_nama.Text = reader["nama_pengunjung"].ToString();
                txtAlamat.Text = reader["alamat"].ToString();
                txt_noHP.Text = reader["nohp"].ToString();
                txt_tipeMotor.Text = reader["tipe_motor"].ToString();
                txt_nomorKendaraan.Text = reader["nomor_kendaraan"].ToString();
                txt_point.Text = reader["point"].ToString();
                txt_total.Text = reader["total_harga"].ToString();
                txt_diskon.Text = reader["diskon"].ToString();
                txt_totalAkhir.Text = reader["total_akhir"].ToString();
                txt_bayar.Text = reader["bayar"].ToString();
                txt_kembali.Text = reader["kembali"].ToString();

                reader.Close();
            }
            else {
                reader.Close();
            }
        }

        private void list()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            ListViewItem item;
            string sqll = "select * from penjualan2 left join barang on PENJUALAN2.id_item = barang.id_barang left join jasa on PENJUALAN2.id_item = jasa.id_jasa where kd_jual = '" + kodeFaktur + "'";
            cmd = new SqlCommand(sqll, conn);

            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    item = new ListViewItem();
                    item.Text = reader["id_item"].ToString();
                    if (string.IsNullOrEmpty(reader["nama_barang"].ToString()))
                    {
                        item.SubItems.Add(reader["nama_jasa"].ToString());
                    }
                    else if (string.IsNullOrEmpty(reader["nama_jasa"].ToString()))
                    {
                        item.SubItems.Add(reader["nama_barang"].ToString());

                    }
                    item.SubItems.Add(reader["harga_jual"].ToString());
                    item.SubItems.Add(reader["qty"].ToString());
                    item.SubItems.Add(reader["sub_total"].ToString());
                    lsvFaktur.Items.Add(item);
                }
            }
            reader.Close();
            conn.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txt_diskon_Click(object sender, EventArgs e)
        {

        }

        private void txt_total_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_nomorKendaraan_Click(object sender, EventArgs e)
        {

        }

        private void txt_Click(object sender, EventArgs e)
        {

        }

        private void txt_point_Click(object sender, EventArgs e)
        {

        }

        private void txt_tipeMotor_Click(object sender, EventArgs e)
        {

        }

        private void txt_noHP_Click(object sender, EventArgs e)
        {

        }

        private void txtAlamat_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txt_nama_Click(object sender, EventArgs e)
        {

        }

        private void txt_idPengunjung_Click(object sender, EventArgs e)
        {

        }

        private void txt_tanggal_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void lsvFaktur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_totalAkhir_Click(object sender, EventArgs e)
        {

        }
    }
}
