using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 成员变量和访问修饰符
{
    class Person
    {
        public int age;

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Person p1 = new Person();
            //Person p2 = p1;
            //p1.age = 11;
            //Console.WriteLine(p2.age);

            //p2.age = 20;
            //Console.WriteLine(p1.age);
            string s1 = "111";
            string s2 = s1;
            s2 = "222";
            Console.WriteLine(s1);
            
            Console.ReadKey();
            
        }
    }
}
