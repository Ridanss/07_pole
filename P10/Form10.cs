using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            string slovo = textBox1.Text;
            char[] value = new char[textBox1.Text.Length];
            for (int i =0;i< textBox1.Text.Length - 1; i++)
            {
                value[i] = slovo[i];
            }

        }
    }
}
