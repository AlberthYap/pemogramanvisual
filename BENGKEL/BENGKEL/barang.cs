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
using System.ComponentModel.DataAnnotations;


namespace BENGKEL
{
    public partial class barang : Form
    {

        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        string KodeAuto = "";
        

        private void barang_Load(object sender, EventArgs e)
        {
            string connString = Properties.Settings.Default.DB;
            conn = new SqlConnection(connString);
            conn.Open();
            ListItem();
        }


        public barang()
        {
            InitializeComponent();
        }

        public void ListItem()
        {
            lstBarang.View = View.Details;
            lstBarang.FullRowSelect = true;
            lstBarang.Columns.Add("KODE");
            lstBarang.Columns.Add("NAMA BARANG");
            lstBarang.Columns.Add("HARGA JUAL");
            lstBarang.Columns.Add("STOCK");

            lstBarang.Columns[0].Width = 50;
            lstBarang.Columns[1].Width = 200;
            lstBarang.Columns[2].Width = 100;
            lstBarang.Columns[3].Width = 50;


            ListViewItem item;
            string sql = "Select * from barang";
            cmd = new SqlCommand(sql, conn);

            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    item = new ListViewItem();
                    item.Text = reader["id_barang"].ToString();
                    item.SubItems.Add(reader["nama_barang"].ToString());
                    item.SubItems.Add(reader["harga_jual"].ToString());
                    item.SubItems.Add(reader["stock"].ToString());

                    lstBarang.Items.Add(item);
                }
            }
            reader.Close();
            conn.Close();
        }

        private void AutoNumber()
        {
            string maxString = "";
            int maxInteger = 0;

            string ssql = " SELECT MAX(id_barang) AS MAXIMUM, COUNT(id_barang) AS JUMLAH " +
                          " FROM barang ";

            reader.Close();

            cmd = new SqlCommand(ssql, conn);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if (reader["JUMLAH"].ToString() == "0")
                    maxString = "B0000";
                else
                    maxString = reader["MAXIMUM"].ToString();

            }

            maxInteger = int.Parse(maxString.Substring(1, 4));
            maxInteger = maxInteger + 1;
            maxString = maxInteger.ToString();

            if (maxString.Length == 1)
                KodeAuto = "B000" + maxString;
            else if (maxString.Length == 2)
                KodeAuto = "B00" + maxString;
            else if (maxString.Length == 3)
                KodeAuto = "B0" + maxString;
            else if (maxString.Length == 4)
                KodeAuto = "B" + maxString;

            reader.Close();
        }

        public void clean()
        {
            txt_idBarang.Clear();
            txtBarang.Clear();
            txtJual.Text = "0";

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBarang.Text) || string.IsNullOrEmpty(txtJual.Text))
            {
                string message = "Lengkapi Data Terlebih Dahulu";
                string title = "Data Tidak Lengkap";
                MessageBox.Show(message, title);
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();


                string sql = "SELECT * FROM BARANG WHERE id_barang = '" + txt_idBarang.Text + "'";

                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    sql = "UPDATE barang set nama_barang = '" + txtBarang.Text + "' ,  harga_jual = "+ txtJual.Text+" WHERE id_barang = '"+ txt_idBarang.Text +"' ";
                    reader.Close();
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    clean();
                    lstBarang.Clear();
                    ListItem();
                }
                else
                {
                    AutoNumber();
                    txt_idBarang.Text = KodeAuto;
                    sql = "INSERT INTO BARANG VALUES('" + txt_idBarang.Text + "' , '" + txtBarang.Text + "' , " + txtJual.Text + ", 0)";

                    reader.Close();
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    ListViewItem item;
                    item = new ListViewItem();
                    item.Text = txt_idBarang.Text;
                    item.SubItems.Add(txtBarang.Text);
                    item.SubItems.Add(txtJual.Text);
                    item.SubItems.Add("0");
                    lstBarang.Items.Add(item);

                    clean();
                }

                conn.Close();
                MessageBox.Show("Barang Sudah Disimpan");
            }
        }

        private void txtBarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBarang.Text))
            {
                string message = "Pililah Data Terlebih Dahulu";
                string title = "Data Belum Dipilih";
                MessageBox.Show(message, title);
            } else
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string sql = "DELETE FROM barang WHERE id_barang = '"+ txt_idBarang.Text+"'";
                cmd = new SqlCommand(sql, conn);
                reader.Close();
                cmd.ExecuteNonQuery();
                clean();
                lstBarang.Clear();
                ListItem();
                MessageBox.Show("Barang Sudah Dihapus");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void txtBeli_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lstBarang_DoubleClick(object sender, EventArgs e)
        {
            clean();

            string id_barang, nama_barang, harga_jual;
            id_barang = lstBarang.SelectedItems[0].SubItems[0].Text;
            nama_barang = lstBarang.SelectedItems[0].SubItems[1].Text;
            harga_jual = lstBarang.SelectedItems[0].SubItems[2].Text;

            txt_idBarang.Text = id_barang;
            txtBarang.Text = nama_barang;
            txtJual.Text = harga_jual;

        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            if (txtCari.Text != "")
            {
                lstBarang.Items.Clear();


                ListViewItem item;
                string sql = "Select * from barang where id_barang like '%" + txtCari.Text + "%' or harga_jual like '%" + txtCari.Text + "%' or nama_barang like '%" + txtCari.Text + "%' or stock like '%"+txtCari.Text+"%'";

                cmd = new SqlCommand(sql, conn);

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        item = new ListViewItem();
                        item.Text = reader["id_barang"].ToString();
                        item.SubItems.Add(reader["nama_barang"].ToString());
                        item.SubItems.Add(reader["harga_jual"].ToString());
                        item.SubItems.Add(reader["stock"].ToString());
                        lstBarang.Items.Add(item);
                    }
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                lstBarang.Clear();
                ListItem();
            }
        }

        private void txtJual_TextChanged(object sender, EventArgs e)
        {

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
