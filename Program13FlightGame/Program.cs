using System;

namespace Program13FlightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("图例:幸运轮盘○  地雷:☆  暂停:△   时空隧道:卍");

            string[] map = new string[] {"□","□","□", "□", "□","☆", "○", "□", "□", "△", "□", "□", "□", "☆", "□", "□", "□", "☆", "□", "□",
                "卍", "□", "□", "○", "□", "卍", "□", "△", "□", "□", "□", "□", "□", "☆", "□", "□", "□", "□", "☆", "□", "○", "□","□", "□", "□","卍", "□","□", "□", "□",
            "☆", "□", "□", "□", "□","○", "□","□", "□", "□","△", "□", "□","卍","☆","□", "□", "□", "□","○", "□", "□","卍","□", "□", "□", "□","□", "□", "□","☆","□", "□",
            "○", "□","□", "□", "□","卍","□","卍","□", "□","△","☆","□", "□","□", "□","□"};


            ShowMap(map);
        }
        public static void ShowMap(string[] map)
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
