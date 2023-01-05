using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeWageComputation
{
    internal class Program
    {
        public const int PART_TIME = 1;
        public const int FULL_TIME = 2;
        public const int EMP_RATE_PER_DAY = 20;
        public const int EMP_TOTAL_WORKING_DAY = 20;
        public const int EMP_TOTAL_MONTH = 10;
        static void Main(string[] args)
        {
            //Variable
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDay = 0;
            //computation
            while (totalEmpHrs < EMP_TOTAL_WORKING_DAY && totalWorkingDay < EMP_TOTAL_MONTH)
            {
                totalWorkingDay++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case PART_TIME:
                        empHrs = 4;
                        break;
                    case FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("day:" + totalEmpHrs + "empHrs:" + empHrs);
            }
            int totalWage = totalEmpHrs * EMP_RATE_PER_DAY;
            Console.WriteLine("total emp wage:" + totalWage);

        }
    }
}
