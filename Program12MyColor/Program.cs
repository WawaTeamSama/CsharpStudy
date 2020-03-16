using System;

namespace Program12MyColor
{
    //1.定义一个结构叫MyColor，有三个成员，分别定义为int类型的red,green,blue
    //声明一个MyColor类型的变量，并对其进行赋值，使MyColor可以表示成一个红色

        public struct MyColor
    {
       public int red;
       public int green;
       public int blue;
    }
    //2.定义一个结构类型Person，有三个成员，分别为姓名，性别，年龄，性别用枚举类型
    //声明两个Person类型的变量，分别表示张三，男，18岁/小兰，女，16岁
    public struct Person
    {
        public string Name;
        public Gender Gender;
        public int Age;
    }
    public enum Gender { 男,女}

    class Program
    {
        static void Main(string[] args)
        {
            //MyColor my;
            //my.red = 1;
            //Console.WriteLine(my.red);

            Person p1;
            p1.Name = "张三";
            p1.Gender = Gender.男;
            p1.Age = 18;

            Person p2;
            p2.Name = "小兰";
            p2.Gender = Gender.女;
            p2.Age = 16;


            Console.WriteLine("第一个用户信息:" + p1.Name + p1.Gender + p1.Age);
            Console.WriteLine("第二个用户信息:" + p2.Name + p2.Gender + p2.Age);
        }
    }
}
