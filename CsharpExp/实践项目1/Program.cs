using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace 实践项目1
{
    class Program
    {

        static void  ResetPic()// 刷新画面
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Thread.Sleep(1);
        }

        static void Main(string[] args)
        {
            #region 初始化窗口
            Console.SetWindowSize(112, 63);
            Console.SetBufferSize(120, 70);
            Console.CursorVisible = false;
            
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            #endregion
            Console.WriteLine("请输入操作wsad，按q退出");
            char op;
            string block = "  ";
            Console.BackgroundColor = ConsoleColor.Yellow;
            int x = 0, y = 0;
            Console.Write(block);
            do
            {
                op = Console.ReadKey(true).KeyChar;
                if (op == 'q') Console.WriteLine("quit");
                switch (op)
                {
                    case 'w':
                        if (y - 1 > 0) {
                            ResetPic();
                            
                            y = y - 1;
                            Console.SetCursorPosition(x,y);
                            Console.Write(block);
                        }
                        
                        break;
                    case 's':
                        if (y + 1 < 62)
                        {
                            ResetPic();
                            y = y + 1;
                            Console.SetCursorPosition(x, y);
                            Console.Write(block);
                        }
                        break;
                    case 'a':
                        if (x -2 > 0)
                        {
                            ResetPic();
                            x = x - 2;
                            Console.SetCursorPosition(x, y);
                            Console.Write(block);
                        }
                        break;
                        
                    case 'd':
                        if (x + 2 < 110)
                        {
                            ResetPic();
                            x = x + 2;
                            Console.SetCursorPosition(x, y);
                            Console.Write(block);
                        }
                        break;






                }




            } while (op != 'q' && op != 'Q');





            Console.ReadLine();

        }



    }
}
