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
    public partial class Form4 : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string connString = Properties.Settings.Default.coba;
            conn = new SqlConnection(connString);
            conn.Open();

            lsvDaftar.View = View.Details;
            lsvDaftar.FullRowSelect = true;
            lsvDaftar.Columns.Add("KODE");
            lsvDaftar.Columns.Add("NAMA");
            lsvDaftar.Columns.Add("HARGA");
            
            lsvDaftar.Columns[0].Width = 50;
            lsvDaftar.Columns[1].Width = 300;
            lsvDaftar.Columns[2].Width = 200;
            
            ListViewItem item;
            string ssql = "Select * from barang";
            cmd = new SqlCommand(ssql, conn);

            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read()) 
                {
                    item = new ListViewItem();
                    item.Text = reader["kd_brg"].ToString();
                    item.SubItems.Add(reader["nm_brg"].ToString());
                    item.SubItems.Add(reader["harga"].ToString());
                    lsvDaftar.Items.Add(item);
                }
            }
            reader.Close();
            conn.Close();

        }

        private void lsvDaftar_DoubleClick(object sender, EventArgs e)
        {
            Program.kdBarang = lsvDaftar.SelectedItems[0].SubItems[0].Text;
            Program.nmBarang = lsvDaftar.SelectedItems[0].SubItems[1].Text;
            Program.hrgBarang = lsvDaftar.SelectedItems[0].SubItems[2].Text;

            
            this.Close();
        }

        private void lsvDaftar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
