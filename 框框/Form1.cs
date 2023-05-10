using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_Forms;
using Lab_Forms第二題;
using Lab_Forms第三題;
using Lab_Forms第四題;
using 作業OOXX;
using 作業計算機;
using 作業螢幕保護裝置;

namespace 框框
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Lab_Forms.Form1 form1 = new Lab_Forms.Form1();
            form1.TopLevel = false;
            panel1.Controls.Add(form1);
            form1.Show();


        }
        private void button2_Click(object sender, EventArgs e)
        {
            Lab_Forms第二題.Form1 form2 = new Lab_Forms第二題.Form1();
            form2.TopLevel = false;
            panel1.Controls.Add(form2);
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab_Forms第三題.Form1 form3 = new Lab_Forms第三題.Form1();
            form3.TopLevel = false;
            panel1.Controls.Add(form3);
            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab_Forms第四題.Form1 form4 = new Lab_Forms第四題.Form1();
            form4.TopLevel = false;
            panel1.Controls.Add(form4);
            form4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            作業OOXX.Form1 form5 = new 作業OOXX.Form1();
            form5.TopLevel = false;
            panel1.Controls.Add(form5);
            form5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            作業計算機.Form1 form6 = new 作業計算機.Form1();
            form6.TopLevel = false;
            panel1.Controls.Add(form6);
            form6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            作業螢幕保護裝置.Form1 form7 = new 作業螢幕保護裝置.Form1();
            form7.TopLevel = true;
            form7.Show();

        }
    }
}
