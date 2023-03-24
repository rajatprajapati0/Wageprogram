using System;

namespace EmployeeWage
{
    public class EmployeeWage
    {
        const int fullDayPresent = 1;
        const int halfDayPresent = 2;
  

       public static int  empHour = 0, totalday = 0, totalEmpHour = 0;

        public void employeeWageForCompany(int maxDay,int maxHour,int wagePerHour,string companyName)
        {          
            Random rnd = new Random();
            while (totalEmpHour < maxHour && totalday <maxDay) 
            {
                int empCheck = rnd.Next(0, 3);
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
                totalEmpHour += empHour;
                totalday++;          

            }
             int  monthlyWage = totalEmpHour * wagePerHour;
             Console.WriteLine($"Company Name :{companyName}\nMonthly Wage is:{monthlyWage}\nTotal Hour:{totalEmpHour}\nTotal Day{totalday}");
        }
    }
}
