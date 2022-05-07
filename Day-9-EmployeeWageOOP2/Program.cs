// See https://aka.ms/new-console-template for more information

using Day_9_EmployeeWageOOP2;


Console.WriteLine("----- Welcome to Employee Wage Monitoring System -----\n");

CompanyEmpWageBuilder obj = new CompanyEmpWageBuilder();
obj.EmpCheck("Flipcart");
obj.EmpCheck("Amazon");

Console.ReadKey();