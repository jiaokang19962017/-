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

  public  class StudentManager
    {
        private static readonly string strConn = ConfigurationManager.ConnectionStrings["ConnStr"].ToString();
        IStudents studentDA = new StudentDA();
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

        /// <summary>
        /// 添加学生信息方法
        /// </summary>
        /// <returns>添加成功返回true</returns>
        public  bool SetStudentInfo()
        {
            Console.WriteLine("请输入姓名:");
            string name = Console.ReadLine();
            Console.WriteLine("请输入性别:(1.男  0.女)");
            int sex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入出生日期:");
            DateTime birth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("请输入电话:");
            string phone = Console.ReadLine();
            Console.WriteLine("请输入地址:");
            string address = Console.ReadLine();
           bool result = studentDA.AddStuInfo(name,sex,birth,phone,address);
            return result;
        }


        /// <summary>
        /// 查看学生信息方法
        /// </summary>
        public void GetStudentInfo()
        {
            List<Students> lstudent = studentDA.SelectAll();
            foreach (Students stu in lstudent)
            {
                string sex = stu.StuSex == 1 ? "男" : "女";
                StringBuilder sb = new StringBuilder();
                sb.Append(stu.StuId + "\t");
                sb.Append(stu.StuName + "\t");
                sb.Append(sex + "\t");
                sb.Append(stu.StuBirth.ToString("yyyy-MM-dd") + "\t");
                sb.Append(stu.StuPhone + "\t");
                sb.Append(stu.StuPlace + "\t");
                Console.WriteLine(sb.ToString());
            }
        }
        /// <summary>
        /// 删除学生信息方法
        /// </summary>
        /// <returns>成功返回1,失败返回0</returns>
        public int DeleStudentInfo()
        {
            Console.WriteLine("请输入要删除的学生ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            int result =  studentDA.DeleStuInfo(id);
            if (result > 0)
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
        /// <summary>
        /// 修改学生信息的
        /// </summary>
        /// <returns></returns>
        public int UpdateStudentInfo()
        {
            Console.WriteLine("请输入要修改的学生id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入新的姓名:");
            string name = Console.ReadLine();
            Console.WriteLine("请输入新的性别:(1.男  0.女)");
            int sex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入新的出生日期:");
            DateTime birth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("请输入新的电话:");
            string phone = Console.ReadLine();
            Console.WriteLine("请输入新的地址:");
            string address = Console.ReadLine();
            int result = studentDA.UpdateStuInfo(id, name, sex, birth, phone, address);
            if (result > 0)
            {
                Console.WriteLine("修改成功");
                return 1;
            }
            else
            {
                Console.WriteLine("修改失败");
                return 0;
            }
        }

        /// <summary>
        /// 用户登录方法
        /// </summary>
        public  void Load()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("请输入帐号:");
                string userid = Console.ReadLine();
                Console.WriteLine("请输入密码:");
                string userpwd = Console.ReadLine();
                StudentManager um = new StudentManager();

                int count = um.Loading(userid, userpwd);
                if (count == 1) //登录成功返回1,进入下一级
                {
                    Console.Clear();//清除屏幕
                    Home.HomePage();
                    break;
                }

            }
        }
    }
}
