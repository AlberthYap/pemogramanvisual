namespace WindowsFormsApplication6
{
    partial class Form6
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
            this.lsvDaftar.Location = new System.Drawing.Point(12, 29);
            this.lsvDaftar.Name = "lsvDaftar";
            this.lsvDaftar.Size = new System.Drawing.Size(478, 204);
            this.lsvDaftar.TabIndex = 1;
            this.lsvDaftar.UseCompatibleStateImageBehavior = false;
            this.lsvDaftar.SelectedIndexChanged += new System.EventHandler(this.lsvDaftar_SelectedIndexChanged);
            this.lsvDaftar.DoubleClick += new System.EventHandler(this.lsvDaftar_DoubleClick);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 260);
            this.Controls.Add(this.lsvDaftar);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvDaftar;
    }
}