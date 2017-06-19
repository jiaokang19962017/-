using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDataAccess;
using Entity;
using DataAccess;
using System.Data.SqlClient;
using System.Configuration;

namespace StudentMS
{

  public  class UserManager
    {
        private static readonly string strConn = ConfigurationManager.ConnectionStrings["ConnStr"].ToString();


        /// <summary>
        /// 登录方法
        /// </summary>
        /// <param name="userid">用户名</param>
        /// <param name="userpwd">用户密码</param>
        /// <returns>登录成功返回1,登录失败返回0</returns>
        public int Loading(string userid,string userpwd)
        {
            string strsql = "select count(*) from users where userid=@userid and userpwd=@userpwd";
            SqlConnection con = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand(strsql, con);
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter("@userid",userid),
                new SqlParameter("@userpwd",userpwd)
            };
            cmd.Parameters.AddRange(parm);
            con.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                Console.WriteLine("登录成功");
                return 1;
            }
            else
            {
                Console.WriteLine("登录失败,请重新输入");
                return 0;
            }

        }

     



    }
}
