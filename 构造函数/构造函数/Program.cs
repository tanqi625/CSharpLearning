using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 构造函数
{
    class Person
    {
        int age;
        public Person()
        {
            Console.WriteLine("人类创建了");
        }
        public Person(int age):this()
        {
            this.age = age;
        }


    }
    class Ticket
    {
       uint distance;
       float price;
        public Ticket(uint distance)
        {
            this.distance = distance;
            GetPrice();
        }
        public void GetPrice()
        {
            if (this.distance <= 100)
                this.price = this.distance;
            else if (this.distance > 100 && this.distance <= 200) this.price += (distance ) * 0.95f;
            else if (this.distance > 201 && this.distance <= 300) this.price += (distance) * 0.9f;
            else this.price += (distance) * 0.8f;
        }
        public void Print() 
        {
            Console.WriteLine("本次行程{0}消费{1}元", this.distance, this.price);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person(18);
            Ticket t = new Ticket(300);
            
            t.Print();
            Console.ReadKey();
        }
    }
}
