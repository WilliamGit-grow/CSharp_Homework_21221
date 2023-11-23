namespace TowerOfHanoiProblem
{
    internal class Program
    {
        /// <summary>
        /// 汉诺塔问题
        /// </summary>
        /// <param name="Num"></param>
        /// <param name="towerA"></param>
        /// <param name="towerB"></param>
        /// <param name="towerC"></param>
        public static void hanoi(int Num, char towerA, char towerB, char towerC)
        {
            //模拟
            if (Num == 1)
            {
                Console.WriteLine($"1 {towerA} ---> {towerC}");
                return ;
            }
            //问题拆解成三部分
            else
            {
                //第一部分：上面 Num-1 个盘从 A 经过 C 移到 B
                hanoi(Num - 1, towerA, towerC, towerB);
                //第二部分：把最下面的盘从 A 移到 C
                Console.Write(Num.ToString()+" ");
                shift(towerA, towerC);
                
                //第三部分：上面 Num-1 个盘从 B 经过 A 移到 C
                hanoi(Num - 1, towerB, towerA, towerC);
            }
        }        
        public static void shift(char TowerA, char TowerC)
            {
                //输出移动情况

                Console.WriteLine($"{TowerA} ---> {TowerC}");
            }
        static void Main(string[] args)
        {
            //为什么下面这种情况读入int类型以后程序运行会出错?
            Console.WriteLine("Please input the number of plates you simulate");
            //int Num = Console.Read();
            int Num = int.Parse(Console.ReadLine());
            DateTime start = DateTime.Now;
            Console.WriteLine($"The Steps to solve the Hanoi Problem of {Num} plates");
            hanoi(Num, 'A', 'B', 'C');
            DateTime end = DateTime.Now;
            Console.WriteLine($" It takes {(end - start).TotalSeconds} seconds to simulate");
        }
    }
}