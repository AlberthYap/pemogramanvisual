
namespace BENGKEL
{
    partial class penjualan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(penjualan));
            this.txtRiwayat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.lstJual = new System.Windows.Forms.ListView();
            this.btn_Tambah = new System.Windows.Forms.Button();
            this.txtHarga = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_idItem = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.NumericUpDown();
            this.txtTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtBayar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKembali = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiskon = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPengunjung = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAkhir = new System.Windows.Forms.TextBox();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMekanik = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtHarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRiwayat
            // 
            this.txtRiwayat.Location = new System.Drawing.Point(106, 13);
            this.txtRiwayat.Name = "txtRiwayat";
            this.txtRiwayat.ReadOnly = true;
            this.txtRiwayat.Size = new System.Drawing.Size(200, 20);
            this.txtRiwayat.TabIndex = 54;
            this.txtRiwayat.Text = "PRESS";
            this.txtRiwayat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRiwayat_KeyDown);
            this.txtRiwayat.Validated += new System.EventHandler(this.txtRiwayat_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 9);
            this.label4.TabIndex = 53;
            this.label4.Text = "Tekan F1 untuk melihat riwayat pembelian barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Kode Penjualan";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(106, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 51;
            // 
            // txt_total
            // 
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(104, 61);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(134, 22);
            this.txt_total.TabIndex = 50;
            this.txt_total.Text = "0";
            // 
            // lstJual
            // 
            this.lstJual.HideSelection = false;
            this.lstJual.Location = new System.Drawing.Point(12, 202);
            this.lstJual.Name = "lstJual";
            this.lstJual.Size = new System.Drawing.Size(677, 189);
            this.lstJual.TabIndex = 49;
            this.lstJual.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Tambah
            // 
            this.btn_Tambah.Location = new System.Drawing.Point(605, 32);
            this.btn_Tambah.Name = "btn_Tambah";
            this.btn_Tambah.Size = new System.Drawing.Size(49, 23);
            this.btn_Tambah.TabIndex = 48;
            this.btn_Tambah.Text = "+";
            this.btn_Tambah.UseVisualStyleBackColor = true;
            this.btn_Tambah.Click += new System.EventHandler(this.btn_Tambah_Click);
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(411, 35);
            this.txtHarga.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.ReadOnly = true;
            this.txtHarga.Size = new System.Drawing.Size(117, 20);
            this.txtHarga.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(534, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "QTY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(408, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Harga Beli";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Nama Barang";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(263, 35);
            this.txtItem.Name = "txtItem";
            this.txtItem.ReadOnly = true;
            this.txtItem.Size = new System.Drawing.Size(142, 20);
            this.txtItem.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(144, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 9);
            this.label6.TabIndex = 42;
            this.label6.Text = "Tekan F1 untuk memilih Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Kode Barang";
            // 
            // txt_idItem
            // 
            this.txt_idItem.Location = new System.Drawing.Point(146, 35);
            this.txt_idItem.MaxLength = 5;
            this.txt_idItem.Name = "txt_idItem";
            this.txt_idItem.ReadOnly = true;
            this.txt_idItem.Size = new System.Drawing.Size(111, 20);
            this.txt_idItem.TabIndex = 40;
            this.txt_idItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_idBarang_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(104, 130);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(534, 35);
            this.txtQty.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(55, 20);
            this.txtQty.TabIndex = 38;
            this.txtQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(18, 64);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(80, 16);
            this.txtTotal.TabIndex = 37;
            this.txtTotal.Text = "Total Harga";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tanggal Transaksi";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(185, 130);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 35;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtBayar
            // 
            this.txtBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBayar.Location = new System.Drawing.Point(14, 83);
            this.txtBayar.Name = "txtBayar";
            this.txtBayar.Size = new System.Drawing.Size(246, 35);
            this.txtBayar.TabIndex = 56;
            this.txtBayar.TextChanged += new System.EventHandler(this.txtBayar_TextChanged);
            this.txtBayar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBayar_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "Bayar";
            // 
            // txtKembali
            // 
            this.txtKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKembali.Location = new System.Drawing.Point(104, 95);
            this.txtKembali.Name = "txtKembali";
            this.txtKembali.ReadOnly = true;
            this.txtKembali.Size = new System.Drawing.Size(134, 22);
            this.txtKembali.TabIndex = 58;
            this.txtKembali.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(39, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 16);
            this.label11.TabIndex = 57;
            this.label11.Text = "Kembali";
            // 
            // txtDiskon
            // 
            this.txtDiskon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiskon.Location = new System.Drawing.Point(104, 23);
            this.txtDiskon.Name = "txtDiskon";
            this.txtDiskon.ReadOnly = true;
            this.txtDiskon.Size = new System.Drawing.Size(134, 22);
            this.txtDiskon.TabIndex = 60;
            this.txtDiskon.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(46, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 16);
            this.label12.TabIndex = 59;
            this.label12.Text = "Diskon";
            // 
            // txtPengunjung
            // 
            this.txtPengunjung.Location = new System.Drawing.Point(94, 19);
            this.txtPengunjung.Name = "txtPengunjung";
            this.txtPengunjung.ReadOnly = true;
            this.txtPengunjung.Size = new System.Drawing.Size(126, 20);
            this.txtPengunjung.TabIndex = 61;
            this.txtPengunjung.Text = "P00001";
            this.txtPengunjung.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPengunjung_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 9);
            this.label3.TabIndex = 62;
            this.label3.Text = "Tekan F1 untuk memilih Pengunjung";
            // 
            // txtAkhir
            // 
            this.txtAkhir.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAkhir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAkhir.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtAkhir.Location = new System.Drawing.Point(14, 28);
            this.txtAkhir.Name = "txtAkhir";
            this.txtAkhir.ReadOnly = true;
            this.txtAkhir.Size = new System.Drawing.Size(246, 35);
            this.txtAkhir.TabIndex = 64;
            this.txtAkhir.TextChanged += new System.EventHandler(this.txt_total_akhir_TextChanged);
            // 
            // txtPoint
            // 
            this.txtPoint.Location = new System.Drawing.Point(94, 54);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.ReadOnly = true;
            this.txtPoint.Size = new System.Drawing.Size(126, 20);
            this.txtPoint.TabIndex = 65;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(252, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 24);
            this.label13.TabIndex = 67;
            this.label13.Text = "Penjualan / Servis";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 68;
            this.label14.Text = "ID Pengunjung";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(57, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 69;
            this.label15.Text = "Point";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtRiwayat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(377, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 86);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtPengunjung);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtPoint);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(12, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 86);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtMekanik);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txt_idItem);
            this.groupBox3.Controls.Add(this.txtQty);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtItem);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtHarga);
            this.groupBox3.Controls.Add(this.btn_Tambah);
            this.groupBox3.Location = new System.Drawing.Point(12, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(677, 72);
            this.groupBox3.TabIndex = 72;
            this.groupBox3.TabStop = false;
            // 
            // txtMekanik
            // 
            this.txtMekanik.Location = new System.Drawing.Point(13, 35);
            this.txtMekanik.MaxLength = 5;
            this.txtMekanik.Name = "txtMekanik";
            this.txtMekanik.ReadOnly = true;
            this.txtMekanik.Size = new System.Drawing.Size(111, 20);
            this.txtMekanik.TabIndex = 49;
            this.txtMekanik.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 50;
            this.label16.Text = "Kode Mekanik";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(10, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(118, 9);
            this.label17.TabIndex = 51;
            this.label17.Text = "Tekan F1 untuk memilih Mekanik";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.txtDiskon);
            this.groupBox4.Controls.Add(this.txtTotal);
            this.groupBox4.Controls.Add(this.txt_total);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtKembali);
            this.groupBox4.Location = new System.Drawing.Point(12, 404);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 135);
            this.groupBox4.TabIndex = 73;
            this.groupBox4.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(14, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 13);
            this.label18.TabIndex = 74;
            this.label18.Text = "Total Akhir";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.btnSimpan);
            this.groupBox5.Controls.Add(this.txtAkhir);
            this.groupBox5.Controls.Add(this.btnClear);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txtBayar);
            this.groupBox5.Location = new System.Drawing.Point(419, 393);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(269, 158);
            this.groupBox5.TabIndex = 75;
            this.groupBox5.TabStop = false;
            // 
            // penjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::BENGKEL.Properties.Resources.abstract_blue_white_wallpaper__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(699, 556);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lstJual);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "penjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diskon";
            this.Load += new System.EventHandler(this.penjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtHarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRiwayat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.ListView lstJual;
        private System.Windows.Forms.Button btn_Tambah;
        private System.Windows.Forms.NumericUpDown txtHarga;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_idItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.NumericUpDown txtQty;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtBayar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKembali;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDiskon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPengunjung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAkhir;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMekanik;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}