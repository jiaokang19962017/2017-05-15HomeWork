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

            #region 6.编写一个程序,do-while语句,输入5个数,求和
            /*  int i=0;
              int sum1;
              int res=0;
              do
              {
                  Console.Write("请输入第{0}个数:",i+1);
                   sum1 = Convert.ToInt32(Console.ReadLine());
                  res = res + sum1;
                  i++;
              }while(i<5);
              Console.WriteLine("这5个整数的和是:{0}",res);*/
            #endregion

            #region 7.编写一个程序,while语句求出1+(1+2)+(1+2+3)...之和
            /* int k = 10;
             int m = 0;
             for (int i = 1; i <= k; i++)
             {
                 int n = 0;
                 for (int j = 1; j <= i; j++) {
                     n += j;
                 }
                 m += n;
             }
             Console.WriteLine(m);*/
            #endregion

            #region 8.while登录
            /*  int i = 0;
              const string userName = "admin";
              const string passWord = "123456";
              while (i < 3)
              {
                  Console.WriteLine("请输入用户名:");
                  string user = Console.ReadLine();
                  Console.WriteLine("请输入密码:");
                  string pass = Console.ReadLine();
                  if ((user == userName) && (pass == passWord))
                  {
                      Console.WriteLine("登陆成功");
                      break;
                  }
                  else {
                      Console.WriteLine("登录失败,重新输入");
                  }
                  i++;
              }*/
            #endregion

            #region  9.for循环100以内偶数和,奇数和分别多少
            /*   int sum1 = 0;
               int sum2 = 0;
               for (int i = 1; i <= 100; i++)
               {
                   if (i % 2 == 0)
                   {
                       sum1 += i;
                   }
                   else {
                       sum2 += i;
                   }
               }
               Console.WriteLine("偶数和是:{0},奇数和是:{1}",sum1,sum2);*/


            #endregion

            #region 10.水仙花数
            /*  int temp = 0;
              for (int i = 100; i < 999; i++)
              {
                  temp = i;
                  int x = temp % 10;
                  temp = temp / 10;
                  int y = temp % 10;
                  int z = temp / 10;
                  if (i == x * x * x + y * y * y + z * z * z)
                  {
                      Console.WriteLine(i);
                  }
              }*/
            #endregion

            #region 11.小球下落
            /*double s = 0;
            double t = 100;
            for (int i = 1; i <= 10; i++)
            {
                s = s+t;
                t = t / 2;
            }
            Console.WriteLine(s);
            Console.WriteLine(t);*/
            #endregion

            #region 12.猴子吃桃子
            /////
            #endregion

            #region 13.圣诞树
           /* for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine( );
            }*/
            #endregion

        }
    }
}
