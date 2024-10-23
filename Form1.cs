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
    }
}
