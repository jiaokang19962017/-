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
        /// <returns>添加成功返回1,添加失败返回0</returns>
        public int InsertCourseInfo()
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
                return 1;
            }
            else
            {
                Console.WriteLine("添加失败");
                return 0;
            }

        }
        /// <summary>
        /// 删除课程信息方法
        /// </summary>
        /// <returns>成功返回1,失败返回0</returns>
        public int DeleteCourseInfo()
        {
            Console.WriteLine("请输入要删除的课程ID:");
            string id = Console.ReadLine();
            cou.CourseId = id;
            int count = ic.DelCourseInfo(cou);
            if (count > 0)
            {
                Console.WriteLine("删除成功");
                return 1;
            }
            else
            {
                Console.WriteLine("删除失败");
                return 0;
            }
        }
    }
}
