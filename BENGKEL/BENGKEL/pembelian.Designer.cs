
namespace BENGKEL
{
    partial class pembelian
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
            this.components = new System.ComponentModel.Container();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.txt_idBarang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBarang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.NumericUpDown();
            this.btn_Tambah = new System.Windows.Forms.Button();
            this.lstBeli = new System.Windows.Forms.ListView();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRiwayat = new System.Windows.Forms.TextBox();
            this.errorid = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorbarang = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorbarang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(610, 402);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 11;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tanggal Transaksi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Total Harga";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(398, 129);
            this.txtQty.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(55, 20);
            this.txtQty.TabIndex = 17;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(528, 402);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txt_idBarang
            // 
            this.txt_idBarang.Location = new System.Drawing.Point(10, 129);
            this.txt_idBarang.MaxLength = 5;
            this.txt_idBarang.Name = "txt_idBarang";
            this.txt_idBarang.ReadOnly = true;
            this.txt_idBarang.Size = new System.Drawing.Size(111, 20);
            this.txt_idBarang.TabIndex = 20;
            this.txt_idBarang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_idBarang_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Kode Barang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 9);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tekan F1 untuk memilih Barang";
            // 
            // txtBarang
            // 
            this.txtBarang.Location = new System.Drawing.Point(127, 129);
            this.txtBarang.Name = "txtBarang";
            this.txtBarang.ReadOnly = true;
            this.txtBarang.Size = new System.Drawing.Size(142, 20);
            this.txtBarang.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nama Barang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Harga Beli";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(398, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "QTY";
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(275, 129);
            this.txtHarga.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(117, 20);
            this.txtHarga.TabIndex = 27;
            // 
            // btn_Tambah
            // 
            this.btn_Tambah.Location = new System.Drawing.Point(469, 126);
            this.btn_Tambah.Name = "btn_Tambah";
            this.btn_Tambah.Size = new System.Drawing.Size(49, 23);
            this.btn_Tambah.TabIndex = 28;
            this.btn_Tambah.Text = "+";
            this.btn_Tambah.UseVisualStyleBackColor = true;
            this.btn_Tambah.Click += new System.EventHandler(this.btn_Tambah_Click);
            // 
            // lstBeli
            // 
            this.lstBeli.HideSelection = false;
            this.lstBeli.Location = new System.Drawing.Point(10, 175);
            this.lstBeli.Name = "lstBeli";
            this.lstBeli.Size = new System.Drawing.Size(675, 189);
            this.lstBeli.TabIndex = 29;
            this.lstBeli.UseCompatibleStateImageBehavior = false;
            this.lstBeli.DoubleClick += new System.EventHandler(this.lstBeli_DoubleClick);
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(551, 373);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(134, 20);
            this.txt_total.TabIndex = 30;
            this.txt_total.TextChanged += new System.EventHandler(this.txt_total_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(485, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Kode Pembelian";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 9);
            this.label4.TabIndex = 33;
            this.label4.Text = "Tekan F1 untuk melihat riwayat pembelian barang";
            // 
            // txtRiwayat
            // 
            this.txtRiwayat.Location = new System.Drawing.Point(113, 55);
            this.txtRiwayat.Name = "txtRiwayat";
            this.txtRiwayat.ReadOnly = true;
            this.txtRiwayat.Size = new System.Drawing.Size(192, 20);
            this.txtRiwayat.TabIndex = 34;
            this.txtRiwayat.Text = "PRESS";
            this.txtRiwayat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRiwayat_KeyDown);
            this.txtRiwayat.Validated += new System.EventHandler(this.txtRiwayat_Validated);
            // 
            // errorid
            // 
            this.errorid.ContainerControl = this;
            // 
            // errorbarang
            // 
            this.errorbarang.ContainerControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(246, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 24);
            this.label10.TabIndex = 35;
            this.label10.Text = "Pembelian Barang";
            // 
            // pembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(692, 434);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRiwayat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.lstBeli);
            this.Controls.Add(this.btn_Tambah);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBarang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_idBarang);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSimpan);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "pembelian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pembelian Barang";
            this.Load += new System.EventHandler(this.pembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorbarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtQty;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txt_idBarang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBarang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown txtHarga;
        private System.Windows.Forms.Button btn_Tambah;
        private System.Windows.Forms.ListView lstBeli;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRiwayat;
        private System.Windows.Forms.ErrorProvider errorid;
        private System.Windows.Forms.ErrorProvider errorbarang;
        private System.Windows.Forms.Label label10;
    }
}