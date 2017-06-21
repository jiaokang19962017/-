using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDataAccess
{
    public interface IScore
    {
        Dictionary<string, float> GetScore<T, V>(int stuid);
    }
}
