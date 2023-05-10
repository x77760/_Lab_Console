using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 作業螢幕保護裝置
{
    public partial class Form1 : Form
    {

        private Timer timer;   //設定計時容器
        private int x = 0;    //定一個值叫X 給他0的數字
        private int y = 0;
        public Form1()
        {
            InitializeComponent();


            
            timer = new Timer();   // 建立 Timer 物件
            timer.Interval = 10; // Timer間隔為 0.01 秒
            timer.Tick += Timer_Tick; // 給他叫方法事件


        }
             

        private void Form1_Load(object sender, EventArgs e)
        {

            
            this.BackColor = Color.Black; //背景設黑
            this.FormBorderStyle = FormBorderStyle.None; //藏框框
            this.WindowState = FormWindowState.Maximized; //最大視窗
            this.TopMost = true; //顯示最上層
            KeyDown += F1_KeyDown; //按下按鍵後招喚自己做的方法(方法內容寫CLOSE來關掉視窗)


            
            pictureBox1.Location = new Point(0, 0);  //設圖片開始位置

            timer.Start(); //啟動時間容器

        }







        private void Timer_Tick(object sender, EventArgs e)

            {
                
                x += 15;  // 每0.15秒增加X的值(X的值等於圖片位置)
                y += 3;

            pictureBox1.Location = new Point(x, y); //吃下xy的值


            if (pictureBox1.Right >= this.ClientSize.Width)  // 如果 pictureBox1 的位置到達了 Form 的右邊緣，就給x軸定回20
            { x = 20; }
            else if (pictureBox1.Bottom>=this.ClientSize.Height)
            { y = 2; }
         


            }






        private void F1_KeyDown(object sender, KeyEventArgs e)
        { Close(); } //關閉
        private void pictureBox1_Click(object sender, EventArgs e)
        { Close(); }  // 關閉


    }
}
