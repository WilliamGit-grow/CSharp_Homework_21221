namespace VigenereCipher
{
    internal class Program
    {
        /// <summary>
        /// 维吉尼亚密码
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int lengthP, lengthC, tempAscii, ascii, posi = 0;
            string cipher, cipherText = "";
            Console.WriteLine("请输入一串字母");
            string plainText = Console.ReadLine();
            Console.WriteLine("请输入按什么字符加密");
            cipher = Console.ReadLine();
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
            Console.WriteLine("加密后的暗文为");
            Console.WriteLine(cipherText);
        }
    }
}