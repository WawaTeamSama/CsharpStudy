using System;

namespace Program09Const
{
    class Program
    {
        static void Main(string[] args)
        {
            //变量
            var number1 = 1;
            number1 = 2;
            Console.WriteLine("变量:" + number1);
            //常量 在程序中不能改变
            const int number2 = 3;
            //number2 = 4;
            Console.WriteLine("常量:" + number2);

        }
    }
}
