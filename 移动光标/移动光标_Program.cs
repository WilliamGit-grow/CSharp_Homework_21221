namespace HomeworkTwo
{
    /// <summary>
    /// 第二次作业
    /// 用键盘移动光标
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {
            //设置初始坐标
            int x = 1, y = 2;
            //设置结束方式
            Console.Write("Press \"Space\" to stop");
            Console.WriteLine();
            //建立x，y坐标系数系数
            Console.SetCursorPosition(x, y);
            //读取第一步的移动方向
            var Input = Console.ReadKey().KeyChar;
            while (Input != ' ')
            //?while (Input!='\n');
            //?while (Input!="\r\n");
            {
                //清空页面
                Console.Clear();
                //Input = Console.ReadKey().ToString();
                // while (Input != "\n") 
                {
                    //设置边界条件
                    if (((x < 1) || (y < 2)) || ((x>49)||(y>49)))
                        break;
                    switch (Input)
                    {
                        //向上移动
                        case 'w':
                            {
                                y--;
                                Console.SetCursorPosition(x, y);
                                break;
                            }
                        //向下移动
                        case 's':
                            {
                                y++;
                                Console.SetCursorPosition(x, y); break;
                            }
                        //向左移动
                        case 'a':
                            {
                                x--;
                                Console.SetCursorPosition(x, y);
                                break;
                            }
                        //向右移动
                        case 'd':
                            {
                                x++;
                                Console.SetCursorPosition(x, y); break;
                            }
                        //输入错误指令
                        default:
                            {
                                y = 2; x = 1;
                                Console.WriteLine("Errorous Command!!!");
                                Console.SetCursorPosition(x, y);
                                break;
                            }

                    }
                    Input = Console.ReadKey().KeyChar;
                }
            }
            Console.WriteLine("Game over");
        }
    }
}