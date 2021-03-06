﻿using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDataAccess
{
    //课程信息表接口
   public interface ICourse
    {
        /// <summary>
        /// 添加课程信息
        /// </summary>
        /// <returns>插入成功返回1,失败返回0</returns>
        int AddCourseInfo(Course cou);

        /// <summary>
        /// 删除课程信息
        /// </summary>
        /// <param name="cou">实体类的对象</param>
        /// <returns>成功返回1,失败返回0</returns>
        int DelCourseInfo(Course cou);

        /// <summary>
        /// 修改课程信息方法
        /// </summary>
        /// <param name="cou">实体类对象</param>
        /// <returns>成功返回1,失败返回0</returns>
        int UpdCourseInfo(Course cou);

        /// <summary>
        /// 查询全部课程信息方法
        /// </summary>
        /// <returns>返回泛型集合</returns>
        List<Course> SelectAll();
    }
}
