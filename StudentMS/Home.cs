﻿using StudentMS;
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
        StudentManager um = new StudentManager();

        /// <summary>
        /// 主页面
        /// </summary>
        public static void HomePage()
        {
            Console.WriteLine("                       欢迎使用学生信息管理系统                                        ");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("a.课程信息管理  b.学生信息管理  c.考试信息管理  d.模糊信息查询  e.退出系统");
            Console.WriteLine("        f.平均成绩和总成绩查询            g.排行榜                        ");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("请输入功能编号:");
            string select = Console.ReadLine();
            if (string.IsNullOrEmpty(select))
            {
                Console.Clear();
                Console.WriteLine("输入为空,重新输入");
                HomePage();
            }
            else
            {
                if (select == "a" || select == "b" || select == "c" || select == "d" || select == "e"||select=="f"||select=="g")
                {
                    switch (select)
                    {
                        case "a":
                            Console.Clear();
                            Info.CoursePage();//调用课程信息管理方法
                            break;
                        case "b":
                            Console.Clear();
                            Info.StudentPage();//调用学生信息管理方法
                            break;
                        case "c":
                            Console.Clear();
                            Info.ExamPage();
                            break;
                        case "d":
                            Console.Clear();
                            Info.VaguePage();
                            HomePage();
                            break;
                        case "e":
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
                                HomePage();
                            }
                            break;
                        case "f":
                            Console.Clear();
                            Info.ScorePage();
                            HomePage();
                            break;
                        case "g":
                            Console.Clear();
                            Info.TopShow();
                            HomePage();
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("输入有误,重新输入");
                    HomePage();
                }
            }
        }
    }
}
