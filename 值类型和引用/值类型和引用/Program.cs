using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 值类型和引用
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a;
            int[] Ay1 = { 1, 2 };
            int []Ay2 = Ay1;
            int[] Ay3 = (int[])Ay1.Clone();
            Ay1[0] = 0;
            Console.WriteLine("{0}", Ay1[0]);
            Console.WriteLine("{0}", Ay2[0]);
            Console.WriteLine("{0}", Ay3[0]);
            string str = "123";
            string str2 = str;
            str2 = "321";
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
