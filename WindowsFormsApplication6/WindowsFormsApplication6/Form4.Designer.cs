namespace WindowsFormsApplication6
{
    partial class Form4
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
            this.lsvDaftar = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lsvDaftar
            // 
            this.lsvDaftar.Location = new System.Drawing.Point(29, 14);
            this.lsvDaftar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsvDaftar.Name = "lsvDaftar";
            this.lsvDaftar.Size = new System.Drawing.Size(645, 371);
            this.lsvDaftar.TabIndex = 0;
            this.lsvDaftar.UseCompatibleStateImageBehavior = false;
            this.lsvDaftar.SelectedIndexChanged += new System.EventHandler(this.lsvDaftar_SelectedIndexChanged);
            this.lsvDaftar.DoubleClick += new System.EventHandler(this.lsvDaftar_DoubleClick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 399);
            this.Controls.Add(this.lsvDaftar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvDaftar;
    }
}