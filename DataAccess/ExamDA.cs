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

        /// <summary>
        ///删除考试信息方法
        /// </summary>
        /// <param name="ex"></param>
        /// <returns>返回受影响行数</returns>
        public int DelExam(Exam ex)
        {
            string strsql = @"delete from
                                                        Exam 
                                                 where
                                                        StuId=@stuid";

            SqlParameter[] parm = new SqlParameter[] 
            {
                new SqlParameter("@StuId",ex.StuId)
            };
            int count = SqlHelper.ExecutrNonQuery(CommandType.Text, strsql, parm);
            return count;
        }

        /// <summary>
        /// 更新考试信息
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        public int UpdExam(Exam ex)
        {
            string strsql = @"update Exam set
                                                                Score=@score 
                                                   where   StuId=@stuid";
            SqlParameter[] parm = new SqlParameter[] 
            {
                new SqlParameter("@score",ex.Score),
                new SqlParameter("@StuId",ex.StuId)
            };
           int count = SqlHelper.ExecutrNonQuery(CommandType.Text, strsql, parm);
            return count;
        }

        public List<Exam> SelectAll()
        {
            string strsql = @"select 
                                                stu.StuId,
                                                cou.CourseId,
                                                Score 
                                        from Exam ex 
                                        inner join Students stu 
                                        on ex.StuId=stu.StuId 
                                        inner join Course cou 
                                        on ex.CourseId=cou.CourseId";
            SqlDataReader dr = SqlHelper.ExecuteReader(CommandType.Text, strsql, null);
            List<Exam> lex = new List<Exam>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ex.StuId = Convert.ToInt32(dr["StuId"]);
                    ex.CourseId = Convert.ToString(dr["CourseId"]);
                    ex.Score = Convert.ToSingle(dr["Score"]);
                    lex.Add(ex);
                }
            }
            dr.Close();
            return lex;
        }
    }
}
