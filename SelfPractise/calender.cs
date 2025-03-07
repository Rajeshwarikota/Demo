using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractise
{
    internal class calender
    {
        public static void cal()
        {
            DateTime currentdate = DateTime.Today;
            Console.WriteLine(currentdate.ToString("MMMM yyyy"));
            Console.WriteLine("sun Mon Tue Wed Thu fri Sat");

            DateTime frstdayofmnth = new DateTime(currentdate.Year, currentdate.Month, 1);

            int daysinmnth = DateTime.DaysInMonth(currentdate.Year, currentdate.Month);

            DayOfWeek frstdayofweek = frstdayofmnth.DayOfWeek;

            for (int i = 0;i<(int)frstdayofweek;i++)
            {
                Console.WriteLine("   ");
            }

            for (int day = 0; day <= daysinmnth; day++)
            {
                Console.WriteLine($"{day,3}");

                if (frstdayofweek == DayOfWeek.Saturday && day != daysinmnth)
                {
                    Console.WriteLine();
                }
                frstdayofweek = frstdayofweek == DayOfWeek.Saturday ? DayOfWeek.Sunday : frstdayofweek + 1;
            }
            Console.WriteLine();
        
        }
    }
}
