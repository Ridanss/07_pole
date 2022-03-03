using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void execute_manual_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int n = Convert.ToInt32(textBoxN.Text);
            Random rnd = new Random();
            double min = 1000;
            double max = 0;
            int minI = 0, maxI = 0;
            double[] values = new double[n];
            double soucet = 0;
            for (int i = 0; i < n; i++)
            {
                values[i] = rnd.NextDouble() * 999 + 1;
                if (values[i] > max)
                {
                    max = values[i];
                    maxI = i;
                }
                if (values[i] < min)
                {
                    min = values[i];
                    minI = i;
                }
                soucet += values[i];
            }
            if (n > 0)
            {
                if (n > 2)
                {
                    n -= 2;
                    soucet -= min + max;
                    prumer.Text = ("Průměr: " + (soucet / n).ToString("F2"));
                }
                foreach (double item in values)
                {
                    listBox1.Items.Add(item.ToString("F2"));
                }
                values[minI] = max;
                values[maxI] = min;
                foreach (double item in values)
                {
                    listBox2.Items.Add(item.ToString("F2"));
                }
            }
        }

        private void execute_methods_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int n = Convert.ToInt32(textBoxN.Text);
            double[] values = new double[n];
            Random rnd = new Random();
            double soucet = 0;
            for (int i = 0; i < n; i++)
            {
                values[i] = rnd.NextDouble() * 999 + 1;
                soucet += values[i];
            }
            if (values.Length > 0)
            {
                double min = values.Min();
                double max = values.Max();
                if (values.Length > 2)
                {
                    soucet = values.Sum() - (min + max);
                    prumer.Text = ("Průměr: " + (soucet / values.Length - 2).ToString("F2"));
                }
                foreach (double item in values)
                {
                    listBox1.Items.Add(item.ToString("F2"));
                }
                int minI = Array.IndexOf(values, min);
                int maxI = Array.IndexOf(values, max);
                (values[minI], values[maxI]) = (values[maxI], values[minI]);
                foreach (double item in values)
                {
                    listBox2.Items.Add(item.ToString("F2"));
                }
            }
        }
    }
}
