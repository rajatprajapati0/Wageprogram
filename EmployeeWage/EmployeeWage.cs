

using System;

namespace EmployeeWage
{
    public class EmployeeWage
    {
        const int isPresent = 1;
        const int fullDayHour = 8;

        public void attendence() 
        {
            int wagePerHour = 20;
            Random rnd = new Random();
            int empCheck=rnd.Next(0,2);

          if(empCheck == isPresent )
          {
              int dailyWage= wagePerHour* fullDayHour;
                Console.WriteLine($"Employee is present\nDaily Wage is:{dailyWage}");
          }
          else 
          {
                Console.WriteLine("Employee is not present");
          }
        }
    }
}
