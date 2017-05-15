using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.用if-else[判断是否为闰年
            /*  Console.WriteLine("请输入年份:");
              int year = Convert.ToInt32(Console.ReadLine());
              if ((year % 4 == 0) && (year % 100 != 0))
              {
                  Console.WriteLine("{0}年为闰年", year);
              }
              else
              {
                  Console.WriteLine("{0}年不是闰年", year);
              }*/
            #endregion

            #region 2.由键盘输入三个整数分别存入变量num1.num2.num3, 分别使用if-else和三元运算符来输出最大值
            /*Console.WriteLine("请输入第一个数");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第三个数");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int max;
            if ((num1 > num2) && (num1 > num3))
            {
                max = num1;
            }
            else if ((num2 > num1) && (num2 > num3))
            {
                max = num2;
            }
            else {
                max = num3;
            }
            Console.WriteLine("最大的数是{0}",max);*/


            /* Console.WriteLine("请输入第一个数");
             int num1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("请输入第二个数");
             int num2 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("请输入第三个数");
             int num3 = Convert.ToInt32(Console.ReadLine());
             num1 = (num1 > num2) ? num1 : num2;
             num3 = (num3 > num1) ? num3 : num1;
             Console.WriteLine("最大的数是{0}",num3);*/
            #endregion

            #region 由键盘输入三个整数,a,b,c,按大小顺序输出
            /* Console.WriteLine("请输入第一个数");
             int a = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("请输入第二个数");
             int b = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("请输入第三个数");
             int c = Convert.ToInt32(Console.ReadLine());

             if (a > b)
             {
                 if (c > a)
                 {
                     Console.WriteLine(b + " " + a + " " + c);
                 }
                 else if (c < b)
                 {
                     Console.WriteLine(c + " " + b + " " + a);
                 }
                 else
                 {
                     Console.WriteLine(b + " " + c + " " + a);
                 }
             }
             else
             {
                 if (c < a)
                 {
                     Console.WriteLine(c + " " + a + " " + b);
                 }
                 else if (c > b)
                 {
                     Console.WriteLine(a + " " + b + " " + c);
                 }
                 else
                 {
                     Console.WriteLine(a + " " + c + " " + b);
                 }
             }*/
            #endregion

            #region 4.编写一个程序,输入0-100之间的学生分数,switch方法
            /*  int score = Convert.ToInt32(Console.ReadLine());
              score = score / 10;
              switch (score)
              {
                  case 10:
                  case 9:
                      Console.WriteLine("优秀");
                      break;
                  case 8:
                      Console.WriteLine("良好");
                      break;
                  case 7:
                  case 6:
                      Console.WriteLine("及格");
                      break;
                  default:
                      Console.WriteLine("不及格");
                      break;
              }*/
            #endregion

            #region 5.while/do-while/for循环打印100以内3的倍数
            /* int i = 0;
             while (i < 100)
             {
                 if (i % 3 == 0) {
                     Console.WriteLine(i);
                 }
                 i++;
             }*/
            /*   int i=1;
               int sum = 0;
               do
               {
                   if (i % 3 == 0)
                   {
                       sum = sum + i;
                       ++i;
                       Console.WriteLine( sum);
                   }
               } while (i <= 100);*/     //有错误

         /*   for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0) {
                    Console.WriteLine(i);
                }
            }*/
            #endregion
        }
    }
}
