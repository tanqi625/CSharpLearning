using System;
using System.Threading;

class Program
{
    static void ResetPic()// 刷新画面
    {
        Console.Clear();

        Console.BackgroundColor = ConsoleColor.Red;
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.SetCursorPosition(40, 12);
        Thread.Sleep(100);
    }
    static void Main()
    {
        string jikuai = "IT男神";
        Console.SetWindowSize(112, 63);
        Console.SetBufferSize(120, 70);
        Console.CursorVisible = false;

        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();
        
        for(; ; )
        {
            ResetPic();
            Console.WriteLine(jikuai);
            Thread.Sleep(200);
            
        }
        
        Console.ReadKey();

    }
}
