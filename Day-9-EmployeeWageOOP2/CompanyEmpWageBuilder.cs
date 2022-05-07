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
        public const int Max_Working_Days = 20;
        public const int EmpRatePerHr = 20;
        public void EmpCheck(string Company)
        {
            //local variable
            int emphr = 0, totaldays = 0, TotalEmpHr = 0;

            Console.WriteLine(">> Records of " + Company + " Company :\n");

            while (totaldays < Max_Working_Days)

            {
                Random r = new Random(); //TO generate random no
                int empcheck = r.Next(0, 3);

                switch (empcheck)
                {
                    case IS_Fulltime:

                        emphr = 8;
                        break;

                    case IS_Parttime:

                        emphr = 4;
                        break;

                    default:

                        emphr = 0;
                        break;
                }

                TotalEmpHr += emphr; //to Calculate total Emp Hours 

                totaldays++;


                Console.WriteLine("Day:- " + totaldays + " Employee Worked For :- " + emphr + "Hr\n");
            }

            Console.WriteLine(">> Total Employee Wage for " + Company + " company is :- " + EmpWage(Company, TotalEmpHr) + "\n");


        }

        public int EmpWage(string Compnay, int totalEmpHr)
        {
            int TotalWage = EmpRatePerHr * totalEmpHr;
            return TotalWage;
        }





    }
}
