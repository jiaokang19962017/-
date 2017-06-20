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
    class ExamManager
    {
        IExam ie = new ExamDA();
        Exam ex = new Exam();
        public void InsertExamInfo()
        {
            Console.WriteLine("请输入学生编号:");
            int stuid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入课程编号:");
            string cid = Console.ReadLine();
            Console.WriteLine("请输入成绩:");
            float score = Convert.ToSingle(Console.ReadLine());
            ex.StuId = stuid;
            ex.CourseId = cid;
            ex.Score = score;
            int count = ie.AddExam(ex);
            if (count > 0)
            {
                Console.WriteLine("添加成功");
            }
            else
            {
                Console.WriteLine("添加失败");
            }
        }

        public void DelExamInfo()
        {
            Console.WriteLine("请输入要删除的考试编号:");
            int stuid = Convert.ToInt32(Console.ReadLine());
            ex.StuId = stuid;
            int count =  ie.DelExam(ex);
            if (count > 0)
            {
                Console.WriteLine("删除成功");
            }
            else
            {
                Console.WriteLine("删除失败");
            }
        }

        public void UpdExamInfo()
        {
            Console.WriteLine("请输入要更新的成绩编号");
            int stuid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入新的成绩:");
            float score = Convert.ToSingle(Console.ReadLine());
            ex.StuId = stuid;
            ex.Score = score;
            int count = ie.UpdExam(ex);
            if (count > 0)
            {
                Console.WriteLine("删除成功");
            }
            else
            {
                Console.WriteLine("删除失败");
            }
        }

        public void GetExamInfo()
        {
            List<Exam> lex = ie.SelectAll();
            foreach (Exam ex in lex)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(ex.StuId+"\t");
                sb.Append(ex.CourseId + "\t");
                sb.Append(ex.Score + "\t");
                Console.WriteLine(sb.ToString());
            }
        }
    }
}
