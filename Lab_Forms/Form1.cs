using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String Ename = textBox2.Text;
            String BGname = textBox3.Text;
            String Sname = textBox4.Text;
            MessageBox.Show
                ("哈樓，我是" + name +"\r\n"+"我的英文名稱是:"+
                Ename+ "\r\n"+"我性別為:"+BGname+ "\r\n"+
                "我的星座:"+Sname+ "\r\n"+ "很高興認識你"
                );
           





        }

        private void button2_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String Ename = textBox2.Text;
            String BGname = textBox3.Text;
            String Sname = textBox4.Text;
            MessageBox.Show
                ("HI，我是" + name + "\r\n" + "我的英文名稱是:" +
                Ename + "\r\n" + "我性別為:" + BGname + "\r\n" +
                "我的星座:" + Sname + "\r\n"+"很高興認識你"
                );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
