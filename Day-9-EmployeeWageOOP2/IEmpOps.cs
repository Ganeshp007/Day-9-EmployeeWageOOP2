using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_EmployeeWageOOP2
{
    internal interface IEmpOps
    {

        public int CalEmpHr(String CmpName, int MaxWorkingDays, int MaxWorkingHr);

        public int TotalWage(int Emp_Rate_Hr);
    }
}
