using System;

namespace Program10Enum
{
    class Program
    {
        //用枚举定义性别
        public enum Gender
        {
            男=1,女=2
        }
        static void Main(string[] args)
        {
            #region 枚举类型转int类型
            Console.WriteLine("男的值是:" + (int)Gender.男);
            Console.WriteLine("女的值是:" + (int)Gender.女);
            #endregion

            #region int类型转枚举类型

            Console.WriteLine("男是：" + (Gender)1);
            Console.WriteLine("女是：" + (Gender)2);
            #endregion
        }
    }
}
