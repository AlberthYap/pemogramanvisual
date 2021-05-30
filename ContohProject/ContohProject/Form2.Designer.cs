
namespace ContohProject
{
    partial class FormPegawai
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNIP = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.rdbLaki = new System.Windows.Forms.RadioButton();
            this.rdbPerempuan = new System.Windows.Forms.RadioButton();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Kelamin";
            // 
            // txtNIP
            // 
            this.txtNIP.Location = new System.Drawing.Point(106, 27);
            this.txtNIP.Name = "txtNIP";
            this.txtNIP.Size = new System.Drawing.Size(100, 20);
            this.txtNIP.TabIndex = 3;
            this.txtNIP.Validated += new System.EventHandler(this.txtNIP_Validated);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(106, 61);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(159, 20);
            this.txtNama.TabIndex = 4;
            // 
            // rdbLaki
            // 
            this.rdbLaki.AutoSize = true;
            this.rdbLaki.Location = new System.Drawing.Point(106, 98);
            this.rdbLaki.Name = "rdbLaki";
            this.rdbLaki.Size = new System.Drawing.Size(74, 17);
            this.rdbLaki.TabIndex = 5;
            this.rdbLaki.TabStop = true;
            this.rdbLaki.Text = "Laki - Laki";
            this.rdbLaki.UseVisualStyleBackColor = true;
            // 
            // rdbPerempuan
            // 
            this.rdbPerempuan.AutoSize = true;
            this.rdbPerempuan.Location = new System.Drawing.Point(186, 98);
            this.rdbPerempuan.Name = "rdbPerempuan";
            this.rdbPerempuan.Size = new System.Drawing.Size(79, 17);
            this.rdbPerempuan.TabIndex = 6;
            this.rdbPerempuan.TabStop = true;
            this.rdbPerempuan.Text = "Perempuan";
            this.rdbPerempuan.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(27, 142);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 7;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(117, 142);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 8;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(208, 142);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 9;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // FormPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 199);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.rdbPerempuan);
            this.Controls.Add(this.rdbLaki);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPegawai";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNIP;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.RadioButton rdbLaki;
        private System.Windows.Forms.RadioButton rdbPerempuan;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnKeluar;
    }
}