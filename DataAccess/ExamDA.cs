using IDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;
using Common;
using System.Data;

namespace DataAccess
{
 public  class ExamDA : IExam

    {
        Exam ex= new Exam();
        /// <summary>
        /// 添加成绩方法
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        public int AddExam(Exam ex)
        {
            string strsql = @"insert into Exam(
                                                                StuId,
                                                                CourseId,
                                                                Score)
                                                        values(
                                                                @stuid,
                                                                @courseid,
                                                                @score)";
            SqlParameter[] parm = new SqlParameter[] {
                new  SqlParameter("@stuid",ex.StuId),
                new  SqlParameter("@courseid",ex.CourseId),
                new  SqlParameter("@score",ex.Score),
            };
            int count = SqlHelper.ExecutrNonQuery(CommandType.Text, strsql, parm);
            return count;
        }
    }

}
