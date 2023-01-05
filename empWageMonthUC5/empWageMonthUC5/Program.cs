using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empWageMonthUC5
{
    internal class Program
    {
        public const int PART_TIME = 1;
        public const int FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAY = 20;
        static void Main(string[] args)
        {
            //variable
            int empHrs = 0;
            int empWage = 0; 
            int totalEmpWage = 0;
            //computaion

            for(int i=0; i<NUM_OF_WORKING_DAY; i++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case PART_TIME:
                       // console.writeLine("employee is working PartTime");
                        empHrs = 4;
                        break;
                    case FULL_TIME:
                      //  console.writeLine("employee is working fullTime");
                        empHrs = 8;
                        break;
                    default:
                       // console.writeLine("employee is working absent");
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;

                Console.WriteLine("emp wage" + empWage);
            }
            Console.WriteLine("total emp wage" + totalEmpWage);
        }
    }
}
