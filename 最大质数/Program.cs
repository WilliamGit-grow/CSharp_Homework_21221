namespace Homework3
{
    internal class Program
    {
        /// <summary>
        /// 输入一个数
        /// 输出小于他的最大质数
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int Num = Convert.ToInt32(Console.ReadLine());
            int i, j;
            bool Test;
            int Ans;
            DateTime Start, End;
            //计时开始
            Start= DateTime.Now;
            for ( i = Num; i >=2; i--)
            {
                Test = true;
                Ans = i;
                for ( j = 2; j < Math.Sqrt(Ans); j++)
                {
                    if (Ans % j == 0) 
                    {
                        Test=false;
                        break; 
                    }
                }
                //如果是质数，就输出并跳出循环
                if (Test == true)
                {
                    Console.WriteLine($"Max Prime Number is {Ans}");
                    break;
                }
            }
            //计时结束
            End = DateTime.Now;
            double Duration = (End - Start).TotalSeconds;
            Console.WriteLine($"Runs for {Duration.ToString()} seconds");
        }
    }
}