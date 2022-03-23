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
            listBox1.Items.Clear();
            string slovo = textBox1.Text;
            char[] value = new char[textBox1.Text.Length];
            int znakI = 0;
            int znakX = 1, znakY = 1;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                value[i] = slovo[i];
            }
            foreach (char znak in value)
            {
                listBox1.Items.Add(znak);
                for (int i = Array.IndexOf(value, znak) + 1; i < Array.LastIndexOf(value, znak); i++)
                {
                    if (znak == value[i])
                    {
                        znakX++;
                        if (znakX > znakY) znakI = i;
                    }
                }
                if (znakY < znakX) znakY = znakX;
                znakX = 1;
            }
            labelVysledek.Text = ("Nejčetnější znak:\nznak " + value[znakI] + " " + znakY + "x");
        }
    }
}
