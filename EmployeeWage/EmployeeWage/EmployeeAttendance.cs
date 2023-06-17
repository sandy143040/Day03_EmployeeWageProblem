using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeAttendance
    {
        //UC5-Calculating Wages for Month

        public static void EmployeeWage()
        {
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int NUM_OF_WORKING_DAYS = 20;
            const int EMP_RATE_PER_HOUR = 20;

            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                //Random Function
                Random random = new Random();
                int empCheck = random.Next(0, 3);


                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Employee Wage is: " + empWage);
            }
            Console.WriteLine("total emp wage : " + totalEmpWage);
        } 
    }
}
