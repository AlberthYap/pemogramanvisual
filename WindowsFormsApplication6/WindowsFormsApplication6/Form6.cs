using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication6
{
    public partial class Form6 : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string connString = Properties.Settings.Default.coba;
            conn = new SqlConnection(connString);
            conn.Open();

            lsvDaftar.View = View.Details;
            lsvDaftar.FullRowSelect = true;
            lsvDaftar.Columns.Add("KODE");
            lsvDaftar.Columns.Add("TANGGAL");
            lsvDaftar.Columns.Add("TOTAL");
            lsvDaftar.Columns.Add("BAYAR");
            lsvDaftar.Columns.Add("KEMBALI");

            lsvDaftar.Columns[0].Width = 50;
            lsvDaftar.Columns[1].Width = 200;
            lsvDaftar.Columns[2].Width = 200;
            lsvDaftar.Columns[3].Width = 200;
            lsvDaftar.Columns[4].Width = 200;

            ListViewItem item;
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string ssql = "Select * from transaksi";
            cmd = new SqlCommand(ssql, conn);

            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    item = new ListViewItem();
                    item.Text = reader["kd_trs"].ToString();
                    item.SubItems.Add(reader["tgl_trs"].ToString());
                    item.SubItems.Add(reader["total"].ToString());
                    item.SubItems.Add(reader["bayar"].ToString());
                    item.SubItems.Add(reader["kembali"].ToString());
                    lsvDaftar.Items.Add(item);
                }
            }
            reader.Close();
            conn.Close();
        }

        private void lsvDaftar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lsvDaftar_DoubleClick(object sender, EventArgs e)
        {
            Program.kdTrs = lsvDaftar.SelectedItems[0].SubItems[0].Text;

            this.Close();
        }
    }
}
