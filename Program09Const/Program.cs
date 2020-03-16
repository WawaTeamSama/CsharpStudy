using System;

namespace Program09Const
{
    class Program
    {
        //static readonly是动态常量，常量的值在编译期间不解析，所以开始都是默认值，X与Y都是int类型，故都是0。
        //而在程序执行到X=Y*10;所以X=0*10=0,程序接着执行到Y=10这句时候，才会真正的Y的初值10赋给Y。
        static readonly int x = y * 2;
        static readonly int y = 1;

        //const是静态常量，所以在编译的时候就将A与B的值确定下来了

        static void Main(string[] args)
        {
            ////变量
            //var number1 = 1;
            //number1 = 2;
            //Console.WriteLine("变量:" + number1);
            ////Const常量 在程序中不能改变
            //const int number2 = 3;
            ////number2 = 4;
            //Console.WriteLine("常量:" + number2);

            Console.WriteLine("x:" + x + " y:" + y);
        }
    }
}
