using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameExp
{
    class Program
    {
        public static int width = 50;
        public static int hight = 30;
        public static string PrincessName = "小马珍珠";

        #region BOSS属性
        public  static int bossHeath = 100;
        public static int bossAttackMax = 20;
        public static int bossAttackMin = 10;
        public static int bossPositionX = 20;
        public static int bossPositionY = 15;
        

        public static ConsoleColor bossColor = ConsoleColor.Green;
        public static string bossIcon = "●";
        public static string bossName = "八足马";

        #endregion
        #region 玩家属性
        public static int playerHeath = 100;
        public static int playerAttackMax = 20;
        public static int playerAttackMin = 10;
        public static int playerPositionX = 20;
        public static int playerPositionY = 10;
        

        public static ConsoleColor playerColor = ConsoleColor.Yellow;
        public static string playerIcon = "◇";
        public static string playerName = "丁真";
        #endregion

        static void Main(string[] args)
        {
            #region 窗口初始化

            Console.CursorVisible = false; //隐藏光标
            Console.SetWindowSize(width,hight);//设置舞台大小
            Console.SetBufferSize(width,hight);//设置缓冲区大小

            #endregion
            #region 多个场景
            //int stageStartMenu = 0;
            //int stageGame = 1;
            //int stageEnd = 2;
            int nowStage = 0;
            bool isFighting;
            while (true)
            {
                switch (nowStage)
                {
                    case 0:
                        #region 开始菜单逻辑
                        Console.Clear();
                        Console.SetCursorPosition(width / 2 - (2+ PrincessName.Length), 8);//设置居中标题
                        Console.Write("拯救{0}",PrincessName);
                        int nowSelection = 1; //当前选中的选项
                        bool isExit = false;
                        while (!isExit)
                        {
                            
                            Console.ForegroundColor = (nowSelection == 1 )? ConsoleColor.Red : ConsoleColor.White;
                            Console.SetCursorPosition(width / 2 - 4, 13);
                            Console.Write("开始游戏");
                            Console.SetCursorPosition(width / 2 - 4, 15);
                            Console.ForegroundColor = (nowSelection == 2) ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("退出游戏");
                            char input = Console.ReadKey(true).KeyChar;//检测玩家输入
                            switch (input)
                            {
                                case 'w':
                                case 'W':
                                    nowSelection = 1;
                                    break;
                                case 'S':
                                case 's':
                                    nowSelection = 2;
                                    break;
                                case 'J':
                                case 'j':
                                    if(nowSelection == 1)
                                    {
                                        nowStage = 1;
                                        isExit = true;
                                    }
                                    else
                                    {
                                        Environment.Exit(0);
                                    }
                                    break;


                            }

                        }
                        break;
                    #endregion 
                    case 1:
                        Console.Clear();
                        isFighting  = false;
                        #region 地图墙
                        Console.ForegroundColor = ConsoleColor.Red;
                        for(int i=0;i<width-1;i++)
                        {
                            Console.SetCursorPosition(i, 0);
                            Console.Write("■");
                            Console.SetCursorPosition(i, hight - 2);
                            Console.Write("■");
                            Console.SetCursorPosition(i, hight - 6);
                            Console.Write("■");
                        }
                        for (int j = 0; j < hight - 1; j++)
                        {
                            Console.SetCursorPosition(0, j);
                            Console.Write("■");
                            Console.SetCursorPosition(width - 2, j);
                            Console.Write("■");
                        }





                        #endregion
                        

                        char op;
                        while (true)
                        {
                            #region BOSS机制
                            if (bossHeath > 0) 
                            {                            
                                Console.SetCursorPosition(bossPositionX, bossPositionY);
                                Console.ForegroundColor = bossColor;

                                Console.Write(bossIcon);

                                #endregion
                                #region 玩家机制
                                Console.Write("  ");
                                Console.SetCursorPosition(playerPositionX, playerPositionY);
                                Console.ForegroundColor = playerColor;
                                
                                Console.Write(playerIcon);
                                op = Console.ReadKey(true).KeyChar;
                                if (!isFighting)//玩家移动机制
                                {
                                    Console.SetCursorPosition(playerPositionX, playerPositionY);
                                    Console.Write("  ");
                                    switch (op)
                                    {
                                        case 'w':
                                        case 'W':
                                            if (playerPositionY - 1 > 0 && playerPositionY - 1 != hight - 6 && playerPositionY - 1 != hight - 2 && !IsBossPosition(playerPositionX, playerPositionY - 1))
                                            {
                                                playerPositionY -= 1;
                                            }
                                            break;
                                        case 's':
                                        case 'S':
                                            if (playerPositionY + 1 <= hight && playerPositionY + 1 != hight - 6 && playerPositionY + 1 != hight - 2 && !IsBossPosition(playerPositionX, playerPositionY + 1))
                                            {
                                                playerPositionY += 1;
                                            }
                                            break;
                                        case 'A':
                                        case 'a':
                                            if (playerPositionX - 2 > 1 && !IsBossPosition(playerPositionX - 2, playerPositionY))
                                            {
                                                playerPositionX -= 2;
                                            }
                                            break;
                                        case 'D':
                                        case 'd':
                                            if (playerPositionX + 2 < width && playerPositionX + 2 != width - 2 && !IsBossPosition(playerPositionX + 2, playerPositionY))
                                            {
                                                playerPositionX += 2;
                                            }
                                            break;
                                        case 'J':
                                        case 'j':
                                            if (CanFight()) //战斗预备场景
                                            {
                                                isFighting = true;
                                                Console.SetCursorPosition(2, hight - 5);
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.Write("======开始战斗===按J键继续====================");

                                                Console.SetCursorPosition(2, hight - 4);
                                                Console.Write("玩家{0}当前血量为{1}", playerName, playerHeath);
                                                Console.SetCursorPosition(2, hight - 3);
                                                Console.Write("BOSS{0}当前血量为{1}", bossName, bossHeath);


                                            }

                                            break;
                                    }

                                }
                                else //进入战斗状态
                                {
                                    if(op == 'J' || op == 'j')
                                    {
                                        Random R = new Random();
                                        int playerCurrentATK = R.Next(playerAttackMin, playerAttackMax);
                                        bossHeath -= playerCurrentATK;
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.SetCursorPosition(2, hight - 4);
                                        Console.Write("                                              ");
                                        Console.SetCursorPosition(2, hight - 4);
                                        Console.Write("{0}对BOSS{1}产生了{2}点伤害,Boss当前血量{3}", playerName, bossName, playerCurrentATK,bossHeath);
                                        if(bossHeath > 0)
                                        {
                                            int bossCurrentATK = R.Next(bossAttackMin, bossAttackMax);
                                            playerHeath -= bossCurrentATK;
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.SetCursorPosition(2, hight - 3);
                                            Console.Write("                                              ");
                                            Console.SetCursorPosition(2, hight - 3);
                                            Console.Write("{0}对玩家{1}产生了{2}点伤害,玩家当前血量{3}", bossName, playerName, bossCurrentATK, playerHeath);
                                            if(playerHeath <= 0)
                                            {
                                                Console.SetCursorPosition(2, hight - 4);
                                                Console.Write("                                              ");
                                                Console.SetCursorPosition(2, hight - 3);
                                                Console.Write("                                              ");
                                                Console.SetCursorPosition(2, hight - 5);
                                                Console.Write("                                              ");
                                                Console.SetCursorPosition(2, hight - 5);
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.Write("{0}在和{1}激战中不幸阵亡,让我们缅怀ta",playerName,bossName);
                                                Console.SetCursorPosition(2, hight - 4);
                                                Console.Write("按J键重新开始游戏");
                                                nowStage = 2;
                                                break;


                                            }
                                        }
                                        else  //boss 已经死亡状态
                                        {
                                            Console.SetCursorPosition(2, hight - 4);
                                            Console.Write("                                              ");
                                            Console.SetCursorPosition(2, hight - 3);
                                            Console.Write("                                              ");
                                            Console.SetCursorPosition(2, hight - 5);
                                            Console.Write("                                              ");
                                            Console.SetCursorPosition(2, hight - 5);
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.Write("恭喜你，战胜了BOSS,快去拯救{0}吧",PrincessName);
                                            Console.SetCursorPosition(2, hight - 4);
                                            Console.Write("按J键继续");
                                            Console.SetCursorPosition(bossPositionX, bossPositionY);
                                            Console.Write("  ");
                                            isFighting = false;



                                        }


                                    }

                                }
                                
                                #endregion }
                            
                                    
                            }


                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("游戏结束");
                        break;

                }

            }
            #endregion
            
        }
        static bool IsBossPosition(int PositionX,int PositionY)
        {
            if(bossHeath != 0 && PositionX ==bossPositionX && PositionY == bossPositionY)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static bool CanFight()
        {
            if (playerPositionX == bossPositionX && Math.Abs( playerPositionY - bossPositionY) ==1 || playerPositionY == bossPositionY && Math.Abs(playerPositionX - bossPositionX) == 2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
