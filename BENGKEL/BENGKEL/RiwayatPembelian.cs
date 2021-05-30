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
    public partial class RiwayatPembelian : Form
    {

        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        public RiwayatPembelian()
        {
            InitializeComponent();
        }

        private void RiwayatPembelian_Load(object sender, EventArgs e)
        {
            string connString = Properties.Settings.Default.DB;
            conn = new SqlConnection(connString);
            conn.Open();

            lsvRiwayat.View = View.Details;
            lsvRiwayat.FullRowSelect = true;
            lsvRiwayat.Columns.Add("KODE BELI");
            lsvRiwayat.Columns.Add("TANGGAL BELI");
            lsvRiwayat.Columns.Add("TOTAL BELI");


            lsvRiwayat.Columns[0].Width = 50;
            lsvRiwayat.Columns[1].Width = 150;
            lsvRiwayat.Columns[2].Width = 150;


            ListViewItem item;
            string sql = "Select * from pembelian1";
            cmd = new SqlCommand(sql, conn);

            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    item = new ListViewItem();
                    item.Text = reader["kd_beli"].ToString();
                    item.SubItems.Add(reader["waktu_beli"].ToString());
                    item.SubItems.Add(reader["total_harga"].ToString());
                    lsvRiwayat.Items.Add(item);
                }
            }
            reader.Close();
            conn.Close();
        }

        private void lsvRiwayat_DoubleClick(object sender, EventArgs e)
        {
            Program.id_beli = lsvRiwayat.SelectedItems[0].SubItems[0].Text;

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
                string sql = "Select * from pembelian1 where kd_beli like '%" + txtCari.Text + "%' or waktu_beli like '%" + txtCari.Text + "%' or total_harga like '%" + txtCari.Text + "%'";
                cmd = new SqlCommand(sql, conn);

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        item = new ListViewItem();
                        item.Text = reader["kd_beli"].ToString();
                        item.SubItems.Add(reader["waktu_beli"].ToString());
                        item.SubItems.Add(reader["total_harga"].ToString());
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
                string sql = "Select * from pembelian1";
                cmd = new SqlCommand(sql, conn);

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        item = new ListViewItem();
                        item.Text = reader["kd_beli"].ToString();
                        item.SubItems.Add(reader["waktu_beli"].ToString());
                        item.SubItems.Add(reader["total_harga"].ToString());
                        lsvRiwayat.Items.Add(item);
                    }
                }
                reader.Close();
                conn.Close();
            }
        }
    }
}
