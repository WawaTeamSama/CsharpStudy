using System;
using System.Collections;

namespace Program06
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一题内容
            //try
            //{
            MaxAndMinMethod();//调用方法 实现循环
                              //}
                              //catch 
                              //{
                              //    Console.WriteLine("您的输入不合法!");
                              //    MaxAndMinMethod();
                              //}

            //第二题内容
            //MultiplicationTable();
            
            
        }
        //1.输入一个不为0的整数，输出其中的最大值和最小值，输入数字0的时候结束循环。
        public static void MaxAndMinMethod() 
        {
           
            ArrayList arraylist = new ArrayList();//实例化一个ArrayList可变长数组
            Console.WriteLine("请输入一个整数(输入0结束)");

            int num;
            //检测用户输入的数是否为整数 3.13 并赋值给num
            while (!(int.TryParse(Console.ReadLine(),out num)))
            {
                Console.WriteLine("您的输入不合法,请重新输入一个整数(输入0结束)");
            }

           
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
        //2.实现9 * 9乘法表的功能
        public static void MultiplicationTable() 
        {
            int num1 = 1, num2 = 1;//定义两个乘数
            
            for(int i = 0; i < 9; i++) //此循环控制行数 一共有9行
            {
                Console.Write("{0}×{1}={2}", num1, num2, num1 * num2); 
                for(int y = 0; y < i; y++)//此循环控制列数 第几行就有几列
                {
                    if (i > 0) //第一行的乘数2不做加，所以从第二行开始乘数2才自增
                    {
                        num2++;
                    }
                    Console.Write("   {0}×{1}={2}", num1, num2, num1 * num2);
                    
                }
                num1++;//乘数1保持自增
                num2 = 1;//控制乘数2每次从1开始自增
                Console.WriteLine();//换行

            }
        }
    }
}
