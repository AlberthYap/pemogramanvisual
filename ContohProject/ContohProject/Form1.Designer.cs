
namespace ContohProject
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
            this.masterDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataDepartemenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataJabatanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterDataToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.laporanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(465, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterDataToolStripMenuItem
            // 
            this.masterDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataPegawaiToolStripMenuItem,
            this.dataDepartemenToolStripMenuItem,
            this.dataJabatanToolStripMenuItem});
            this.masterDataToolStripMenuItem.Name = "masterDataToolStripMenuItem";
            this.masterDataToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.masterDataToolStripMenuItem.Text = "Master Data";
            // 
            // dataPegawaiToolStripMenuItem
            // 
            this.dataPegawaiToolStripMenuItem.Name = "dataPegawaiToolStripMenuItem";
            this.dataPegawaiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataPegawaiToolStripMenuItem.Text = "Data Pegawai";
            this.dataPegawaiToolStripMenuItem.Click += new System.EventHandler(this.dataPegawaiToolStripMenuItem_Click);
            // 
            // dataDepartemenToolStripMenuItem
            // 
            this.dataDepartemenToolStripMenuItem.Name = "dataDepartemenToolStripMenuItem";
            this.dataDepartemenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataDepartemenToolStripMenuItem.Text = "Data Departemen";
            // 
            // dataJabatanToolStripMenuItem
            // 
            this.dataJabatanToolStripMenuItem.Name = "dataJabatanToolStripMenuItem";
            this.dataJabatanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataJabatanToolStripMenuItem.Text = "Data Jabatan";
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.laporanToolStripMenuItem.Text = "Laporan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 285);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPegawaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataDepartemenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataJabatanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
    }
}

