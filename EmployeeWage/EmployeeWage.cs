using System;

namespace EmployeeWage
{
    public class EmployeeWage
    {
        const int fullDayPresent = 1;
        const int halfDayPresent = 2;

        public void attendence() 
        {
            int dailyWage = 0;
            int empHour = 0;
            int wagePerHour = 20;
            Random rnd = new Random();
            int empCheck=rnd.Next(0,3);

            switch (empCheck)
            {
                case fullDayPresent: empHour = 8; 
                    
                    break;

                case halfDayPresent: empHour = 4;
                    
                    break;

                default            : empHour=0;
                    
                    break;
            }

            dailyWage = empHour * wagePerHour;
            Console.WriteLine($"Daily Wage is:{dailyWage}");
                  
        }
    }
}
