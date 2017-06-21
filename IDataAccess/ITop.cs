using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDataAccess
{
    public interface ITop
    {
        DataTable GetStu(string courseId, out float score);
    }
}
