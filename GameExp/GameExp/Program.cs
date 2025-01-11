using System;

namespace GameExp
{
    class Program
    {
        public static bool IsWin ;
        public static int width = 50;
        public static int hight = 30;
        public static int nowStage = 0;
        

        #region 公主属性
        public static string PrincessName = "小马珍珠";
        public static string PrincesssIcon = "Φ";
        public static int PrincessPositionX = 14;
        public static int PrincessPositionY = 10;
        public static bool IsPrincessExit = false;
        public static ConsoleColor PrincessColor = ConsoleColor.Magenta;
        #endregion

        #region BOSS属性
        public static int bossHealth;
        public static int bossAttackMax = 20;
        public static int bossAttackMin = 10;
        public static int bossPositionX = 20;
        public static int bossPositionY = 15;


        public static ConsoleColor bossColor = ConsoleColor.Green;
        public static string bossIcon = "●";
        public static string bossName = "八足马";

        #endregion
        #region 玩家属性
        public static int playerHealth;
        public static int playerAttackMax = 20;
        public static int playerAttackMin = 10;
        public static int playerPositionX;
        public static int playerPositionY;


        public static ConsoleColor playerColor = ConsoleColor.Yellow;
        public static string playerIcon = "◇";
        public static string playerName = "丁真";
        #endregion

        static void Main(string[] args)
        {

            //窗口初始化
            SetGameWindow();



            //游戏主控逻辑
            while (true)
            {
                playerHealth = 100;
                bossHealth = 100;
                playerPositionX = 20;
                playerPositionY = 10;
                
                switch (nowStage)
                {
                    case 0:
                        StartMenu();
                        break;
                    case 1:
                        
                        PlayGame();
                        break;
                    case 2:
                        GameOver();
                        IsWin = false;
                        break;



                }




            }






        }
        public static void SetGameWindow()
        {
            Console.CursorVisible = false; //隐藏光标
            Console.SetWindowSize(width, hight);//设置舞台大小
            Console.SetBufferSize(width, hight);//设置缓冲区大小


        }
        public static void  StartMenu()
        {
            Console.Clear();
            Console.SetCursorPosition(width / 2 - (2 + PrincessName.Length), 8);//设置居中标题
            Console.Write("拯救{0}", PrincessName);
            int nowSelection = 1; //当前选中的选项
            bool isExit = false;
            while (!isExit)
            {

                Console.ForegroundColor = (nowSelection == 1) ? ConsoleColor.Red : ConsoleColor.White;
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
                        if (nowSelection == 1)
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
            

        }
        public static void DrawWall()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < width - 1; i++)
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
        }
        public static void DrawBoss()
        {
            Console.SetCursorPosition(bossPositionX, bossPositionY);
            Console.ForegroundColor = bossColor;
            Console.Write(bossIcon);
        }
        public static void DrawPlayer()
        {
            //Console.Write("  ");
            Console.SetCursorPosition(playerPositionX, playerPositionY);
            Console.ForegroundColor = playerColor;

            Console.Write(playerIcon);

        }
        

        public static void PlayGame()
        {
            bool isFighting = false;
            char operation;
            bool IsGaming = true;
            DrawWall();
            while (IsGaming)
            {
                if (bossHealth > 0) DrawBoss();
                else
                {
                    IsPrincessExit = true;
                    Console.ForegroundColor = PrincessColor;
                    Console.SetCursorPosition(PrincessPositionX, PrincessPositionY);
                    Console.Write(PrincesssIcon);
                }
                DrawPlayer();
                operation = Console.ReadKey(true).KeyChar;
                if (!isFighting)//玩家移动机制
                {
                    Console.SetCursorPosition(playerPositionX, playerPositionY);
                    Console.Write("  ");
                    switch (operation)
                    {
                        case 'w':
                        case 'W':
                            if (playerPositionY - 1 > 0 && playerPositionY - 1 != hight - 6 && playerPositionY - 1 != hight - 2 && !IsBossPosition(playerPositionX, playerPositionY - 1) )
                            {
                                if(!IsPrincessPosition(playerPositionX, playerPositionY - 1))
                                playerPositionY -= 1;
                            }
                            break;
                        case 's':
                        case 'S':
                            if (playerPositionY + 1 <= hight && playerPositionY + 1 != hight - 6 && playerPositionY + 1 != hight - 2 && !IsBossPosition(playerPositionX, playerPositionY + 1) )
                            {
                                if (!IsPrincessPosition(playerPositionX, playerPositionY + 1))
                                    playerPositionY += 1;
                            }
                            break;
                        case 'A':
                        case 'a':
                            if (playerPositionX - 2 > 1 && !IsBossPosition(playerPositionX - 2, playerPositionY) )
                            {
                                if(!IsPrincessPosition(playerPositionX - 2, playerPositionY))
                                playerPositionX -= 2;
                            }
                            break;
                        case 'D':
                        case 'd':
                            if (playerPositionX + 2 < width && playerPositionX + 2 != width - 2 && !IsBossPosition(playerPositionX + 2, playerPositionY) )
                            {
                                if(!IsPrincessPosition(playerPositionX + 2, playerPositionY))
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
                                Console.Write("玩家{0}当前血量为{1}", playerName, playerHealth);
                                Console.SetCursorPosition(2, hight - 3);
                                Console.Write("BOSS{0}当前血量为{1}", bossName, bossHealth);


                            }
                            else if (IsNearPrincess())
                            {

                                
                                nowStage = 2;
                                IsGaming = false;

                            }

                            break;
                    }

                }
                else //进入战斗状态
                {
                    if (operation == 'J' || operation == 'j')
                    {
                        Random R = new Random();
                        int playerCurrentATK = R.Next(playerAttackMin, playerAttackMax);
                        bossHealth -= playerCurrentATK;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(2, hight - 4);
                        Console.Write("                                              ");
                        Console.SetCursorPosition(2, hight - 4);
                        Console.Write("{0}对BOSS{1}产生了{2}点伤害,Boss当前血量{3}", playerName, bossName, playerCurrentATK, bossHealth);
                        if (bossHealth > 0)
                        {
                            int bossCurrentATK = R.Next(bossAttackMin, bossAttackMax);
                            playerHealth -= bossCurrentATK;
                            if (playerHealth <= 0)
                            {
                                IsWin = false;
                                Console.SetCursorPosition(2, hight - 4);
                                Console.Write("                                              ");
                                Console.SetCursorPosition(2, hight - 3);
                                Console.Write("                                              ");
                                Console.SetCursorPosition(2, hight - 5);
                                Console.Write("                                              ");
                                Console.SetCursorPosition(2, hight - 5);
                                Console.ForegroundColor = ConsoleColor.White;
                                
                                Console.Write("{0}在和{1}激战中不幸阵亡,让我们缅怀ta", playerName, bossName);
                                Console.SetCursorPosition(2, hight - 4);
                                Console.ReadKey(true);
                                Console.Write("按J键重新开始游戏");
                                
                                nowStage = 2;
                                break;
                                


                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(2, hight - 3);
                            Console.Write("                                              ");
                            Console.SetCursorPosition(2, hight - 3);
                            Console.Write("{0}对玩家{1}产生了{2}点伤害,玩家当前血量{3}", bossName, playerName, bossCurrentATK, playerHealth);
                            
                        }
                        
                        else  //boss 已经死亡状态
                        {
                            IsWin = true;
                            Console.SetCursorPosition(bossPositionX, bossPositionY);
                            Console.Write("  ");
                            Console.SetCursorPosition(2, hight - 4);
                            Console.Write("                                              ");
                            Console.SetCursorPosition(2, hight - 3);
                            Console.Write("                                              ");
                            Console.SetCursorPosition(2, hight - 5);
                            Console.Write("                                              ");
                            Console.SetCursorPosition(2, hight - 5);
                            Console.ForegroundColor = ConsoleColor.White;
                            
                            Console.Write("恭喜你，战胜了BOSS,快去拯救{0}吧", PrincessName);
                            Console.SetCursorPosition(2, hight - 4);
                            
                            Console.Write("按J键继续");
                            Console.SetCursorPosition(bossPositionX, bossPositionY);
                            Console.Write("  ");
                            isFighting = false;
                            //break;


                        }


                    }

                }


            }


        }

        static bool IsBossPosition(int PositionX,int PositionY)
        {
            if(bossHealth >= 0 && PositionX ==bossPositionX && PositionY == bossPositionY)
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
            if (bossHealth < 0) return false;
            if (playerPositionX == bossPositionX && Math.Abs( playerPositionY - bossPositionY) ==1 || playerPositionY == bossPositionY && Math.Abs(playerPositionX - bossPositionX) == 2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static bool IsPrincessPosition(int PositionX, int PositionY)
        {
            if (bossHealth<=0&& PositionX == PrincessPositionX  && PositionY == PrincessPositionY)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static bool IsNearPrincess()
        {
            if (bossHealth > 0) return false;
            if (playerPositionX == PrincessPositionX && Math.Abs(playerPositionY - PrincessPositionY) == 1 || playerPositionY == PrincessPositionY && Math.Abs(playerPositionX - PrincessPositionX) == 2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static void GameOver()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(width / 2 - 4, 8);//设置居中标题
            Console.Write("GameOver");
            if(IsWin)
            {             
                Console.SetCursorPosition(width / 2 - 4, 10);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("游戏通关");
            }

            int nowSelection = 1; //当前选中的选项
            bool isExit = false;
            while (!isExit)
            {

                Console.ForegroundColor = (nowSelection == 1) ? ConsoleColor.Red : ConsoleColor.White;
                Console.SetCursorPosition(width / 2 - 5, 13);
                Console.Write("回到主菜单");
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
                        if (nowSelection == 1)
                        {
                            nowStage = 0;
                            isExit = true;
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                        break;


                }

            }


        }
    }
}
