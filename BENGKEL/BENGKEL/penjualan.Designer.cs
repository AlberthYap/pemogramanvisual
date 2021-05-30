
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtHarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRiwayat
            // 
            this.txtRiwayat.Location = new System.Drawing.Point(118, 22);
            this.txtRiwayat.Name = "txtRiwayat";
            this.txtRiwayat.ReadOnly = true;
            this.txtRiwayat.Size = new System.Drawing.Size(192, 20);
            this.txtRiwayat.TabIndex = 54;
            this.txtRiwayat.Text = "PRESS";
            this.txtRiwayat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRiwayat_KeyDown);
            this.txtRiwayat.Validated += new System.EventHandler(this.txtRiwayat_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 9);
            this.label4.TabIndex = 53;
            this.label4.Text = "Tekan F1 untuk melihat riwayat pembelian barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Kode Penjualan";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(492, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 51;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(601, 390);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(134, 20);
            this.txt_total.TabIndex = 50;
            this.txt_total.Text = "0";
            this.txt_total.TextChanged += new System.EventHandler(this.txt_total_TextChanged);
            // 
            // lstJual
            // 
            this.lstJual.HideSelection = false;
            this.lstJual.Location = new System.Drawing.Point(42, 153);
            this.lstJual.Name = "lstJual";
            this.lstJual.Size = new System.Drawing.Size(671, 189);
            this.lstJual.TabIndex = 49;
            this.lstJual.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Tambah
            // 
            this.btn_Tambah.Location = new System.Drawing.Point(603, 91);
            this.btn_Tambah.Name = "btn_Tambah";
            this.btn_Tambah.Size = new System.Drawing.Size(49, 23);
            this.btn_Tambah.TabIndex = 48;
            this.btn_Tambah.Text = "+";
            this.btn_Tambah.UseVisualStyleBackColor = true;
            this.btn_Tambah.Click += new System.EventHandler(this.btn_Tambah_Click);
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(409, 94);
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
            this.label9.Location = new System.Drawing.Point(532, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "QTY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Harga Beli";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Nama Barang";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(261, 94);
            this.txtItem.Name = "txtItem";
            this.txtItem.ReadOnly = true;
            this.txtItem.Size = new System.Drawing.Size(142, 20);
            this.txtItem.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(145, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 9);
            this.label6.TabIndex = 42;
            this.label6.Text = "Tekan F1 untuk memilih Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Kode Barang";
            // 
            // txt_idItem
            // 
            this.txt_idItem.Location = new System.Drawing.Point(144, 94);
            this.txt_idItem.MaxLength = 5;
            this.txt_idItem.Name = "txt_idItem";
            this.txt_idItem.ReadOnly = true;
            this.txt_idItem.Size = new System.Drawing.Size(111, 20);
            this.txt_idItem.TabIndex = 40;
            this.txt_idItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_idBarang_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(591, 475);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(532, 94);
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
            this.txtTotal.Location = new System.Drawing.Point(532, 393);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(63, 13);
            this.txtTotal.TabIndex = 37;
            this.txtTotal.Text = "Total Harga";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tanggal Transaksi";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(673, 475);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 35;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtBayar
            // 
            this.txtBayar.Location = new System.Drawing.Point(601, 416);
            this.txtBayar.Name = "txtBayar";
            this.txtBayar.Size = new System.Drawing.Size(134, 20);
            this.txtBayar.TabIndex = 56;
            this.txtBayar.TextChanged += new System.EventHandler(this.txtBayar_TextChanged);
            this.txtBayar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBayar_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(532, 419);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "Bayar";
            // 
            // txtKembali
            // 
            this.txtKembali.Location = new System.Drawing.Point(601, 442);
            this.txtKembali.Name = "txtKembali";
            this.txtKembali.ReadOnly = true;
            this.txtKembali.Size = new System.Drawing.Size(134, 20);
            this.txtKembali.TabIndex = 58;
            this.txtKembali.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(532, 445);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "Kembali";
            // 
            // txtDiskon
            // 
            this.txtDiskon.Location = new System.Drawing.Point(602, 361);
            this.txtDiskon.Name = "txtDiskon";
            this.txtDiskon.ReadOnly = true;
            this.txtDiskon.Size = new System.Drawing.Size(134, 20);
            this.txtDiskon.TabIndex = 60;
            this.txtDiskon.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(533, 364);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Diskon";
            // 
            // txtPengunjung
            // 
            this.txtPengunjung.Location = new System.Drawing.Point(15, 94);
            this.txtPengunjung.Name = "txtPengunjung";
            this.txtPengunjung.ReadOnly = true;
            this.txtPengunjung.Size = new System.Drawing.Size(100, 20);
            this.txtPengunjung.TabIndex = 61;
            this.txtPengunjung.Text = "P00001";
            this.txtPengunjung.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPengunjung_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 9);
            this.label3.TabIndex = 62;
            this.label3.Text = "Tekan F1 untuk memilih Barang";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 63;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // penjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPengunjung);
            this.Controls.Add(this.txtDiskon);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtKembali);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBayar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRiwayat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.lstJual);
            this.Controls.Add(this.btn_Tambah);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_idItem);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSimpan);
            this.Name = "penjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diskon";
            this.Load += new System.EventHandler(this.penjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtHarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).EndInit();
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
        private System.Windows.Forms.Button button1;
    }
}