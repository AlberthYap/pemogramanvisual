
namespace BENGKEL
{
    partial class mekanik
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
            this.txtMekanik = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.lsvMekanik = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idMekanik = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txt_nohp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.RichTextBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMekanik
            // 
            this.txtMekanik.Location = new System.Drawing.Point(126, 105);
            this.txtMekanik.Name = "txtMekanik";
            this.txtMekanik.Size = new System.Drawing.Size(200, 20);
            this.txtMekanik.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Clean";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(126, 211);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 24;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // lsvMekanik
            // 
            this.lsvMekanik.HideSelection = false;
            this.lsvMekanik.Location = new System.Drawing.Point(347, 68);
            this.lsvMekanik.Name = "lsvMekanik";
            this.lsvMekanik.Size = new System.Drawing.Size(446, 166);
            this.lsvMekanik.TabIndex = 23;
            this.lsvMekanik.UseCompatibleStateImageBehavior = false;
            this.lsvMekanik.DoubleClick += new System.EventHandler(this.lsvMekanik_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nama Mekanik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID Mekanik";
            // 
            // txt_idMekanik
            // 
            this.txt_idMekanik.Location = new System.Drawing.Point(126, 69);
            this.txt_idMekanik.Name = "txt_idMekanik";
            this.txt_idMekanik.ReadOnly = true;
            this.txt_idMekanik.Size = new System.Drawing.Size(200, 20);
            this.txt_idMekanik.TabIndex = 19;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(45, 211);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 18;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txt_nohp
            // 
            this.txt_nohp.Location = new System.Drawing.Point(126, 179);
            this.txt_nohp.Name = "txt_nohp";
            this.txt_nohp.Size = new System.Drawing.Size(200, 20);
            this.txt_nohp.TabIndex = 29;
            this.txt_nohp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nohp_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "NO HP";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(126, 140);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(200, 30);
            this.txtAlamat.TabIndex = 31;
            this.txtAlamat.Text = "";
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(630, 30);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(163, 20);
            this.txtCari.TabIndex = 32;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // mekanik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(805, 260);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txt_nohp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMekanik);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.lsvMekanik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_idMekanik);
            this.Controls.Add(this.btnSimpan);
            this.Name = "mekanik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mekanik";
            this.Load += new System.EventHandler(this.mekanik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMekanik;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.ListView lsvMekanik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idMekanik;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txt_nohp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtAlamat;
        private System.Windows.Forms.TextBox txtCari;
    }
}