using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAIHS_CSHARP_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // 訊息方塊
        {
            MessageBox.Show("是否有兩個按鈕的訊息方塊", "訊息方塊練習", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // 顯示yes&no的訊息方塊
        }

        private void button2_Click(object sender, EventArgs e) //判斷按鈕1
        {
            DialogResult callBack = MessageBox.Show("Am I cute?", "Simple Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // 顯示yes&no的訊息方塊並取得回傳值
            if (callBack == DialogResult.Yes) // 判斷是否按下Yes
            {
                MessageBox.Show("Yaaaaa!", "Reply", MessageBoxButtons.OK, MessageBoxIcon.Information); // 按下Yes的訊息方塊
            }
            else
            {
                MessageBox.Show("Fine :(", "Reply", MessageBoxButtons.OK, MessageBoxIcon.Information); // 按下No的訊息方塊
            }
        }

        private void button3_Click(object sender, EventArgs e) //判斷按鈕2
        {
            DialogResult callBack = MessageBox.Show("看你按了哪個按鈕", "按鈕判斷二", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); // 顯示OK&Cancel的訊息方塊並取得回傳值
            if (callBack == DialogResult.OK)
            {
                MessageBox.Show("你按了 確定", "回復", MessageBoxButtons.OK, MessageBoxIcon.Information); // 按下確定的訊息方塊

            }
            else
            {
                MessageBox.Show("你按了 取消", "回復", MessageBoxButtons.OK, MessageBoxIcon.Information); // 按下取消的訊息方塊
            }
        }

        private void button4_Click(object sender, EventArgs e) //判斷按鈕3
        {
            DialogResult callBack = MessageBox.Show("看你按了哪個按鈕", "按鈕判斷二", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question); // 顯示Abort&Retry&Ignore的訊息方塊並取得回傳值
            MessageBox.Show("你按了 " + (callBack == DialogResult.Abort ? "中止" : callBack == DialogResult.Retry ? "重試" : "略過"), "回復", MessageBoxButtons.OK, MessageBoxIcon.Information); // 顯示按下的按鈕
        }

        private void button5_Click(object sender, EventArgs e) // 判斷機數偶數按鈕
        {
            int input = (int)Convert.ToInt32(textBox1.Text); // 取得輸入的數字
            res.Text = input == 0 ? string.Empty : (input % 2 == 0 ? input + "是偶數" : input + "是奇數"); // 判斷是否為偶數

        }

        private void genRandom_Click(object sender, EventArgs e) // 產生亂數按鈕
        {
            Random random = new Random(); // 建立亂數物件
            randomNum.Text = random.Next(27, 60 + 1).ToString(); // 產生27~60的亂數
        }
    }
}
