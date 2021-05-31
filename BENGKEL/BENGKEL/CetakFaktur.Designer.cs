
namespace BENGKEL
{
    partial class CetakFaktur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CetakFaktur));
            this.txt = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lsvFaktur = new System.Windows.Forms.ListView();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.txt_tanggal = new System.Windows.Forms.Label();
            this.txt_idPengunjung = new System.Windows.Forms.Label();
            this.txt_nama = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.Label();
            this.txt_noHP = new System.Windows.Forms.Label();
            this.txt_tipeMotor = new System.Windows.Forms.Label();
            this.txt_point = new System.Windows.Forms.Label();
            this.txt_nomorKendaraan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.Label();
            this.txt_diskon = new System.Windows.Forms.Label();
            this.txt_totalAkhir = new System.Windows.Forms.Label();
            this.txt_kembali = new System.Windows.Forms.Label();
            this.txt_bayar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(538, 361);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(69, 13);
            this.txt.TabIndex = 37;
            this.txt.Text = "Total Harga :";
            this.txt.Click += new System.EventHandler(this.txt_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(567, 427);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "Bayar : ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(561, 383);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Diskon :";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(557, 448);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "Kembali :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(320, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 24);
            this.label13.TabIndex = 76;
            this.label13.Text = "Faktur Servis";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // lsvFaktur
            // 
            this.lsvFaktur.HideSelection = false;
            this.lsvFaktur.Location = new System.Drawing.Point(54, 157);
            this.lsvFaktur.Name = "lsvFaktur";
            this.lsvFaktur.Size = new System.Drawing.Size(677, 189);
            this.lsvFaktur.TabIndex = 74;
            this.lsvFaktur.UseCompatibleStateImageBehavior = false;
            this.lsvFaktur.SelectedIndexChanged += new System.EventHandler(this.lsvFaktur_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(52, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 81;
            this.label16.Text = "Tanggal : ";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(63, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 82;
            this.label17.Text = "Nama : ";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(80, 63);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 13);
            this.label18.TabIndex = 83;
            this.label18.Text = "ID :  ";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(499, 39);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 13);
            this.label19.TabIndex = 84;
            this.label19.Text = "No Invoice : ";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(587, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 85;
            this.button1.Text = "INVOICE";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(531, 128);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 13);
            this.label22.TabIndex = 88;
            this.label22.Text = "Point : ";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(504, 83);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 13);
            this.label23.TabIndex = 89;
            this.label23.Text = "Tipe Motor :";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(469, 106);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(102, 13);
            this.label24.TabIndex = 90;
            this.label24.Text = "Nomor Kendaraan : ";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(59, 128);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(45, 13);
            this.label25.TabIndex = 91;
            this.label25.Text = "No HP :";
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(59, 106);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(45, 13);
            this.label26.TabIndex = 92;
            this.label26.Text = "Alamat :";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // txt_tanggal
            // 
            this.txt_tanggal.AutoSize = true;
            this.txt_tanggal.Location = new System.Drawing.Point(121, 39);
            this.txt_tanggal.Name = "txt_tanggal";
            this.txt_tanggal.Size = new System.Drawing.Size(55, 13);
            this.txt_tanggal.TabIndex = 93;
            this.txt_tanggal.Text = "Tanggal : ";
            this.txt_tanggal.Click += new System.EventHandler(this.txt_tanggal_Click);
            // 
            // txt_idPengunjung
            // 
            this.txt_idPengunjung.AutoSize = true;
            this.txt_idPengunjung.Location = new System.Drawing.Point(121, 63);
            this.txt_idPengunjung.Name = "txt_idPengunjung";
            this.txt_idPengunjung.Size = new System.Drawing.Size(30, 13);
            this.txt_idPengunjung.TabIndex = 94;
            this.txt_idPengunjung.Text = "ID :  ";
            this.txt_idPengunjung.Click += new System.EventHandler(this.txt_idPengunjung_Click);
            // 
            // txt_nama
            // 
            this.txt_nama.AutoSize = true;
            this.txt_nama.Location = new System.Drawing.Point(121, 83);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(44, 13);
            this.txt_nama.TabIndex = 95;
            this.txt_nama.Text = "Nama : ";
            this.txt_nama.Click += new System.EventHandler(this.txt_nama_Click);
            // 
            // txtAlamat
            // 
            this.txtAlamat.AutoSize = true;
            this.txtAlamat.Location = new System.Drawing.Point(121, 106);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(45, 13);
            this.txtAlamat.TabIndex = 96;
            this.txtAlamat.Text = "Alamat :";
            this.txtAlamat.Click += new System.EventHandler(this.txtAlamat_Click);
            // 
            // txt_noHP
            // 
            this.txt_noHP.AutoSize = true;
            this.txt_noHP.Location = new System.Drawing.Point(121, 128);
            this.txt_noHP.Name = "txt_noHP";
            this.txt_noHP.Size = new System.Drawing.Size(45, 13);
            this.txt_noHP.TabIndex = 97;
            this.txt_noHP.Text = "No HP :";
            this.txt_noHP.Click += new System.EventHandler(this.txt_noHP_Click);
            // 
            // txt_tipeMotor
            // 
            this.txt_tipeMotor.AutoSize = true;
            this.txt_tipeMotor.Location = new System.Drawing.Point(587, 83);
            this.txt_tipeMotor.Name = "txt_tipeMotor";
            this.txt_tipeMotor.Size = new System.Drawing.Size(64, 13);
            this.txt_tipeMotor.TabIndex = 98;
            this.txt_tipeMotor.Text = "Tipe Motor :";
            this.txt_tipeMotor.Click += new System.EventHandler(this.txt_tipeMotor_Click);
            // 
            // txt_point
            // 
            this.txt_point.AutoSize = true;
            this.txt_point.Location = new System.Drawing.Point(587, 128);
            this.txt_point.Name = "txt_point";
            this.txt_point.Size = new System.Drawing.Size(40, 13);
            this.txt_point.TabIndex = 99;
            this.txt_point.Text = "Point : ";
            this.txt_point.Click += new System.EventHandler(this.txt_point_Click);
            // 
            // txt_nomorKendaraan
            // 
            this.txt_nomorKendaraan.AutoSize = true;
            this.txt_nomorKendaraan.Location = new System.Drawing.Point(587, 106);
            this.txt_nomorKendaraan.Name = "txt_nomorKendaraan";
            this.txt_nomorKendaraan.Size = new System.Drawing.Size(102, 13);
            this.txt_nomorKendaraan.TabIndex = 100;
            this.txt_nomorKendaraan.Text = "Nomor Kendaraan : ";
            this.txt_nomorKendaraan.Click += new System.EventHandler(this.txt_nomorKendaraan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "Total Akhir : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 16);
            this.label2.TabIndex = 102;
            this.label2.Text = "Terima Kasih Telah Berkunjung";
            // 
            // txt_total
            // 
            this.txt_total.AutoSize = true;
            this.txt_total.Location = new System.Drawing.Point(620, 361);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(69, 13);
            this.txt_total.TabIndex = 103;
            this.txt_total.Text = "Total Harga :";
            this.txt_total.Click += new System.EventHandler(this.txt_total_Click);
            // 
            // txt_diskon
            // 
            this.txt_diskon.AutoSize = true;
            this.txt_diskon.Location = new System.Drawing.Point(620, 383);
            this.txt_diskon.Name = "txt_diskon";
            this.txt_diskon.Size = new System.Drawing.Size(46, 13);
            this.txt_diskon.TabIndex = 104;
            this.txt_diskon.Text = "Diskon :";
            this.txt_diskon.Click += new System.EventHandler(this.txt_diskon_Click);
            // 
            // txt_totalAkhir
            // 
            this.txt_totalAkhir.AutoSize = true;
            this.txt_totalAkhir.Location = new System.Drawing.Point(620, 406);
            this.txt_totalAkhir.Name = "txt_totalAkhir";
            this.txt_totalAkhir.Size = new System.Drawing.Size(67, 13);
            this.txt_totalAkhir.TabIndex = 105;
            this.txt_totalAkhir.Text = "Total Akhir : ";
            this.txt_totalAkhir.Click += new System.EventHandler(this.txt_totalAkhir_Click);
            // 
            // txt_kembali
            // 
            this.txt_kembali.AutoSize = true;
            this.txt_kembali.Location = new System.Drawing.Point(620, 448);
            this.txt_kembali.Name = "txt_kembali";
            this.txt_kembali.Size = new System.Drawing.Size(50, 13);
            this.txt_kembali.TabIndex = 106;
            this.txt_kembali.Text = "Kembali :";
            // 
            // txt_bayar
            // 
            this.txt_bayar.AutoSize = true;
            this.txt_bayar.Location = new System.Drawing.Point(620, 427);
            this.txt_bayar.Name = "txt_bayar";
            this.txt_bayar.Size = new System.Drawing.Size(43, 13);
            this.txt_bayar.TabIndex = 107;
            this.txt_bayar.Text = "Bayar : ";
            // 
            // CetakFaktur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(786, 473);
            this.Controls.Add(this.txt_bayar);
            this.Controls.Add(this.txt_kembali);
            this.Controls.Add(this.txt_totalAkhir);
            this.Controls.Add(this.txt_diskon);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nomorKendaraan);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_point);
            this.Controls.Add(this.txt_tipeMotor);
            this.Controls.Add(this.txt_noHP);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.txt_idPengunjung);
            this.Controls.Add(this.txt_tanggal);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lsvFaktur);
            this.Name = "CetakFaktur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CetakFaktur ";
            this.Load += new System.EventHandler(this.CetakFaktur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView lsvFaktur;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label txt_tanggal;
        private System.Windows.Forms.Label txt_idPengunjung;
        private System.Windows.Forms.Label txt_nama;
        private System.Windows.Forms.Label txtAlamat;
        private System.Windows.Forms.Label txt_noHP;
        private System.Windows.Forms.Label txt_tipeMotor;
        private System.Windows.Forms.Label txt_point;
        private System.Windows.Forms.Label txt_nomorKendaraan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_total;
        private System.Windows.Forms.Label txt_diskon;
        private System.Windows.Forms.Label txt_totalAkhir;
        private System.Windows.Forms.Label txt_kembali;
        private System.Windows.Forms.Label txt_bayar;
    }
}