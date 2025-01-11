using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_var
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2100000000;
            sbyte sb = 127;
            short st = 32767;
            long l = i * i;

            uint ui = 4200000000u;

            byte bt = 155;
            ushort us = 65000;
            ulong ul = 10000000000000000ul;

            
            Console.WriteLine((byte)(bt - (byte)160));
            Console.ReadKey();


        }
    }
}
