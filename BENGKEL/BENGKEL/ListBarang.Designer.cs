
namespace BENGKEL
{
    partial class ListBarang
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
            this.lstBarang = new System.Windows.Forms.ListView();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstBarang
            // 
            this.lstBarang.HideSelection = false;
            this.lstBarang.Location = new System.Drawing.Point(6, 60);
            this.lstBarang.Name = "lstBarang";
            this.lstBarang.Size = new System.Drawing.Size(445, 247);
            this.lstBarang.TabIndex = 0;
            this.lstBarang.UseCompatibleStateImageBehavior = false;
            this.lstBarang.SelectedIndexChanged += new System.EventHandler(this.lstBarang_SelectedIndexChanged);
            this.lstBarang.DoubleClick += new System.EventHandler(this.lstBarang_DoubleClick);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(288, 34);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(163, 20);
            this.txtCari.TabIndex = 29;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // ListBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 319);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.lstBarang);
            this.Name = "ListBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBarang";
            this.Load += new System.EventHandler(this.ListBarang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstBarang;
        private System.Windows.Forms.TextBox txtCari;
    }
}