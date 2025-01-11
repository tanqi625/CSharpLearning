using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace expMethod2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.SetWindowSize(120, 60);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.CursorVisible = false;
            string block = "■";
            Console.WriteLine("请输入操作wsad，按q退出");
            char op;
            
            int x = 0, y = 0;
            Console.Write(block);
            do
            {
                Console.SetCursorPosition(x, y);
                Console.Write(block);
                op = Console.ReadKey(true).KeyChar;
                Console.SetCursorPosition(x, y);
                Console.Write("  ");
                if (op == 'q') Console.WriteLine("quit");
                switch (op)
                {
                    case 'w':
                    case 'W':
                        if (y - 1 > 0)
                        {


                            y = y - 1;

                        }

                        break;
                    case 's':
                    case 'S':
                        if (y + 1 < Console.BufferHeight)
                        {

                            y = y + 1;

                        }
                        break;
                    case 'a':
                    case 'A':
                        if (x - 2 > 0)
                        {

                            x = x - 2;

                        }
                        break;

                    case 'd':
                    case 'D':
                        if (x + 2 < Console.BufferWidth)
                        {

                            x = x + 2;

                        }
                        break;






                }




            } while (op != 'q' && op != 'Q');




        }
    }
}
