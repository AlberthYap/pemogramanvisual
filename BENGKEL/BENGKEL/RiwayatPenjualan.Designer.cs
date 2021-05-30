
namespace BENGKEL
{
    partial class RiwayatPenjualan
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
            this.lsvRiwayat = new System.Windows.Forms.ListView();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lsvRiwayat
            // 
            this.lsvRiwayat.HideSelection = false;
            this.lsvRiwayat.Location = new System.Drawing.Point(7, 90);
            this.lsvRiwayat.Name = "lsvRiwayat";
            this.lsvRiwayat.Size = new System.Drawing.Size(656, 344);
            this.lsvRiwayat.TabIndex = 1;
            this.lsvRiwayat.UseCompatibleStateImageBehavior = false;
            this.lsvRiwayat.SelectedIndexChanged += new System.EventHandler(this.lsvRiwayat_SelectedIndexChanged);
            this.lsvRiwayat.DoubleClick += new System.EventHandler(this.lsvRiwayat_DoubleClick);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(477, 50);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(186, 20);
            this.txtCari.TabIndex = 2;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // RiwayatPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 476);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.lsvRiwayat);
            this.Name = "RiwayatPenjualan";
            this.Text = "RiwayatPenjualan";
            this.Load += new System.EventHandler(this.RiwayatPenjualan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvRiwayat;
        private System.Windows.Forms.TextBox txtCari;
    }
}