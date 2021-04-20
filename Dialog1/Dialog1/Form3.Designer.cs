
namespace Dialog1
{
    partial class frmColorDialog
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblTeks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ubah &Warna Teks";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTeks
            // 
            this.lblTeks.AutoSize = true;
            this.lblTeks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeks.Location = new System.Drawing.Point(12, 20);
            this.lblTeks.Name = "lblTeks";
            this.lblTeks.Size = new System.Drawing.Size(300, 22);
            this.lblTeks.TabIndex = 1;
            this.lblTeks.Text = "Teks untuk ekperimen Class Color Dialog";
            this.lblTeks.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmColorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 95);
            this.Controls.Add(this.lblTeks);
            this.Controls.Add(this.button1);
            this.Name = "frmColorDialog";
            this.Text = "Property dan Metoda Class ColorDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblTeks;
    }
}