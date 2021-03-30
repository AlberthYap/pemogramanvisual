
namespace QuisUTS
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbox = new System.Windows.Forms.ListBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.txtIsi = new System.Windows.Forms.TextBox();
            this.cbAsuransi = new System.Windows.Forms.CheckBox();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.cbZakat = new System.Windows.Forms.CheckBox();
            this.cbPPH = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gaji";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbox
            // 
            this.lbox.FormattingEnabled = true;
            this.lbox.Location = new System.Drawing.Point(251, 71);
            this.lbox.Name = "lbox";
            this.lbox.Size = new System.Drawing.Size(201, 108);
            this.lbox.TabIndex = 1;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(121, 59);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(59, 17);
            this.rb1.TabIndex = 2;
            this.rb1.TabStop = true;
            this.rb1.Text = "1 Anak";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // txtIsi
            // 
            this.txtIsi.Location = new System.Drawing.Point(121, 18);
            this.txtIsi.Name = "txtIsi";
            this.txtIsi.Size = new System.Drawing.Size(100, 20);
            this.txtIsi.TabIndex = 3;
            this.txtIsi.TextChanged += new System.EventHandler(this.txtIsi_TextChanged);
            // 
            // cbAsuransi
            // 
            this.cbAsuransi.AutoSize = true;
            this.cbAsuransi.Location = new System.Drawing.Point(313, 20);
            this.cbAsuransi.Name = "cbAsuransi";
            this.cbAsuransi.Size = new System.Drawing.Size(66, 17);
            this.cbAsuransi.TabIndex = 4;
            this.cbAsuransi.Text = "Asuransi";
            this.cbAsuransi.UseVisualStyleBackColor = true;
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
            this.cmb.Location = new System.Drawing.Point(113, 158);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(121, 21);
            this.cmb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tunjangan Anak";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tunjungan Golongan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Potongan";
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(121, 82);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(59, 17);
            this.rb2.TabIndex = 9;
            this.rb2.TabStop = true;
            this.rb2.Text = "2 Anak";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(121, 105);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(59, 17);
            this.rb3.TabIndex = 10;
            this.rb3.TabStop = true;
            this.rb3.Text = "3 Anak";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(121, 128);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(82, 17);
            this.rb4.TabIndex = 11;
            this.rb4.TabStop = true;
            this.rb4.Text = "Lebih Dari 3";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // cbZakat
            // 
            this.cbZakat.AutoSize = true;
            this.cbZakat.Location = new System.Drawing.Point(313, 43);
            this.cbZakat.Name = "cbZakat";
            this.cbZakat.Size = new System.Drawing.Size(54, 17);
            this.cbZakat.TabIndex = 12;
            this.cbZakat.Text = "Zakat";
            this.cbZakat.UseVisualStyleBackColor = true;
            // 
            // cbPPH
            // 
            this.cbPPH.AutoSize = true;
            this.cbPPH.Location = new System.Drawing.Point(385, 20);
            this.cbPPH.Name = "cbPPH";
            this.cbPPH.Size = new System.Drawing.Size(48, 17);
            this.cbPPH.TabIndex = 13;
            this.cbPPH.Text = "PPH";
            this.cbPPH.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "Hitung";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 263);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbPPH);
            this.Controls.Add(this.cbZakat);
            this.Controls.Add(this.rb4);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.cbAsuransi);
            this.Controls.Add(this.txtIsi);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.lbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbox;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.TextBox txtIsi;
        private System.Windows.Forms.CheckBox cbAsuransi;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.CheckBox cbZakat;
        private System.Windows.Forms.CheckBox cbPPH;
        private System.Windows.Forms.Button button1;
    }
}

