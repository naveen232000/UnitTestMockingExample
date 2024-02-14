using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpLib
{
    public class ProcessEmp
    {
        public bool InsertEmp(CheckEmpSecondDevs objemp)
        {
            objemp.CheckEmp();
            return true;
        }
    }
}
