using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeWageSwitch
{
    internal class Program
    {
        public const int PART_TIME = 1;
        public const int FULL_TIME = 2;
        public const int EMP_RATE_HOUR = 20;
        static void Main(string[] args)
        {
            //Variable
            int empHrs = 0;
            int empWage = 0;
            //computation
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
            empWage = empHrs * EMP_RATE_HOUR;

            Console.WriteLine("emp wage" + empWage);
        }
    }
}
