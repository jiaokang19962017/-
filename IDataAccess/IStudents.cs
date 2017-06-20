using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDataAccess
{
    public interface IStudents
    {
        /// <summary>
        /// 添加学生信息
        /// </summary>
        /// <param name="stuname">学生姓名</param>
        /// <param name="stusex">学生性别</param>
        /// <param name="stubirth">学生出生日期</param>
        /// <param name="stuphone">学生电话</param>
        /// <param name="stuplace">学生地址</param>
        /// <returns>成功返回true</returns>
        bool AddStuInfo(string stuname, int stusex, DateTime stubirth, string stuphone, string stuplace);

        /// <summary>
        /// 查询学生信息
        /// </summary>
        /// <returns>返回集合</returns>
        List<Students> SelectAll();

        /// <summary>
        /// 删除学生信息
        /// </summary>
        /// <returns>返回受影响行数</returns>
        int DeleStuInfo(int stuid);
        /// <summary>
        /// 修改学生信息
        /// </summary>
        /// <param name="stuid"></param>
        /// <returns></returns>
        int UpdateStuInfo(int stuid,string stuname,int stesex,DateTime stubirth,string stuphone,string stuplace);
    }
}
