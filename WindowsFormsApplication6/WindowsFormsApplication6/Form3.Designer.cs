namespace WindowsFormsApplication6
{
    partial class Form3
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
            this.lsvBarang = new System.Windows.Forms.ListView();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.TxtNama = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtBayar = new System.Windows.Forms.TextBox();
            this.txtKembali = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpTglTrs = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKodeTrs = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBaru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvBarang
            // 
            this.lsvBarang.HideSelection = false;
            this.lsvBarang.Location = new System.Drawing.Point(12, 96);
            this.lsvBarang.Name = "lsvBarang";
            this.lsvBarang.Size = new System.Drawing.Size(694, 201);
            this.lsvBarang.TabIndex = 0;
            this.lsvBarang.UseCompatibleStateImageBehavior = false;
            this.lsvBarang.SelectedIndexChanged += new System.EventHandler(this.lsvBarang_SelectedIndexChanged);
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(12, 70);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(56, 20);
            this.txtKode.TabIndex = 1;
            this.txtKode.TextChanged += new System.EventHandler(this.txtKode_TextChanged);
            this.txtKode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKode_KeyDown);
            // 
            // TxtNama
            // 
            this.TxtNama.Location = new System.Drawing.Point(74, 70);
            this.TxtNama.Name = "TxtNama";
            this.TxtNama.Size = new System.Drawing.Size(197, 20);
            this.TxtNama.TabIndex = 2;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(277, 70);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(100, 20);
            this.txtHarga.TabIndex = 3;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(383, 70);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(34, 20);
            this.txtQty.TabIndex = 4;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(423, 67);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 5;
            this.btnTambah.Text = "+";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Harga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Qty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(606, 316);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 11;
            // 
            // txtBayar
            // 
            this.txtBayar.Location = new System.Drawing.Point(606, 342);
            this.txtBayar.Name = "txtBayar";
            this.txtBayar.Size = new System.Drawing.Size(100, 20);
            this.txtBayar.TabIndex = 12;
            this.txtBayar.TextChanged += new System.EventHandler(this.txtBayar_TextChanged);
            this.txtBayar.Validated += new System.EventHandler(this.textBox2_Validated);
            // 
            // txtKembali
            // 
            this.txtKembali.Location = new System.Drawing.Point(606, 367);
            this.txtKembali.Name = "txtKembali";
            this.txtKembali.Size = new System.Drawing.Size(100, 20);
            this.txtKembali.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bayar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(523, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Kembali";
            // 
            // dtpTglTrs
            // 
            this.dtpTglTrs.Location = new System.Drawing.Point(506, 12);
            this.dtpTglTrs.Name = "dtpTglTrs";
            this.dtpTglTrs.Size = new System.Drawing.Size(200, 20);
            this.dtpTglTrs.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(405, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tanggal Transaksi";
            // 
            // txtKodeTrs
            // 
            this.txtKodeTrs.Location = new System.Drawing.Point(99, 18);
            this.txtKodeTrs.Name = "txtKodeTrs";
            this.txtKodeTrs.Size = new System.Drawing.Size(100, 20);
            this.txtKodeTrs.TabIndex = 18;
            this.txtKodeTrs.Text = "AUTO";
            this.txtKodeTrs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKodeTrs_KeyDown);
            this.txtKodeTrs.Validated += new System.EventHandler(this.txtKodeTrs_Validated);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Kode Transaksi";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(41, 342);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 20;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(124, 340);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 21;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnBaru
            // 
            this.btnBaru.Location = new System.Drawing.Point(214, 339);
            this.btnBaru.Name = "btnBaru";
            this.btnBaru.Size = new System.Drawing.Size(75, 23);
            this.btnBaru.TabIndex = 22;
            this.btnBaru.Text = "Baru";
            this.btnBaru.UseVisualStyleBackColor = true;
            this.btnBaru.Click += new System.EventHandler(this.btnBaru_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 399);
            this.Controls.Add(this.btnBaru);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtKodeTrs);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpTglTrs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKembali);
            this.Controls.Add(this.txtBayar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.TxtNama);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.lsvBarang);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvBarang;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.TextBox TxtNama;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtBayar;
        private System.Windows.Forms.TextBox txtKembali;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpTglTrs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKodeTrs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBaru;
    }
}