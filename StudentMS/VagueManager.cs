using DataAccess;
using Entity;
using IDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS
{
  public  class VagueManager
    {
        IVague iva = new VagueDA();
        public void SeleVague()
        {
            Console.WriteLine("请输入查询条件:");
            string search = Console.ReadLine();
            List<Vague> Ivag = iva.selectAll(search);
            foreach (Vague vag in Ivag)
            {
                string sex = vag.StuSex == 1 ? "男" : "女";
                StringBuilder sb = new StringBuilder();
                sb.Append(vag.StuId + "\t");
                sb.Append(vag.StuName + "\t");
                sb.Append(sex + "\t");
                sb.Append(vag.StuPhone + "\t");
                sb.Append(vag.StuPlace + "\t");
                sb.Append(vag.CourseId + "\t");
                sb.Append(vag.CourseName + "\t");
                sb.Append(vag.Credit + "\t");
                sb.Append(vag.Score + "\t");
                Console.WriteLine(sb.ToString());

            }
        }
    }
}
