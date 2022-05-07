using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_EmployeeWageOOP2
{
    internal class CompanyEmpWageBuilder
    {

        public const int IS_Fulltime = 1;

        public void EmpCheck(string Company)
        {

            Random r = new Random();
            int empcheck = r.Next(0, 2);

            switch (empcheck)
            {
                case IS_Fulltime:
                    Console.WriteLine("\nEmployee of " + Company + " is Present and it is Fulltime Employee....");
                    break;

            
                default:
                    Console.WriteLine("\nEmployee of " + Company + " is Absent....");
                    break;
            }



        }
    }
}
