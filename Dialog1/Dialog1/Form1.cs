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
    public partial class frmOpenFileDialog : Form
    {
        public frmOpenFileDialog()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Buka File Gambar";
            //openFileDialog1.Title = "Image Files (*.BMP;*.JPG;*.GIF) | *.BMP;*.JPG;*.GIF|All Files (*.*)|*.*"
            openFileDialog1.Filter = "Bmp Files (*.BMP)|*.BMP|Jpg Files" + "(*.JPG)|*.Jpg|Gif Files (*.Gif) | *.Gif | All files (*.*)|*.*";
            openFileDialog1.FileName = "";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.InitialDirectory = "c:\\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                picPhoto.Image = Image.FromFile(openFileDialog1.FileName);
       
        }
    }
}
