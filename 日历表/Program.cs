using System.Collections;
using System.Net.Http.Headers;

namespace Homewrok3
{
    /// <summary>
    /// To set up a canlendar of some year you input
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //设置行列宽
            const int MonthHeight = 12;
            const int MonthWidth = 36;
            Console.WriteLine("Please input the year you counsel:");
            //输入想查询的年份
            int Year = Convert.ToInt32(Console.ReadLine());
            if (Year <= 0)
            {
                Console.WriteLine("Errorous Input");//非法输入
                return;
            }
            //为了防止输入被输出结果覆盖
            int x = 0, y = 2;
            //将月份转化为英文形式
            string[] theMonth = new string[] { "Jan", "Feb", "Mar", "Apri", "May", "Jun", "Jul","Agu","Sept","Oct","Nov","Dec" };
            DateTime theDay;
            for (theDay = new DateTime(Year, 1, 1); theDay.Year == Year; theDay = theDay.AddDays(1))
            {
                //讨论每月的1号这一特殊情况（涉及到生成每个月历&&重新定位）
                if ((int)theDay.Day == 1)
                {
                    y = 2+((int)theDay.Month - 1) / 3 * MonthHeight;
                    x=  (((int)theDay.Month - 1) % 3) * MonthWidth;
                    
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine(theMonth[(int)theDay.Month-1].PadLeft(16,' '));
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("  Sun Mon Tue Wed Thu Fri Sat");
                    Console.SetCursorPosition(x,y);
                    x += (int)theDay.DayOfWeek * 4;
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write(theDay.Day.ToString(). PadLeft(4, ' '));
                }
                //讨论每个周六这一特殊情况(涉及到换行）
                if ((int)theDay.DayOfWeek == 6)
                {
                    Console.SetCursorPosition(x, y);
                    if ((int)theDay.Day != 1)
                    {
                        Console.Write(theDay.Day.ToString().PadLeft(4, ' '));
                    }
                    y++;
                    x -= 24;
                }   
                //一般情况
                else
                {
                    Console.SetCursorPosition(x, y);
                    if ((int)theDay.Day != 1)
                    {
                        Console.Write(theDay.Day.ToString().PadLeft(4, ' '));
                    }
                    x += 4;
                }
            }
        }
    }
}