using System;

namespace Program05
{
    class Program
    {
        static void Main(string[] args)
        {
            //if…else语句是指如果满足某种条件，就进行某种处理，否则就进行另一种处理，例如判断一个人的体重是否正常。
            //体重是反应和衡量个人健康状况的重要标志，接下来使用if…else语句编写一个程序，通过获取用户的性别、身高、体重等信息来判断此人的健康状况。 
            /*世界卫生组织推荐的标准计算方法如下： 
             * 男性：(身高cm－80)×70﹪= 标准体重
             * 女性：(身高cm－70)×60﹪= 标准体重
             * 标准体重正负10﹪为正常体重
             * 标准体重正负10﹪~20﹪为体重过重或过轻
             * 标准体重正负20﹪以上为肥胖或体重不足
            */
            //创建program05完成功能

          
            string result;//用于保存健康状况信息
            Console.WriteLine("请输入您的性别(男/女)");
            string input1 = Console.ReadLine(); //获取用户输入的性别 记为input1
            //当用户输入的信息不合法时，要求用户重新输入
            while (!(input1 == "男" || input1 == "女")) 
            {
                Console.WriteLine("您的输入不合法,请重新输入性别(男/女)!");
                input1 = Console.ReadLine();

            }
            if (input1 == "男") 
            {
               
                Console.WriteLine("请输入您的身高(cm)");
                double input2 = Convert.ToInt32(Console.ReadLine()); //获取用户输入的身高 记为input2
                //判断用户输入的身高是否合法
                while (!(input2 > 0)) 
                {
                    Console.WriteLine("您的输入不合法,请重新输入身高!");
                    input2 = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("请输入您的体重(kg)");
                double input3 = Convert.ToInt32(Console.ReadLine());//获取用户输入的体重 记为input3

                //判断用户输入的体重是否合法
                while (!(input3 > 0))
                {
                    Console.WriteLine("您的输入不合法,请重新输入体重!");

                    input3 = Convert.ToInt32(Console.ReadLine());
                }

                double output1 = (input2 - 80) * 0.7; //计算标准体重
             


                //用较大的数减去较小的数计算一个不为负的差值
                double output2;
                if (input3 >= output1) 
                {
                    output2 = input3 - output1; //此时可能出现正常体重 体重过重 肥胖
                   
                    if (output2 <= output1 * 0.1)
                    {
                        result = "正常体重";
                    }
                    else if(output2>output1 * 0.1 && output2 <= output1 * 0.2) 
                    {
                        result = "体重过重";
                    }
                    else
                    {
                        result = "肥胖";
                    }
                    Console.WriteLine("您的健康状况是:" + result);
                }
                else 
                {
                    output2 = output1 - input3;//此时可能出现正常体重 体重过轻 体重不足
                  
                    if (output2 <= output1 * 0.1)
                    {
                        result = "正常体重";
                    }
                    else if (output2 > output1 * 0.1 && output2 <= output1 * 0.2)
                    {
                        result = "体重过轻";
                    }
                    else
                    {
                        result = "体重不足";
                    }
                    Console.WriteLine("您的健康状况是:" + result);
                }
                
                
                
            }
            else if (input1 == "女") 
            {

                Console.WriteLine("请输入您的身高(cm)");
                double input2 = Convert.ToInt32(Console.ReadLine()); //获取用户输入的身高 记为input2
                Console.WriteLine("请输入您的体重(kg)");
                double input3 = Convert.ToInt32(Console.ReadLine());//获取用户输入的体重 记为input3

                double output1 = (input2 - 70) * 0.6; //计算标准体重
               


                //用较大的数减去较小的数计算一个不为负的差值
                double output2;
                if (input3 >= output1)
                {
                    output2 = input3 - output1; //此时可能出现正常体重 体重过重 肥胖
                
                    if (output2 <= output1 * 0.1)
                    {
                        result = "正常体重";
                    }
                    else if (output2 > output1 * 0.1 && output2 <= output1 * 0.2)
                    {
                        result = "体重过重";
                    }
                    else
                    {
                        result = "肥胖";
                    }
                    Console.WriteLine("您的健康状况是:" + result);
                }
                else
                {
                    output2 = output1 - input3;//此时可能出现正常体重 体重过轻 体重不足
                  
                    if (output2 <= output1 * 0.1)
                    {
                        result = "正常体重";
                    }
                    else if (output2 > output1 * 0.1 && output2 <= output1 * 0.2)
                    {
                        result = "体重过轻";
                    }
                    else
                    {
                        result = "体重不足";
                    }
                    Console.WriteLine("您的健康状况是:" + result);
                }
            }
           

            

            
        }
    }
}
