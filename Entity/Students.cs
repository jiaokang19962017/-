using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    /// <summary>
    /// 学生实体类
    /// </summary>
    public class Students
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
        public string StuSex { get; set; }
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
    }
}
