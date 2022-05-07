using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_EmployeeWageOOP2
{
    internal class CompanyEmpWageBuilder
    {



        public const int Is_Fulltime = 1;
        public const int Is_Parttime = 2;

        public static int TotalEmpwage = 0;
        public static int TotalEmpHr = 0;

        public static int CalEmpHr(String CmpName, int MaxWorkingDays, int MaxWorkingHr)
        {
            int Emp_Hr = 0, TotalWorkingDays = 0;

            while (TotalEmpHr <= MaxWorkingHr && TotalWorkingDays < MaxWorkingDays)
            {
                Random obj = new Random();
                int empcheck = obj.Next(0, 3); //it will generate 0 and 1 only bcoz its limit is n-1 ie 2-1=1

                if (empcheck == Is_Fulltime)
                {
                    //Console.WriteLine("Employee is Fulltime\n");
                    Emp_Hr = 8;
                }
                else if (empcheck == Is_Parttime)
                {
                    // Console.WriteLine("Employee is Parttime\n");
                    Emp_Hr = 4;
                }
                else
                {
                    Emp_Hr = 0;
                    //Console.WriteLine("Employee is Absent\n");
                }

                TotalEmpHr += Emp_Hr;
                TotalWorkingDays++;

            }
            Console.WriteLine("\n>> Company Name Of Employee:- " + CmpName);
            Console.WriteLine("\n>> Total working Hr of cureent EMployee:- " + TotalEmpHr);
            return TotalEmpHr;
        }

        public static int TotalWage(int Emp_Rate_Hr)
        {
            TotalEmpwage = Emp_Rate_Hr * TotalEmpHr;
            Console.WriteLine("\n>> Total Wage of current Empolyee is :- " + TotalEmpwage);

            return TotalEmpwage;

        }
    }
}
