using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeAttendance
    {
        //UC3-Add PartTime Employee and Wage
        public static void EmployeeWage()
        {
            int empHrs = 0;
            int empWage = 0;
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;
            

            //Random Function
            Random random = new Random();
            int empCheck = random.Next(0, 3); 
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee attendance is present");
                empHrs = 8;
            }
            else if(empCheck == IS_PART_TIME)
            {
                Console.WriteLine("PartTime Employee attendance is present");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee attendance is absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage is: " +empWage);
        }
    }
}
