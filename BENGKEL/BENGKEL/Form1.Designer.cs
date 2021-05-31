
namespace BENGKEL
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.penjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daftarBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daftarJasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mekanikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengunjungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penjualanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cetakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penjualanToolStripMenuItem,
            this.laporanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // penjualanToolStripMenuItem
            // 
            this.penjualanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daftarBarangToolStripMenuItem,
            this.tambahStockToolStripMenuItem,
            this.daftarJasaToolStripMenuItem,
            this.mekanikToolStripMenuItem,
            this.pengunjungToolStripMenuItem,
            this.penjualanToolStripMenuItem1});
            this.penjualanToolStripMenuItem.Name = "penjualanToolStripMenuItem";
            this.penjualanToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.penjualanToolStripMenuItem.Text = "Penjualan";
            // 
            // daftarBarangToolStripMenuItem
            // 
            this.daftarBarangToolStripMenuItem.Name = "daftarBarangToolStripMenuItem";
            this.daftarBarangToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.daftarBarangToolStripMenuItem.Text = "Daftar Barang";
            this.daftarBarangToolStripMenuItem.Click += new System.EventHandler(this.daftarBarangToolStripMenuItem_Click);
            // 
            // tambahStockToolStripMenuItem
            // 
            this.tambahStockToolStripMenuItem.Name = "tambahStockToolStripMenuItem";
            this.tambahStockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tambahStockToolStripMenuItem.Text = "Pembelian Barang";
            this.tambahStockToolStripMenuItem.Click += new System.EventHandler(this.tambahStockToolStripMenuItem_Click);
            // 
            // daftarJasaToolStripMenuItem
            // 
            this.daftarJasaToolStripMenuItem.Name = "daftarJasaToolStripMenuItem";
            this.daftarJasaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.daftarJasaToolStripMenuItem.Text = "Daftar Jasa";
            this.daftarJasaToolStripMenuItem.Click += new System.EventHandler(this.daftarJasaToolStripMenuItem_Click);
            // 
            // mekanikToolStripMenuItem
            // 
            this.mekanikToolStripMenuItem.Name = "mekanikToolStripMenuItem";
            this.mekanikToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mekanikToolStripMenuItem.Text = "Mekanik";
            this.mekanikToolStripMenuItem.Click += new System.EventHandler(this.mekanikToolStripMenuItem_Click);
            // 
            // pengunjungToolStripMenuItem
            // 
            this.pengunjungToolStripMenuItem.Name = "pengunjungToolStripMenuItem";
            this.pengunjungToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pengunjungToolStripMenuItem.Text = "Pengunjung";
            this.pengunjungToolStripMenuItem.Click += new System.EventHandler(this.pengunjungToolStripMenuItem_Click);
            // 
            // penjualanToolStripMenuItem1
            // 
            this.penjualanToolStripMenuItem1.Name = "penjualanToolStripMenuItem1";
            this.penjualanToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.penjualanToolStripMenuItem1.Text = "Penjualan";
            this.penjualanToolStripMenuItem1.Click += new System.EventHandler(this.penjualanToolStripMenuItem1_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barangToolStripMenuItem,
            this.cetakToolStripMenuItem});
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.laporanToolStripMenuItem.Text = "Laporan";
            // 
            // barangToolStripMenuItem
            // 
            this.barangToolStripMenuItem.Name = "barangToolStripMenuItem";
            this.barangToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.barangToolStripMenuItem.Text = "Barang";
            this.barangToolStripMenuItem.Click += new System.EventHandler(this.barangToolStripMenuItem_Click);
            // 
            // cetakToolStripMenuItem
            // 
            this.cetakToolStripMenuItem.Name = "cetakToolStripMenuItem";
            this.cetakToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cetakToolStripMenuItem.Text = "Cetak";
            this.cetakToolStripMenuItem.Click += new System.EventHandler(this.cetakToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem penjualanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daftarBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daftarJasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mekanikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengunjungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penjualanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cetakToolStripMenuItem;
    }
}

