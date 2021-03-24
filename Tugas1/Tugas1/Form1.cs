using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Tugas1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btninput1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 1; i  <= int.Parse(txtInput1.Text); i++)
            {
                string angka = Interaction.InputBox("Angka ke - " + i, "Input", "", 0,0);

                if ((angka) == "")
                {
                    angka = "-";
                }
                listBox1.Items.Add(angka);
            }
        }

        private void btnInput2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            for (int i = 1; i <= int.Parse(txtInput2.Text); i++)
            {
                string angka = Interaction.InputBox("Angka ke - " + i, "Input", "", 0, 0);

                if ((angka) == "")
                {
                    angka = "-";
                }
                listBox2.Items.Add(angka);
            }
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            int list1 = int.Parse(listBox1.Text);

        }
    }
}
