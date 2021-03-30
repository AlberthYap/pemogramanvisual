
namespace Quis1
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
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rd4 = new System.Windows.Forms.RadioButton();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.txtIsi = new System.Windows.Forms.TextBox();
            this.cbAsuransi = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPPH = new System.Windows.Forms.CheckBox();
            this.cbZakat = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbox = new System.Windows.Forms.ListBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(121, 58);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(59, 17);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "1 Anak";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(121, 79);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(59, 17);
            this.rb2.TabIndex = 1;
            this.rb2.TabStop = true;
            this.rb2.Text = "2 Anak";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(121, 102);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(59, 17);
            this.rb3.TabIndex = 2;
            this.rb3.TabStop = true;
            this.rb3.Text = "3 Anak";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rd4
            // 
            this.rd4.AutoSize = true;
            this.rd4.Location = new System.Drawing.Point(121, 125);
            this.rd4.Name = "rd4";
            this.rd4.Size = new System.Drawing.Size(82, 17);
            this.rd4.TabIndex = 3;
            this.rd4.TabStop = true;
            this.rd4.Text = "Lebih Dari 3";
            this.rd4.UseVisualStyleBackColor = true;
            // 
            // cmb
            // 
            this.cmb.FormattingEnabled = true;
            this.cmb.Items.AddRange(new object[] {
            "Gol IA",
            "Gol IB",
            "Gol IC",
            "Gol IIA",
            "Gol IIB",
            "Gol IIC"});
            this.cmb.Location = new System.Drawing.Point(121, 161);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(121, 21);
            this.cmb.TabIndex = 4;
            // 
            // txtIsi
            // 
            this.txtIsi.Location = new System.Drawing.Point(121, 12);
            this.txtIsi.Name = "txtIsi";
            this.txtIsi.Size = new System.Drawing.Size(100, 20);
            this.txtIsi.TabIndex = 5;
            // 
            // cbAsuransi
            // 
            this.cbAsuransi.AutoSize = true;
            this.cbAsuransi.Location = new System.Drawing.Point(121, 213);
            this.cbAsuransi.Name = "cbAsuransi";
            this.cbAsuransi.Size = new System.Drawing.Size(66, 17);
            this.cbAsuransi.TabIndex = 6;
            this.cbAsuransi.Text = "Asuransi";
            this.cbAsuransi.UseVisualStyleBackColor = true;
            this.cbAsuransi.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gaji";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tunjangan Anak";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbPPH
            // 
            this.cbPPH.AutoSize = true;
            this.cbPPH.Location = new System.Drawing.Point(282, 213);
            this.cbPPH.Name = "cbPPH";
            this.cbPPH.Size = new System.Drawing.Size(48, 17);
            this.cbPPH.TabIndex = 9;
            this.cbPPH.Text = "PPH";
            this.cbPPH.UseVisualStyleBackColor = true;
            this.cbPPH.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbZakat
            // 
            this.cbZakat.AutoSize = true;
            this.cbZakat.Location = new System.Drawing.Point(206, 213);
            this.cbZakat.Name = "cbZakat";
            this.cbZakat.Size = new System.Drawing.Size(54, 17);
            this.cbZakat.TabIndex = 10;
            this.cbZakat.Text = "Zakat";
            this.cbZakat.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tunjangan Golongan";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Potongan";
            // 
            // lbox
            // 
            this.lbox.FormattingEnabled = true;
            this.lbox.Location = new System.Drawing.Point(293, 12);
            this.lbox.Name = "lbox";
            this.lbox.Size = new System.Drawing.Size(169, 186);
            this.lbox.TabIndex = 13;
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(121, 248);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(246, 39);
            this.btnHitung.TabIndex = 14;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 299);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.lbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbZakat);
            this.Controls.Add(this.cbPPH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAsuransi);
            this.Controls.Add(this.txtIsi);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.rd4);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rd4;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.TextBox txtIsi;
        private System.Windows.Forms.CheckBox cbAsuransi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbPPH;
        private System.Windows.Forms.CheckBox cbZakat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbox;
        private System.Windows.Forms.Button btnHitung;
    }
}

