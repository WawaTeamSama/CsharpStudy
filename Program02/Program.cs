using System;

namespace Program02
{
    class Program
    {
        static void Main(string[] args)
        {
            int b1 = 3;
            byte b2 = 4;

            byte b3 = (byte)(b1 + (int)b2);
            Console.WriteLine(b3);
        }
    }
}
