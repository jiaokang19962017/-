﻿using Entity;
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

        List<Students> SelectAll();
    }
}
