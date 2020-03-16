using System;

namespace Program13FlightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow ; //设置字体颜色为暗黄
            Console.WriteLine("图例:幸运轮盘○  地雷:☆  暂停:△   时空隧道:卍");

            //初始化地图
            string[] map = new string[] {"□","□","□", "□", "□","☆", "○", "□", "□", "△", "□", "□", "□", "☆", "□", "□", "□", "☆", "□", "□",
                "卍", "□", "□", "○", "□", "卍", "□", "△", "□", "□", "□", "□", "□", "☆", "□", "□", "□", "□", "☆", "□", "○", "□","□", "□", "□","卍", "□","□", "□", "□",
            "☆", "□", "□", "□", "□","○", "□","□", "□", "□","△", "□", "□","卍","☆","□", "□", "□", "□","○", "□", "□","卍","□", "□", "□", "□","□", "□", "□","☆","□", "□",
            "○", "□","□", "□", "□","卍","□","卍","□", "□","△","☆","□", "□","□", "□","□"};


            ShowMap(map);
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
        } 
    }
}
