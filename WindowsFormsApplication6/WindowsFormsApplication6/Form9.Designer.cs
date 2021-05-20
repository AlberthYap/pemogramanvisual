namespace WindowsFormsApplication6
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPoliklinikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPasienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.dataTindakanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataObatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trsPendaftaranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.trsPerawatanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.trsPembayaranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lapRegistrasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lapRiwayatPasienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lapPembayaranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataMasterToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.laporanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(426, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataMasterToolStripMenuItem
            // 
            this.dataMasterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataPegawaiToolStripMenuItem,
            this.dataPoliklinikToolStripMenuItem,
            this.dataPasienToolStripMenuItem,
            this.toolStripMenuItem1,
            this.dataTindakanToolStripMenuItem,
            this.dataObatToolStripMenuItem});
            this.dataMasterToolStripMenuItem.Name = "dataMasterToolStripMenuItem";
            this.dataMasterToolStripMenuItem.Size = new System.Drawing.Size(120, 29);
            this.dataMasterToolStripMenuItem.Text = "Data Master";
            // 
            // dataPegawaiToolStripMenuItem
            // 
            this.dataPegawaiToolStripMenuItem.Image = global::WindowsFormsApplication6.Properties.Resources.gimp_prefs_folders;
            this.dataPegawaiToolStripMenuItem.Name = "dataPegawaiToolStripMenuItem";
            this.dataPegawaiToolStripMenuItem.Size = new System.Drawing.Size(209, 30);
            this.dataPegawaiToolStripMenuItem.Text = "Data Pegawai";
            this.dataPegawaiToolStripMenuItem.Click += new System.EventHandler(this.dataPegawaiToolStripMenuItem_Click);
            // 
            // dataPoliklinikToolStripMenuItem
            // 
            this.dataPoliklinikToolStripMenuItem.Image = global::WindowsFormsApplication6.Properties.Resources.gimp_prefs_folders_themes;
            this.dataPoliklinikToolStripMenuItem.Name = "dataPoliklinikToolStripMenuItem";
            this.dataPoliklinikToolStripMenuItem.Size = new System.Drawing.Size(209, 30);
            this.dataPoliklinikToolStripMenuItem.Text = "Data Poliklinik";
            // 
            // dataPasienToolStripMenuItem
            // 
            this.dataPasienToolStripMenuItem.Name = "dataPasienToolStripMenuItem";
            this.dataPasienToolStripMenuItem.Size = new System.Drawing.Size(209, 30);
            this.dataPasienToolStripMenuItem.Text = "Data Pasien";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(206, 6);
            // 
            // dataTindakanToolStripMenuItem
            // 
            this.dataTindakanToolStripMenuItem.Name = "dataTindakanToolStripMenuItem";
            this.dataTindakanToolStripMenuItem.Size = new System.Drawing.Size(209, 30);
            this.dataTindakanToolStripMenuItem.Text = "Data Tindakan";
            // 
            // dataObatToolStripMenuItem
            // 
            this.dataObatToolStripMenuItem.Name = "dataObatToolStripMenuItem";
            this.dataObatToolStripMenuItem.Size = new System.Drawing.Size(209, 30);
            this.dataObatToolStripMenuItem.Text = "Data Obat";
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trsPendaftaranToolStripMenuItem,
            this.toolStripMenuItem2,
            this.trsPerawatanToolStripMenuItem,
            this.toolStripMenuItem3,
            this.trsPembayaranToolStripMenuItem});
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // trsPendaftaranToolStripMenuItem
            // 
            this.trsPendaftaranToolStripMenuItem.Name = "trsPendaftaranToolStripMenuItem";
            this.trsPendaftaranToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.trsPendaftaranToolStripMenuItem.Text = "Trs Pendaftaran";
            this.trsPendaftaranToolStripMenuItem.Click += new System.EventHandler(this.trsPendaftaranToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(216, 6);
            // 
            // trsPerawatanToolStripMenuItem
            // 
            this.trsPerawatanToolStripMenuItem.Name = "trsPerawatanToolStripMenuItem";
            this.trsPerawatanToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.trsPerawatanToolStripMenuItem.Text = "Trs Perawatan";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(216, 6);
            // 
            // trsPembayaranToolStripMenuItem
            // 
            this.trsPembayaranToolStripMenuItem.Name = "trsPembayaranToolStripMenuItem";
            this.trsPembayaranToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.trsPembayaranToolStripMenuItem.Text = "Trs Pembayaran";
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lapRegistrasiToolStripMenuItem,
            this.lapRiwayatPasienToolStripMenuItem,
            this.lapPembayaranToolStripMenuItem});
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.laporanToolStripMenuItem.Text = "Laporan";
            // 
            // lapRegistrasiToolStripMenuItem
            // 
            this.lapRegistrasiToolStripMenuItem.Name = "lapRegistrasiToolStripMenuItem";
            this.lapRegistrasiToolStripMenuItem.Size = new System.Drawing.Size(246, 30);
            this.lapRegistrasiToolStripMenuItem.Text = "Lap Registrasi";
            // 
            // lapRiwayatPasienToolStripMenuItem
            // 
            this.lapRiwayatPasienToolStripMenuItem.Name = "lapRiwayatPasienToolStripMenuItem";
            this.lapRiwayatPasienToolStripMenuItem.Size = new System.Drawing.Size(246, 30);
            this.lapRiwayatPasienToolStripMenuItem.Text = "Lap Riwayat pasien";
            // 
            // lapPembayaranToolStripMenuItem
            // 
            this.lapPembayaranToolStripMenuItem.Name = "lapPembayaranToolStripMenuItem";
            this.lapPembayaranToolStripMenuItem.Size = new System.Drawing.Size(246, 30);
            this.lapPembayaranToolStripMenuItem.Text = "Lap Pembayaran";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator2,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 35);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(426, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::WindowsFormsApplication6.Properties.Resources.ang_direct;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::WindowsFormsApplication6.Properties.Resources.gimp_linked;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::WindowsFormsApplication6.Properties.Resources.gimp_prefs_folders;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form9";
            this.Text = "Form9";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPegawaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPoliklinikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPasienToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dataTindakanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataObatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trsPendaftaranToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem trsPerawatanToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem trsPembayaranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lapRegistrasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lapRiwayatPasienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lapPembayaranToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
    }
}