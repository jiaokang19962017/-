using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS
{
    class Program
    {

        /// <summary>
        /// 视图层
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("请输入帐号:");
                string userid = Console.ReadLine();
                Console.WriteLine("请输入密码:");
                string userpwd = Console.ReadLine();
                UserManager um = new UserManager();
                int count = um.Loading(userid, userpwd);
                if (count==1) //登录成功返回1,进入下一级
                {
                    Console.Clear();//清除屏幕
                    Home.HomePage();
                    break;
                }
        
            }
           
        }
    }
}

