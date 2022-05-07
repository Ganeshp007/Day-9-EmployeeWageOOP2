using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_EmployeeWageOOP2
{
    internal class CompanyEmpWageBuilder
    {

        //init instance Variable
        public const int IS_Parttime = 1;
        public const int IS_Fulltime = 2;
        public const int EmpRatePerHr = 20;
        public void EmpCheck(string Company)
        { //local variable
            int emphr = 0;


            Random r = new Random(); //TO generate random no
            int empcheck = r.Next(0, 3);

            switch (empcheck)
            {
                case IS_Fulltime:
                    emphr = 8;
                    Console.WriteLine(">> Employee of " + Company + " is Present and it is Fulltime Employee ....\n");

                    break;
                case IS_Parttime:
                    emphr = 4;
                    Console.WriteLine(">> Employee of " + Company + " is Present and it is Parttime Employee ....\n");
                    break;

                default:
                    emphr = 0;
                    Console.WriteLine(">> Employee of " + Company + " is Absent....\n");
                    break;
            }
            int Dailywage = EmpRatePerHr * emphr; //to Calculate Daily Employee wage


            Console.WriteLine("Employee Wage of a day to " + Company + " company for current Employee is :- " + Dailywage + "\n");
        }






    }
}
