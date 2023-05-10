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

namespace Lab_Forms第四題
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] name = new string[1];
        int[] soc = new int[3];



        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {

            name[0] = textBox1.Text;
            soc[0] =int.Parse(textBox2.Text);
            soc[1] = int.Parse(textBox3.Text);
            soc[2] = int.Parse(textBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {


            label6.Text = "姓名:" + name[0] + "\r\n" +
                 "國文成績:" + soc[0] + "\r\n"+
                 "英文成績:" + soc[1] + "\r\n" +
                 "數學成績:" + soc[2] + "\r\n";






        }

        private void button3_Click(object sender, EventArgs e)
        {

            int max = soc[0]; // 假设数组的第一个元素为最大值

            // 使用循环遍历数组，找到最大值
            for (int i = 1; i < soc.Length; i++)
            {
                if (soc[i] > max)
                {
                    max = soc[i]; // 更新最大值
                }
            }
                string M = max.ToString();

            int min = soc[0]; // 假设数组的第一个元素为最小值

            // 使用循环遍历数组，找到最小值
            for (int i = 1; i < soc.Length; i++)
            {
                if (soc[i] < min)
                {
                    min = soc[i]; // 更新最小值
                }
            }
            string MM = min.ToString();


            label7.Text =("最高分:"+M+"    最低分:"+MM); 

                


        }
    }
}
