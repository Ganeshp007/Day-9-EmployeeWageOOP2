﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_EmployeeWageOOP2
{
    internal interface IEmpOps
    {

        public int EmpWage(string Company, int totalEmpHr);

        public void EmpCheck(string Compnay);
    }
}
