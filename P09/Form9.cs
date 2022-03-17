using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P09
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int n = Convert.ToInt32(textBoxN.Text);
            Random rnd = new Random();
            int[] pole = new int[n];


            for (int i = 0; i < n; i++)
            {
                pole[i] = rnd.Next(1, 11);
            }
            Array.Sort(pole);


            int medianX;
            if (n % 2 != 0)
            {
                int median = pole[n / 2];
                medianX = Array.LastIndexOf(pole, median) - Array.IndexOf(pole, median) + 1;
                labelVysledek.Text = ("Medián je " + median + " a vyskytuje se " + medianX + "x");
            }
            else
            {
                double median = ((double)pole[n / 2] + pole[(n / 2) - 1]) / 2;
                if (median == (int)median)
                {
                    int medianI = Array.IndexOf(pole, (int)median);
                    if (medianI > 0)
                    {
                        medianX = Array.LastIndexOf(pole, (int)median) - medianI + 1;
                        labelVysledek.Text = ("Medián je " + median + " a vyskytuje se " + medianX + "x");
                    }
                    else
                    {
                        labelVysledek.Text = ("Medián je " + median + " a vyskytuje se 0x");
                    }
                }
                else
                {
                    labelVysledek.Text = ("Medián je " + median + " a vyskytuje se 0x");
                }
            }
            foreach (int value in pole)
            {
                listBox1.Items.Add(value);
            }
        }
    }
}
