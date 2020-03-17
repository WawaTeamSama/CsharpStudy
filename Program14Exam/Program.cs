using System;

namespace Program14Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.从一个整数数组中取出最大的整数，最小整数，总和，平均值
            int[] intArray = new int[] { 5, 63, 27, 47, 4 };

            Array.Sort(intArray);//将数组排序（从小到大）

            int max = intArray[intArray.Length - 1];
            int min = intArray[0];
            
            int sum = 0; //总和
            double ave = 0;//平均值
            foreach(int i in intArray)
            {
                sum += i;
            }

            ave = sum / intArray.Length;
            Console.WriteLine("最大值{0},最小值{1},总和{2},平均值{3}", max, min, sum, ave);
        }
    }
}
