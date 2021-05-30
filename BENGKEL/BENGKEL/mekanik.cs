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


namespace BENGKEL
{

    public partial class mekanik : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        public mekanik()
        {
            InitializeComponent();
        }

        private void mekanik_Load(object sender, EventArgs e)
        {
            string connString = Properties.Settings.Default.DB;
            conn = new SqlConnection(connString);
            conn.Open();
            ListItem();
        }

        public void ListItem()
        {
            lsvMekanik.View = View.Details;
            lsvMekanik.FullRowSelect = true;
            lsvMekanik.Columns.Add("KODE");
            lsvMekanik.Columns.Add("NAMA MEKANIK");
            lsvMekanik.Columns.Add("ALAMAT");
            lsvMekanik.Columns.Add("NO HP");

            lsvMekanik.Columns[0].Width = 50;
            lsvMekanik.Columns[1].Width = 100;
            lsvMekanik.Columns[2].Width = 200;
            lsvMekanik.Columns[3].Width = 100;



            ListViewItem item;
            string sql = "Select * from mekanik";
            cmd = new SqlCommand(sql, conn);

            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    item = new ListViewItem();
                    item.Text = reader["id_mekanik"].ToString();
                    item.SubItems.Add(reader["nama_mekanik"].ToString());
                    item.SubItems.Add(reader["alamat"].ToString());
                    item.SubItems.Add(reader["nohp"].ToString());

                    lsvMekanik.Items.Add(item);
                }
            }
            reader.Close();
            conn.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMekanik.Text) || string.IsNullOrEmpty(txtAlamat.Text) || string.IsNullOrEmpty(txt_nohp.Text))
            {
                string message = "Lengkapi Data Terlebih Dahulu";
                string title = "Data Tidak Lengkap";
                MessageBox.Show(message, title);
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();


                string sql = "SELECT * FROM mekanik WHERE id_mekanik = '" + txt_idMekanik.Text + "'";

                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    sql = "UPDATE mekanik set nama_mekanik = '" + txtMekanik.Text + "' ,  alamat = '" + txtAlamat.Text + "' , nohp = " + txt_nohp.Text + "  WHERE id_mekanik = '" + txt_idMekanik.Text + "' ";
                    reader.Close();
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    clean();
                    lsvMekanik.Clear();
                    ListItem();
                }
                else
                {
                    sql = "INSERT INTO MEKANIK VALUES('" + txtMekanik.Text + "' , '" + txtAlamat.Text + "' , " + txt_nohp.Text + ")";

                    reader.Close();
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    clean();
                    lsvMekanik.Clear();

                    ListItem();

                }

                conn.Close();
                MessageBox.Show("mekanik Sudah Disimpan");
            }
        }

        public void clean()
        {
            txt_idMekanik.Clear();
            txtMekanik.Clear();
            txtAlamat.Clear();
            txt_nohp.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void lsvMekanik_DoubleClick(object sender, EventArgs e)
        {
            clean();

            string id_mekanik, nama_mekanik, alamat, nohp;
            id_mekanik = lsvMekanik.SelectedItems[0].SubItems[0].Text;
            nama_mekanik = lsvMekanik.SelectedItems[0].SubItems[1].Text;
            alamat = lsvMekanik.SelectedItems[0].SubItems[2].Text;
            nohp = lsvMekanik.SelectedItems[0].SubItems[3].Text;


            txt_idMekanik.Text = id_mekanik;
            txtMekanik.Text = nama_mekanik;
            txtAlamat.Text = alamat;
            txt_nohp.Text = nohp;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMekanik.Text) || string.IsNullOrEmpty(txtAlamat.Text) || string.IsNullOrEmpty(txt_nohp.Text))
            {
                string message = "Pililah Data Terlebih Dahulu";
                string title = "Data Belum Dipilih";
                MessageBox.Show(message, title);
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string sql = "DELETE FROM mekanik WHERE id_mekanik = '" + txt_idMekanik.Text + "'";
                cmd = new SqlCommand(sql, conn);
                reader.Close();
                cmd.ExecuteNonQuery();
                clean();
                lsvMekanik.Clear();
                ListItem();
                MessageBox.Show("Mekanik Sudah Dihapus");
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            if (txtCari.Text != "")
            {
                lsvMekanik.Items.Clear();
                ListViewItem item;
                string sql = "Select * from mekanik where id_mekanik like '%" + txtCari.Text + "%' or alamat like '%" + txtCari.Text + "%' or nama_mekanik like '%" + txtCari.Text + "%' or nohp like '%" + txtCari.Text + "%' ";

                cmd = new SqlCommand(sql, conn);

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        item = new ListViewItem();
                        item.Text = reader["id_mekanik"].ToString();
                        item.SubItems.Add(reader["nama_mekanik"].ToString());
                        item.SubItems.Add(reader["alamat"].ToString());
                        item.SubItems.Add(reader["nohp"].ToString());

                        lsvMekanik.Items.Add(item);
                    }
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                lsvMekanik.Clear();
                ListItem();
            }
        }

        private void txt_nohp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Hanya Bisa Angka");
            }
        }
    }
}
