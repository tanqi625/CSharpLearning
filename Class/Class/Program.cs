using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Person
    {



    }
    class Program
    {


        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = p1;
            p2 = new Person();
            Console.ReadKey();
        }
    }
}
