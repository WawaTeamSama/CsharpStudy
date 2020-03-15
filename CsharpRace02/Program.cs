using System;
using System.Collections;

namespace CsharpRace02
{
    class Program
    {
        static void Main(string[] args)
        {
            //题目描述：设 A[1…..n]是一个包含 n 个不同数的数组，如果在 i<j 的情况下， 有 A[i]>A[j], 则（i, j）就称为 A 中的一个逆序对。

            //请编写程序，根据用户输入的正整数 n(n>=2)和 n 个不同的数，求出数组 A[n] 的逆序对个数。其中，第一行输入数组包含的元素个数 n，第二行输入 n 个不同的数（以逗号分隔）。

            //假设有数组 A[10]，给数组输入 10 个数，则样例输入：

            //10

            //1，2，3，6，4，5，7，8，9，10

            //样例输出：

            //2
            Console.WriteLine("请输入要输入的数组个数");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n < 2)
            {
                Console.WriteLine("请输入2个以上的数组个数");
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("请输入{0}个数(以逗号分隔)", n);
            string array = Console.ReadLine();
            string[] stringArray = array.Split(",");//将用户输入的内容转换为单个字符串传入一个数组


            
            int[] intArray = new int[n];

            intArray = Array.ConvertAll(stringArray, int.Parse); //将string数组转成int数组 
            int i = 0;
            int j = 1;
            int result = 0;//记录逆序对个数
           
            for (; i < n; )  //若是两个数就比较1次 三个数就比较3次 四个数就比较6次  1 3 6 10所以是n先减1 后达成通项公式n(n+1)/2次
            { 
                for (; j < n; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        result++;
                    }
                }
                i++;
                j = i + 1;

            }
            Console.WriteLine(result);

        }
            

    }
}
