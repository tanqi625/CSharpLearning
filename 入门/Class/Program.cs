using System;
namespace LineApplication
{
    class Line
    {
        private double length;   // 线条的长度
        public Line()  // 构造函数
        {
            Console.WriteLine("对象已创建");
        }
        ~Line() //析构函数
        {
            Console.WriteLine("对象已删除");
        }

        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }

        static void Main(string[] args)
        {
            Line line = new Line();
            // 设置线条长度
            line.setLength(6.0);
            Console.WriteLine("线条的长度： {0}", line.getLength());
            Console.ReadKey();
        }
    }
}