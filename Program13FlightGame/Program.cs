using System;

namespace Program13FlightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //开场白
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*****************************");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*****************************");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*****************************");
            Console.WriteLine("**死亡版绅士飞行棋游戏--v1.0*");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*****************************");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("*****************************");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("*****************************");
            Console.WriteLine("请输入玩家A的姓名");

            string NameA = Console.ReadLine();

            Console.WriteLine("请输入玩家B的姓名");

            string NameB = Console.ReadLine();

            Console.Clear(); //清空控制台

            Console.WriteLine("{0}的士兵用A表示", NameA);
            Console.WriteLine("{0}的士兵用B表示", NameB);

            Console.ForegroundColor = ConsoleColor.DarkYellow ; //设置字体颜色为暗黄
            

            //初始化地图
            string[] map = new string[] {"□","□","□", "□", "□","☆", "○", "□", "□", "△", "□", "□", "□", "☆", "□", "□", "□", "☆", "□", "□",
                "卍", "□", "□", "○", "□", "卍", "□", "△", "□", "□", "□", "□", "□", "☆", "□", "□", "□", "□", "☆", "□", "○", "□","□", "□", "□","卍", "□","□", "□", "□",
            "☆", "□", "□", "□", "□","○", "□","□", "□", "□","△", "□", "□","卍","☆","□", "□", "□", "□","○", "□", "□","卍","□", "□", "□", "□","□", "□", "□","☆","□", "□",
            "○", "□","□", "□", "□","卍","□","卍","□", "□","△","☆","□", "□","□", "□","□"};


            ShowMap(map);

            ActA(NameA,map);
           
        }
        public static void StartMap()
        {
            string[] map = new string[] {"□","□","□", "□", "□","☆", "○", "□", "□", "△", "□", "□", "□", "☆", "□", "□", "□", "☆", "□", "□",
                "卍", "□", "□", "○", "□", "卍", "□", "△", "□", "□", "□", "□", "□", "☆", "□", "□", "□", "□", "☆", "□", "○", "□","□", "□", "□","卍", "□","□", "□", "□",
            "☆", "□", "□", "□", "□","○", "□","□", "□", "□","△", "□", "□","卍","☆","□", "□", "□", "□","○", "□", "□","卍","□", "□", "□", "□","□", "□", "□","☆","□", "□",
            "○", "□","□", "□", "□","卍","□","卍","□", "□","△","☆","□", "□","□", "□","□"};
        } //初始化地图
        public static void ShowMap(string[] map) //绘制地图的方法
        {
            Console.WriteLine("图例:幸运轮盘○  地雷:☆  暂停:△   时空隧道:卍");
            for (int i = 0; i < map.Length; i++)
            {
              
                if (i > 29 && i < 34)
                {
                    Console.WriteLine();
                    Console.Write("                                                          " + map[i]);
                }
                else if (i == 34 )
                {
                   
                    Console.WriteLine();
                    Console.Write("                                                          " + map[i]);
                    Array.Reverse(map);
                    Console.WriteLine();
                }
                else if (i == 64 )
                {

                    
                    Console.WriteLine(map[i]);
                    Array.Reverse(map);

                }
                else if (i >= 64 && i <= 69)
                {
                    Console.WriteLine(map[i]);
                }
               
                
                else
                    Console.Write(map[i]);

            }
            Console.WriteLine();
        } 

        public static void ActA(string NameA, string[] map) //玩家A的行动回合
        {
            Console.WriteLine("玩家{0}按任意键开始掷骰子", NameA);
            Console.ReadKey();//按任意键继续
            Random Rnumber = new Random();//使用随机数
            int number = Rnumber.Next(1, 7);//控制随机数生成区间为1-6
            Console.WriteLine("玩家{0}掷出了{1}", NameA, number);
            Console.ReadKey();//按任意键
            Console.WriteLine("玩家{0}按任意键开始行动", NameA);
            Console.ReadKey();//按任意键
            Console.WriteLine("玩家{0}行动完了", NameA);
            Console.ReadKey();//按任意键
            string result = "踩到了方块,神马都不干";
            Console.WriteLine("玩家{0}{1}", NameA,result);
        }
    }
}
