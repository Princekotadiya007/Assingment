using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeePartTimeUC3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //contants
            int PART_TIME = 1;
            int FULL_TIME = 2;
            int EMP_RATE_HOUR = 20;
            //variables
            int empHrs = 0;
            int empWage = 0;
            //computation
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            if(empCheck == PART_TIME)
            {
                empHrs = 4;
            }
            else if (empCheck == FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_HOUR;

            Console.WriteLine("emp wage" + empWage);
        }
    }
}
