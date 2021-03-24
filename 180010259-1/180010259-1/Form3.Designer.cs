
namespace _180010259_1
{
    partial class Form3
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
            this.btnFor = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.LstData = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(12, 12);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(75, 23);
            this.btnFor.TabIndex = 0;
            this.btnFor.Text = "For";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(12, 54);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(75, 23);
            this.btnWhile.TabIndex = 1;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Location = new System.Drawing.Point(12, 92);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(75, 23);
            this.btnDoWhile.TabIndex = 2;
            this.btnDoWhile.Text = "Do While";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // LstData
            // 
            this.LstData.FormattingEnabled = true;
            this.LstData.ItemHeight = 15;
            this.LstData.Location = new System.Drawing.Point(112, 12);
            this.LstData.Name = "LstData";
            this.LstData.Size = new System.Drawing.Size(120, 109);
            this.LstData.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 168);
            this.Controls.Add(this.LstData);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnFor);
            this.Name = "Form3";
            this.Text = "Latihan Perulangan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.ListBox LstData;
    }
}