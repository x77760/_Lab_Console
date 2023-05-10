using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Forms第二題
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        public void button3_Click(object sender, EventArgs e, string monthlyPayment)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            double housePrice = Convert.ToDouble(textBox1.Text);
            int loanTerm = Convert.ToInt32(textBox2.Text);            
            double interestRate = Convert.ToDouble(textBox3.Text);
            double headGold = Convert.ToDouble(textBox4.Text);

            // 貸款總月数
            int numberOfMonths = loanTerm * 12;

            // 月利率
            double monthlyInterestRate = interestRate / 100 / 12;

            //月付款
            double monthlyPayment =
    (housePrice - headGold) * (monthlyInterestRate *
    Math.Pow(1 + monthlyInterestRate, numberOfMonths)) /
    (Math.Pow(1 + monthlyInterestRate, numberOfMonths) - 1);

            int monthlyPaymentInt = Convert.ToInt32(monthlyPayment);//整數化


            MessageBox.Show("總付金額:" + numberOfMonths* monthlyPaymentInt);




        }

        public void button1_Click(object sender, EventArgs e)
        {
            double housePrice = Convert.ToDouble(textBox1.Text);//房屋價格
            int loanTerm = Convert.ToInt32(textBox2.Text);//貸款時間
            double interestRate = Convert.ToDouble(textBox3.Text);//利率
            double headGold = Convert.ToDouble(textBox4.Text);//頭期款

            // 月利率
            double monthlyInterestRate = interestRate / 100 / 12;
            // 貸款總月数
            int numberOfMonths = loanTerm * 12;

            //月付款
            double monthlyPayment =
    (housePrice - headGold) * (monthlyInterestRate *
    Math.Pow(1 + monthlyInterestRate, numberOfMonths)) /
    (Math.Pow(1 + monthlyInterestRate, numberOfMonths) - 1);




            int monthlyPaymentInt = Convert.ToInt32(monthlyPayment);

            MessageBox.Show ("月付金額:"+ monthlyPaymentInt);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            double housePrice = Convert.ToDouble(textBox1.Text);//房屋價格
            int loanTerm = Convert.ToInt32(textBox2.Text);//貸款時間
            double interestRate = Convert.ToDouble(textBox3.Text);//利率
            double headGold = Convert.ToDouble(textBox4.Text);//頭期款

            // 月利率
            double monthlyInterestRate = interestRate / 100 / 12;
            // 貸款總月数
            int numberOfMonths = loanTerm * 12;

            //月付款
            double monthlyPayment =
    (housePrice - headGold) * (monthlyInterestRate *
    Math.Pow(1 + monthlyInterestRate, numberOfMonths)) /
    (Math.Pow(1 + monthlyInterestRate, numberOfMonths) - 1);




            int monthlyPaymentInt = Convert.ToInt32(monthlyPayment);


            Form2 form2 = new Form2();

            // 修改 Form2 中的 Label 文本内容
            form2.label6.Text = textBox1.Text;
            form2.label7.Text = textBox2.Text;
            form2.label8.Text = textBox3.Text;
            form2.label9.Text = "" + monthlyPaymentInt;
            form2.label10.Text = "" + numberOfMonths * monthlyPaymentInt;


            form2.Show();
        }
    }
}
