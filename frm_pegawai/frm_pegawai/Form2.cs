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

namespace frm_pegawai
{
    public partial class Form2 : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader rdr = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            
            byte jnksl;
            if (rdbLaki.Checked)
            {
                jnksl = 1;
            }
            else
            {
                jnksl = 0;
            }
            
            string sql = "SELECT * FROM pegawai WHERE NIP = '" + txtNIP.Text + "'";
            cmd = new SqlCommand(sql, conn);
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                // insert
                sql = "UPDATE pegawai SET nama = '" + txtNama.Text + "', jk = " +jnksl + "WHERE nip = '" + txtNIP.Text+ "'";
            }
            else
            {
                //update
                sql = "INSERT INTO pegawai " + 
                      "VALUES ('"+txtNIP.Text +"' , '" + txtNama.Text + "' ,  " + jnksl + ")";
            }

            rdr.Close();
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Sudah Disimpan");


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string connstring = @"Data source= DESKTOP-8OM2UC1\SQLEXPRESS;
                                  initial catalog=STIKOM; integrated security=true";

            conn = new SqlConnection(connstring);
            conn.Open();

            string sql = "SELECT * FROM pegawai WHERE NIP = 'P001'";
            cmd = new SqlCommand(sql, conn);
            rdr = cmd.ExecuteReader();

            if(rdr.HasRows)
            {
                rdr.Read();
                txtNIP.Text = rdr["nip"].ToString();
                txtNama.Text = rdr["nama"].ToString();
                if (Convert.ToBoolean(rdr["jk"]) == true)
                    rdbLaki.Checked = true;
                else
                    radioButton2.Checked = true;
            }

            rdr.Close();
            conn.Close();
        }

        private void txtNIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNIP_Validated(object sender, EventArgs e)
        {

        }
    }
}
