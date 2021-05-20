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
    public partial class frmMGrade : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        public frmMGrade()
        {
            InitializeComponent();
        }
        private void frmMGrade_Load(object sender, EventArgs e)
        {
            string connString = Properties.Settings.Default.coba;
            conn = new SqlConnection(connString);
            conn.Open();

            string ssql = "Select * from ms_grade";
            cmd = new SqlCommand(ssql, conn);

            reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                reader.Read();
                textBox1.Text = reader["grade_id"].ToString();
                textBox2.Text = reader["nilai"].ToString();
                textBox3.Text = reader["discount"].ToString();
            }
            reader.Close();
            conn.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string ssql = "Select * from ms_grade where grade_id = '" + textBox1.Text + "'";
                cmd = new SqlCommand(ssql, conn);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    ssql = "Update ms_grade " +
                           "Set nilai = '" + textBox2.Text + "'," +
                           "discount = '" + textBox3.Text + "'" +
                           "where grade_id = '" + textBox1.Text + "'";
                }
                else
                {
                    ssql = "insert into ms_grade " +
                           "values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Value + "')";
                }
                reader.Close();
                cmd = new SqlCommand(ssql, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Data Telah Disimpn");
            }
        }

       

        
    }
}
