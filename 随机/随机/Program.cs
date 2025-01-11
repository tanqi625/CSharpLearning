using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 随机
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random r = new Random();
            int monsterHeath = 20;
            int monsterDefence = 10;
            while (monsterHeath >0)
            {
                
                int attackForce = r.Next(8, 13);
                if (attackForce > monsterDefence)
                {
                    monsterHeath = monsterHeath - (attackForce - monsterDefence);
                    Console.WriteLine("怪兽受到{0}点伤害", attackForce - monsterDefence);
                }
            }
            Console.WriteLine("怪兽死亡");
            Console.ReadKey();
        }
    }
}
