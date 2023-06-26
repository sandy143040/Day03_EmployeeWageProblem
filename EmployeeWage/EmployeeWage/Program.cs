using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of companies: ");
            int numCompanies = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numCompanies; i++)
            {
                Console.WriteLine($"Enter details for company {i}:");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Wage per hour: ");
                int wage = Convert.ToInt32(Console.ReadLine());

                Console.Write("Working hours per day: ");
                int hours = Convert.ToInt32(Console.ReadLine());

                Console.Write("Working days per month: ");
                int days = Convert.ToInt32(Console.ReadLine());

                EmployeeAttendance.ComputeEmpWage(name, wage, hours, days);
                Console.ReadLine();
            }
        }
    }
}
