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
    public partial class RiwayatPenjualan : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;

        public RiwayatPenjualan()
        {
            InitializeComponent();
        }

        private void lsvRiwayat_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lsvRiwayat_DoubleClick(object sender, EventArgs e)
        {
            Program.id_jual = lsvRiwayat.SelectedItems[0].SubItems[0].Text;

            this.Close();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            if (txtCari.Text != "")
            {
                lsvRiwayat.Items.Clear();

                ListViewItem item;
                string sql = "Select * from penjualan1 where kd_jual like '%" + txtCari.Text + "%' or waktu_jual like '%" + txtCari.Text + "%' or total_harga like '%" + txtCari.Text + "%' or bayar like '%" + txtCari.Text + "%' or kembali like '%" + txtCari.Text + "%' or diskon like '%" + txtCari.Text + "%' or pengunjung_id like '%" + txtCari.Text + "%'";
                cmd = new SqlCommand(sql, conn);

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        item = new ListViewItem();
                        item.Text = reader["kd_jual"].ToString();
                        item.SubItems.Add(reader["waktu_jual"].ToString());
                        item.SubItems.Add(reader["total_harga"].ToString());
                        item.SubItems.Add(reader["bayar"].ToString());
                        item.SubItems.Add(reader["kembali"].ToString());
                        item.SubItems.Add(reader["diskon"].ToString());
                        item.SubItems.Add(reader["pengunjung_id"].ToString());

                        lsvRiwayat.Items.Add(item);
                    }
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                lsvRiwayat.Items.Clear();
                ListViewItem item;
                string sql = "Select * from penjualan1";
                cmd = new SqlCommand(sql, conn);

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        item = new ListViewItem();
                        item.Text = reader["kd_jual"].ToString();
                        item.SubItems.Add(reader["waktu_jual"].ToString());
                        item.SubItems.Add(reader["total_harga"].ToString());
                        item.SubItems.Add(reader["bayar"].ToString());
                        item.SubItems.Add(reader["kembali"].ToString());
                        item.SubItems.Add(reader["diskon"].ToString());
                        item.SubItems.Add(reader["pengunjung_id"].ToString());

                        lsvRiwayat.Items.Add(item);
                    }
                }
                reader.Close();
                conn.Close();
            }
        }

        private void RiwayatPenjualan_Load(object sender, EventArgs e)
        {
            string connString = Properties.Settings.Default.DB;
            conn = new SqlConnection(connString);
            conn.Open();

            lsvRiwayat.View = View.Details;
            lsvRiwayat.FullRowSelect = true;
            lsvRiwayat.Columns.Add("KODE JUAL");
            lsvRiwayat.Columns.Add("TANGGAL JUAL");
            lsvRiwayat.Columns.Add("TOTAL HARGA");
            lsvRiwayat.Columns.Add("DISKON");
            lsvRiwayat.Columns.Add("BAYAR");
            lsvRiwayat.Columns.Add("KEMBALI");
            lsvRiwayat.Columns.Add("KODE USER");


            lsvRiwayat.Columns[0].Width = 50;
            lsvRiwayat.Columns[1].Width = 100;
            lsvRiwayat.Columns[2].Width = 100;
            lsvRiwayat.Columns[3].Width = 100;
            lsvRiwayat.Columns[4].Width = 100;
            lsvRiwayat.Columns[5].Width = 100;
            lsvRiwayat.Columns[6].Width = 100;



            ListViewItem item;
            string sql = "Select * from penjualan1";
            cmd = new SqlCommand(sql, conn);

            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    item = new ListViewItem();
                    item.Text = reader["kd_jual"].ToString();
                    item.SubItems.Add(reader["waktu_jual"].ToString());
                    item.SubItems.Add(reader["total_harga"].ToString());
                    item.SubItems.Add(reader["bayar"].ToString());
                    item.SubItems.Add(reader["kembali"].ToString());
                    item.SubItems.Add(reader["diskon"].ToString());
                    item.SubItems.Add(reader["pengunjung_id"].ToString());

                    lsvRiwayat.Items.Add(item);
                }
            }
            reader.Close();
            conn.Close();
        }
    }
}
