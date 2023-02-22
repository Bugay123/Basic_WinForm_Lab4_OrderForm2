using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Var2
{
    public partial class Form1 : Form
    {
        List<RadioButton> rbs = new List<RadioButton>();
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                if (groupBox1.Controls[i].GetType() == typeof(RadioButton))
                {
                    rbs.Add((RadioButton)groupBox1.Controls[i]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pizza;
            int cost = 0;
            int count = 0;
            double sum = 0;

            for (int i = 0; i < rbs.Count; i++)
            {
                if (rbs[i].Checked)
                {
                    pizza = rbs[i].Text;
                    cost = int.Parse(groupBox2.Controls[i].Text);
                    count = int.Parse(groupBox3.Controls[i].Text);

                    if (count > 20)
                    {
                        sum = (cost * count) * 0.9;
                    }
                    else
                    {
                        sum = cost * count;
                    }
                }
            }
            textBox5.Text = sum.ToString();
        }
    }
}
