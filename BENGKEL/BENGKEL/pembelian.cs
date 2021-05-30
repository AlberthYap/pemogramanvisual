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
    public partial class pembelian : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        string KodeAuto = "";

        public pembelian()
        {
            InitializeComponent();
        }

        private void pembelian_Load(object sender, EventArgs e)
        {
            lstBeli.View = View.Details;
            lstBeli.Columns.Add("KODE");
            lstBeli.Columns.Add("NAMA BARANG");
            lstBeli.Columns.Add("HARGA BELI");
            lstBeli.Columns.Add("QTY");
            lstBeli.Columns.Add("SUB TOTAL");
            lstBeli.Columns[0].Width = 60;
            lstBeli.Columns[1].Width = 200;
            lstBeli.Columns[2].Width = 200;
            lstBeli.Columns[3].Width = 100;
            lstBeli.Columns[4].Width = 100;

            lstBeli.FullRowSelect = true;

            string connString = Properties.Settings.Default.DB;
            conn = new SqlConnection(connString);
            conn.Open();
        }
        private string HitungTotal()
        {
            int n = lstBeli.Items.Count - 1;
            double total = 0;

            for (int i = 0; i <= n; i++)
            {
                
                total = total + double.Parse(lstBeli.Items[i].SubItems[4].Text);
            }
            return total.ToString();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            if (lstBeli.Items.Count != 0){
                String sql = "SELECT * " +
                             "FROM pembelian1 " +
                             "WHERE kd_beli = '" + txtRiwayat.Text + "'";
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    sql = "UPDATE pembelian1 " +
                           "SET waktu_beli = '" + dateTimePicker1.Value.ToString("MM-dd-yyyy hh:mm:ss") + "'," +
                           "total_harga = " + txt_total.Text + "WHERE kd_beli = '" + txtRiwayat.Text + "'";
                    reader.Close();
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    

                    int n = lstBeli.Items.Count - 1;
                    for (int i = 0; i <= n; i++)
                    {
                        string a = "SELECT * from pembelian2 where beli_kd = '" + txtRiwayat.Text +
                                   "' and barang_id = '" + lstBeli.Items[i].SubItems[0].Text + "'";
                        cmd = new SqlCommand(a, conn);
                        reader = cmd.ExecuteReader();
                        reader.Read();

                        if (reader.HasRows)
                        {
                            string sql2 = "UPDATE barang SET STOCK -= " + reader["qty_beli"].ToString() +
                                          " WHERE ID_BARANG = '" +
                                          lstBeli.Items[i].SubItems[0].Text + "' ";
                            reader.Close();
                            cmd = new SqlCommand(sql2, conn);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            reader.Close();
                        }
                    }

                    string sqll = "DELETE FROM pembelian2 WHERE beli_kd ='" + txtRiwayat.Text + "'";
                    cmd = new SqlCommand(sqll, conn);
                    cmd.ExecuteNonQuery();

                    for (int i = 0; i <= n; i++)
                    {
                        sql = "INSERT INTO pembelian2 " +
                          "VALUES('" + txtRiwayat.Text + "','" +
                          lstBeli.Items[i].SubItems[0].Text + "'," +
                          lstBeli.Items[i].SubItems[2].Text + "," +
                          lstBeli.Items[i].SubItems[3].Text + "," +
                          lstBeli.Items[i].SubItems[4].Text + ")";
                        string sql1 = "UPDATE barang SET stock += " + lstBeli.Items[i].SubItems[3].Text +
                                      " where id_barang = '" + lstBeli.Items[i].SubItems[0].Text + "'";
                        cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand(sql1, conn);
                        cmd.ExecuteNonQuery();

                    }
                } else
                {
                    AutoNumber();
                    txtRiwayat.Text = KodeAuto;
                    sql = "INSERT INTO pembelian1 " +
                        "VALUES('" + txtRiwayat.Text + "','" + dateTimePicker1.Value.ToString("MM-dd-yyyy hh:mm:ss") + "'," + txt_total.Text + ")";
                    reader.Close();
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    int n = lstBeli.Items.Count - 1;
                    for (int i = 0; i <= n; i++)
                    {
                        sql = "INSERT INTO pembelian2 " +
                               "VALUES('" + txtRiwayat.Text + "','" +
                               lstBeli.Items[i].SubItems[0].Text + "'," +
                               lstBeli.Items[i].SubItems[2].Text + "," +
                               lstBeli.Items[i].SubItems[3].Text + "," +
                               lstBeli.Items[i].SubItems[4].Text + ")";
                        string sql1 = "UPDATE barang SET stock += " + lstBeli.Items[i].SubItems[3].Text +
                                      " where id_barang = '"+ lstBeli.Items[i].SubItems[0].Text  + "'";
                        cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand(sql1, conn);
                        cmd.ExecuteNonQuery();
                    }
                }

               
                clear();
                conn.Close();
                MessageBox.Show("Barang Sudah Disimpan");
            } else
            {
                string message = "Lengkapi Data Terlebih Dahulu";
                string title = "Data Tidak Lengkap";
                MessageBox.Show(message, title);
            }
        }


        private void btn_Tambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_idBarang.Text))
            {
                string message = "Lengkapi Data Terlebih Dahulu";
                string title = "Data Tidak Lengkap";
                MessageBox.Show(message, title);
            }
            else
            {
                ListViewItem item;
                item = new ListViewItem();
                item.Text = txt_idBarang.Text;
                item.SubItems.Add(txtBarang.Text);
                item.SubItems.Add(txtHarga.Text);
                item.SubItems.Add(txtQty.Text);
                double totall = Convert.ToDouble(txtHarga.Text) * Convert.ToDouble(txtQty.Text);
                item.SubItems.Add(totall.ToString());
                lstBeli.Items.Add(item);

                txt_idBarang.Clear();
                txtBarang.Clear();
                txtHarga.Value = 0;
                txtQty.Value = 0;

                txt_total.Text = HitungTotal();
            }

        }

        private void AutoNumber()
        {
            string maxString = "";
            int maxInteger = 0;

            string ssql = " SELECT MAX(kd_beli) AS MAXIMUM, COUNT(kd_beli) AS JUMLAH " +
                          " FROM pembelian1 ";

            reader.Close();

            cmd = new SqlCommand(ssql, conn);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if (reader["JUMLAH"].ToString() == "0")
                    maxString = "A0000";
                else
                    maxString = reader["MAXIMUM"].ToString();

            }

            maxInteger = int.Parse(maxString.Substring(1, 4));
            maxInteger = maxInteger + 1;
            maxString = maxInteger.ToString();

            if (maxString.Length == 1)
                KodeAuto = "A000" + maxString;
            else if (maxString.Length == 2)
                KodeAuto = "A00" + maxString;
            else if (maxString.Length == 3)
                KodeAuto = "A0" + maxString;
            else if (maxString.Length == 4)
                KodeAuto = "A" + maxString;

            reader.Close();
        }

        private void clear()
        {
            //txtRiwayat.Enabled = false;
            txtRiwayat.Text = "PRESS";
            dateTimePicker1.Value = DateTime.Now;
            txt_idBarang.Clear();
            txtBarang.Clear();
            txtHarga.Text = "0";
            txtQty.Text = "0";
            txt_total.Text = "0";
            lstBeli.Items.Clear();
        }

        private void txt_idBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                ListBarang frmsearch = new ListBarang();
                frmsearch.ShowDialog();
            }

            txt_idBarang.Text = Program.id_barang;
            txtBarang.Text = Program.nama_barang;
        }

        private void lstBeli_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txtRiwayat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                RiwayatPembelian frmsearch_trs = new RiwayatPembelian();
                frmsearch_trs.ShowDialog();
                txtRiwayat.Text = Program.id_beli;
                SendKeys.Send("{Tab}");
            }
        }

        private void txtRiwayat_Validated(object sender, EventArgs e)
        {
            if ((txtRiwayat.Text.Length != 0) && (txtRiwayat.Text != "PRESS"))
            {
                lstBeli.Items.Clear();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string sql = "SELECT * " +
                              "FROM pembelian1 " +
                              "WHERE kd_beli = '" + txtRiwayat.Text + "'";
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    dateTimePicker1.Value = Convert.ToDateTime(reader["waktu_beli"]);
                    txt_total.Text = reader["total_harga"].ToString();

                }
                reader.Close();

                sql = "SELECT * " +
                       "FROM pembelian2 a " +
                       "INNER JOIN barang b " +
                       "ON a.barang_id = b.id_barang " +
                       "WHERE a.beli_kd = '" + txtRiwayat.Text + "'";
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    lstBeli.Items.Clear();
                    ListViewItem item;
                    while (reader.Read())
                    {
                        item = new ListViewItem();
                        item.Text = reader["id_barang"].ToString();
                        item.SubItems.Add(reader["nama_barang"].ToString());
                        item.SubItems.Add(reader["harga_beli"].ToString());
                        item.SubItems.Add(reader["qty_beli"].ToString());
                        item.SubItems.Add(reader["sub_total"].ToString());
                        lstBeli.Items.Add(item);
                    }
                }
                reader.Close();
            }
        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
