using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void execute_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int n = Convert.ToInt32(textBoxN.Text);
            Random rnd = new Random();
            int[] values = new int[n];
            for (int i = 0; i < n; i++)
            {
                values[i] = rnd.Next(1, 11);
                listBox1.Items.Add(values[i]);
            }
            Array.Sort(values);
            int nd_max = Array.IndexOf(values, values[values.Length - 1]) + 1;
            int nd_min = Array.LastIndexOf(values, values[0]) - 1;
            if (radio_sestupne.Checked)
            {
                Array.Reverse(values);
            }
            foreach (int value in values)
            {
                listBox2.Items.Add(value);
            }
        }
    }
}
