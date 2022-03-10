using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int[] pole;

        private void Execute_program_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            int b = Convert.ToInt32(textBoxB.Text);
            int n = Convert.ToInt32(textBoxN.Text);
            foreach (int value in pole)
            {
                listBox2.Items.Add(value);
            }
            int[] poleVetsi = new int[n];
            int iVetsi = 0;
            int[] poleMensi = new int[n];
            int iMensi = 0;
            for (int i = 0; i < n; i++)
            {
                if (pole[i] > b) {
                    poleVetsi[iVetsi]=pole[i];
                    iVetsi++;
                }
                else if (pole[i] <= b)
                {
                    poleMensi[iMensi] = pole[i];
                    iMensi++;
                }
            }
            poleMensi= poleMensi.Except(int mimo=0
            foreach(int value in poleVetsi)
            {
                listBox3.Items.Add(value);
            }
            foreach(int value in poleMensi)
            {
                listBox4.Items.Add(value);
            }
        }

        private void Generate_array_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            int n = Convert.ToInt32(textBoxN.Text);
            pole = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                pole[i] = rnd.Next(1, 20);
                listBox1.Items.Add(pole[i]);
            }
            Array.Sort(pole);
        }
    }
}
