using Common;
using Entity;
using IDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CourseDA : ICourse
    {
        Course cou = new Course();
        /// <summary>
        /// 添加课程方法
        /// </summary>
        /// <param name="cou">课程实体类对象</param>
        /// <returns>返回受影响行数</returns>
        public int AddCourseInfo(Course cou)
        {
            string strsql = @"insert into Course(
                                                                    CourseId,
                                                                    CourseName,
                                                                    Credit)
                                                         values(
                                                                    @courseid,
                                                                    @coursename,
                                                                     @credit)";
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter("@courseid",cou.CourseId),
                 new SqlParameter("@coursename",cou.CourseName),
                  new SqlParameter("@credit",cou.Credit),
                };
            int count = SqlHelper.ExecutrNonQuery(CommandType.Text, strsql, parm);
            return count;
        }

        /// <summary>
        /// 删除课程信息方法
        /// </summary>
        /// <param name="cou">课程实体类对象</param>
        /// <returns>返回受影响行数</returns>
        public int DelCourseInfo(Course cou)
        {
            string strsql = @"DELETE FROM 
                                                            Course
                                                   WHERE Courseid =@courseid";
            SqlParameter[] parm = new SqlParameter[] 
            {
                new  SqlParameter("@courseid",cou.CourseId)
            };
           int count = SqlHelper.ExecutrNonQuery(CommandType.Text, strsql, parm);
            return count;
        }

        /// <summary>
        /// 修改课程信息方法
        /// </summary>
        /// <param name="cou">课程实体类对象</param>
        /// <returns>返回受影响行数</returns>
        public int UpdCourseInfo(Course cou)
        {
            string strsql = @"update Course set 
                                                                    CourseName=@coursename,
                                                                    Credit=@credit 
                                                           where
                                                                    CourseId =@courseid";
            SqlParameter[] parm = new SqlParameter[] 
            {
                new  SqlParameter("@coursename",cou.CourseName),
                new  SqlParameter("@credit",cou.Credit),
                new  SqlParameter("@courseid",cou.CourseId)
            };
            int count = SqlHelper.ExecutrNonQuery(CommandType.Text, strsql, parm);
            return count;
        }


        /// <summary>
        /// 查询全部课程信息
        /// </summary>
        /// <returns>返回集合</returns>
        public List<Course> SelectAll()
        {
            string strsql = @"select 
                                                CourseId,
                                                CourseName,
                                                Credit 
                                       from Course";
            SqlDataReader dr = SqlHelper.ExecuteReader(CommandType.Text, strsql, null);
            List<Course> lcourse = new List<Course>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cou.CourseId = Convert.ToString(dr["CourseId"]);
                    cou.CourseName = Convert.ToString(dr["CourseName"]);
                    cou.Credit = Convert.ToInt32(dr["Credit"]);
                    lcourse.Add(cou);
                }
            }
            dr.Close();
            return lcourse;
        }
    }
}
