using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractise
{
    internal class Multiplytablewithoutoperator
    {
        public static void multiply()
        {
            Console.WriteLine("enter the number which table you want");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the size the Table");
            int size = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= size; i++)
            {
                int result = MultiplyByvalue(number,i);
                Console.WriteLine($"{number} x {i} = {result}");
            }
            Console.ReadLine();
        }
        static int MultiplyByvalue(int n,int mul)
        {
            int result = 0;
            for (int i = 0; i < mul; i++)
            {
                result += n;
            }
            return result;
        }
    }
}
