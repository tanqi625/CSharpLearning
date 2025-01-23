using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 成员属性
{
    class Student
    {
        
        public char sex;
        public int age;
        public int CSharpGrade;
        public int UnityGrade;
        public string Name
        {
            set;
            get;
        }
        public void SayHello()
        {
            Console.WriteLine("{0} {1} {2} {3} {4}", Name, sex, age, CSharpGrade + UnityGrade, (CSharpGrade + UnityGrade) / 2);
        }
        public int Age
        {
            set
            {
                if (value >= 0 && value <= 150) age = value;
                else age = 0;
            }
            get
            {
                return age;
            }
        }
        public int CSharpgrade
        {
            set
            {
                if (value >= 0 && value <= 100) CSharpGrade = value;
                else { CSharpGrade = 0; }
            }
            get
            {

                return CSharpGrade;
            }


        }
        public int Unitygrade
        {
            set
            {
                if (value >= 0 && value <= 100) UnityGrade = value;
            }
            get
            {

                return UnityGrade;
            }


        }
        public char Sex
        {
            set
            {
                if (value == '男' || value == '女') sex = value;
            }
            get
            {
                return sex;
            }
        }
        
        class Program
        {
            static void Main(string[] args)
            {
                Student s1 = new Student();
                Student s2 = new Student();
                s1.Name = "牛马";                                     
                s1.Sex = '男';
                s1.Unitygrade = 100;
                s1.CSharpgrade = 999;
                s1.SayHello();
                Console.ReadKey();
            }
        }


    }
}
