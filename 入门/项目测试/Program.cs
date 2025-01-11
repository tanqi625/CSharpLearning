using System;





namespace 项目测试
{
    /// <summary>
    /// </summary>
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("1");
            Console.WriteLine("2");
            //string x = Console.ReadLine();
            //int n = Convert.ToInt32(Console.ReadLine());
            Print('#',3);
            Console.ReadKey();

        }
        static void Print(char x , int n)
        {
            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= 2*n-1; j++)
                {
                    if((Math.Abs(j-(n+1)/2)) < i)
                    { 
                        Console.Write(x);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
