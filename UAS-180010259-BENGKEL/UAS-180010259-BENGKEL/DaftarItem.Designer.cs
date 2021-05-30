
namespace UAS_180010259_BENGKEL
{
    partial class DaftarItem
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
            this.txtBarang = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJual = new System.Windows.Forms.TextBox();
            this.txtBeli = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.txt_idBarang = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Barang";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // txtBarang
            // 
            this.txtBarang.Location = new System.Drawing.Point(124, 55);
            this.txtBarang.Name = "txtBarang";
            this.txtBarang.Size = new System.Drawing.Size(121, 20);
            this.txtBarang.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(332, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(285, 238);
            this.listBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Harga Beli";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Harga Jual";
            // 
            // txtJual
            // 
            this.txtJual.Location = new System.Drawing.Point(124, 134);
            this.txtJual.Name = "txtJual";
            this.txtJual.Size = new System.Drawing.Size(121, 20);
            this.txtJual.TabIndex = 6;
            // 
            // txtBeli
            // 
            this.txtBeli.Location = new System.Drawing.Point(124, 93);
            this.txtBeli.Name = "txtBeli";
            this.txtBeli.Size = new System.Drawing.Size(121, 20);
            this.txtBeli.TabIndex = 7;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(54, 187);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 8;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(138, 187);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 9;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // txt_idBarang
            // 
            this.txt_idBarang.Location = new System.Drawing.Point(124, 12);
            this.txt_idBarang.Name = "txt_idBarang";
            this.txt_idBarang.Size = new System.Drawing.Size(100, 20);
            this.txt_idBarang.TabIndex = 10;
            // 
            // DaftarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 293);
            this.Controls.Add(this.txt_idBarang);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtBeli);
            this.Controls.Add(this.txtJual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtBarang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DaftarItem";
            this.Text = "Pendaftaran Item";
            this.Load += new System.EventHandler(this.DaftarItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBarang;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJual;
        private System.Windows.Forms.TextBox txtBeli;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.TextBox txt_idBarang;
    }
}