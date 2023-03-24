using System;

namespace EmployeeWage
{
    public class EmployeeWage
    {
        const int fullDayPresent = 1;
        const int halfDayPresent = 2;
        const int maxDay = 20;
        const int maxHour = 100;

       public static int dailyWage, empHour = 0, totalday = 0, totalEmpHour = 0, wagePerHour = 20;

       public static int getEmployeeHour(int empCheck)
       {
            switch (empCheck)
            {
                case fullDayPresent:
                    empHour = 8;
                    break;

                case halfDayPresent:
                    empHour = 4;

                    break;

                default:
                    empHour = 0;
                    break;
            }
            return empHour;
       }
        public void employeeWage() 
        {
            Random rnd = new Random();

            while (empHour <= maxHour && totalday <maxDay) 
            {
               
                int empCheck = rnd.Next(0, 3);
                totalEmpHour += getEmployeeHour(empCheck);

                totalday++;
                Console.WriteLine($"Emp Hour:{empHour}\nTotal Day{totalday}");

            }
            dailyWage = totalEmpHour * wagePerHour;
            Console.WriteLine($"Daily Wage is:{dailyWage}\nTotal Hour:{totalEmpHour}\nTotal Day{totalday}");
        }
    }
}
