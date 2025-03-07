using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractise
{
    internal class PyramidReverse
    {
        public static void ReversePyramidShape()
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = num; i >= 1; i--)
            {
                for (int j = 1; j <= (num - i); j++)
                {
                    Console.Write("-");
                }

                for (int k = 1; k <= i * 2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
