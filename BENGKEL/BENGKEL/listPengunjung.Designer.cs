
namespace BENGKEL
{
    partial class listPengunjung
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
            this.lsvPengunjung = new System.Windows.Forms.ListView();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lsvPengunjung
            // 
            this.lsvPengunjung.HideSelection = false;
            this.lsvPengunjung.Location = new System.Drawing.Point(72, 53);
            this.lsvPengunjung.Name = "lsvPengunjung";
            this.lsvPengunjung.Size = new System.Drawing.Size(656, 344);
            this.lsvPengunjung.TabIndex = 2;
            this.lsvPengunjung.UseCompatibleStateImageBehavior = false;
            this.lsvPengunjung.SelectedIndexChanged += new System.EventHandler(this.lsvPengunjung_SelectedIndexChanged);
            this.lsvPengunjung.DoubleClick += new System.EventHandler(this.lsvPengunjung_DoubleClick);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(542, 12);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(186, 20);
            this.txtCari.TabIndex = 3;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // listPengunjung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.lsvPengunjung);
            this.Name = "listPengunjung";
            this.Text = "listPengunjung";
            this.Load += new System.EventHandler(this.listPengunjung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvPengunjung;
        private System.Windows.Forms.TextBox txtCari;
    }
}