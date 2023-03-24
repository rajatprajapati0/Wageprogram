using System;

namespace EmployeeWage
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in Employee Wage program");
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.employeeWageForCompany(20,100,20, "Demart");
            employeeWage.employeeWageForCompany(24,120, 30, "Tata");


        }
    }
}
