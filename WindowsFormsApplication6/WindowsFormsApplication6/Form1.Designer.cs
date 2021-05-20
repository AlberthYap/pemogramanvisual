namespace WindowsFormsApplication6
{
    partial class Form1
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
            this.txtGapok = new System.Windows.Forms.TextBox();
            this.cmbGol = new System.Windows.Forms.ComboBox();
            this.rdb1Anak = new System.Windows.Forms.RadioButton();
            this.rdb2Anak = new System.Windows.Forms.RadioButton();
            this.rdb3Anak = new System.Windows.Forms.RadioButton();
            this.dtpAwal = new System.Windows.Forms.DateTimePicker();
            this.dtpAkhir = new System.Windows.Forms.DateTimePicker();
            this.lblHasil = new System.Windows.Forms.Label();
            this.btnHitung = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvGaji = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGaji)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGapok
            // 
            this.txtGapok.Location = new System.Drawing.Point(77, 16);
            this.txtGapok.Name = "txtGapok";
            this.txtGapok.Size = new System.Drawing.Size(100, 20);
            this.txtGapok.TabIndex = 0;
            // 
            // cmbGol
            // 
            this.cmbGol.FormattingEnabled = true;
            this.cmbGol.Items.AddRange(new object[] {
            "1A",
            "1B",
            "2A",
            "2B"});
            this.cmbGol.Location = new System.Drawing.Point(77, 49);
            this.cmbGol.Name = "cmbGol";
            this.cmbGol.Size = new System.Drawing.Size(121, 21);
            this.cmbGol.TabIndex = 1;
            // 
            // rdb1Anak
            // 
            this.rdb1Anak.AutoSize = true;
            this.rdb1Anak.Location = new System.Drawing.Point(77, 86);
            this.rdb1Anak.Name = "rdb1Anak";
            this.rdb1Anak.Size = new System.Drawing.Size(59, 17);
            this.rdb1Anak.TabIndex = 2;
            this.rdb1Anak.TabStop = true;
            this.rdb1Anak.Text = "1 Anak";
            this.rdb1Anak.UseVisualStyleBackColor = true;
            // 
            // rdb2Anak
            // 
            this.rdb2Anak.AutoSize = true;
            this.rdb2Anak.Location = new System.Drawing.Point(77, 109);
            this.rdb2Anak.Name = "rdb2Anak";
            this.rdb2Anak.Size = new System.Drawing.Size(59, 17);
            this.rdb2Anak.TabIndex = 3;
            this.rdb2Anak.TabStop = true;
            this.rdb2Anak.Text = "2 Anak";
            this.rdb2Anak.UseVisualStyleBackColor = true;
            // 
            // rdb3Anak
            // 
            this.rdb3Anak.AutoSize = true;
            this.rdb3Anak.Location = new System.Drawing.Point(77, 132);
            this.rdb3Anak.Name = "rdb3Anak";
            this.rdb3Anak.Size = new System.Drawing.Size(68, 17);
            this.rdb3Anak.TabIndex = 4;
            this.rdb3Anak.TabStop = true;
            this.rdb3Anak.Text = "> 2 Anak";
            this.rdb3Anak.UseVisualStyleBackColor = true;
            // 
            // dtpAwal
            // 
            this.dtpAwal.Location = new System.Drawing.Point(77, 164);
            this.dtpAwal.Name = "dtpAwal";
            this.dtpAwal.Size = new System.Drawing.Size(200, 20);
            this.dtpAwal.TabIndex = 5;
            // 
            // dtpAkhir
            // 
            this.dtpAkhir.Location = new System.Drawing.Point(77, 190);
            this.dtpAkhir.Name = "dtpAkhir";
            this.dtpAkhir.Size = new System.Drawing.Size(200, 20);
            this.dtpAkhir.TabIndex = 6;
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasil.Location = new System.Drawing.Point(109, 234);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(76, 25);
            this.lblHasil.TabIndex = 7;
            this.lblHasil.Text = "label1";
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(93, 282);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(924, 51);
            this.btnHitung.TabIndex = 8;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Gaji Pokok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Golongan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Anak";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Masa Kerja";
            // 
            // dgvGaji
            // 
            this.dgvGaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGaji.Location = new System.Drawing.Point(295, 12);
            this.dgvGaji.Name = "dgvGaji";
            this.dgvGaji.Size = new System.Drawing.Size(797, 198);
            this.dgvGaji.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 345);
            this.Controls.Add(this.dgvGaji);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.dtpAkhir);
            this.Controls.Add(this.dtpAwal);
            this.Controls.Add(this.rdb3Anak);
            this.Controls.Add(this.rdb2Anak);
            this.Controls.Add(this.rdb1Anak);
            this.Controls.Add(this.cmbGol);
            this.Controls.Add(this.txtGapok);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGaji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGapok;
        private System.Windows.Forms.ComboBox cmbGol;
        private System.Windows.Forms.RadioButton rdb1Anak;
        private System.Windows.Forms.RadioButton rdb2Anak;
        private System.Windows.Forms.RadioButton rdb3Anak;
        private System.Windows.Forms.DateTimePicker dtpAwal;
        private System.Windows.Forms.DateTimePicker dtpAkhir;
        private System.Windows.Forms.Label lblHasil;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvGaji;
    }
}

