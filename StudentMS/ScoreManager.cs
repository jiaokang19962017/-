using IDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
namespace StudentMS
{
   public class ScoreManager
    {
        IScore isc = new ScoreDA();
        public void GetScoreManager()
        {
            Console.WriteLine("输入学生的学号：");
            int stuId = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, float> score = isc.GetScore<string, float>(stuId);

            foreach (KeyValuePair<String, float> kvp in score)
            {
                Console.WriteLine(String.Format("{0};{1}", kvp.Key, kvp.Value));

            }

        }
    }
}
