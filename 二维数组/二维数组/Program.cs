using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二维数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region t1
            //int[,] a = new int[100, 100];
            //for(int i = 0; i < 10000; i++)
            //{
            //    int p1 = i / a.GetLength(0);
            //    a[p1, i % a.GetLength(0)] = i+1;
            //}
            //for(int i = 0; i < a.GetLength(0); i++)
            //{
            //    for(int j = 0; j < a.GetLength(1); j++)
            //    {
            //        Console.Write("   {0}", a[i, j]);
            //    }
            //}
            //#endregion

            //#region t2
            //int[,] b = new int[4, 4];
            //Random r = new Random();
            //for(int i = 0; i < b.GetLength(0); i++)
            //{
            //    for(int j= 0; j<b.GetLength(1); j++)
            //    {
            //        b[i, j] = r.Next(1, 101);
            //    }
            //}
            //for (int i = 0; i < b.GetLength(0); i++)
            //{
            //    for (int j = 0; j < b.GetLength(1); j++)
            //    {
            //        Console.Write("   {0}", b[i, j]);

            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //for (int i = 0; i < b.GetLength(0)/2; i++)
            //{
            //    for (int j = b.GetLength(1)/2; j < b.GetLength(1); j++)
            //    {
            //        b[i, j] = 0;
            //    }
            //}

            //for (int i = 0; i < b.GetLength(0); i++)
            //{
            //    for (int j = 0; j < b.GetLength(1); j++)
            //    {
            //        Console.Write("{0}   ", b[i,j]);
            //    }
            //    Console.WriteLine();
            //}


            //#endregion
            //#region t3
            //Random t = new Random();
            //int[,] c = new int[3, 3];
            //int sum = 0;
            //for(int i = 0; i < c.GetLength(0); i++)
            //{
            //    for(int j = 0; j < c.GetLength(1); j++)
            //    {
            //        c[i, j] = t.Next(1, 11);
            //    }
            //}


            //for (int i = 0; i < c.GetLength(0); i++) 
            //{
            //    for(int j = 0; j < c.GetLength(1); j++)
            //    {
            //        Console.Write("   {0}",c[i,j]);
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < c.GetLength(0); i++)
            //{
            //    sum += c[i, i];
            //}
            //Console.WriteLine("Sum = {0}",sum);
            //#endregion
            //#region t4
            //int[,] d = new int[5, 5];
            //Random s = new Random();
            //for(int i = 0; i < d.GetLength(0); i++)
            //{
            //    for(int j = 0; j < d.GetLength(1); j++)
            //    {
            //        d[i, j] = s.Next(1, 501);
            //    }
            //}
            //for (int i = 0; i < d.GetLength(0); i++)
            //{
            //    for (int j = 0; j < d.GetLength(1); j++)
            //    {
            //        Console.Write("   {0}", d[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //int max = d[0,0];
            //int x = 0, y = 0;
            //for (int i = 0; i < d.GetLength(0); i++)
            //{
            //    for (int j = 1; j < d.GetLength(1); j++)
            //    {
            //        if (d[i, j] > max) max = d[i,j];
            //        x = i;
            //        y = j;
            //    }
            //}
            //Console.WriteLine(" (x,y) = ({0},{0})", x+1, y+1);
            //#endregion

            #region t5

            int[,] e = new int[5, 5] {      
                {0,0,0,0,0 },
                {0,0,0,0,0 },
                {0,1,0,0,0 },
                {0,0,1,1,0 },
                {0,0,0,0,0 },
            };
            for (int i = 0; i < e.GetLength(0); i++)
            {
                for (int j = 0; j < e.GetLength(1); j++)
                {
                    Console.Write("   {0}", e[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("******************************");
            bool[] line = new bool[e.GetLength(1)];
            bool[] row = new bool[e.GetLength(0)];
            for(int i = 0; i < e.GetLength(0); i++)
            {
                for(int j = 0; j < e.GetLength(1); j++)
                {
                    if(e[i,j] == 1 )
                    {
                        line[j] = true;
                        row[i] = true;
                    }
                }
            }
            for (int i = 0; i < e.GetLength(0); i++)
            {
                for (int j = 0; j < e.GetLength(1); j++)
                {
                    if (row[i] || line[j]) e[i,j] = 1;
                }
            }
            for (int i = 0; i < e.GetLength(0); i++)
            {
                for (int j = 0; j < e.GetLength(1); j++)
                {
                    Console.Write("   {0}", e[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            #endregion




        }
    }
}
