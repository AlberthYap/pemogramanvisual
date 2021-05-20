namespace WindowsFormsApplication6
{
    partial class Form2
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
            this.dgvGaji = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHitung = new System.Windows.Forms.Button();
            this.txtGapok = new System.Windows.Forms.TextBox();
            this.txtTGol = new System.Windows.Forms.TextBox();
            this.txtTAnak = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGaji)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGaji
            // 
            this.dgvGaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGaji.Location = new System.Drawing.Point(40, 152);
            this.dgvGaji.Name = "dgvGaji";
            this.dgvGaji.Size = new System.Drawing.Size(616, 198);
            this.dgvGaji.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tunjangan Golongan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Gaji Pokok";
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(40, 374);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(648, 51);
            this.btnHitung.TabIndex = 15;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // txtGapok
            // 
            this.txtGapok.Location = new System.Drawing.Point(165, 26);
            this.txtGapok.Name = "txtGapok";
            this.txtGapok.Size = new System.Drawing.Size(100, 20);
            this.txtGapok.TabIndex = 14;
            // 
            // txtTGol
            // 
            this.txtTGol.Location = new System.Drawing.Point(165, 52);
            this.txtTGol.Name = "txtTGol";
            this.txtTGol.Size = new System.Drawing.Size(100, 20);
            this.txtTGol.TabIndex = 19;
            // 
            // txtTAnak
            // 
            this.txtTAnak.Location = new System.Drawing.Point(165, 78);
            this.txtTAnak.Name = "txtTAnak";
            this.txtTAnak.Size = new System.Drawing.Size(100, 20);
            this.txtTAnak.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tunjangan Anak";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 437);
            this.Controls.Add(this.txtTAnak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTGol);
            this.Controls.Add(this.dgvGaji);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.txtGapok);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGaji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGaji;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.TextBox txtGapok;
        private System.Windows.Forms.TextBox txtTGol;
        private System.Windows.Forms.TextBox txtTAnak;
        private System.Windows.Forms.Label label1;
    }
}