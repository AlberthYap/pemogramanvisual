
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.penjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daftarBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daftarJasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mekanikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengunjungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penjualanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.barangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cetakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penjualanToolStripMenuItem,
            this.laporanToolStripMenuItem,
            this.penjualanToolStripMenuItem1,
            this.laporanToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1267, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // penjualanToolStripMenuItem
            // 
            this.penjualanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daftarBarangToolStripMenuItem,
            this.daftarJasaToolStripMenuItem,
            this.mekanikToolStripMenuItem,
            this.pengunjungToolStripMenuItem});
            this.penjualanToolStripMenuItem.Image = global::BENGKEL.Properties.Resources.add;
            this.penjualanToolStripMenuItem.Name = "penjualanToolStripMenuItem";
            this.penjualanToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.penjualanToolStripMenuItem.Text = "Tambah";
            this.penjualanToolStripMenuItem.Click += new System.EventHandler(this.penjualanToolStripMenuItem_Click);
            // 
            // daftarBarangToolStripMenuItem
            // 
            this.daftarBarangToolStripMenuItem.Image = global::BENGKEL.Properties.Resources.dangerous_goods;
            this.daftarBarangToolStripMenuItem.Name = "daftarBarangToolStripMenuItem";
            this.daftarBarangToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.daftarBarangToolStripMenuItem.Text = "Barang";
            this.daftarBarangToolStripMenuItem.Click += new System.EventHandler(this.daftarBarangToolStripMenuItem_Click);
            // 
            // daftarJasaToolStripMenuItem
            // 
            this.daftarJasaToolStripMenuItem.Image = global::BENGKEL.Properties.Resources.technical_support;
            this.daftarJasaToolStripMenuItem.Name = "daftarJasaToolStripMenuItem";
            this.daftarJasaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.daftarJasaToolStripMenuItem.Text = "Jasa";
            this.daftarJasaToolStripMenuItem.Click += new System.EventHandler(this.daftarJasaToolStripMenuItem_Click);
            // 
            // mekanikToolStripMenuItem
            // 
            this.mekanikToolStripMenuItem.Image = global::BENGKEL.Properties.Resources.mechanic;
            this.mekanikToolStripMenuItem.Name = "mekanikToolStripMenuItem";
            this.mekanikToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mekanikToolStripMenuItem.Text = "Mekanik";
            this.mekanikToolStripMenuItem.Click += new System.EventHandler(this.mekanikToolStripMenuItem_Click);
            // 
            // pengunjungToolStripMenuItem
            // 
            this.pengunjungToolStripMenuItem.Image = global::BENGKEL.Properties.Resources.group;
            this.pengunjungToolStripMenuItem.Name = "pengunjungToolStripMenuItem";
            this.pengunjungToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pengunjungToolStripMenuItem.Text = "Pengunjung";
            this.pengunjungToolStripMenuItem.Click += new System.EventHandler(this.pengunjungToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.Image = global::BENGKEL.Properties.Resources.shopping_cart;
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.laporanToolStripMenuItem.Text = "Pembelian";
            this.laporanToolStripMenuItem.Click += new System.EventHandler(this.laporanToolStripMenuItem_Click);
            // 
            // penjualanToolStripMenuItem1
            // 
            this.penjualanToolStripMenuItem1.Image = global::BENGKEL.Properties.Resources.shopping_bag;
            this.penjualanToolStripMenuItem1.Name = "penjualanToolStripMenuItem1";
            this.penjualanToolStripMenuItem1.Size = new System.Drawing.Size(87, 20);
            this.penjualanToolStripMenuItem1.Text = "Penjualan";
            this.penjualanToolStripMenuItem1.Click += new System.EventHandler(this.penjualanToolStripMenuItem1_Click_1);
            // 
            // laporanToolStripMenuItem1
            // 
            this.laporanToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barangToolStripMenuItem,
            this.cetakToolStripMenuItem,
            this.allToolStripMenuItem});
            this.laporanToolStripMenuItem1.Image = global::BENGKEL.Properties.Resources.report;
            this.laporanToolStripMenuItem1.Name = "laporanToolStripMenuItem1";
            this.laporanToolStripMenuItem1.Size = new System.Drawing.Size(78, 20);
            this.laporanToolStripMenuItem1.Text = "Laporan";
            // 
            // barangToolStripMenuItem
            // 
            this.barangToolStripMenuItem.Image = global::BENGKEL.Properties.Resources.document;
            this.barangToolStripMenuItem.Name = "barangToolStripMenuItem";
            this.barangToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.barangToolStripMenuItem.Text = "Barang";
            this.barangToolStripMenuItem.Click += new System.EventHandler(this.barangToolStripMenuItem_Click_1);
            // 
            // cetakToolStripMenuItem
            // 
            this.cetakToolStripMenuItem.Image = global::BENGKEL.Properties.Resources.invoice;
            this.cetakToolStripMenuItem.Name = "cetakToolStripMenuItem";
            this.cetakToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.cetakToolStripMenuItem.Text = "Cetak";
            this.cetakToolStripMenuItem.Click += new System.EventHandler(this.cetakToolStripMenuItem_Click_1);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(466, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "BENGKEL HOKI MOTOR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::BENGKEL.Properties.Resources.group;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(225, 311);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 170);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(220, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "PENDAFTARAN \r\nPENGUNJUNG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(606, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "PENJUALAN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::BENGKEL.Properties.Resources.shopping_bag;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(593, 311);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 170);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(963, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "CETAK FAKTUR";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::BENGKEL.Properties.Resources.printer;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(958, 311);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(176, 170);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::BENGKEL.Properties.Resources.settings;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(416, 90);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 40);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::BENGKEL.Properties.Resources.settings;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(901, 90);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(44, 40);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BENGKEL.Properties.Resources._1080p_white_background_6__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1267, 609);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "BENGKEL HOKI MOTOR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem penjualanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daftarBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daftarJasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mekanikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengunjungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem penjualanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem barangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cetakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
    }
}

