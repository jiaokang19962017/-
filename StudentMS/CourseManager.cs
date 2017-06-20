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
   public class CourseManager
    {
        ICourse ic = new CourseDA();
        Course cou = new Course();
        /// <summary>
        /// 添加课程信息方法
        /// </summary>
        /// <returns></returns>
        public void InsertCourseInfo()
        {
            Console.WriteLine("请输入课程编号:");
            string cid = Console.ReadLine();
            Console.WriteLine("请输入课程名称:");
            string cname = Console.ReadLine();
            Console.WriteLine("请输入学分:");
            int cdit = Convert.ToInt32(Console.ReadLine());
            cou.CourseId = cid;
            cou.CourseName = cname;
            cou.Credit = cdit;
            int count = ic.AddCourseInfo(cou);
            if (count > 0)
            {
                Console.WriteLine("添加成功");
                
            }
            else
            {
                Console.WriteLine("添加失败");
              
            }

        }
        /// <summary>
        /// 删除课程信息方法
        /// </summary>

        public void DeleteCourseInfo()
        {
            Console.WriteLine("请输入要删除的课程ID:");
            string id = Console.ReadLine();
            cou.CourseId = id;
            int count = ic.DelCourseInfo(cou);
            if (count > 0)
            {
                Console.WriteLine("删除成功");
                
            }
            else
            {
                Console.WriteLine("删除失败");
                
            }
        }

        /// <summary>
        /// 修改课程信息方法
        /// </summary>

        public void UpdateCourseInfo()
        {
            Console.WriteLine("请输入要修改的课程ID:");
            string id = Console.ReadLine();
            Console.WriteLine("请输入新的课程名:");
            string name = Console.ReadLine();
            Console.WriteLine("请输入新的学分:");
            int cit = Convert.ToInt32(Console.ReadLine());
            cou.CourseId = id;
            cou.CourseName = name;
            cou.Credit =cit;
            int count =  ic.UpdCourseInfo(cou);
            if (count > 0)
            {
                Console.WriteLine("修改成功");
              
            }
            else
            {
                Console.WriteLine("修改失败");
                
            }

        }

        /// <summary>
        /// 查询课程信息方法
        /// </summary>
        public void GetCourseInfo()
        {
            List<Course> lcourse = ic.SelectAll();
            foreach (Course cou in lcourse)
            { 
                StringBuilder sb = new StringBuilder();
                sb.Append(cou.CourseId +"\t");
                sb.Append(cou.CourseName +"\t");
                sb.Append(cou.Credit +"\t");
                Console.WriteLine(sb.ToString());
            }

        }
    }
}
