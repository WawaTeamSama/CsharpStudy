using System;
using System.Collections;

namespace Program08Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("第一题的递归算法,当n为4时:"+Recursion(4));
            Console.WriteLine("第一题的非递归算法那,当n为5时:" + NoRecursion(5));

            //第二题的非递归算法
            Console.WriteLine("所有可能的密码组合有(非递归算法)");
            NoRecursion("a", "b", "c");


            
            //第二题的递归算法
            Console.WriteLine("所有可能的密码组合有(递归算法)");
            CodeRecursion(26);

        }
        //1.用递归和非递归计算1* 2 * 3 ... n的值
        //递归算法
        public static int Recursion(int n)
        {
            if (n == 1)//当到第一个数时 返回1
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
        //非递归算法
        public static void NoRecursion(string a ,string b ,string c)
        {
            string[] CodeNumber = new string[3] { a,b,c}; //建立数组 将密码的三个可能数输入进去
            ArrayList Code = new ArrayList();
            for(int i = 0; i < 3; i++)
            {
                for(int y = 0; y < 3; y++)
                {
                    for(int k = 0; k < 3; k++)
                    {
                        Code.Add(CodeNumber[i] + CodeNumber[y] + CodeNumber[k]);
                    }
                }
            }
            foreach(string i in Code)//遍历密码集合并输出
            {
                Console.WriteLine(i);
            }
        }
        //递归算法
        public static int CodeRecursion(int n)
        {
            string[] CodeNumber = new string[3] { "a", "b", "c" }; //建立数组 将密码的三个可能数输入进去
            ArrayList Code = new ArrayList();
            for (int i = 0; i < 3; i++)
            {
                for (int y = 0; y < 3; y++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Code.Add(CodeNumber[i] + CodeNumber[y] + CodeNumber[k]);
                    }
                }
            }

            Console.WriteLine(Code[n]);
            if (n == 0)
            {     
                return 0;
            }
            
            return CodeRecursion(n - 1);
            ;
        }
    }
}
