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
    public partial class ListMekanik : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        public ListMekanik()
        {
            InitializeComponent();
        }

        private void ListMekanik_Load(object sender, EventArgs e)
        {
            string connString = Properties.Settings.Default.DB;
            conn = new SqlConnection(connString);
            conn.Open();

            lstBarang.View = View.Details;
            lstBarang.FullRowSelect = true;
            lstBarang.Columns.Add("KODE");
            lstBarang.Columns.Add("NAMA");
            lstBarang.Columns.Add("NO HP");


            lstBarang.Columns[0].Width = 50;
            lstBarang.Columns[1].Width = 250;
            lstBarang.Columns[2].Width = 130;


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
                    item.SubItems.Add(reader["nohp"].ToString());
                    lstBarang.Items.Add(item);
                }
            }
            reader.Close();
            conn.Close();
        }

        private void lstBarang_DoubleClick(object sender, EventArgs e)
        {
            Program.id_mekanik = lstBarang.SelectedItems[0].SubItems[0].Text;

            this.Close();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            if (txtCari.Text != "")
            {
                lstBarang.Items.Clear();


                ListViewItem item;
                string sql = "Select * from mekanik where id_mekanik like '%" + txtCari.Text + "%' or nama_mekanik like '%" + txtCari.Text + "%' or nohp like '%" + txtCari.Text + "%'";

                cmd = new SqlCommand(sql, conn);

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        item = new ListViewItem();
                        item.Text = reader["id_mekanik"].ToString();
                        item.SubItems.Add(reader["nama_mekanik"].ToString());
                        item.SubItems.Add(reader["nohp"].ToString());
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
                string sql = "Select * from mekanik ";

                cmd = new SqlCommand(sql, conn);

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        item = new ListViewItem();
                        item.Text = reader["id_mekanik"].ToString();
                        item.SubItems.Add(reader["nama_mekanik"].ToString());
                        item.SubItems.Add(reader["nohp"].ToString());
                        lstBarang.Items.Add(item);
                    }
                }
                reader.Close();
                conn.Close();
            }
        }
    }
}
