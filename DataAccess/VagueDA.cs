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
   public class VagueDA : IVague
    {
        public List<Vague> selectAll(string str)
        {
            string strsql = @"select 
                                                stu.StuId,StuName,StuSex,StuBirth,StuPhone,StuPlace,cou.CourseId,CourseName,Credit,Score 
                                                from Exam ex inner join Students stu on ex.StuId=stu.StuId inner join Course cou on ex.CourseId=cou.CourseId
                                                where stu.stuid=@str or stuname=@str or stusex=@str or coursename=@str";
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter("@str",str)
            };
            SqlDataReader dr = SqlHelper.ExecuteReader(CommandType.Text, strsql, parm);
            List<Vague> Ivag = new List<Vague>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Vague vge = new Vague();
                    vge.StuId = Convert.ToInt32(dr["stu.StuId"]);
                    vge.StuName = Convert.ToString(dr["StuName"]);
                    vge.StuSex = Convert.ToInt32(dr["StuSex"]);
                    vge.StuBirth = Convert.ToDateTime(dr["StuBirth"]);
                    vge.StuPlace = Convert.ToString(dr["StuPlace"]);
                    vge.CourseId = Convert.ToString(dr["cou.CourseId"]);
                    vge.CourseName = Convert.ToString(dr["CourseName"]);
                    vge.Credit = Convert.ToInt32(dr["Credit"]);
                    vge.Score = Convert.ToSingle(dr["Score"]);
                    Ivag.Add(vge);
                }
            }
            dr.Close();
            return Ivag;
        }
    }
}
