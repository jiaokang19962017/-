using Common;
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
    public class TopDA:ITop
    {
        /// <summary>
        /// 成绩排行
        /// </summary>
        /// <param name="courseId"></param>
        /// <param name="score"></param>
        /// <returns></returns>
        public DataTable GetStu(string courseId, out float score)
        {
            SqlParameter[] pa = new SqlParameter[] {
                new SqlParameter("@couId",courseId),
                new SqlParameter("@avgscore",SqlDbType.Float){Direction=ParameterDirection.Output  },
            };
            DataTable dt = SqlHelper.ExecuteDataTable(CommandType.StoredProcedure, "proc_stu", pa);
            score = Convert.ToSingle(pa[1].Value);
            return dt;
        }
    }
}
