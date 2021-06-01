
namespace BENGKEL
{
    partial class pengunjung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pengunjung));
            this.lsvPengunjung = new System.Windows.Forms.ListView();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idPengunjung = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtPengunjung = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNoHp = new System.Windows.Forms.TextBox();
            this.txtMotor = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.RichTextBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.txtNomor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvPengunjung
            // 
            this.lsvPengunjung.HideSelection = false;
            this.lsvPengunjung.Location = new System.Drawing.Point(12, 32);
            this.lsvPengunjung.Name = "lsvPengunjung";
            this.lsvPengunjung.Size = new System.Drawing.Size(726, 257);
            this.lsvPengunjung.TabIndex = 37;
            this.lsvPengunjung.UseCompatibleStateImageBehavior = false;
            this.lsvPengunjung.SelectedIndexChanged += new System.EventHandler(this.lsvJasa_SelectedIndexChanged);
            this.lsvPengunjung.DoubleClick += new System.EventHandler(this.lsvPengunjung_DoubleClick);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(198, 245);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 35;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(117, 245);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 34;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nama Pengunjung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "ID Pengunjung";
            // 
            // txt_idPengunjung
            // 
            this.txt_idPengunjung.Location = new System.Drawing.Point(116, 14);
            this.txt_idPengunjung.Name = "txt_idPengunjung";
            this.txt_idPengunjung.ReadOnly = true;
            this.txt_idPengunjung.Size = new System.Drawing.Size(172, 20);
            this.txt_idPengunjung.TabIndex = 30;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(36, 245);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 29;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtPengunjung
            // 
            this.txtPengunjung.Location = new System.Drawing.Point(116, 50);
            this.txtPengunjung.Name = "txtPengunjung";
            this.txtPengunjung.Size = new System.Drawing.Size(172, 20);
            this.txtPengunjung.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tipe Motor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "No HP";
            // 
            // txtNoHp
            // 
            this.txtNoHp.Location = new System.Drawing.Point(116, 139);
            this.txtNoHp.Name = "txtNoHp";
            this.txtNoHp.Size = new System.Drawing.Size(172, 20);
            this.txtNoHp.TabIndex = 41;
            this.txtNoHp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoHp_KeyPress);
            // 
            // txtMotor
            // 
            this.txtMotor.Location = new System.Drawing.Point(116, 174);
            this.txtMotor.Name = "txtMotor";
            this.txtMotor.Size = new System.Drawing.Size(172, 20);
            this.txtMotor.TabIndex = 42;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(116, 85);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(172, 39);
            this.txtAlamat.TabIndex = 43;
            this.txtAlamat.Text = "";
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(581, 6);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(157, 20);
            this.txtCari.TabIndex = 44;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // txtNomor
            // 
            this.txtNomor.Location = new System.Drawing.Point(116, 209);
            this.txtNomor.Name = "txtNomor";
            this.txtNomor.Size = new System.Drawing.Size(172, 20);
            this.txtNomor.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Nomor Kendaraan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(324, 24);
            this.label7.TabIndex = 47;
            this.label7.Text = "Pendaftaran Member Pengunjung";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(541, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Cari : ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtNomor);
            this.groupBox1.Controls.Add(this.txtPengunjung);
            this.groupBox1.Controls.Add(this.btnSimpan);
            this.groupBox1.Controls.Add(this.txt_idPengunjung);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAlamat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMotor);
            this.groupBox1.Controls.Add(this.btnHapus);
            this.groupBox1.Controls.Add(this.txtNoHp);
            this.groupBox1.Controls.Add(this.btnClean);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(745, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 283);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // pengunjung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BENGKEL.Properties.Resources.abstract_blue_white_wallpaper__1_;
            this.ClientSize = new System.Drawing.Size(1045, 294);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.lsvPengunjung);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pengunjung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pendaftaran Member Pengunjung";
            this.Load += new System.EventHandler(this.pengunjung_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvPengunjung;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idPengunjung;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtPengunjung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNoHp;
        private System.Windows.Forms.TextBox txtMotor;
        private System.Windows.Forms.RichTextBox txtAlamat;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.TextBox txtNomor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}