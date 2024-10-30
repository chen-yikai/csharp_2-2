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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult callBack = MessageBox.Show("是否有兩個按鈕的訊息方塊","訊息方塊練習",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var callBack = MessageBox.Show("Am I cute?", "Simple Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(callBack == DialogResult.Yes)
            {
                MessageBox.Show("Yaaaaa!","Reply",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fine :(","Reply",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var callBack  = MessageBox.Show("看你按了哪個按鈕","按鈕判斷二",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(callBack == DialogResult.OK)
            {
                MessageBox.Show("你按了 確定","回復",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("你按了 取消", "回復", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var callBack = MessageBox.Show("看你按了哪個按鈕", "按鈕判斷二", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);
            MessageBox.Show("你按了 "+(callBack == DialogResult.Abort? "中止":callBack == DialogResult.Retry? "重試": "略過"), "回復", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int input = (int)Convert.ToInt32(textBox1.Text);
            res.Text = input == 0 ? string.Empty : (input % 2 == 0 ? input + "是偶數" : input + "是奇數");
           
        }

        private void genRandom_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            randomNum.Text = random.Next(27, 60 + 1).ToString();
        }
    }
}
