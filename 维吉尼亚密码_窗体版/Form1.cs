using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VigenereCipherWindows
{
    /// <summary>
    /// 用窗体显示维吉尼亚密码加密后的结果
    /// </summary>
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //读入窗体中输入的原码和加密代码
            string plainText = this.textBox1.Text;
            string cipher = this.textBox2.Text;
            int lengthP, lengthC, tempAscii, ascii, posi = 0;
            string cipherText = "";
            lengthP = plainText.Length;
            lengthC = cipher.Length;
            //储存原文和密文的每个字符
            char[] myCharP = plainText.ToCharArray();
            char[] myCharsC = cipher.ToCharArray();
            for (int i = 0; i < lengthP; i++)
            {
                tempAscii = ((int)myCharP[i] - 97) + ((int)myCharsC[posi] - 97);
                posi++;
                //求ascii码
                ascii = 97 + tempAscii % 26;
                //还原成字符
                cipherText += (char)ascii;
                //边界判断
                if (posi >= lengthC)
                    posi = 0;
            }
            this.textBox3.Text = cipherText;
            Console.WriteLine(this.textBox3.Text);
        }

    }
}
