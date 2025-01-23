using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct Student{
        public int age;
        public int grade;
        public string name;
        public Student(int age, int grade,string name)
        {
            this.age = age;
            this.grade = grade;
            this.name = name;

        }



    }
    struct Monster
    {
        public int HP;
        public  string name;
        public int ATK;

        Random r;
        public Monster(string name)
        {
            this.name = name;
            HP = 100;
            r = new Random();
            ATK = r.Next(10, 30);
        }
    }
    struct Player
    {
        string name;
        string role;
        string skill;
        public Player(string name,string role)
        {
            this.name = name;
            this.role = role;
            skill = "";
            switch (role)
            {
                case "战士":
                    skill = "冲锋";
                    break;
                case "猎人":
                    skill = "冲锋";
                    break;
                case "法师":
                    skill = "冲锋";
                    break;
            }
        }
        public void Print()
        {
            Console.WriteLine("名字----职业--技能");
            Console.WriteLine("{0}    {1}  {2}",name,role,skill);



        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //string name = Console.ReadLine();
            //string role = Console.ReadLine();
            //Player p = new Player(name,role);
            //p.Print();
            
            Monster[] m = new Monster[10];
            for (int i = 0; i < m.Length; i++)
            {
                m[i] = new Monster("小怪兽" + i);
                Console.WriteLine("{0}造成{1}", m[i].name, m[i].ATK);

            }
            Console.ReadKey();
        }
    }
}
