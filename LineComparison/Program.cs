using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, length1, length2;
            Console.WriteLine("enter first point line x1 & y1:");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second point line x2 & y2:");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            length1 = Math.Sqrt(Math.Pow (x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            length2 = Math.Sqrt(Math.Pow (x1 - x2, 2) + Math.Pow(y1 - y2, 2));

            int check = length1.CompareTo(length2);

            if(check > 0)
            {
                Console.WriteLine("first length greater then:");
            }
            else if (check < 0)
            {
                Console.WriteLine("seconf length less then :");
            }
            else
            {
                Console.WriteLine("both line is equal");
            }
        }
    }
}
