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
    public partial class listPengunjung : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;

        public listPengunjung()
        {
            InitializeComponent();
        }

        private void listPengunjung_Load(object sender, EventArgs e)
        {
            string connString = Properties.Settings.Default.DB;
            conn = new SqlConnection(connString);
            conn.Open();

            lsvPengunjung.View = View.Details;
            lsvPengunjung.FullRowSelect = true;
            lsvPengunjung.Columns.Add("ID ");
            lsvPengunjung.Columns.Add("NAMA");
            lsvPengunjung.Columns.Add("ALAMAT");
            lsvPengunjung.Columns.Add("NOHP");
            lsvPengunjung.Columns.Add("NOMOR KENDARAAN");
            lsvPengunjung.Columns.Add("TIPE MOTOR");
            lsvPengunjung.Columns.Add("POINT");


            lsvPengunjung.Columns[0].Width = 50;
            lsvPengunjung.Columns[1].Width = 100;
            lsvPengunjung.Columns[2].Width = 100;
            lsvPengunjung.Columns[3].Width = 100;
            lsvPengunjung.Columns[4].Width = 100;
            lsvPengunjung.Columns[5].Width = 100;
            lsvPengunjung.Columns[6].Width = 100;



            ListViewItem item;
            string sql = "Select * from pengunjung";
            cmd = new SqlCommand(sql, conn);

            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    item = new ListViewItem();
                    item.Text = reader["id_pengunjung"].ToString();
                    item.SubItems.Add(reader["nama_pengunjung"].ToString());
                    item.SubItems.Add(reader["alamat"].ToString());
                    item.SubItems.Add(reader["nohp"].ToString());
                    item.SubItems.Add(reader["nomor_kendaraan"].ToString());
                    item.SubItems.Add(reader["tipe_motor"].ToString());
                    item.SubItems.Add(reader["point"].ToString());

                    lsvPengunjung.Items.Add(item);
                }
            }
            reader.Close();
            conn.Close();
        }

        private void lsvPengunjung_DoubleClick(object sender, EventArgs e)
        {
            Program.id_pengunjung = lsvPengunjung.SelectedItems[0].SubItems[0].Text;
            Program.point = lsvPengunjung.SelectedItems[0].SubItems[6].Text;

            this.Close();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            if (txtCari.Text != "")
            {
                lsvPengunjung.Items.Clear();

                ListViewItem item;
                string sql = "Select * from pengunjung where id_pengunjung like '%" + txtCari.Text + "%' or nama_pengunjung like '%" + txtCari.Text + "%' or alamat like '%" + txtCari.Text + "%' or nohp like '%" + txtCari.Text + "%' or nomor_kendaraan like '%" + txtCari.Text + "%' or tipe_motor like '%" + txtCari.Text + "%' or point like '%" + txtCari.Text + "%'";
                cmd = new SqlCommand(sql, conn);

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        item = new ListViewItem();
                        item.Text = reader["id_pengunjung"].ToString();
                        item.SubItems.Add(reader["nama_pengunjung"].ToString());
                        item.SubItems.Add(reader["alamat"].ToString());
                        item.SubItems.Add(reader["nohp"].ToString());
                        item.SubItems.Add(reader["nomor_kendaraan"].ToString());
                        item.SubItems.Add(reader["tipe_motor"].ToString());
                        item.SubItems.Add(reader["point"].ToString());

                        lsvPengunjung.Items.Add(item);
                    }
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                lsvPengunjung.Items.Clear();
                ListViewItem item;
                string sql = "Select * from pengunjung";
                cmd = new SqlCommand(sql, conn);

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        item = new ListViewItem();
                        item.Text = reader["id_pengunjung"].ToString();
                        item.SubItems.Add(reader["nama_pengunjung"].ToString());
                        item.SubItems.Add(reader["alamat"].ToString());
                        item.SubItems.Add(reader["nohp"].ToString());
                        item.SubItems.Add(reader["nomor_kendaraan"].ToString());
                        item.SubItems.Add(reader["tipe_motor"].ToString());
                        item.SubItems.Add(reader["point"].ToString());

                        lsvPengunjung.Items.Add(item);
                    }
                }
                reader.Close();
                conn.Close();
            }
        }

        private void lsvPengunjung_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
