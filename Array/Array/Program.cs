using System.Linq;
using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int[] b = new int[100];
            int[] c = new int[10];
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = i;
                b[i] = 2 * a[i];
            }
            Random r = new Random();
            for(int i = 0; i < c.Length; i++)
            {
                
                c[i] = r.Next(0, 101);
            }
            int[] d = new int[10];
            for(int i = 0; i < c.Length; i++)
            {
                int t = c[i];
                c[i] = c[c.Length - 1 - i];
                c[c.Length - i - 1] = t;
                
            }

            d = c;
            for(int i = 0; i < c.Length; i++)
            {
                Console.Write("   {0}", c[i]);
            }
            Console.WriteLine();
            for(int i = 0; i < d.Length; i++)
            {
                if (d[i] > 0) d[i]++;
                else if (d[i] < 0) d[i]--;
            }
            
            for (int i = 0; i < d.Length; i++)
            {
                Console.Write("   {0}", d[i]);
            }
            Console.WriteLine();
            Console.WriteLine(Max(c));
            Console.WriteLine(GetSum(c));
            Console.WriteLine(GetAverage(c));
            Console.WriteLine(Min(c));
            Console.WriteLine("d是{0}",GetSum(d));
            string[] map = {
                "□","■", "□", "■","□",
                "■","□", "■", "□","■" ,
                "□","■", "□", "■","□",
                "■","□", "■", "□","■" ,
                "□","■", "□", "■","□",
            };
            for(int i = 0; i < map.Length; i++)
            {
                Console.Write(map[i]);
                if ( (i + 1) % 5 == 0) Console.WriteLine();
                
                

            }
            int[] grades = new int[10];
            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = Convert.ToInt32( Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine(Max(grades));
            Console.WriteLine(GetSum(grades));
            Console.WriteLine(GetAverage(grades));
            Console.WriteLine(Min(grades));
            Console.ReadKey();

        }
        static int Max(int[] data)
        {
            int max = data[0];
            for(int i = 1; i < data.Length; i++)
            {
                if (data[i] > max) max = data[i];
            }
            return max;
        }

        static int Min(int[] data)
        {
            int min = data[0];
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] < min) min = data[i];
            }
            return min;
        }

        static int GetSum(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;

        }
        static double GetAverage(int []a)
        {
            int sum = GetSum(a);
            return sum / a.Length;

        }
    }
}
