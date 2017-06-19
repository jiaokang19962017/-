using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS
{
    /// <summary>
    /// 学生信息表
    /// </summary>
   public class Home
    {
        public static void HomePage()
        {
            Console.WriteLine("                  欢迎使用学生信息管理系统                     ");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("1.课程信息管理  2.学生信息管理  3.考试信息管理  4.退出系统");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("请输入功能编号:");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("课程信息表");
                    break;
                case 2:
                    Console.WriteLine("学生信息表:");
                    break;
                case 3:
                    Console.WriteLine("学生信息表:");
                    break;
                case 4:
                    Console.WriteLine("您确定要退出本系统吗? y/是  n/否");
                    string choose = Console.ReadLine();
                    if (choose == "y")//如果为y,关闭窗体
                    {
                        Console.WriteLine("已退出,按任意键结束本程序!");
                        Environment.Exit(0);//关闭窗体
                     
                    }
                    else if (choose == "n")//如果为n,继续调用主界面方法
                    {
                        Console.Clear();
                        Home.HomePage();
                    }
                    break;
            }
        }
    }
}
