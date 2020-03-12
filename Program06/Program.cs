using System;
using System.Collections;

namespace Program06
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.输入一个不为0的整数，输出其中的最大值和最小值，输入数字0的时候结束循环。

            ArrayList arraylist = new ArrayList();//实例化一个ArrayList可变长数组
            Console.WriteLine("请输入一个整数(输入0结束)");
           
            int num = Convert.ToInt32(Console.ReadLine()); //获取用户第一个输入的数字
            arraylist.Add(num);//将用户第一个输入的数字添加到ArrayList数组中
            while (!(num == 0)) //当用户未输入0时,执行循环要求用户再次输入整数
            {
                Console.WriteLine("请输入一个整数(输入0结束)");
                num = Convert.ToInt32(Console.ReadLine());//获取用户输入的数字并更新整型变量num
                arraylist.Add(num);//将用户输入的最新的数字添加到ArrayList数组中
            }
            arraylist.Sort();//将数组排序
            Console.WriteLine("结束");
            Console.WriteLine("最大值是:" + arraylist[arraylist.Count - 1] + " 最小值:" + arraylist[1]);

        }
    }
}
