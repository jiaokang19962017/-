using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    /// <summary>
    /// 课程实体类
    /// </summary>
   public class Course
    {
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
