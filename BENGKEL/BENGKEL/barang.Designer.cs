
namespace BENGKEL
{
    partial class barang
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
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txt_idBarang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstBarang = new System.Windows.Forms.ListView();
            this.btnHapus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBarang = new System.Windows.Forms.TextBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.txtJual = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(7, 157);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 3;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txt_idBarang
            // 
            this.txt_idBarang.Location = new System.Drawing.Point(117, 51);
            this.txt_idBarang.Name = "txt_idBarang";
            this.txt_idBarang.ReadOnly = true;
            this.txt_idBarang.Size = new System.Drawing.Size(127, 20);
            this.txt_idBarang.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nama Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Harga Jual";
            // 
            // lstBarang
            // 
            this.lstBarang.HideSelection = false;
            this.lstBarang.Location = new System.Drawing.Point(267, 40);
            this.lstBarang.Name = "lstBarang";
            this.lstBarang.Size = new System.Drawing.Size(413, 150);
            this.lstBarang.TabIndex = 10;
            this.lstBarang.UseCompatibleStateImageBehavior = false;
            this.lstBarang.DoubleClick += new System.EventHandler(this.lstBarang_DoubleClick);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(88, 157);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 11;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Clean";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBarang
            // 
            this.txtBarang.Location = new System.Drawing.Point(117, 87);
            this.txtBarang.Name = "txtBarang";
            this.txtBarang.Size = new System.Drawing.Size(127, 20);
            this.txtBarang.TabIndex = 17;
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(539, 14);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(141, 20);
            this.txtCari.TabIndex = 18;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // txtJual
            // 
            this.txtJual.Location = new System.Drawing.Point(117, 119);
            this.txtJual.Name = "txtJual";
            this.txtJual.Size = new System.Drawing.Size(127, 20);
            this.txtJual.TabIndex = 19;
            this.txtJual.TextChanged += new System.EventHandler(this.txtJual_TextChanged);
            this.txtJual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJual_KeyPress);
            // 
            // barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(694, 233);
            this.Controls.Add(this.txtJual);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.txtBarang);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.lstBarang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_idBarang);
            this.Controls.Add(this.btnSimpan);
            this.Name = "barang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "barang";
            this.Load += new System.EventHandler(this.barang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txt_idBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lstBarang;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBarang;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.TextBox txtJual;
    }
}