
namespace Tugas1
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
            this.btninput1 = new System.Windows.Forms.Button();
            this.btnInput2 = new System.Windows.Forms.Button();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.cmbPilih = new System.Windows.Forms.ComboBox();
            this.lblHasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btninput1
            // 
            this.btninput1.Location = new System.Drawing.Point(32, 72);
            this.btninput1.Name = "btninput1";
            this.btninput1.Size = new System.Drawing.Size(75, 23);
            this.btninput1.TabIndex = 0;
            this.btninput1.Text = "Input";
            this.btninput1.UseVisualStyleBackColor = true;
            this.btninput1.Click += new System.EventHandler(this.btninput1_Click);
            // 
            // btnInput2
            // 
            this.btnInput2.Location = new System.Drawing.Point(32, 195);
            this.btnInput2.Name = "btnInput2";
            this.btnInput2.Size = new System.Drawing.Size(75, 23);
            this.btnInput2.TabIndex = 1;
            this.btnInput2.Text = "Input";
            this.btnInput2.UseVisualStyleBackColor = true;
            this.btnInput2.Click += new System.EventHandler(this.btnInput2_Click);
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(32, 35);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(100, 20);
            this.txtInput1.TabIndex = 2;
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(32, 152);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(100, 20);
            this.txtInput2.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(153, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(153, 152);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 5;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(385, 35);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(132, 212);
            this.listBox3.TabIndex = 7;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(293, 72);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(75, 146);
            this.btnProses.TabIndex = 8;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // cmbPilih
            // 
            this.cmbPilih.FormattingEnabled = true;
            this.cmbPilih.Items.AddRange(new object[] {
            "Bilangan Terbesar",
            "Bilangan Terkecil",
            "Rata - Rata"});
            this.cmbPilih.Location = new System.Drawing.Point(217, 273);
            this.cmbPilih.Name = "cmbPilih";
            this.cmbPilih.Size = new System.Drawing.Size(121, 21);
            this.cmbPilih.TabIndex = 9;
            this.cmbPilih.Text = "Silahkan Pilih";
            this.cmbPilih.SelectedIndexChanged += new System.EventHandler(this.cmbPilih_SelectedIndexChanged);
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasil.Location = new System.Drawing.Point(267, 311);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(21, 24);
            this.lblHasil.TabIndex = 10;
            this.lblHasil.Text = "0";
            this.lblHasil.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 344);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.cmbPilih);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.txtInput1);
            this.Controls.Add(this.btnInput2);
            this.Controls.Add(this.btninput1);
            this.Name = "Form1";
            this.Text = "E-Class1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninput1;
        private System.Windows.Forms.Button btnInput2;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.ComboBox cmbPilih;
        private System.Windows.Forms.Label lblHasil;
    }
}

