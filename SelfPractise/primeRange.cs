using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractise
{
    internal class primeRange
    {
        public static void PrimeRange()
        {
            //Console.WriteLine("Enter the Lower Number");
            //int lower = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Upper Number");
            //int upper = Convert.ToInt32(Console.ReadLine());

            //Boolean flag = true;
            //Console.WriteLine("Prime Number Between " + lower + " and " + upper);
            //for (int k = lower; k <= upper; k++)
            //{
            //    flag = true;
            //    for (int i = 2; i < k; i++)
            //    {
            //        if (k % i == 0)
            //        {
            //            flag = false;
            //            break;
            //        }
            //    }
            //    if (flag == true)
            //    {
            //        Console.WriteLine(k);
            //    }
            //}
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("PrimeFactors of this " + num + "are");
            for (int i = 2; i < num; i++)
            {
                while (num % i == 0)
                {
                    Console.WriteLine(i);
                    num = num / i;
                }


            }
        }
    }
}
