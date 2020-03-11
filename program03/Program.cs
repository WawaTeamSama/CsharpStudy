using System;

namespace program03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("请输入一个英文单词："); 
            string s = Console.ReadLine(); int n = s.Length; char[] arr = new char[n]; foreach (char c in s) { arr[i] = c; i++; }

            switch (arr[n - 1]) 
            { case 'y': arr[n - 1] = 'i'; foreach (char c in arr) Console.Write(c); Console.Write("es"); 
                    break; case 's': case 'x': case 'o': foreach (char c in arr) Console.Write(c); Console.Write("es"); break;
                case 'h': if (arr[n - 2] == 's' || arr[n - 2] == 'c') { foreach (char c in arr) Console.Write(c); Console.Write("es"); }
                    else { foreach (char c in arr) Console.Write(c); Console.Write("s"); } break; default: foreach (char c in arr) Console.Write(c); Console.Write("s"); break; }
           
            Console.ReadKey();

        }
    }
}
