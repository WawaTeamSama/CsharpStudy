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

            Console.WriteLine("求1-6的和为" + Test(6));
            Console.WriteLine("小兔子在第3年第1个月的对数为:" + Fibonacci(25));
        }
        public static int Add(int num1,int num2)
        {
            return num1 + num2;
        }
        //使用递归实现求1-n的和
        public static int Test(int n)
        {
            if (n == 1)
            {
                return n;
            }
            int tmp = Test(n - 1);
            return tmp + n;
        } 
        //3月13日作业小兔子问题 斐波那契数列
        public static int Fibonacci(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
