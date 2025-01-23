using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paragram
{
    class Program
    {
        static void Main(string[] args)
        {
            int max;
            int a = 1;
            int b = 2;
            Console.WriteLine("{0} {1}",More(a, b, out max),max);
            Console.ReadKey();
        }
        static bool More(int a,int b,out int max)
        {
            if (a > b)
            {
                max = a;
                return true;
            }
            max = b;
            return false;
        }
        static int Max(params int[] args)
        {
            int Max = args[0];
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] > Max) Max = args[i];
            }
            return Max;
        }
        static float Max(params float[] args)
        {
            float Max = args[0];
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] > Max) Max = args[i];
            }
            return Max;
        }
        static double Max(params double[] args)
        {
            double Max = args[0];
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] > Max) Max = args[i];
            }
            return Max;
        }
    }
}
