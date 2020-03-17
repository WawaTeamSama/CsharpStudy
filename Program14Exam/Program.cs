using System;

namespace Program14Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.从一个整数数组中取出最大的整数，最小整数，总和，平均值
            //int[] intArray = new int[] { 5, 63, 27, 47, 4 };

            //Array.Sort(intArray);//将数组排序（从小到大）

            //int max = intArray[intArray.Length - 1];
            //int min = intArray[0];
            
            //int sum = 0; //总和
            //double ave = 0;//平均值
            //foreach(int i in intArray)
            //{
            //    sum += i;
            //}

            //ave = sum / intArray.Length;
            //Console.WriteLine("最大值{0},最小值{1},总和{2},平均值{3}", max, min, sum, ave);

            //3.数组里的人名分割
            //string[] strArray = new string[] { "老杨", "老苏", "老马", "老牛" };
            //foreach(string i in strArray)
            //{
            //    Console.Write(i + "|");
            //    if(i==strArray[strArray.Length-1])
            //    {
            //        Console.Write(i);
            //    }
            //}

            //4
            int[] intArray = new int[] { 457, 12, 6, 4, -6, -641, -132, 0, 5, 1, -5 };
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                if (intArray[i] > 0)
                {
                    intArray[i] += 1;
                    Console.WriteLine(intArray[i]);
                }
                else if (intArray[i] < 0)
                {
                    intArray[i] -= 1;
                    Console.WriteLine(intArray[i]);
                }
                else
                {
                    Console.WriteLine(intArray[i]);
                }
            }
            //5.
            string[] GoodMan = new string[] { "我", "是", "好人" };

            for(int i = 0; i < GoodMan.Length - 1; i++)
            {
                string tmp = GoodMan[i];
                GoodMan[i] = GoodMan[GoodMan.Length - 1 - i];
                GoodMan[GoodMan.Length - 1 - i] = tmp;
            }
            foreach(string i in GoodMan)
            {
                Console.Write(i);
            }
            


        }

        
        
        }
    }

