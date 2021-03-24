
namespace _180010259_1
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
            this.CmbNegara = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnIbuKota = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbNegara
            // 
            this.CmbNegara.FormattingEnabled = true;
            this.CmbNegara.Items.AddRange(new object[] {
            "Indonesia",
            "India",
            "Amerika",
            "Prancis",
            "Spanyol"});
            this.CmbNegara.Location = new System.Drawing.Point(99, 14);
            this.CmbNegara.Name = "CmbNegara";
            this.CmbNegara.Size = new System.Drawing.Size(121, 23);
            this.CmbNegara.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pilih Negara";
            // 
            // BtnIbuKota
            // 
            this.BtnIbuKota.Location = new System.Drawing.Point(73, 63);
            this.BtnIbuKota.Name = "BtnIbuKota";
            this.BtnIbuKota.Size = new System.Drawing.Size(75, 23);
            this.BtnIbuKota.TabIndex = 2;
            this.BtnIbuKota.Text = "Ibu Kota";
            this.BtnIbuKota.UseVisualStyleBackColor = true;
            this.BtnIbuKota.Click += new System.EventHandler(this.BtnIbuKota_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 137);
            this.Controls.Add(this.BtnIbuKota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbNegara);
            this.Name = "Form2";
            this.Text = "IbuKota Negara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbNegara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnIbuKota;
    }
}