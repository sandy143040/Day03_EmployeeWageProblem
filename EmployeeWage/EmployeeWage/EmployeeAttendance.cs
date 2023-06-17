using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeAttendance
    {
        //UC1-Check Employee Attendance
        public static void EmployeeCheck()
        {
            int isPresent = 1;
            Random random = new Random();
            int employeeAttendence = random.Next(0, 2); //0 or 1
            if (employeeAttendence == isPresent)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
