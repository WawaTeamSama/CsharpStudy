using System;

namespace Program13FlightGame
{
    class Program
    {
        static void Main(string[] args)
        {

            //1 画游戏头
            //2 输入玩家姓名
            //3 初始化飞行棋地图
            //4 显示地图
            //5 循环走棋
            //6 显示胜利画面
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
            if(string.IsNullOrEmpty(NameA))
            {
                Console.WriteLine("玩家名字不能为空！");

            }

            Console.WriteLine("请输入玩家B的姓名");

            
            string NameB = Console.ReadLine();
            if(string.IsNullOrEmpty(NameB))
            {
               Console.WriteLine("玩家名字不能为空！");            
            }
            if(NameB==NameA)
                Console.WriteLine("玩家名字不能重复！");
            

            Console.Clear(); //清空控制台

            Console.WriteLine("{0}的士兵用A表示", NameA);
            Console.WriteLine("{0}的士兵用B表示", NameB);

            Console.ForegroundColor = ConsoleColor.DarkYellow ; //设置字体颜色为暗黄
            

            //用于游戏的地图 会改变的地图
            string[] map = new string[] {"□","□","□", "□", "□","☆", "○", "□", "□", "△", "□", "□", "□", "☆", "□", "□", "□", "☆", "□", "□",
                "卍", "□", "□", "○", "□", "卍", "□", "△", "□", "□", "□", "□", "□", "☆", "□", "□", "□", "□", "☆", "□", "○", "□","□", "□", "□","卍", "□","□", "□", "□",
            "☆", "□", "□", "□", "□","○", "□","□", "□", "□","△", "□", "□","卍","☆","□", "□", "□", "□","○", "□", "□","卍","□", "□", "□", "□","□", "□", "□","☆","□", "□",
            "○", "□","□", "□", "□","卍","□","卍","□", "□","△","☆","□", "□","□", "□","□"};

            //原始地图 不做改变的地图
            string[] map2 = new string[] {"□","□","□", "□", "□","☆", "○", "□", "□", "△", "□", "□", "□", "☆", "□", "□", "□", "☆", "□", "□",
                "卍", "□", "□", "○", "□", "卍", "□", "△", "□", "□", "□", "□", "□", "☆", "□", "□", "□", "□", "☆", "□", "○", "□","□", "□", "□","卍", "□","□", "□", "□",
            "☆", "□", "□", "□", "□","○", "□","□", "□", "□","△", "□", "□","卍","☆","□", "□", "□", "□","○", "□", "□","卍","□", "□", "□", "□","□", "□", "□","☆","□", "□",
            "○", "□","□", "□", "□","卍","□","卍","□", "□","△","☆","□", "□","□", "□","□"};

            int positionA = 0;//用于记录A当前的位置

            int positionB = 0;//用于记录B当前的位置

            string messageA = "";//用于记录A的信息

           

            string[] orderA ;//用于记录信息所给出的指示

            string[] orderB;//用于记录B信息所给出的指示

            int pauseA = 1;//用于设置A是否跳过回合

            int pauseB = 1;//用于设置B是否跳过回合

            int end = 0; //用于指示游戏是否结束 0表示继续 1表示结束

            for (int i=1; end==0;i++ )
            {
               

                ShowMap(map);

                if (i == 1)
                {
                    messageA = ActA(NameA, map, positionA, positionB,map2[positionA]);

                    
                }

                orderA = messageA.Split(",");//解析A的信息 传出的信息分别为0/1 positionA positionB
                positionA =Convert.ToInt32(orderA[1]);
                positionB = Convert.ToInt32(orderA[2]);
               
                if (pauseA == 1 && i > 1)
                {
                    messageA = ActA(NameA, map, positionA, positionB, map2[positionA]);
                    if (messageA == "3")//3的返回值表示游戏结束
                    {
                        Console.WriteLine("玩家{0}获得胜利！", NameA);
                        end = 1;
                    }
                }
                else if (orderA[0] == "0" && i > 1)
                {
                    pauseA = 1;
                }

                Console.Clear();

                ShowMap(map);
                if (i == 1)
                {
                    messageA = ActB(NameB, map, positionA, positionB, map2[positionB]);
                }
                
                orderB = messageA.Split(",");
                positionA = Convert.ToInt32(orderB[1]);
                positionB = Convert.ToInt32(orderB[2]);
                if (pauseB==1 && i > 1)
                {
                    messageA = ActB(NameB, map, positionA, positionB, map2[positionB]);
                    if (messageA == "3")
                    {
                        Console.WriteLine("玩家{0}获得胜利！", NameB);
                        end = 1;
                    }
                }
                else if (orderB[0] == "0" && i > 1)
                {
                    pauseB = 1;
                }
                pauseA = Convert.ToInt32(orderA[0]);
                pauseB = Convert.ToInt32(orderB[0]);

               
                   
                
              
                   
                
                Console.Clear();
            }
            Showvictory();
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
              if(map[i]== "○")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
              else if(map[i]== "☆")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (map[i] == "△")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (map[i] == "卍")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
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

        public static string ActA(string NameA, string[] map,int positionA,int positionB,string under) //玩家A的行动回合
        {
            
            map[positionA] = under; //重置之前踩过的地方
            Console.WriteLine("玩家{0}按任意键开始掷骰子", NameA);
            Console.ReadKey();//按任意键继续
            Random Rnumber = new Random();//使用随机数
            int number = Rnumber.Next(1, 7);//控制随机数生成区间为1-6
            Console.WriteLine("玩家{0}掷出了{1}", NameA, number);
            Console.ReadKey();//按任意键
            Console.WriteLine("玩家{0}按任意键开始行动", NameA);
            Console.ReadKey();//按任意键
            positionA += number;
            if (positionA > map.Length) //结束游戏
            {
                return "3";
            }
            string task = map[positionA];//用于获取此时A走到的格子是否有事件

            string result = "踩到了方块  神马都不干";
            if (task== "☆")
            {
                result = "踩到了地雷 退6格";
                //map[positionA] = task;
                positionA -= 6;
                if (positionA < 0)
                    positionA = 0;
                

                
            }
            else if (task =="卍")
            {
                result = "踩到了时空隧道 进10格"; 
                positionA += 10;
                if (positionA > map.Length) //结束游戏
                {
                    return "3";
                }
            }
             
            else if(task== "△")
            {
                map[positionA] = "A";
                Console.WriteLine("玩家{0}行动完了", NameA);
                Console.ReadKey();//按任意键
                result = "踩到了暂停  暂停一回合  ";
                Console.WriteLine("玩家{0}{1}", NameA, result);
                Console.ReadKey();//按任意键
                return "0,"+positionA+","+positionB;//返回0表示下次的回合被跳过
            }
            else if (task == "B")
            {
                result = "踩到了玩家B 玩家B退6格";
                positionB -= 6;
                if (positionB < 0)
                {
                    positionB = 0;
                }
            }

            map[positionB] = "B";
            map[positionA] = "A";
            Console.WriteLine("玩家{0}行动完了", NameA);
            Console.ReadKey();//按任意键

            if (task == "○")
            {             
                Console.WriteLine("踩到了幸运轮盘 1交换位置  2 轰炸对方 使对方退6格");
                int order = Convert.ToInt32(Console.ReadLine());
                if (order == 1)
                {
                    int tmp = positionA;
                    positionA = positionB;
                    positionB = tmp;

                    map[positionA] = "A";
                    map[positionB] = "B";
                    return "1," + positionA + "," + positionB;
                }
                else{
                    positionB -= 6;
                    if (positionB < 0)
                        positionB = 0;
                    map[positionB] = "B";
                    return "1," + positionA + "," + positionB;
                }
            }
            else
            {
                Console.WriteLine("玩家{0}{1}", NameA, result);
                Console.ReadKey();//按任意键
                return "1," + positionA + "," + positionB;
            }

            
        }

        public static string ActB(string NameB,string[] map, int positionA, int positionB,string under)
        {
           

            map[positionB] = under; //重置之前踩过的地方
            Console.WriteLine("玩家{0}按任意键开始掷骰子", NameB);
            Console.ReadKey();//按任意键继续
            Random Rnumber = new Random();//使用随机数
            int number = Rnumber.Next(1, 7);//控制随机数生成区间为1-6
            Console.WriteLine("玩家{0}掷出了{1}", NameB, number);
            Console.ReadKey();//按任意键
            Console.WriteLine("玩家{0}按任意键开始行动", NameB);
            Console.ReadKey();//按任意键
            positionB += number;
            if (positionB > map.Length) //结束游戏
            {
                return "3";
            }
            string task = map[positionB];//用于获取此时A走到的格子是否有事件

            string result = "踩到了方块  神马都不干";
            if (task == "☆")
            {
                result = "踩到了地雷 退6格";
                //map[positionA] = task;
                positionB -= 6;
                if (positionB < 0)
                    positionB = 0;


            }
            else if (task == "卍")
            {
                result = "踩到了时空隧道 进10格";
                positionB += 10;
                if (positionB > map.Length) //结束游戏
                {
                    return "3";
                }
            }

            else if (task == "△")
            {
                map[positionA] = "A";
                Console.WriteLine("玩家{0}行动完了", NameB);
                Console.ReadKey();//按任意键
                result = "踩到了暂停  暂停一回合  ";
                Console.WriteLine("玩家{0}{1}", NameB, result);
                Console.ReadKey();//按任意键
                return "0," + positionA + "," + positionB; ;//返回0表示下次的回合被跳过
            }
            else if (task == "A")
            {
                result = "踩到了玩家A 玩家B退6格";
                positionA -= 6;
                if (positionA < 0)
                {
                    positionA = 0;
                }
            }
            map[positionA] = "A";
            map[positionB] = "B";
            Console.WriteLine("玩家{0}行动完了", NameB);
            Console.ReadKey();//按任意键
            
                if (task == "○")
                {
                    Console.WriteLine("踩到了幸运轮盘 1交换位置  2 轰炸对方 使对方退6格");
                    int order = Convert.ToInt32(Console.ReadLine());
                    if (order == 1)
                    {
                        int tmp = positionA;
                        positionA = positionB;
                        positionB = tmp;

                        map[positionA] = "A";
                        map[positionB] = "B";
                        return "1," + positionA + "," + positionB; //返回0表示下次的回合被跳过
                    }
                    else
                    {
                        positionA -= 6;
                        if (positionA < 0)
                            positionA = 0   ;
                        map[positionA] = "A";
                        return "1," + positionA + "," + positionB;
                    }
                }


                else
                {
                    Console.WriteLine("玩家{0}{1}", NameB, result);
                    Console.ReadKey();//按任意键
                    return "1," + positionA + "," + positionB;  //返回1表示回合未被暂停
                }
            }
        public static void Showvictory()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                          ◆                      ");
            Console.WriteLine("                    ■                  ◆               ■        ■");
            Console.WriteLine("      ■■■■  ■  ■                ◆■         ■    ■        ■");
            Console.WriteLine("      ■    ■  ■  ■              ◆  ■         ■    ■        ■");
            Console.WriteLine("      ■    ■ ■■■■■■       ■■■■■■■   ■    ■        ■");
            Console.WriteLine("      ■■■■ ■   ■                ●■●       ■    ■        ■");
            Console.WriteLine("      ■    ■      ■               ● ■ ●      ■    ■        ■");
            Console.WriteLine("      ■    ■ ■■■■■■         ●  ■  ●     ■    ■        ■");
            Console.WriteLine("      ■■■■      ■             ●   ■   ■    ■    ■        ■");
            Console.WriteLine("      ■    ■      ■            ■    ■         ■    ■        ■");
            Console.WriteLine("      ■    ■      ■                  ■               ■        ■ ");
            Console.WriteLine("     ■     ■      ■                  ■           ●  ■          ");
            Console.WriteLine("    ■    ■■ ■■■■■■             ■              ●         ●");
            Console.ResetColor();
        }


        }
    }

