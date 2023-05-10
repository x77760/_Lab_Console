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

namespace 作業計算機
{
    public partial class Form1 : Form
    {
        double a, b, c; 

        public Form1()
        {
            InitializeComponent();
            textBox3.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = a + b;
            textBox3.Text = c.ToString();            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = a - b;
            textBox3.Text = c.ToString();            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = a * b;
            textBox3.Text = c.ToString();           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = a / b;
            textBox3.Text = c.ToString();
        }
    }
}
