using System;

namespace Program12MyColor
{
    //1.定义一个结构叫MyColor，有三个成员，分别定义为int类型的red,green,blue
    //声明一个MyColor类型的变量，并对其进行赋值，使MyColor可以表示成一个红色

        public struct MyColor
    {
       public int red;
       public int green;
       public int blue;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyColor my;
            my.red = 1;
            Console.WriteLine(my.red);

        }
    }
}
