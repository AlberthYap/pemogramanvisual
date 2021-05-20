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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            double tAnak = 0;
            if (rdb1Anak.Checked)
            {
                tAnak = 1000;
            }
            else if (rdb2Anak.Checked)
            {
                tAnak = 1500;
            }
            else if (rdb3Anak.Checked)
            {
                tAnak = 3000;
            }

            double tGol = 0;
            switch (cmbGol.SelectedIndex)
            {
                case 0:
                    tGol = 5000;
                    break;
                case 1:
                    tGol = 6000;
                    break;
                case 2:
                    tGol = 10000;
                    break;
                case 3:
                    tGol = 11000;
                    break;
            }

            int masakerja = 0;
            masakerja = dtpAkhir.Value.Year - dtpAwal.Value.Year;
            double bonus = 0;
            if (masakerja < 5)
            {
                bonus = 1000;
            }
            else if ((masakerja >= 5) && (masakerja <= 10))
            {
                bonus = 2000;
            }
            else if (masakerja > 10)
            {
                bonus = 3000;
            }

            double totGaji = double.Parse(txtGapok.Text) + tGol + tAnak + bonus;

            lblHasil.Text = totGaji.ToString();

            int n = dgvGaji.Rows.Add();
            dgvGaji.Rows[n].Cells[0].Value = txtGapok.Text;
            dgvGaji.Rows[n].Cells[1].Value = tAnak.ToString();
            dgvGaji.Rows[n].Cells[2].Value = tGol.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvGaji.Rows.Clear();
            dgvGaji.Columns.Clear();

            dgvGaji.Columns.Add("Gaji Pokok", "GAJI POKOK");
            dgvGaji.Columns.Add("TAnak", "TUNJANGAN ANAK");
            dgvGaji.Columns.Add("TGol", "TUNJANGAN GOLONGAN");
            dgvGaji.Columns.Add("Bonus", "BONUS");
            dgvGaji.Columns.Add("Sub Total", "SUB TOTAL");
            dgvGaji.Columns.Add("Pph", "PPH");
            dgvGaji.Columns.Add("Total Gaji", "TOTAL GAJI");

            
        }
    }
}
