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

namespace UAS_180010259_BENGKEL
{
    public partial class DaftarItem : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader rdr = null;
        string KodeAuto = "";

        public DaftarItem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DaftarItem_Load(object sender, EventArgs e)
        {
            string connstring = Properties.Settings.Default.BENGKEL;
            conn = new SqlConnection(connstring);
            conn.Open();

        }

        private void AutoNumber()
        {
            string maxString = "";
            int maxInteger = 0;

            string sql = " SELECT MAX(id_barang) AS MAXIMUM, COUNT(id_barang) AS JUMLAH FROM barang ";

            rdr.Close();

            cmd = new SqlCommand(sql, conn);
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                if (rdr["JUMLAH"].ToString() == "0")
                    maxString = "B0000";
                else
                    maxString = rdr["MAXIMUM"].ToString();

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

            rdr.Close();
        }


        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            AutoNumber();
            txt_idBarang.Text = KodeAuto;
            string sql = "SELECT * FROM BARANG WHERE id_barang = '" + txt_idBarang.Text+ "'";
            cmd = new SqlCommand(sql, conn);
            rdr = cmd.ExecuteReader();
            //if (rdr.HasRows)
            //{
            //    //// insert
            //    //sql = "UPDATE pegawai SET nama = '" + txtNama.Text + "', jk = " + jnksl + "WHERE nip = '" + txtNIP.Text + "'";
            //}
            //else
            //{
            //    //update
                sql = "INSERT INTO BARANG VALUES("+ txt_idBarang.Text + ", '" + txtBarang.Text + "' , " + txtBeli.Text + " , " + txtJual.Text +", NULL)";
            //}

        rdr.Close();

            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Data Sudah Disimpan");
        }
    }
}
