using System;

namespace Program07MethodTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(4,4));
            Console.WriteLine("3度的余弦值:" + Math.Cos(3));
            Console.WriteLine("2的4次方" + Math.Pow(2, 4));
        }
        public static int Add(int num1,int num2)
        {
            return num1 + num2;
        }
    }
}
