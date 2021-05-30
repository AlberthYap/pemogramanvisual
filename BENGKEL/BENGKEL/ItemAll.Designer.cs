
namespace BENGKEL
{
    partial class ItemAll
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
            this.txtCari = new System.Windows.Forms.TextBox();
            this.lstItem = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(294, 19);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(163, 20);
            this.txtCari.TabIndex = 31;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // lstItem
            // 
            this.lstItem.HideSelection = false;
            this.lstItem.Location = new System.Drawing.Point(12, 45);
            this.lstItem.Name = "lstItem";
            this.lstItem.Size = new System.Drawing.Size(445, 247);
            this.lstItem.TabIndex = 30;
            this.lstItem.UseCompatibleStateImageBehavior = false;
            this.lstItem.SelectedIndexChanged += new System.EventHandler(this.lstBarang_SelectedIndexChanged);
            this.lstItem.DoubleClick += new System.EventHandler(this.lstItem_DoubleClick);
            // 
            // ItemAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 317);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.lstItem);
            this.Name = "ItemAll";
            this.Text = "ItemAll";
            this.Load += new System.EventHandler(this.ItemAll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.ListView lstItem;
    }
}