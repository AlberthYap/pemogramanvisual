
namespace _180010259_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblNilaiHuruf = new System.Windows.Forms.Label();
            this.TxtNilaiAngka = new System.Windows.Forms.TextBox();
            this.BtnProses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nilai Angka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nilai Huruf";
            // 
            // LblNilaiHuruf
            // 
            this.LblNilaiHuruf.AutoSize = true;
            this.LblNilaiHuruf.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblNilaiHuruf.Location = new System.Drawing.Point(100, 58);
            this.LblNilaiHuruf.Name = "LblNilaiHuruf";
            this.LblNilaiHuruf.Size = new System.Drawing.Size(72, 30);
            this.LblNilaiHuruf.TabIndex = 2;
            this.LblNilaiHuruf.Text = "label3";
            this.LblNilaiHuruf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtNilaiAngka
            // 
            this.TxtNilaiAngka.Location = new System.Drawing.Point(86, 19);
            this.TxtNilaiAngka.Name = "TxtNilaiAngka";
            this.TxtNilaiAngka.Size = new System.Drawing.Size(100, 23);
            this.TxtNilaiAngka.TabIndex = 3;
            // 
            // BtnProses
            // 
            this.BtnProses.Location = new System.Drawing.Point(61, 117);
            this.BtnProses.Name = "BtnProses";
            this.BtnProses.Size = new System.Drawing.Size(75, 23);
            this.BtnProses.TabIndex = 4;
            this.BtnProses.Text = "Proses";
            this.BtnProses.UseVisualStyleBackColor = true;
            this.BtnProses.Click += new System.EventHandler(this.BtnProses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 180);
            this.Controls.Add(this.BtnProses);
            this.Controls.Add(this.TxtNilaiAngka);
            this.Controls.Add(this.LblNilaiHuruf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Nilai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblNilaiHuruf;
        private System.Windows.Forms.TextBox TxtNilaiAngka;
        private System.Windows.Forms.Button BtnProses;
    }
}

