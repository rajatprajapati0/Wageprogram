

using System;

namespace EmployeeWage
{
    public class EmployeeWage
    {
        const int fullDayPresent = 1;
        const int halfDayPresent = 2;

        const int fullDayHour = 8;
        const int halfDayHour = 4;

        public void attendence() 
        {
            int wagePerHour = 20;
            Random rnd = new Random();
            int empCheck=rnd.Next(0,3);

          if(empCheck == fullDayPresent)
          {
              int dailyWage= wagePerHour* fullDayHour;
                Console.WriteLine($"Employee is present for full day\nDaily Wage is:{dailyWage}");
          }
          else if(empCheck== halfDayPresent)
          {
                int dailyWage = wagePerHour * halfDayHour;
                Console.WriteLine($"Employee is present for half day\nDaily Wage is:{dailyWage}");
          }
          else 
          {
                Console.WriteLine("Employee is not present");
          }
        }
    }
}
