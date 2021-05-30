
namespace BENGKEL
{
    partial class RiwayatPembelian
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
            this.lsvRiwayat.Location = new System.Drawing.Point(12, 54);
            this.lsvRiwayat.Name = "lsvRiwayat";
            this.lsvRiwayat.Size = new System.Drawing.Size(354, 344);
            this.lsvRiwayat.TabIndex = 0;
            this.lsvRiwayat.UseCompatibleStateImageBehavior = false;
            this.lsvRiwayat.DoubleClick += new System.EventHandler(this.lsvRiwayat_DoubleClick);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(203, 28);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(163, 20);
            this.txtCari.TabIndex = 30;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // RiwayatPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 447);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.lsvRiwayat);
            this.Name = "RiwayatPembelian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RiwayatPembelian";
            this.Load += new System.EventHandler(this.RiwayatPembelian_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvRiwayat;
        private System.Windows.Forms.TextBox txtCari;
    }
}