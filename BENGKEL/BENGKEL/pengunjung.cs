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
    public partial class pengunjung : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        string KodeAuto = "";
        public pengunjung()
        {
            InitializeComponent();
        }

        private void lsvJasa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pengunjung_Load(object sender, EventArgs e)
        {
            string connString = Properties.Settings.Default.DB;
            conn = new SqlConnection(connString);
            conn.Open();
            ListItem();
        }

        public void ListItem()
        {
            lsvPengunjung.View = View.Details;
            lsvPengunjung.FullRowSelect = true;
            lsvPengunjung.Columns.Add("KODE");
            lsvPengunjung.Columns.Add("NAMA PENGUNJUNG");
            lsvPengunjung.Columns.Add("ALAMAT");
            lsvPengunjung.Columns.Add("NO HP");
            lsvPengunjung.Columns.Add("NOMOR_KENDARAAN");
            lsvPengunjung.Columns.Add("TIPE KENDARAAN");
            lsvPengunjung.Columns.Add("POINT");


            lsvPengunjung.Columns[0].Width = 50;
            lsvPengunjung.Columns[1].Width = 130;
            lsvPengunjung.Columns[2].Width = 130;
            lsvPengunjung.Columns[3].Width = 100;
            lsvPengunjung.Columns[4].Width = 130;
            lsvPengunjung.Columns[5].Width = 130;
            lsvPengunjung.Columns[6].Width = 50;



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

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            if (txtCari.Text != "")
            {
                lsvPengunjung.Items.Clear();

                ListViewItem item;
                string sql = "Select * from pengunjung where id_pengunjung like '%" + txtCari.Text + "%' or nama_pengunjung like '%" + txtCari.Text + "%' or alamat like '%" + txtCari.Text + "%' or nohp like '%" + txtCari.Text + "%' or nomor_kendaraan like '%" + txtCari.Text + "%' or tipe_motor like '%" + txtCari.Text + "%' or point like '%" + txtCari.Text + "%' ";

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
                lsvPengunjung.Clear();
                ListItem();
            }
        }

        public void clean()
        {
            txt_idPengunjung.Clear();
            txtPengunjung.Clear();
            txtAlamat.Clear();
            txtNoHp.Clear();
            txtNomor.Clear();
            txtMotor.Clear();
        }

        private void AutoNumber()
        {
            string maxString = "";
            int maxInteger = 0;

            string ssql = " SELECT MAX(id_pengunjung) AS MAXIMUM, COUNT(id_pengunjung) AS JUMLAH " +
                          " FROM pengunjung ";

            reader.Close();

            cmd = new SqlCommand(ssql, conn);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if (reader["JUMLAH"].ToString() == "0")
                    maxString = "P00000";
                else
                    maxString = reader["MAXIMUM"].ToString();

            }

            maxInteger = int.Parse(maxString.Substring(1, 5));
            maxInteger = maxInteger + 1;
            maxString = maxInteger.ToString();

            if (maxString.Length == 1)
                KodeAuto = "P0000" + maxString;
            else if (maxString.Length == 2)
                KodeAuto = "P000" + maxString;
            else if (maxString.Length == 3)
                KodeAuto = "P00" + maxString;
            else if (maxString.Length == 4)
                KodeAuto = "P0" + maxString;
            else if (maxString.Length == 5)
                KodeAuto = "P" + maxString;

            reader.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPengunjung.Text) || string.IsNullOrEmpty(txtAlamat.Text) || string.IsNullOrEmpty(txtNoHp.Text) || string.IsNullOrEmpty(txtNomor.Text) || string.IsNullOrEmpty(txtMotor.Text) )
            {
                string message = "Lengkapi Data Terlebih Dahulu";
                string title = "Data Tidak Lengkap";
                MessageBox.Show(message, title);
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string sql = "SELECT * FROM PENGUNJUNG WHERE id_pengunjung = '" + txt_idPengunjung.Text + "'";

                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    sql = "UPDATE pengunjung set nama_pengunjung = '" + txtPengunjung.Text + "' ,  alamat = '" + txtAlamat.Text + "' ,  nohp = '" + txtNoHp.Text + "' ,  nomor_kendaraan = '" + txtNomor.Text + "' ,  tipe_motor = '" + txtMotor.Text + "' WHERE id_pengunjung = '"  + txt_idPengunjung.Text + "' ";
                    reader.Close();
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    clean();
                    lsvPengunjung.Clear();
                    ListItem();
                }
                else
                {
                    AutoNumber();
                    txt_idPengunjung.Text = KodeAuto;
                    sql = "INSERT INTO PENGUNJUNG VALUES('" + txt_idPengunjung.Text + "' , '" + txtPengunjung.Text + "' , '" + txtAlamat.Text + "' , '" + txtNoHp.Text + "' , '" + txtNomor.Text + "' , '" + txtMotor.Text + "' , 0)";

                    reader.Close();
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    ListViewItem item;
                    item = new ListViewItem();
                    item.Text = txt_idPengunjung.Text;
                    item.SubItems.Add(txtPengunjung.Text);
                    item.SubItems.Add(txtAlamat.Text);
                    item.SubItems.Add(txtNoHp.Text);
                    item.SubItems.Add(txtNomor.Text);
                    item.SubItems.Add(txtMotor.Text);
                    item.SubItems.Add("0");
                    lsvPengunjung.Items.Add(item);

                    clean();
                }

                conn.Close();
                MessageBox.Show("Pengunjung Sudah Disimpan");
            }
        }

        private void txtNoHp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) )
            {
                MessageBox.Show("Hanya Bisa Angka");
            }
        }

        private void lsvPengunjung_DoubleClick(object sender, EventArgs e)
        {
            clean();

            string id_pengunjung, nama_pengunjung, alamat, nohp, nomor_kendaraan, tipe_kendaraan_;
            id_pengunjung = lsvPengunjung.SelectedItems[0].SubItems[0].Text;
            nama_pengunjung = lsvPengunjung.SelectedItems[0].SubItems[1].Text;
            alamat = lsvPengunjung.SelectedItems[0].SubItems[2].Text;
            nohp = lsvPengunjung.SelectedItems[0].SubItems[3].Text;
            nomor_kendaraan = lsvPengunjung.SelectedItems[0].SubItems[4].Text;
            tipe_kendaraan_ = lsvPengunjung.SelectedItems[0].SubItems[5].Text;


            txt_idPengunjung.Text = id_pengunjung;
            txtPengunjung.Text = nama_pengunjung;
            txtAlamat.Text = alamat;
            txtNoHp.Text = nohp;
            txtNomor.Text = nomor_kendaraan;
            txtMotor.Text = tipe_kendaraan_;

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_idPengunjung.Text)) {
                string message = "Pililah Data Terlebih Dahulu";
            string title = "Data Belum Dipilih";
            MessageBox.Show(message, title);
        }
        else
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string sql = "DELETE FROM pengunjung WHERE id_pengunjung = '" + txt_idPengunjung.Text + "'";
            cmd = new SqlCommand(sql, conn);
            reader.Close();
            cmd.ExecuteNonQuery();
            clean();
            lsvPengunjung.Clear();
            ListItem();
            MessageBox.Show("Jasa Sudah Dihapus");
        }
        }
    }
}
