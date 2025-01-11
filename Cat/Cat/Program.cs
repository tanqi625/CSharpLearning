using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] catArt1 = {
            " /\\_/\\",
            "( o.o )",
            " > ^ <"
        };
            string[] catArt2 = {
            " /\\_/\\",
            "( -.- )",
            " > ^ <"
        };
            Console.CursorVisible = false;

        while(!Console.KeyAvailable)
        {
              
                Console.WriteLine(catArt1[0]);
                int x = Console.CursorLeft;
                int y = Console.CursorTop;
                Console.WriteLine(catArt1[1]);
                Thread.Sleep(1000);
                Console.SetCursorPosition(x,y);
                Console.WriteLine(catArt2[1]);
                Thread.Sleep(1000);
                Console.WriteLine(catArt2[2]);
                Console.SetCursorPosition(0, 0);
        
        }
            Console.ReadKey();    
       

        }
    }
}
