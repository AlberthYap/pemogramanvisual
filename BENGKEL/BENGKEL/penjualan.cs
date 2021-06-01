﻿using System;
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
    public partial class penjualan : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        string KodeAuto = "";

        public penjualan()
        {
            InitializeComponent();
        }

        private void penjualan_Load(object sender, EventArgs e)
        {
            lstJual.View = View.Details;
            lstJual.Columns.Add("KODE");
            lstJual.Columns.Add("NAMA ITEM");
            lstJual.Columns.Add("HARGA");
            lstJual.Columns.Add("QTY");
            lstJual.Columns.Add("SUB TOTAL");
            lstJual.Columns[0].Width = 60;
            lstJual.Columns[1].Width = 200;
            lstJual.Columns[2].Width = 200;
            lstJual.Columns[3].Width = 100;
            lstJual.Columns[4].Width = 100;

            lstJual.FullRowSelect = true;

            string connString = Properties.Settings.Default.DB;
            conn = new SqlConnection(connString);
            conn.Open();
        }

        private void txt_idBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                ItemAll frmsearch_trs = new ItemAll();
                frmsearch_trs.ShowDialog();
            }

            txt_idItem.Text = Program.id_barang;
            txtItem.Text = Program.nama_barang;
            txtHarga.Text = Program.harga_jual;
        }

        private void btn_Tambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_idItem.Text))
            {
                string message = "Lengkapi Data Terlebih Dahulu";
                string title = "Data Tidak Lengkap";
                MessageBox.Show(message, title);
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();


                if (txt_idItem.Text.Substring(0, 1) == "B")
                {
                    string sql = "SELECT * " +
                             "FROM barang " +
                             "WHERE id_barang = '" + txt_idItem.Text + "'";
                    cmd = new SqlCommand(sql, conn);
                    reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();

                        if (Convert.ToDouble(reader["stock"].ToString()) == 0)
                        {
                            string message = "Stock Kosong";
                            string title = "Stock Kosong";
                            MessageBox.Show(message, title);
                        }
                        else if (Convert.ToDouble(reader["stock"].ToString()) < Convert.ToDouble(txtQty.Text))
                        {
                            string message = "Stock Tidak Mencukupi";
                            string title = "Stock Tidak Mencukupi";
                            MessageBox.Show(message, title);
                        }
                        else
                        {
                            ListViewItem item;
                            item = new ListViewItem();
                            item.Text = txt_idItem.Text;
                            item.SubItems.Add(txtItem.Text);
                            item.SubItems.Add(txtHarga.Text);
                            item.SubItems.Add(txtQty.Text);
                            double totall = Convert.ToDouble(txtHarga.Text) * Convert.ToDouble(txtQty.Text);
                            item.SubItems.Add(totall.ToString());
                            lstJual.Items.Add(item);

                            txt_idItem.Clear();
                            txtItem.Clear();
                            txtHarga.Value = 0;
                            txtQty.Value = 1;

                            txt_total.Text = HitungTotal();
                            txtAkhir.Text = Convert.ToString(Convert.ToDouble(txt_total.Text) - Convert.ToDouble(txtDiskon.Text));

                            diskon();
                        }
                    }

                    reader.Close();
                } 
                else if (txt_idItem.Text.Substring(0, 1) == "J")
                {
                    if (Convert.ToDouble(txtQty.Text) > 1)
                    {
                        string message = "QTY Kelebihan";
                        string title = "QTY Kelebihan";
                        MessageBox.Show(message, title);
                    }
                    else
                    {
                        ListViewItem item;
                        item = new ListViewItem();
                        item.Text = txt_idItem.Text;
                        item.SubItems.Add(txtItem.Text);
                        item.SubItems.Add(txtHarga.Text);
                        item.SubItems.Add(txtQty.Text);
                        double totall = Convert.ToDouble(txtHarga.Text) * Convert.ToDouble(txtQty.Text);
                        item.SubItems.Add(totall.ToString());
                        lstJual.Items.Add(item);

                        txt_idItem.Clear();
                        txtItem.Clear();
                        txtHarga.Value = 0;
                        txtQty.Value = 1;

                        txt_total.Text = HitungTotal();
                        txtAkhir.Text = Convert.ToString(Convert.ToDouble(txt_total.Text) - Convert.ToDouble(txtDiskon.Text));

                        diskon();
                    }
                }
                

            }
        }

        public void diskon()
        {
            if (txtPengunjung.Text == "P00001")
            {
                txtDiskon.Text = "0";
            }
            else
            {
                if (int.Parse(txtPoint.Text) >= 100)
                {
                    txtDiskon.Text = Convert.ToString(0.05 * Convert.ToDouble(txt_total.Text));
                }
                else if (int.Parse(txtPoint.Text) >= 200)
                {
                    txtDiskon.Text = Convert.ToString(0.1 * Convert.ToDouble(txt_total.Text));

                }
            }
        }

        private void AutoNumber()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string maxString = "";
            int maxInteger = 0;
            string tanggal = DateTime.Now.ToString("yyyyMMdd");


            string ssql = " SELECT MAX(kd_jual) AS MAXIMUM, COUNT(kd_jual) AS JUMLAH " +
                          " FROM penjualan1 WHERE kd_jual like '" + tanggal+ "%'";

            reader.Close();

            cmd = new SqlCommand(ssql, conn);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if (reader["JUMLAH"].ToString() == "0")
                    KodeAuto = tanggal + "0001";
                else {
                    maxString = reader["MAXIMUM"].ToString();

                    maxInteger = int.Parse(maxString.Substring(8, 4));
                    maxInteger = maxInteger + 1;
                    maxString = maxInteger.ToString();

                    if (maxString.Length == 1)
                        KodeAuto = tanggal + "000" + maxString;
                    else if (maxString.Length == 2)
                        KodeAuto = tanggal + "00" + maxString;
                    else if (maxString.Length == 3)
                        KodeAuto = tanggal + "0" + maxString;
                    else if (maxString.Length == 4)
                        KodeAuto = tanggal + maxString;
                }

            }
            reader.Close();
        }

        private string HitungTotal()
        {
            int n = lstJual.Items.Count - 1;
            double total = 0;

            for (int i = 0; i <= n; i++)
            {
                total = total + double.Parse(lstJual.Items[i].SubItems[4].Text);
            }
            return total.ToString();
        }

        private void DapatPoint()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            if ((txtPengunjung.Text != "P00001") && (Convert.ToDouble(txtAkhir.Text) >= 100000) )
            {
                string sqll = "update pengunjung set point += 10 where id_pengunjung = '"+ txtPengunjung.Text +"'";
                cmd = new SqlCommand(sqll, conn);
                cmd.ExecuteNonQuery();
            }
        }

        private void KurangPoint()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            reader.Close();

            string sql = "SELECT * " +
                         "FROM penjualan1 " +
                         "WHERE kd_jual = '" + txtRiwayat.Text + "'";
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                string a = reader["pengunjung_id"].ToString();

                if (reader["pengunjung_id"].ToString() != "P00001" && (reader["pengunjung_id"].ToString() == txtPengunjung.Text && Convert.ToDouble(reader["total_akhir"].ToString()) >= 100000  ))
                {
                    reader.Close();

                    string sqll = "update pengunjung set point -= 10 where id_pengunjung = '" + txtPengunjung.Text + "'";
                    cmd = new SqlCommand(sqll, conn);
                    cmd.ExecuteNonQuery();
                } 
                else if (reader["pengunjung_id"].ToString() != "P00001" && (reader["pengunjung_id"].ToString() != txtPengunjung.Text && Convert.ToDouble(reader["total_akhir"].ToString()) >= 100000))
                {
                    reader.Close();
                    string sqll1 = "update pengunjung set point -= 10 where id_pengunjung = '" + a + "'";
                    cmd = new SqlCommand(sqll1, conn);
                    cmd.ExecuteNonQuery();
                }

            }
        }


        private void clear()
        {
            //txtRiwayat.Enabled = false;
            txtRiwayat.Text = "PRESS";
            dateTimePicker1.Value = DateTime.Now;
            txt_idItem.Clear();
            txtItem.Clear();
            txtHarga.Text = "0";
            txtQty.Text = "1";
            txt_total.Text = "0";
            txtDiskon.Text = "0";
            txtKembali.Clear();
            txtBayar.Clear();
            txtAkhir.Clear();
            lstJual.Items.Clear();
            txtPengunjung.Text = "P00001";
            txtPoint.Text = "0";
            txtMekanik.Clear();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            if (lstJual.Items.Count != 0 && txtBayar.Text != "" && txtMekanik.Text != "") 
            { 
                if (int.Parse(txtBayar.Text) >= int.Parse(txtAkhir.Text)) 
                {
                    String sql = "SELECT * " +
                                 "FROM penjualan1 " +
                                 "WHERE kd_jual = '" + txtRiwayat.Text + "'";
                        cmd = new SqlCommand(sql, conn);
                        reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            KurangPoint();
                            DapatPoint();
                            sql = "UPDATE penjualan1 " +
                                  "SET waktu_jual = '" + dateTimePicker1.Value.ToString("MM-dd-yyyy hh:mm:ss") + "'," +
                                  "total_harga = " + txt_total.Text + ", bayar = '" + txtBayar.Text + "', kembali = '" +
                                  txtKembali.Text + "', diskon = '" + txtDiskon.Text + "', pengunjung_id = '" +
                                  txtPengunjung.Text + "' , total_akhir = '" +
                                  txtAkhir.Text + "', id_mekanik = '" + txtMekanik.Text +"' WHERE kd_jual = '" + txtRiwayat.Text + "'";
                            reader.Close();
                            cmd = new SqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();



                            int n = lstJual.Items.Count - 1;
                            for (int i = 0; i <= n; i++)
                            {
                                string a = "SELECT * from penjualan2 where kd_jual = '" + txtRiwayat.Text +
                                           "' and id_item = '" + lstJual.Items[i].SubItems[0].Text +
                                           "' and id_item like 'B%'";
                                cmd = new SqlCommand(a, conn);
                                reader = cmd.ExecuteReader();
                                reader.Read();

                                if (reader.HasRows)
                                {
                                    string sql2 = "UPDATE barang SET STOCK += " + reader["qty"].ToString() +
                                                  " WHERE ID_BARANG = '" +
                                                  lstJual.Items[i].SubItems[0].Text + "' ";
                                    reader.Close();
                                    cmd = new SqlCommand(sql2, conn);
                                    cmd.ExecuteNonQuery();
                                }
                                else
                                {
                                    reader.Close();
                                }
                            }

                            string sqll = "DELETE FROM penjualan2 WHERE kd_jual ='" + txtRiwayat.Text + "'";
                            cmd = new SqlCommand(sqll, conn);
                            cmd.ExecuteNonQuery();

                            for (int i = 0; i <= n; i++)
                            {
                                sql = "INSERT INTO penjualan2 " +
                                      "VALUES('" + txtRiwayat.Text + "','" +
                                      lstJual.Items[i].SubItems[0].Text + "'," +
                                      lstJual.Items[i].SubItems[2].Text + "," +
                                      lstJual.Items[i].SubItems[3].Text + "," +
                                      lstJual.Items[i].SubItems[4].Text + ")";
                                cmd = new SqlCommand(sql, conn);
                                cmd.ExecuteNonQuery();


                                if (lstJual.Items[i].SubItems[0].Text.Substring(0, 1) == "B")
                                {
                                    string sql1 = "UPDATE barang SET stock -= " + lstJual.Items[i].SubItems[3].Text +
                                                  " where id_barang = '" + lstJual.Items[i].SubItems[0].Text + "'";

                                    cmd = new SqlCommand(sql1, conn);
                                    cmd.ExecuteNonQuery();
                                }

                            }
                        }
                        else
                        {
                            AutoNumber();
                            DapatPoint();
                            txtRiwayat.Text = KodeAuto;
                            sql = "INSERT INTO penjualan1 " +
                                  "VALUES('" + txtRiwayat.Text + "','" +
                                  dateTimePicker1.Value.ToString("MM-dd-yyyy hh:mm:ss") + "'," + txt_total.Text + "," +
                                  txtBayar.Text + ",'" + txtKembali.Text + "', '" +txtDiskon.Text + "' , '" + txtPengunjung.Text + "', '"+ txtAkhir.Text +"' ,'" + txtMekanik.Text +"')";
                            reader.Close();
                            cmd = new SqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();

                            int n = lstJual.Items.Count - 1;
                            for (int i = 0; i <= n; i++)
                            {
                                sql = "INSERT INTO penjualan2 " +
                                      "VALUES('" + txtRiwayat.Text + "','" +
                                      lstJual.Items[i].SubItems[0].Text + "'," +
                                      lstJual.Items[i].SubItems[2].Text + "," +
                                      lstJual.Items[i].SubItems[3].Text + "," +
                                      lstJual.Items[i].SubItems[4].Text + ")";
                                cmd = new SqlCommand(sql, conn);
                                cmd.ExecuteNonQuery();


                                if (lstJual.Items[i].SubItems[0].Text.Substring(0, 1) == "B")
                                {
                                    string sql1 = "UPDATE barang SET stock -= " + lstJual.Items[i].SubItems[3].Text +
                                                  " where id_barang = '" + lstJual.Items[i].SubItems[0].Text + "'";

                                    cmd = new SqlCommand(sql1, conn);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        Program.id_faktur = txtRiwayat.Text;
                        clear();
                        conn.Close();
                        MessageBox.Show("Barang Sudah Disimpan");

                        Form Cetak= new CetakFaktur();
                        Cetak.Show();
                }
                else 
                {
                        string message = "Jumlah Uang Yang Dimasukkan Kurang";
                        string title = "Uang Kurang";
                        MessageBox.Show(message, title);
                }
            }
            else
            {
                    string message = "Lengkapi Data Terlebih Dahulu";
                    string title = "Data Tidak Lengkap";
                    MessageBox.Show(message, title);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AutoNumber();
            txtRiwayat.Text = KodeAuto;
        }

        private void txtBayar_TextChanged(object sender, EventArgs e)
        {
            kembali();
        }

        private void txtBayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Hanya Bisa Angka");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txtRiwayat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                RiwayatPenjualan frmsearch_trs = new RiwayatPenjualan();
                frmsearch_trs.ShowDialog();
                txtRiwayat.Text = Program.id_jual;
                SendKeys.Send("{Tab}");
            }
        }

        private void txtRiwayat_Validated(object sender, EventArgs e)
        {
            if ((txtRiwayat.Text.Length != 0) && (txtRiwayat.Text != "PRESS"))
            {
                lstJual.Items.Clear();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string sql = "SELECT * " +
                             "FROM penjualan1 " +
                             "WHERE kd_jual = '" + txtRiwayat.Text + "'";
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    dateTimePicker1.Value = Convert.ToDateTime(reader["waktu_jual"]);
                    txt_total.Text = reader["total_harga"].ToString();
                    txtPengunjung.Text = reader["pengunjung_id"].ToString();
                    txtDiskon.Text = reader["diskon"].ToString();
                    txtAkhir.Text = reader["total_akhir"].ToString();
                    txtKembali.Text = reader["kembali"].ToString();
                    txtBayar.Text = reader["bayar"].ToString();
                    txtMekanik.Text = reader["id_mekanik"].ToString();



                }
                reader.Close();


                sql = "SELECT * " +
                      "FROM pengunjung " +
                      "WHERE id_pengunjung = '" + txtPengunjung.Text + "'";
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    txtPoint.Text = reader["point"].ToString();
                }

                reader.Close();

                sql = "SELECT * FROM PENJUALAN2 a " +
                      "inner join jasa j " +
                      "on a.id_item = j.id_jasa " +
                      "where a.kd_jual = '"+ txtRiwayat.Text +"'  and id_item like 'J%'";
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    ListViewItem item;
                    while (reader.Read())
                    {
                        item = new ListViewItem();
                        item.Text = reader["id_item"].ToString();
                        item.SubItems.Add(reader["nama_jasa"].ToString());
                        item.SubItems.Add(reader["harga_jual"].ToString());
                        item.SubItems.Add(reader["qty"].ToString());
                        item.SubItems.Add(reader["sub_total"].ToString());
                        lstJual.Items.Add(item);
                    }
                }
                reader.Close();

                string sqll = "SELECT * FROM PENJUALAN2 a " +
                      "inner join barang b " +
                      "on a.id_item = b.id_barang " +
                      "where a.kd_jual = '" + txtRiwayat.Text + "'  and id_item like 'B%'";
                cmd = new SqlCommand(sqll, conn);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    ListViewItem item;
                    while (reader.Read())
                    {
                        item = new ListViewItem();
                        item.Text = reader["id_item"].ToString();
                        item.SubItems.Add(reader["nama_barang"].ToString());
                        item.SubItems.Add(reader["harga_jual"].ToString());
                        item.SubItems.Add(reader["qty"].ToString());
                        item.SubItems.Add(reader["sub_total"].ToString());
                        lstJual.Items.Add(item);
                    }
                }
                reader.Close();

               kembali();
            }
        }

        private void kembali()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            if (string.IsNullOrEmpty(txtBayar.Text))
            {

            }
            else
            { 
                txtKembali.Text =
                        Convert.ToString(Convert.ToDouble(txtBayar.Text) - Convert.ToDouble(txtAkhir.Text));
            }
        }
        

        private void txtPengunjung_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                listPengunjung frmsearch_trs = new listPengunjung();
                frmsearch_trs.ShowDialog();
            }

            txtPengunjung.Text = Program.id_pengunjung;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string sql = "SELECT * " +
                         "FROM pengunjung " +
                         "WHERE id_pengunjung = '" + txtPengunjung.Text + "'";
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                txtPoint.Text = reader["point"].ToString();
            }

            reader.Close();

            diskon();
        }

        private void txt_total_akhir_TextChanged(object sender, EventArgs e)
        {
            kembali();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                ListMekanik frmsearch_trs = new ListMekanik();
                frmsearch_trs.ShowDialog();
            }

            txtMekanik.Text = Program.id_mekanik;
        }
    }
}
