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
            int n = Convert.ToInt32(textBoxN.Text);
            Random rnd = new Random();
            int[] values = new int[n];
            for (int i = 0; i < n; i++)
            {
                values[i] = rnd.Next(1, 11);
            }
            if (radio_sestupne.Checked)
            {
                Array.Sort(values);
                foreach (int value in values)
                {
                    listBox1.Items.Add(value);
                }
                
            }
            else
            {
                Array.Sort(values);
                Array.Reverse(values);
                foreach (int value in values)
                {
                    listBox1.Items.Add(value);
                }
            }
        }
    }
}
