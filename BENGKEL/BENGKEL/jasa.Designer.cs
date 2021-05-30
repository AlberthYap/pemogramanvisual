
namespace BENGKEL
{
    partial class jasa
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idJasa = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtJasa = new System.Windows.Forms.TextBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.lsvJasa = new System.Windows.Forms.ListView();
            this.txtJual = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Clean";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(101, 175);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 24;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Harga Jasa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nama Jasa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID Jasa";
            // 
            // txt_idJasa
            // 
            this.txt_idJasa.Location = new System.Drawing.Point(130, 69);
            this.txt_idJasa.Name = "txt_idJasa";
            this.txt_idJasa.ReadOnly = true;
            this.txt_idJasa.Size = new System.Drawing.Size(127, 20);
            this.txt_idJasa.TabIndex = 19;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(20, 175);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 18;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtJasa
            // 
            this.txtJasa.Location = new System.Drawing.Point(130, 105);
            this.txtJasa.Name = "txtJasa";
            this.txtJasa.Size = new System.Drawing.Size(127, 20);
            this.txtJasa.TabIndex = 17;
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(488, 32);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(163, 20);
            this.txtCari.TabIndex = 28;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // lsvJasa
            // 
            this.lsvJasa.HideSelection = false;
            this.lsvJasa.Location = new System.Drawing.Point(281, 58);
            this.lsvJasa.Name = "lsvJasa";
            this.lsvJasa.Size = new System.Drawing.Size(370, 150);
            this.lsvJasa.TabIndex = 27;
            this.lsvJasa.UseCompatibleStateImageBehavior = false;
            this.lsvJasa.DoubleClick += new System.EventHandler(this.lsvJasa_DoubleClick);
            // 
            // txtJual
            // 
            this.txtJual.Location = new System.Drawing.Point(130, 140);
            this.txtJual.Name = "txtJual";
            this.txtJual.Size = new System.Drawing.Size(127, 20);
            this.txtJual.TabIndex = 29;
            this.txtJual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJual_KeyPress);
            // 
            // jasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 261);
            this.Controls.Add(this.txtJual);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.lsvJasa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_idJasa);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtJasa);
            this.Name = "jasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "jasa";
            this.Load += new System.EventHandler(this.jasa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idJasa;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtJasa;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.ListView lsvJasa;
        private System.Windows.Forms.TextBox txtJual;
    }
}