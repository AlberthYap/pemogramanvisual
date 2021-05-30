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
    public partial class jasa : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        string KodeAuto = "";
        

        public jasa()
        {
            InitializeComponent();
        }

        private void AutoNumber()
        {
            string maxString = "";
            int maxInteger = 0;

            string ssql = " SELECT MAX(id_jasa) AS MAXIMUM, COUNT(id_jasa) AS JUMLAH " +
                          " FROM jasa ";

            reader.Close();

            cmd = new SqlCommand(ssql, conn);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if (reader["JUMLAH"].ToString() == "0")
                    maxString = "J0000";
                else
                    maxString = reader["MAXIMUM"].ToString();

            }

            maxInteger = int.Parse(maxString.Substring(1, 4));
            maxInteger = maxInteger + 1;
            maxString = maxInteger.ToString();

            if (maxString.Length == 1)
                KodeAuto = "J000" + maxString;
            else if (maxString.Length == 2)
                KodeAuto = "J00" + maxString;
            else if (maxString.Length == 3)
                KodeAuto = "J0" + maxString;
            else if (maxString.Length == 4)
                KodeAuto = "J" + maxString;

            reader.Close();
        }

        public void clean()
        {
            txt_idJasa.Clear();
            txtJasa.Clear();
            txtJual.Text = "0";
        }


        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtJasa.Text) || string.IsNullOrEmpty(txtJual.Text))
            {
                string message = "Lengkapi Data Terlebih Dahulu";
                string title = "Data Tidak Lengkap";
                MessageBox.Show(message, title);
            }
            else 
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();


                string sql = "SELECT * FROM JASA WHERE id_jasa = '" + txt_idJasa.Text + "'";

                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    sql = "UPDATE jasa set nama_jasa = '" + txtJasa.Text + "' ,  harga_jasa = " + txtJual.Text + " WHERE id_jasa = '" + txt_idJasa.Text + "' ";
                    reader.Close();
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    clean();
                    lsvJasa.Clear();
                    ListItem();
                }
                else
                {
                    AutoNumber();
                    txt_idJasa.Text = KodeAuto;
                    sql = "INSERT INTO JASA VALUES('" + txt_idJasa.Text + "' , '" + txtJasa.Text + "' , " + txtJual.Text + ")";

                    reader.Close();
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    ListViewItem item;
                    item = new ListViewItem();
                    item.Text = txt_idJasa.Text;
                    item.SubItems.Add(txtJasa.Text);
                    item.SubItems.Add(txtJual.Text);
                    item.SubItems.Add("0");
                    lsvJasa.Items.Add(item);

                    clean();
                }

                conn.Close();
                MessageBox.Show("Jasa Sudah Disimpan");
            }
        }
        

        private void jasa_Load(object sender, EventArgs e)
        {
             string connString = Properties.Settings.Default.DB;
            conn = new SqlConnection(connString);
            conn.Open();
            ListItem();
        }

        public void ListItem()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            lsvJasa.View = View.Details;
            lsvJasa.FullRowSelect = true;
            lsvJasa.Columns.Add("KODE");
            lsvJasa.Columns.Add("NAMA JASA");
            lsvJasa.Columns.Add("HARGA JASA");

            lsvJasa.Columns[0].Width = 50;
            lsvJasa.Columns[1].Width = 200;
            lsvJasa.Columns[2].Width = 100;


            ListViewItem item;
            string sql = "Select * from jasa";
            cmd = new SqlCommand(sql, conn);

            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    item = new ListViewItem();
                    item.Text = reader["id_jasa"].ToString();
                    item.SubItems.Add(reader["nama_jasa"].ToString());
                    item.SubItems.Add(reader["harga_jasa"].ToString());

                    lsvJasa.Items.Add(item);
                }
            }
            reader.Close();
            conn.Close();
        }

       

        private void lsvJasa_DoubleClick(object sender, EventArgs e)
        {
            clean();

            string id_jasa, nama_jasa, harga_jual;
            id_jasa = lsvJasa.SelectedItems[0].SubItems[0].Text;
            nama_jasa = lsvJasa.SelectedItems[0].SubItems[1].Text;
            harga_jual = lsvJasa.SelectedItems[0].SubItems[2].Text;

            txt_idJasa.Text = id_jasa;
            txtJasa.Text = nama_jasa;
            txtJual.Text = harga_jual;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_idJasa.Text))
            {
                string message = "Pililah Data Terlebih Dahulu";
                string title = "Data Belum Dipilih";
                MessageBox.Show(message, title);
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string sql = "DELETE FROM Jasa WHERE id_Jasa = '" + txt_idJasa.Text + "'";
                cmd = new SqlCommand(sql, conn);
                reader.Close();
                cmd.ExecuteNonQuery();
                clean();
                lsvJasa.Clear();
                ListItem();
                MessageBox.Show("Jasa Sudah Dihapus");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clean();
        }


        public void CariJasa()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            if (txtCari.Text != "")
            {
                lsvJasa.Items.Clear();
                
                ListViewItem item;
                string sql = "Select * from jasa where id_jasa like '%" +txtCari.Text + "%' or harga_jasa like '%" + txtCari.Text + "%' or nama_jasa like '%" + txtCari.Text + "%'";
                cmd = new SqlCommand(sql, conn);

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        item = new ListViewItem();
                        item.Text = reader["id_jasa"].ToString();
                        item.SubItems.Add(reader["nama_jasa"].ToString());
                        item.SubItems.Add(reader["harga_jasa"].ToString());

                        lsvJasa.Items.Add(item);
                    }
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                lsvJasa.Clear();
                ListItem();
            }

        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            CariJasa();
        }

        private void txtJual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Hanya Bisa Angka");
            }
        }
    }
}
