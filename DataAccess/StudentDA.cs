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
    public class StudentDA : IStudents
    {
        /// <summary>
        /// 添加学生信息方法
        /// </summary>
        /// <param name="stu">student实体的对象</param>
        /// <returns>成功返回true,失败返回false</returns>
        public bool AddStuInfo(string stuname,int stusex,DateTime stubirth,string stuphone,string stuplace)
        {
            string strsql = @"insert into Students(
                                                                    StuName,
                                                                    StuSex,
                                                                    StuBirth,
                                                                    StuPhone,
                                                                    StuPlace)
                                                          values(
                                                                    @stuname,@stusex,@stubirth,@stuphone,@stuplace)";
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter("@stuname",stuname),
                new SqlParameter("@stusex",stusex),
                new SqlParameter("@stubirth",stubirth),
                new SqlParameter("@stuphone",stuphone),
                new SqlParameter("@stuplace",stuplace)
            };
           int count =  SqlHelper.ExecutrNonQuery(CommandType.Text,strsql,parm);
            return count > 0 ? true : false;
        }
        /// <summary>
        /// 学生信息删除方法
        /// </summary>
        /// <param name="stuid">学生id</param>
        /// <returns>返回受影响行数</returns>
        public int DeleStuInfo(int stuid)
        {
            string strsql = @"DELETE FROM Students WHERE StuId =@stuid";
            SqlParameter[] parm = new SqlParameter[] 
            {
                new SqlParameter("@stuid",stuid)
            };

            int count = SqlHelper.ExecutrNonQuery(CommandType.Text, strsql, parm);
            return count;
        }


        /// <summary>
        /// 查询学生信息
        /// </summary>
        /// <returns>返回集合</returns>
        public List<Students> SelectAll()
        {
            string strsql = @"select StuId,
                                                StuName,
                                                StuSex,
                                                StuBirth,
                                                StuPhone,
                                                StuPlace 
                                        from Students";
            SqlDataReader dr = SqlHelper.ExecuteReader(CommandType.Text, strsql, null);
            List<Students> lstudent = new List<Students>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Students stu = new Students();
                    stu.StuId = Convert.ToInt32(dr["StuId"]);
                    stu.StuName = Convert.ToString(dr["StuName"]);
                    stu.StuSex = Convert.ToInt32(dr["StuSex"]);
                    stu.StuBirth = Convert.ToDateTime(dr["StuBirth"]);
                    stu.StuPhone = Convert.ToString(dr["StuPhone"]);
                    stu.StuPlace = Convert.ToString(dr["StuPlace"]);
                    lstudent.Add(stu);
                }
              
            }
            dr.Close();
            return lstudent;
        }

        /// <summary>
        /// 修改学生信息
        /// </summary>
        /// <param name="stuid"></param>
        /// <returns></returns>

        public int UpdateStuInfo(int stuid, string stuname, int stusex, DateTime stubirth, string stuphone, string stuplace)
        {
            string strsql = @"update students set   
                                                stuname=@stuname,
                                                stusex=@stusex,
                                                stubirth=@stubirth,
                                                stuphone=@stuphone,
                                                stuplace=@stuplace
                                                where stuid=@stuid";
            SqlParameter[] parm = new SqlParameter[] 
            {
                new SqlParameter("@stuname",stuname),
                new SqlParameter("@stusex",stusex),
                new SqlParameter("@stubirth",stubirth),
                new SqlParameter("@stuphone",stuphone),
                new SqlParameter("@stuplace",stuplace),
                new SqlParameter("@stuid",stuid)
            };
            int count =  SqlHelper.ExecutrNonQuery(CommandType.Text, strsql, parm);
            return count;
        }

    }
}
