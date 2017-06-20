using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDataAccess
{
    /// <summary>
    /// 学生成绩接口
    /// </summary>
  public  interface IExam
    {
        int AddExam(Exam ex);
    }
}
