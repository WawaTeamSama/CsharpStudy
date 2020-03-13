using System;

namespace Program08Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("第一题,当n为4时:"+Recursion(4));
            Console.WriteLine("第一题的非递归算法那,当n为5时:" + NoRecursion(5));
        }
        //1.用递归和非递归计算1* 2 * 3 ... n的值
        //递归算法
        public static int Recursion(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return Recursion(n - 1) * n;
            }
        }
        //非递归算法
        public static int NoRecursion(int n) 
        {
            int result = 1;
            if (n == 1)
            {
                return result;
            }
            else
            {
                for(int i = 1; i <= n; i++)
                {
                    result = i*result;
                }
                return result;
            }
        }
        //2.用递归和非递归遍历密码组合，已知密码由a、b、c组成，密码只有3位字符，列出所有可能的密码组合
    }
}
