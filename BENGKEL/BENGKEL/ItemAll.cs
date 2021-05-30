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
    public partial class ItemAll : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        public ItemAll()
        {
            InitializeComponent();
        }

        private void lstBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ItemAll_Load(object sender, EventArgs e)
        {
            string connString = Properties.Settings.Default.DB;
            conn = new SqlConnection(connString);
            conn.Open();

            lstItem.View = View.Details;
            lstItem.FullRowSelect = true;
            lstItem.Columns.Add("KODE");
            lstItem.Columns.Add("NAMA");
            lstItem.Columns.Add("HARGA");


            lstItem.Columns[0].Width = 50;
            lstItem.Columns[1].Width = 250;
            lstItem.Columns[2].Width = 130;


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
                    lstItem.Items.Add(item);
                }
            }
            reader.Close();

            string sql1 = "Select * from jasa";
            cmd = new SqlCommand(sql1, conn);

            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    item = new ListViewItem();
                    item.Text = reader["id_jasa"].ToString();
                    item.SubItems.Add(reader["nama_jasa"].ToString());
                    item.SubItems.Add(reader["harga_jasa"].ToString());
                    lstItem.Items.Add(item);
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
                lstItem.Items.Clear();
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
                        lstItem.Items.Add(item);
                    }
                }
                reader.Close();

                string sql1 = "Select * from jasa where id_jasa like '%" + txtCari.Text + "%' or harga_jasa like '%" + txtCari.Text + "%' or nama_jasa like '%" + txtCari.Text + "%'";

                cmd = new SqlCommand(sql1, conn);

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        item = new ListViewItem();
                        item.Text = reader["id_jasa"].ToString();
                        item.SubItems.Add(reader["nama_jasa"].ToString());
                        item.SubItems.Add(reader["harga_jasa"].ToString());
                        lstItem.Items.Add(item);
                    }
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                lstItem.Items.Clear();
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
                        lstItem.Items.Add(item);
                    }
                }
                reader.Close();

                string sql1 = "Select * from jasa";
                cmd = new SqlCommand(sql1, conn);

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        item = new ListViewItem();
                        item.Text = reader["id_jasa"].ToString();
                        item.SubItems.Add(reader["nama_jasa"].ToString());
                        item.SubItems.Add(reader["harga_jasa"].ToString());
                        lstItem.Items.Add(item);
                    }
                }
                reader.Close();
                conn.Close();
            }
        }

        private void lstItem_DoubleClick(object sender, EventArgs e)
        {
            Program.id_barang = lstItem.SelectedItems[0].SubItems[0].Text;
            Program.nama_barang = lstItem.SelectedItems[0].SubItems[1].Text;
            Program.harga_jual = lstItem.SelectedItems[0].SubItems[2].Text;
            this.Close();

        }
    }
}
