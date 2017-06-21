using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Top
    {
        /// <summary>
        /// 学号
        /// </summary>
        public int StuId { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string StuName { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public int StuSex { set; get; }

        /// <summary>
        /// 联系方式
        /// </summary>
        public string StuPhone { get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime StuBirth { get; set; }

        /// <summary>
        /// 籍贯
        /// </summary>
        public string StuPlace { get; set; }


        /// <summary>
        /// 课程编号
        /// </summary>
        public string CourseId { set; get; }
        /// <summary>
        /// 课程名称
        /// </summary>
        public string CourseName { set; get; }
        /// <summary>
        /// 学分
        /// </summary>
        public int Credit { set; get; }
    }
}
