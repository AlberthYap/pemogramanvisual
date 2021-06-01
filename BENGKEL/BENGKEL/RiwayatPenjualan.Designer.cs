
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RiwayatPenjualan));
            this.lsvRiwayat = new System.Windows.Forms.ListView();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsvRiwayat
            // 
            this.lsvRiwayat.HideSelection = false;
            this.lsvRiwayat.Location = new System.Drawing.Point(11, 44);
            this.lsvRiwayat.Name = "lsvRiwayat";
            this.lsvRiwayat.Size = new System.Drawing.Size(797, 344);
            this.lsvRiwayat.TabIndex = 1;
            this.lsvRiwayat.UseCompatibleStateImageBehavior = false;
            this.lsvRiwayat.SelectedIndexChanged += new System.EventHandler(this.lsvRiwayat_SelectedIndexChanged);
            this.lsvRiwayat.DoubleClick += new System.EventHandler(this.lsvRiwayat_DoubleClick);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(622, 18);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(186, 20);
            this.txtCari.TabIndex = 2;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cari : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Riwayat Penjualan";
            // 
            // RiwayatPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BENGKEL.Properties.Resources.abstract_blue_white_wallpaper__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 393);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.lsvRiwayat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RiwayatPenjualan";
            this.Text = "Riwayat Penjualan";
            this.Load += new System.EventHandler(this.RiwayatPenjualan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvRiwayat;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}