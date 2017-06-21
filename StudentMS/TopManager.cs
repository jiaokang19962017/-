using DataAccess;
using IDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS
{
    public class TopManager
    {
        ITop it = new TopDA();
        public void ShowScore()
        {
            Console.WriteLine("请输入课程编号：");
            string couId = Console.ReadLine();
            float score;
            DataTable dt = it.GetStu(couId, out score);
            Console.WriteLine("课程编号{0}的平均成绩是{1}", couId, score);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    Console.Write(dt.Rows[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
