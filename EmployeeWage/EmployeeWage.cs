

using System;

namespace EmployeeWage
{
    public class EmployeeWage
    {
        const int isPresent = 1;
        public void attendence() 
        {
            Random rnd = new Random();
            int empCheck=rnd.Next(0,2);

          if(empCheck == isPresent )
          {
                Console.WriteLine("Employee is present");
          }
          else 
          {
                Console.WriteLine("Employee is not present");
          }
        }
    }
}
