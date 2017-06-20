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
        /// <summary>
        /// 添加考试信息
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        int AddExam(Exam ex);

        /// <summary>
        /// 删除考试信息
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        int DelExam(Exam ex);

        /// <summary>
        /// 修改考试信息
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        int UpdExam(Exam ex);
        /// <summary>
        /// 查看考试信息
        /// </summary>
        /// <returns></returns>
        List<Exam> SelectAll();
    }
}
