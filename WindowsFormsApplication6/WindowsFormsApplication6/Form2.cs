using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dgvGaji.Rows.Clear();
            dgvGaji.Columns.Clear();

            dgvGaji.Columns.Add("Gaji Pokok", "GAJI");
            dgvGaji.Columns.Add("TAnak", "TUNJANGAN ANAK");
            dgvGaji.Columns.Add("TGol", "TUNJANGAN GOLONGAN");

            dgvGaji.Columns[1].Width = 200;
            dgvGaji.Columns[2].Width = 200;
           
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            //int n = dgvGaji.Rows.Count;
            //MessageBox.Show("Banyak Baris = " + n);
            //int m = dgvGaji.ColumnCount;
            //MessageBox.Show("Banyak Kolom = " + m);

            int n = dgvGaji.Rows.Add();
            dgvGaji.Rows[n].Cells[0].Value = txtGapok.Text;
            dgvGaji.Rows[n].Cells[1].Value = txtTAnak.Text;
            dgvGaji.Rows[n].Cells[2].Value = txtTGol.Text;

        }
    }
}
