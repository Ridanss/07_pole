using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Execute_program_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int n = Convert.ToInt32(textBoxN.Text);
            int[] pole = new int[n];
            Random rnd = new Random();

            for (int  i = 0; i < n; i++)
            {
                pole[i] = rnd.Next(1, 21);
                listBox1.Items.Add(pole[i]);
            }
            pole = pole.Distinct().ToArray();
            int maxToremove = pole.Max();
            int minToremove = pole.Min();
            (pole[Array.IndexOf(pole, maxToremove)], pole[Array.IndexOf(pole, minToremove)]) = (pole[pole.Length - 1], pole[pole.Length - 2]);
            pole = pole.Take(pole.Length - 2).ToArray();
            //pole = pole.Except(new int[] { maxToremove, minToremove }).ToArray();
            foreach(int value in pole)
            {
                listBox2.Items.Add(value);
            }
        }
    }
}
