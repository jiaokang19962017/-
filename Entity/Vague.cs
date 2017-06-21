using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    /// <summary>
    /// 模糊查询实体类
    /// </summary>
   public class Vague
    {
        public int StuId { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string StuName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public int StuSex { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime StuBirth { get; set; }
        /// <summary>
        /// 联系方式
        /// </summary>
        public string StuPhone { get; set; }
        /// <summary>
        /// 籍贯
        /// </summary>
        public string StuPlace { get; set; }

        public float Score { get; set; }
        /// <summary>
        /// 课程编号
        /// </summary>
        public string CourseId { get; set; }
        /// <summary>
        /// 课程名称
        /// </summary>
        public string CourseName { get; set; }
        /// <summary>
        /// 学分
        /// </summary>
        public int Credit { get; set; }
    }
}
