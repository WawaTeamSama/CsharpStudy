using System;

namespace CsharpRace
{
    class Program
    {
        static void Main(string[] args)
        {

            //题目描述：请编写一个程序，可以将英语规则名词（不考虑不满足以下规则的英语单词）由单数变成复数。已知规则如下：

            //以辅音字母 y 结尾，则将 y 改成 i，再加 es；

            //以 s，x，ch，sh 结尾，则加 es；

            //以元音 o 结尾，则加 es；

            //其他情况直接加 s。
            //要求用键盘输入英语规则名词，屏幕输出该名词的复数形式。样例输入：

            //box

            //样例输出：

            //Boxes
            Console.WriteLine("请输入一个英语规则名词");
            string englishWord = Console.ReadLine(); //获取用户的输入

            string englishLastNumber = englishWord.Substring(englishWord.Length - 1, 1); //截获用户输入的英文单词的最后一个字母
            
                Console.WriteLine(englishLastNumber);
            
            string englishResult = "";//用于保存输出的负数结果
            if (englishLastNumber == "y")//当以辅音字母 y 结尾，则将 y 改成 i，再加 es
            {
                englishResult = englishWord.Substring(0, englishWord.Length - 1) + "ies";
            }
            Console.WriteLine(englishResult);
        }
    }
}
