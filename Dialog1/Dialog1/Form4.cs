using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialog1
{
    public partial class frmFontDialog : Form
    {
        public frmFontDialog()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.FontMustExist = true;
            fontDialog1.ShowApply = true;

            fontDialog1.Font = label1.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Font = fontDialog1.Font;
            }
        }
    }
}
