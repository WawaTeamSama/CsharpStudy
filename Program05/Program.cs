using System;

namespace Program05
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义了三个为0的整型
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            //定义两个布尔类型变量
            bool result1, result2;

            //&运算符指示在不满足前置条件的情况下,后置条件也会执行
            result1 = num1 > 0 & num2++ > 1;
            Console.WriteLine(result1);
            Console.WriteLine("num2=" + num2);

            //&&运算符指示在不满足前置条件的情况下,后置条件将不会执行
            result2 = num1 > 0 && num3++ > 1;
            Console.WriteLine(result2);
            Console.WriteLine("num3=" + num3);
        }
    }
}
