using System.Security.Cryptography;

namespace TabGame
{
    /// <summary>
    /// 根据随机给出的提示输入
    /// 统计总用时以及出错次数
    /// </summary>
    internal class Program
    {
        //设置一个枚举类型，分别代表四个方向键
        enum RandomDirection {up,left,down,right};
        const int N = 10;
    static void Main(string[] args)
        {
            int i,ans=0;
            int errorTimes = 0;
            Random random = new Random();
            double theTime=0;
            DateTime start, end;
            end= DateTime.Now;
            start= end;
            for (i = 0;i < N ; i++)
                {
                //清空上一次的屏幕
                Console.Clear();
                //记录每一次用时
                theTime = (end - start).TotalSeconds;
                Console.WriteLine($"现在进行第{i+1}次测试，总用时{theTime}秒");
                Console.WriteLine($"总错误次数:{errorTimes}");
                RandomDirection randomDirection = (RandomDirection)random.Next(0, 4);//左闭右开区间
                Console.WriteLine("Please choose an arrow among ↑ ↓ ← →");
                Console.WriteLine("according to the hint below");
                //读入每一次的方向
                Console.WriteLine(randomDirection.ToString());
                var input = Console.ReadKey().Key;
                //判断方向
                switch (input)
                {
                    case ConsoleKey.UpArrow:
                        ans = 0;
                        break;
                    case ConsoleKey.LeftArrow:
                        ans = 1;
                        break;
                    case ConsoleKey.DownArrow:
                        ans = 2;
                        break;
                    case ConsoleKey.RightArrow:
                        ans = 3;
                        break;
                }
                //若输入不正确
                if ((RandomDirection)ans != randomDirection)
                {
                    errorTimes++;
                    Console.WriteLine("Errorous input. Please Try again");
                }
                end = DateTime.Now;    
                }
            if (theTime * (errorTimes+1) < 10.0) Console.WriteLine("You are such a master!");
            else Console.WriteLine("Keep Going!");
        }
    }
}