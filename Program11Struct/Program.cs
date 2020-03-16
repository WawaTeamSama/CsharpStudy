using System;

namespace Program11Struct
{
    public enum Gender
    {
        男, 女
    }
    public struct Person
    {
        public string Name;
        public Gender Gender;
        public int Age;
    }
    class Program
    {
        

        static void Main(string[] args)
        {
            Person p1;
            p1.Name = "叶陵";
            p1.Age = 20;
            p1.Gender = Gender.男;

            Person p2;
            p2.Name = "VANVAN";
            p2.Age = 20;
            p2.Gender = Gender.女;

            Console.WriteLine("姓名:{0},性别:{1},年龄:{2}", p1.Name, p1.Gender, p1.Age);
        }
    }
}
