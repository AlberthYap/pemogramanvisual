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
            for (int i = 1; i <= int.Parse(txtInput1.Text); i++)
            {
                string angka = Interaction.InputBox("Angka ke - " + i, "Input", "", 0, 0);

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
            listBox3.Items.Clear();
            for (int i=0; i<listBox1.Items.Count;i++)
            {
                int list1, list2;
                list1 = int.Parse(listBox1.Items[i].ToString());

                for (int j=0; j < listBox2.Items.Count;j++)
                {
                    list2 = int.Parse(listBox2.Items[j].ToString());
                    if (list1 == list2)
                    {
                        listBox3.Items.Add(list1);
                    }
                }
            }
        }

        private void cmbPilih_SelectedIndexChanged(object sender, EventArgs e)
        {
            int besar = 0, temp = 0, kecil = 0, rata = 0;
            switch (cmbPilih.Text)
            {
                case "Bilangan Terkecil":
                    kecil = int.Parse(listBox3.Items[0].ToString());
                    for (int i = 0; i <listBox3.Items.Count;i++)
                    {
                        temp = int.Parse(listBox3.Items[i].ToString());
                        if (kecil > temp)
                        {
                            kecil = temp;
                        }
                    }
                    lblHasil.Text = kecil.ToString();
                    break;
                case "Bilangan Terbesar":
                    
                    besar = int.Parse(listBox3.Items[0].ToString());

                    for (int i=0; i < listBox3.Items.Count; i++)
                    {
                        temp = int.Parse(listBox3.Items[i].ToString());
                        if (besar < temp)
                        {
                            besar = temp;
                        }
                    }
                    lblHasil.Text = besar.ToString();
                    break;
                case "Rata - Rata":
                    rata = int.Parse(listBox3.Items[0].ToString());
                    for (int i=0; i < listBox3.Items.Count;i++)
                    {
                        temp += int.Parse(listBox3.Items[i].ToString());
                    }
                    rata = temp / listBox3.Items.Count;
                    lblHasil.Text = rata.ToString();
                    break;
                default:
                    lblHasil.Text = "Tidak Ada Pilihan";
                    break;
            }
        }
    }
}
