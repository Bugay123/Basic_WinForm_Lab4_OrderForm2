using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Task3
{
    public partial class Form1 : Form
    {
        List<CheckBox> rbs = new List<CheckBox>();
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                if (groupBox1.Controls[i].GetType() == typeof(CheckBox))
                {
                    rbs.Add((CheckBox)groupBox1.Controls[i]);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int totalCount = 0;
            double totalSum = 0;

            for (int i = 0; i < rbs.Count; i++)
            {
                if (rbs[i].Checked)
                {
                    int cost = int.Parse(groupBox2.Controls[i].Text);
                    int count = int.Parse(groupBox3.Controls[i].Text);

                    double sum = cost * count;
                    totalCount += count;
                    totalSum += sum;
                }
            }
            if (totalCount > 20)
            {
                totalSum = totalSum * 0.9;
            }
            textBox5.Text = totalSum.ToString();
        } 
    }
}
