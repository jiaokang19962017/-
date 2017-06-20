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
            StudentManager um = new StudentManager();
            um.Load();


        }
    }
}

