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
        public bool AddStuInfo(Students stu)
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
                new SqlParameter("@stname",stu.StuName),
                new SqlParameter("@stusex",stu.StuSex),
                new SqlParameter("@stubirth",stu.StuBirth),
                new SqlParameter("@stuphone",stu.StuPhone),
                new SqlParameter("@stuplace",stu.StuPlace)
            };
           int count =  SqlHelper.ExecutrNonQuery(CommandType.Text,strsql,parm);
            return count > 0 ? true : false;
        }
    }
}
