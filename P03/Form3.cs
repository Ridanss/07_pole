using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
{
    public partial class Form3 : Form
    {
        int[] poleA;
        int[] poleB;
        public Form3()
        {
            InitializeComponent();
        }

        private void arrayA_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (textBox1.Text != "")
            {
                int n = Convert.ToInt32(textBox1.Text);
                poleA = new int[n];
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                {
                    poleA[i] = rnd.Next(3, 11);
                    listBox1.Items.Add(poleA[i]);
                }
            }
        }

        private void arrayB_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (textBox2.Text != "")
            {
                int m = Convert.ToInt32(textBox2.Text);
                poleB = new int[m];
                Random rnd = new Random();
                for (int i = 0; i < m; i++)
                {
                    poleB[i] = rnd.Next(3, 11);
                    listBox2.Items.Add(poleB[i]);
                }
            }
        }

        private void arrayC_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            int[] poleC = poleA.Concat(poleB).ToArray();
            foreach (int value in poleC)
            {
                listBox3.Items.Add(value);
            }
        }

        private void arrayD_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            int[] poleD = poleA.Union(poleB).ToArray();
            foreach (int value in poleD)
            {
                listBox4.Items.Add(value);
            }
        }

        private void arrayE_Click(object sender, EventArgs e)
        {
            listBox5.Items.Clear();
            int[] poleE = poleA.Intersect(poleB).ToArray();
            foreach (int value in poleE)
            {
                listBox5.Items.Add(value);
            }
        }
    }
}
