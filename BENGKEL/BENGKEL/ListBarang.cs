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
    public partial class ListBarang : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        public ListBarang()
        {
            InitializeComponent();
        }

        private void ListBarang_Load(object sender, EventArgs e)
        {
            string connString = Properties.Settings.Default.DB;
            conn = new SqlConnection(connString);
            conn.Open();

            lstBarang.View = View.Details;
            lstBarang.FullRowSelect = true;
            lstBarang.Columns.Add("KODE");
            lstBarang.Columns.Add("NAMA");
            lstBarang.Columns.Add("HARGA JUAL");


            lstBarang.Columns[0].Width = 50;
            lstBarang.Columns[1].Width = 250;
            lstBarang.Columns[2].Width = 130;


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
                    lstBarang.Items.Add(item);
                }
            }
            reader.Close();
            conn.Close();
        }

        private void lstBarang_DoubleClick(object sender, EventArgs e)
        {
            Program.id_barang = lstBarang.SelectedItems[0].SubItems[0].Text;
            Program.nama_barang = lstBarang.SelectedItems[0].SubItems[1].Text;
            Program.harga_jual = lstBarang.SelectedItems[0].SubItems[2].Text;


            this.Close();
        }

        private void lstBarang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            if (txtCari.Text != "")
            {
                lstBarang.Items.Clear();
                

                ListViewItem item;
                string sql = "Select * from barang where id_barang like '%" + txtCari.Text + "%' or harga_jual like '%" + txtCari.Text + "%' or nama_barang like '%" + txtCari.Text + "%'";

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
                        lstBarang.Items.Add(item);
                    }
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                lstBarang.Items.Clear();


                ListViewItem item;
                string sql = "Select * from barang ";

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
                        lstBarang.Items.Add(item);
                    }
                }
                reader.Close();
                conn.Close();
            }
        }
    }
}
