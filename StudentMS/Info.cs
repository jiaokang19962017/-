﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS
{
    public class Info
    {
        public static void StudentPage()
        {
            Console.WriteLine("-------------------------------学生信息管理---------------------------------");
            Console.WriteLine();
            Console.WriteLine("1.增加学生信息  2.删除学生信息  3.修改学生信息  4.查询学生信息  5.返回主菜单");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("请输入功能编号:");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("增加学生信息");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("删除学生信息");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("修改学生信息");
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("查询学生信息");
                    break;
                case 5:
                    Console.Clear();
                    Home.HomePage();
                    break;
            }
        }
        




        public static void CoursePage()
        {
            Console.WriteLine("-------------------------------课程信息管理---------------------------------");
            Console.WriteLine();
            Console.WriteLine("1.增加课程信息  2.删除学生信息  3.修改学生信息  4.查询学生信息  5.返回主菜单");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------");
        }
    }
}