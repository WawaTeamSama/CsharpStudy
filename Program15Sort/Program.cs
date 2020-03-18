using System;

namespace Program15Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.冒泡排序法 即比较每一位以及其后一位 如果后一位小，就交换位置，每一次遍历结束后会确定一个最大值，所以下一次遍历需要减少一次 就是找出每一次的最大值 然后放在数组的最后面
            int[] array = new int[] { 4, 5, 2, 1, 3 };
            int l = array.Length;
            //for (int j = 0; j < l; ++j)
            //{
            //    for (int i = j; i < l; ++i)
            //    {
            //        if (array[j] > array[i])
            //        {
            //            int temp = array[j];
            //            array[j] = array[i];
            //            array[i] = temp;
            //        }
            //    }
            //}
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
            //2.选择排序 即比较每一项以及后一项 记录每次循环中最小值的下标并保存，循环一次后将最小值放在第i位(i从0开始)
            //for (int i = 0; i < l - 1; i++)
            //{
            //    int index = i;
            //    for (int j = i + 1; j < l; j++)
            //    {
            //        if (array [j] < array [index])
            //        {
            //            index = j;
            //        }
            //    }
            //    if (index != i)
            //    {
            //        int t = array [index];
            //        array [index] = array[i];
            //        array [i] = t;
            //    }
            //}
            //foreach (int i in array)
            //{
            //    Console.WriteLine(i);
            //}

            //3.插入排序
            for (int i = 1; i < l; i++)
            {
                int wait = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > wait)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = wait;
            }
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

        }
    }
}
