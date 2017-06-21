using DataAccess;
using Entity;
using IDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS
{
    public class Info
    {
       

       /// <summary>
       /// 学生信息管理分页面
       /// </summary>
        public static void StudentPage()
        {
            
            StudentManager um = new StudentManager();
            Console.WriteLine("-------------------------------学生信息管理---------------------------------");
            Console.WriteLine();
            Console.WriteLine("a.增加学生信息  b.删除学生信息  c.修改学生信息  d.查询学生信息  e.返回主菜单");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("请输入功能编号:");
            string select = Console.ReadLine();
            if (string.IsNullOrEmpty(select))
            {
                Console.Clear();
                Console.WriteLine("输入为空,请重新输入");
                StudentPage();
            }
            else
            {
                if (select == "a" || select == "b" || select == "c" || select == "d" || select == "e")
                {
                    switch (select)
                    {
                        case "a":
                            Console.Clear();
                            bool result = um.SetStudentInfo();
                            if (result)
                            {
                                Console.Clear();
                                Console.WriteLine("插入成功");
                                StudentPage();
                            }
                            else
                            {
                                Console.WriteLine("插入失败");
                                um.SetStudentInfo();
                            }
                            break;
                        case "b":
                            Console.Clear();
                            Console.WriteLine("                    删除学生信息              ");
                            Console.WriteLine();
                            Console.WriteLine("编号    姓名   性别      出生日期         手机号       籍贯");
                            Console.WriteLine();
                            um.GetStudentInfo();
                            um.DeleStudentInfo();
                            StudentPage();
                            break;
                        case "c":
                            Console.Clear();
                            Console.WriteLine("                    修改学生信息              ");
                            Console.WriteLine();
                            Console.WriteLine("编号    姓名   性别      出生日期         手机号       籍贯");
                            Console.WriteLine();
                            um.GetStudentInfo();
                            um.UpdateStudentInfo();
                            StudentPage();
                            Console.WriteLine("修改学生信息");
                            break;
                        case "d":
                            Console.Clear();
                            Console.WriteLine("                    查询学生信息              ");
                            Console.WriteLine();
                            Console.WriteLine("编号    姓名   性别      出生日期         手机号       籍贯");
                            Console.WriteLine();
                            um.GetStudentInfo();
                            StudentPage();
                            break;
                        case "e":
                            Console.Clear();
                            Home.HomePage();
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("输入有误,重新输入:");
                    StudentPage();
                }

            }

        }
        
        /// <summary>
        /// 课程信息管理分页面
        /// </summary>
        public static void CoursePage()
        {
            CourseManager cm = new CourseManager();
            Console.WriteLine("-------------------------------课程信息管理---------------------------------");
            Console.WriteLine();
            Console.WriteLine("a.增加课程信息  b.删除课程信息  c.修改课程信息  d.查询课程信息  e.返回主菜单");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("请输入功能编号:");
            string select = Console.ReadLine();
            if (string.IsNullOrEmpty(select))
            {
                Console.Clear();
                Console.WriteLine("输入为空,请重新输入");
                CoursePage();
            }
            else
            {
                if (select == "a" || select == "b" || select == "c" || select == "d" || select == "e")
                {
                    switch (select)
                    {
                        case "a":
                            cm.InsertCourseInfo();
                            CoursePage();
                            break;
                        case "b":
                            Console.Clear();
                            Console.WriteLine("                    删除课程信息              ");
                            Console.WriteLine();
                            Console.WriteLine("编号      课程名      学分");
                            Console.WriteLine();
                            cm.GetCourseInfo();
                            cm.DeleteCourseInfo();
                            CoursePage();
                            break;
                        case "c":
                            Console.Clear();
                            Console.WriteLine("                    修改课程信息              ");
                            Console.WriteLine();
                            Console.WriteLine("编号      课程名      学分");
                            Console.WriteLine();
                            cm.GetCourseInfo();
                            cm.UpdateCourseInfo();
                            CoursePage();
                            break;
                        case "d":
                            Console.Clear();
                            Console.WriteLine("                    查询课程信息              ");
                            Console.WriteLine();
                            Console.WriteLine("编号      课程名      学分");
                            Console.WriteLine();
                            cm.GetCourseInfo();
                            CoursePage();
                            break;
                        case "e":
                            Console.Clear();
                            Home.HomePage();
                            break;

                    }
                }
                else {
                    Console.Clear();
                    Console.WriteLine("输入错误,重新输入:");
                    CoursePage();
                }


                }




        }

        /// <summary>
        /// 考试信息管理分页面
        /// </summary>
        public static void ExamPage()
        {
            ExamManager em = new ExamManager();
            Console.WriteLine("-------------------------------考试信息管理---------------------------------");
            Console.WriteLine();
            Console.WriteLine("a.增加考试信息  b.删除考试信息  c.修改考试信息  d.查询考试信息  e.返回主菜单");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("请输入功能编号:");
            string select = Console.ReadLine();
            if (string.IsNullOrEmpty(select))
            {
                Console.Clear();
                Console.WriteLine("输入为空,请重新输入");
                CoursePage();
            }
            else
            {
                if (select == "a" || select == "b" || select == "c" || select == "d" || select == "e")
                {
                    switch (select)
                    {
                        case "a":
                            em.InsertExamInfo();
                            CoursePage();
                            break;
                        case "b":
                            Console.Clear();
                            Console.WriteLine("                    删除考试信息              ");
                            Console.WriteLine();
                            Console.WriteLine("编号      课程名      成绩");
                            Console.WriteLine();
                            em.GetExamInfo();
                            em.DelExamInfo();
                            CoursePage();
                            break;
                        case "c":
                            Console.Clear();
                            Console.WriteLine("                    修改考试信息              ");
                            Console.WriteLine();
                            Console.WriteLine("编号      课程名      学分");
                            Console.WriteLine();
                            em.GetExamInfo();
                            em.UpdExamInfo();
                            CoursePage();
                            break;
                        case "d":
                            Console.Clear();
                            Console.WriteLine("                    查询考试信息              ");
                            Console.WriteLine();
                            Console.WriteLine("编号      课程名      学分");
                            Console.WriteLine();
                            em.GetExamInfo();
                            CoursePage();
                            break;
                        case "e":
                            Console.Clear();
                            Home.HomePage();
                            break;

                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("输入错误,重新输入:");
                    CoursePage();
                }


            }

        }
        /// <summary>
        /// 模糊查询
        /// </summary>
        public static void VaguePage()
        {
            VagueManager vagm = new VagueManager();
            vagm.SeleVague();
        }

        /// <summary>
        /// 平均成绩和总成绩
        /// </summary>
        public static void ScorePage()
        {
            ScoreManager sm = new ScoreManager();
            sm.GetScoreManager();
        }
        /// <summary>
        /// 排行榜
        /// </summary>
        public static void TopShow()
        {
            TopManager tm = new TopManager();
            tm.ShowScore();
        }

    }
}
