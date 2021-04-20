
namespace UTS_180010259
{
    partial class Biasa
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
            this.cmbKota = new System.Windows.Forms.ComboBox();
            this.rbBiasa = new System.Windows.Forms.RadioButton();
            this.rbKilat = new System.Windows.Forms.RadioButton();
            this.cbAsuransi = new System.Windows.Forms.CheckBox();
            this.cbDelivery = new System.Windows.Forms.CheckBox();
            this.nu = new System.Windows.Forms.NumericUpDown();
            this.cbSms = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProses = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nu)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKota
            // 
            this.cmbKota.FormattingEnabled = true;
            this.cmbKota.Items.AddRange(new object[] {
            "Denpasar",
            "Surabaya",
            "Jakarta",
            "Semarang",
            "Bandung"});
            this.cmbKota.Location = new System.Drawing.Point(118, 70);
            this.cmbKota.Name = "cmbKota";
            this.cmbKota.Size = new System.Drawing.Size(121, 21);
            this.cmbKota.TabIndex = 0;
            this.cmbKota.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rbBiasa
            // 
            this.rbBiasa.AutoSize = true;
            this.rbBiasa.Location = new System.Drawing.Point(118, 106);
            this.rbBiasa.Name = "rbBiasa";
            this.rbBiasa.Size = new System.Drawing.Size(51, 17);
            this.rbBiasa.TabIndex = 1;
            this.rbBiasa.TabStop = true;
            this.rbBiasa.Text = "Biasa";
            this.rbBiasa.UseVisualStyleBackColor = true;
            // 
            // rbKilat
            // 
            this.rbKilat.AutoSize = true;
            this.rbKilat.Location = new System.Drawing.Point(193, 106);
            this.rbKilat.Name = "rbKilat";
            this.rbKilat.Size = new System.Drawing.Size(45, 17);
            this.rbKilat.TabIndex = 2;
            this.rbKilat.TabStop = true;
            this.rbKilat.Text = "Kilat";
            this.rbKilat.UseVisualStyleBackColor = true;
            // 
            // cbAsuransi
            // 
            this.cbAsuransi.AutoSize = true;
            this.cbAsuransi.Location = new System.Drawing.Point(118, 192);
            this.cbAsuransi.Name = "cbAsuransi";
            this.cbAsuransi.Size = new System.Drawing.Size(66, 17);
            this.cbAsuransi.TabIndex = 4;
            this.cbAsuransi.Text = "Asuransi";
            this.cbAsuransi.UseVisualStyleBackColor = true;
            // 
            // cbDelivery
            // 
            this.cbDelivery.AutoSize = true;
            this.cbDelivery.Location = new System.Drawing.Point(118, 215);
            this.cbDelivery.Name = "cbDelivery";
            this.cbDelivery.Size = new System.Drawing.Size(64, 17);
            this.cbDelivery.TabIndex = 5;
            this.cbDelivery.Text = "Delivery";
            this.cbDelivery.UseVisualStyleBackColor = true;
            // 
            // nu
            // 
            this.nu.Location = new System.Drawing.Point(118, 142);
            this.nu.Name = "nu";
            this.nu.Size = new System.Drawing.Size(120, 20);
            this.nu.TabIndex = 6;
            this.nu.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // cbSms
            // 
            this.cbSms.AutoSize = true;
            this.cbSms.Location = new System.Drawing.Point(118, 238);
            this.cbSms.Name = "cbSms";
            this.cbSms.Size = new System.Drawing.Size(94, 17);
            this.cbSms.TabIndex = 7;
            this.cbSms.Text = "SMS Tracking";
            this.cbSms.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "-";
            // 
            // btnProses
            // 
            this.btnProses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProses.Location = new System.Drawing.Point(311, 215);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(129, 44);
            this.btnProses.TabIndex = 9;
            this.btnProses.Text = "Hitung";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(276, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(192, 95);
            this.listBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kota Tujuan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Berat Barang";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Jenis Kecepatan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-4, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fasilitas Pendukung";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(421, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Program Menghitung Biaya Pengiriman";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Keterangan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(296, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total : ";
            // 
            // Biasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(513, 274);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSms);
            this.Controls.Add(this.nu);
            this.Controls.Add(this.cbDelivery);
            this.Controls.Add(this.cbAsuransi);
            this.Controls.Add(this.rbKilat);
            this.Controls.Add(this.rbBiasa);
            this.Controls.Add(this.cmbKota);
            this.Name = "Biasa";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Biasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKota;
        private System.Windows.Forms.RadioButton rbBiasa;
        private System.Windows.Forms.RadioButton rbKilat;
        private System.Windows.Forms.CheckBox cbAsuransi;
        private System.Windows.Forms.CheckBox cbDelivery;
        private System.Windows.Forms.NumericUpDown nu;
        private System.Windows.Forms.CheckBox cbSms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

