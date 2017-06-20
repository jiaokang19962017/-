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

    }
}
