using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_EmployeeWageOOP2
{
    internal class CompanyEmpWageBuilder
    {

        public const int IS_FUlltime = 1;
        public const int EmpRatePerHr = 20;
        public void EmpCheck(string Company)
        {
            int emphr = 0;


            Random r = new Random();
            int empcheck = r.Next(0, 2);

            switch (empcheck)
            {
                case IS_FUlltime:
                    emphr = 8;
                    Console.WriteLine(">> Employee of " + Company + " is Present....\n");

                    break;

                 
                default:
                    emphr = 0;
                    Console.WriteLine(">> Employee of " + Company + " is Absent....\n");
                    break;
            }

            int Dailywage = EmpRatePerHr * emphr;


            Console.WriteLine("Employee Wage of a day to " + Company + " company for current Employee is :- " + Dailywage + "\n");
        }


    }
}
