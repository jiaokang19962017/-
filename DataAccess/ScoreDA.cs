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
   public class ScoreDA : IScore
    {

        /// <summary>
        /// 计算学生平均成绩和总成绩
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <param name="stuid"></param>
        /// <returns></returns>
        public Dictionary<string, float> GetScore<T, V>(int stuid)
        {
            SqlParameter[] pa = new SqlParameter[] {
                new SqlParameter("@stuID",stuid),
                 new SqlParameter("@sumScore",SqlDbType.Float,10) {Direction=ParameterDirection.Output  },
                  new SqlParameter("@avgScore",SqlDbType.Float,10) {Direction=ParameterDirection.Output  }
            };

            SqlHelper.ExecutrNonQuery(CommandType.StoredProcedure, "PROC_score", pa);
            Dictionary<string, float> dis = new Dictionary<string, float>();
            dis.Add("总成绩", Convert.ToSingle(pa[1].Value));
            dis.Add("平均成绩", Convert.ToSingle(pa[2].Value));
            return dis;
        }
    }
}
