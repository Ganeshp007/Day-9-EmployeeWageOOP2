// See https://aka.ms/new-console-template for more information

using Day_9_EmployeeWageOOP2;

Console.WriteLine("----- Welcome to Employee Management System -----\n");

CompanyEmpWageBuilder.CalEmpHr("Dmart", 20, 100);//CompnayNAme,MaxWorkingDays,MaxWorkingHr
CompanyEmpWageBuilder.TotalWage(20);//Emp_RAte_Hr


Console.WriteLine("\nPress Enter to Continue...\n");
Console.ReadKey();


CompanyEmpWageBuilder.CalEmpHr("Amazon", 20, 100);
CompanyEmpWageBuilder.TotalWage(40);

Console.WriteLine("\nPress enter to Exit....");
Console.ReadKey();
