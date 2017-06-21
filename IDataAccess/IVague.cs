using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDataAccess
{
   public interface IVague
    {
        List<Vague> selectAll(string str);
    }
}
