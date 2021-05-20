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
    public partial class Form3 : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        string KodeAuto = "";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Bersihkan();
            lsvBarang.View = View.Details;
            lsvBarang.Columns.Add("KODE");
            lsvBarang.Columns.Add("NAMA");
            lsvBarang.Columns.Add("HARGA");
            lsvBarang.Columns.Add("QTY");
            lsvBarang.Columns.Add("SUB TOTAL");
            lsvBarang.Columns[0].Width = 50;
            lsvBarang.Columns[1].Width = 200;
            lsvBarang.Columns[2].Width = 200;
            lsvBarang.Columns[3].Width = 100;
            lsvBarang.Columns[4].Width = 100;

            lsvBarang.FullRowSelect = true;

            string connString = Properties.Settings.Default.coba;
            conn = new SqlConnection(connString);
            conn.Open();
            
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            ListViewItem item;
            item = new ListViewItem();
            item.Text = txtKode.Text;
            item.SubItems.Add(TxtNama.Text);
            item.SubItems.Add(txtHarga.Text);
            item.SubItems.Add(txtQty.Text);
            double total = Convert.ToDouble(txtHarga.Text) * Convert.ToDouble(txtQty.Text);
            item.SubItems.Add(total.ToString());
            lsvBarang.Items.Add(item);

            txtKode.Clear();
            TxtNama.Clear();
            txtHarga.Clear();
            txtQty.Clear();

            txtTotal.Text = HitungTotal();
        }

        private void txtKode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F9)
            {
                Form4 frmsearch = new Form4();
                frmsearch.ShowDialog();
            }

            txtKode.Text = Program.kdBarang;
            TxtNama.Text = Program.nmBarang;
            txtHarga.Text = Program.hrgBarang;
        }

        private string HitungTotal()
        {
            int n = lsvBarang.Items.Count-1;
            double total = 0;
            for (int i = 0; i <= n; i++ )
            {
                total = total + double.Parse(lsvBarang.Items[i].SubItems[4].Text);
            }
            return total.ToString();
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            
        }

        private void AutoNumber()
        {
            string maxString = "";
            int maxInteger = 0;

            string ssql = " SELECT MAX(kd_trs) AS MAXIMUM, COUNT(kd_trs) AS JUMLAH " +
                          " FROM transaksi ";

            reader.Close();
            cmd = new SqlCommand(ssql, conn);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if (reader["JUMLAH"].ToString() == "0")
                    maxString = "T0000";
                else
                    maxString = reader["MAXIMUM"].ToString();

            }

            maxInteger = int.Parse(maxString.Substring(1, 4));
            maxInteger = maxInteger + 1;
            maxString = maxInteger.ToString();

            if (maxString.Length == 1)
                KodeAuto = "T000" + maxString;
            else if (maxString.Length == 2)
                KodeAuto = "T00" + maxString;
            else if (maxString.Length == 3)
                KodeAuto = "T0" + maxString;
            else if (maxString.Length == 4)
                KodeAuto = "T" + maxString;
            
            reader.Close();
        }
        private void txtBayar_TextChanged(object sender, EventArgs e)
        {
            txtKembali.Text = Convert.ToString(Convert.ToDouble(txtBayar.Text) - Convert.ToDouble(txtTotal.Text));
        }

        private void Bersihkan()
        {
            //txtKodeTrs.Enabled = false;
            txtKodeTrs.Text = "AUTO";
            dtpTglTrs.Value = DateTime.Now;
            txtKode.Clear();
            TxtNama.Clear();
            txtHarga.Text = "0";
            txtQty.Text = "0";
            txtTotal.Text = "0";
            txtBayar.Text = "0";
            txtKembali.Text = "0";
            lsvBarang.Items.Clear();
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            if(txtKodeTrs.Text.Length != 0)
            {
                String ssql = "SELECT * " +
                              "FROM transaksi " +
                              "WHERE kd_trs = '" + txtKodeTrs.Text + "'";
                cmd = new SqlCommand(ssql, conn);
                reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    ssql = "UPDATE transaksi " +
                           "SET tgl_trs = '" + dtpTglTrs.Value.Date.ToString("MM-dd-yyyy") + "'," +
                           "TOTAL = " + txtTotal.Text + "," +
                           "BAYAR = " + txtBayar.Text + "," +
                           "KEMBALI = " + txtKembali.Text +
                           "WHERE kd_trs = '" + txtKodeTrs.Text + "'";
                    reader.Close();
                    cmd = new SqlCommand(ssql, conn);
                    cmd.ExecuteNonQuery();

                    //Delete data di tabel transaksi2 berdasarkan Kode trs
                    //insert data di tabel transaksi2

                    int n = lsvBarang.Items.Count - 1;
                    for (int i = 0; i <= n; i++)
                    {
                        ssql = "UPDATE transaksi2 " +
                               "SET kd_trs = '" + txtKodeTrs.Text + "'," +
                               "kd_brg = '" + lsvBarang.Items[i].SubItems[0].Text + "'," +
                               "Harga = " + lsvBarang.Items[i].SubItems[2].Text + "," +
                               "Qty = " + lsvBarang.Items[i].SubItems[3].Text + "," +
                               "sub_total = " + lsvBarang.Items[i].SubItems[4].Text +
                               "WHERE kd_trs = '" + txtKodeTrs + "'";
                        cmd = new SqlCommand(ssql, conn);
                        cmd.ExecuteNonQuery();

                    }

                }
                else
                {
                    AutoNumber();
                    txtKodeTrs.Text = KodeAuto;
                    ssql = "INSERT INTO transaksi " +
                        "VALUES('" + txtKodeTrs.Text + "','" + dtpTglTrs.Value.Date.ToString("MM-dd-yyyy") + "'," + txtTotal.Text + "," + txtBayar.Text + "," + txtKembali.Text + ")";
                    reader.Close();
                    cmd = new SqlCommand(ssql, conn);
                    cmd.ExecuteNonQuery();

                    int n = lsvBarang.Items.Count - 1;
                    for (int i = 0; i <= n; i++)
                    {
                        ssql = "INSERT INTO transaksi2 " +
                               "VALUES('" + txtKodeTrs.Text + "','" +
                               lsvBarang.Items[i].SubItems[0].Text + "'," +
                               lsvBarang.Items[i].SubItems[2].Text + "," +
                               lsvBarang.Items[i].SubItems[3].Text + "," +
                               lsvBarang.Items[i].SubItems[4].Text + ")" ;
                               
                        cmd = new SqlCommand(ssql, conn);
                        cmd.ExecuteNonQuery();

                    }

                }
                
                conn.Close();
                Bersihkan();
                MessageBox.Show("Transaksi Sudah Disimpan");

            }
        }

        private void txtKodeTrs_Validated(object sender, EventArgs e)
        {
            if ((txtKodeTrs.Text.Length != 0) && (txtKodeTrs.Text != "AUTO"))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string ssql = "SELECT * " +
                              "FROM transaksi " +
                              "WHERE kd_trs = '" + txtKodeTrs.Text + "'";
                cmd = new SqlCommand(ssql, conn);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {

                    reader.Read();
                    dtpTglTrs.Value = Convert.ToDateTime(reader["tgl_trs"]);
                    txtTotal.Text = reader["total"].ToString();
                    txtBayar.Text = reader["bayar"].ToString();
                    txtKembali.Text = reader["kembali"].ToString();
                }
                reader.Close();

                ssql = "SELECT * " +
                       "FROM transaksi2 a " +
                       "INNER JOIN barang b " +
                       "ON a.kd_brg = b.kd_brg " +
                       "WHERE a.kd_trs = '" + txtKodeTrs.Text + "'";
                cmd = new SqlCommand(ssql, conn);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    lsvBarang.Items.Clear();
                    ListViewItem item;
                    while (reader.Read())
                    {
                        item = new ListViewItem();
                        item.Text = reader["kd_brg"].ToString();
                        item.SubItems.Add(reader["nm_brg"].ToString());
                        item.SubItems.Add(reader["harga"].ToString());
                        item.SubItems.Add(reader["qty"].ToString());
                        item.SubItems.Add(reader["sub_total"].ToString());
                        lsvBarang.Items.Add(item);
                    }
                }
                reader.Close();
            }
        }

        private void btnBaru_Click(object sender, EventArgs e)
        {
            Bersihkan();
        }

        private void txtKodeTrs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                Form6 frmsearch_trs = new Form6();
                frmsearch_trs.ShowDialog();
                txtKodeTrs.Text = Program.kdTrs;
                SendKeys.Send("{Tab}");
            }

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            //delete from transaksi1 where kd_trs = txtKodeTrs.Text

            //delete from transaksi2 where kd_trs = txtKodeTrs.Text

        }
    }
}
