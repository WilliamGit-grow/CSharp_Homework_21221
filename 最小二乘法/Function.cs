using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leastSquaresMethod
{
    internal class Function
    {
        public static void main(long[,] GDP, int theYear)
        {
            const int startYear = 1991;
            double averYs = (double)(1991 + 2020) / 2;
            double totolG = 0;
            double bUp = 0, bDown = 0;
            long estimate;
            for (int i = 0; i < 30; i++)
            {
                //取对后对直线进行拟合
                totolG += Math.Log(GDP[i, 2]);
            }
            double averG = (double)totolG / 30;
            //运用公式分别计算b,a
            for (int i = 0; i < 30; i++)
            {
                bUp += (GDP[i, 1] - averYs)* (Math.Log(GDP[i, 2])- averG);
                bDown += (GDP[i, 1] - averYs)* (GDP[i, 1] - averYs);
            }
            double b = bUp / bDown;
            double a = averG - b * averYs;
            double logEstimate = b * (theYear-3) + a;
            estimate=(long)Math.Pow(Math.E,logEstimate);
            double estimateDouble=Math.Round((double)estimate/100000000,2);
            Console.WriteLine($"预计{theYear}年中国的总GDP是： {estimateDouble.ToString()}亿元({estimate}元)");
        }
    }
}
