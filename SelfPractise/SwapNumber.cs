using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractise
{
    internal class SwapNumber
    {
            public static void Swapping()
            {
                int num1, num2, temp;
                Console.WriteLine("Enter the value of n1");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value of n2");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Before Swapping");

                Console.WriteLine("FirstNumber :" + num1);
                Console.WriteLine("SecondNumber :" + num2);

                temp = num1;
                num1 = num2;
                num2 = temp;

                Console.WriteLine("After Swapping");

                Console.WriteLine("FirstNumber :" +num1);
                Console.WriteLine("SecondNumber :" +num2);
                Console.ReadLine();
            }
        
    }
}
