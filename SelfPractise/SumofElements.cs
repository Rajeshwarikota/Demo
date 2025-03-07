using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractise
{
    class SumofElements
    {
        public static void operation()
        {
           int[] elements = { 23, 45, 67 ,34,56,76 };
           for (int i=0; i<elements.Length; i++)
           {
                Console.WriteLine( i+1 + " Element in the Array are :" + elements[i]);
           }
            int sum = 0;
            foreach (int numbers in elements)
            {
                sum += numbers;
            }
            Console.WriteLine("Sum of the elements are : " + sum);
            //---------------------------------------------------------------------------
            int max = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                if (max < elements[i])
                {
                    max = elements[i];
                }
            }
            Console.WriteLine("maximum element in the array is : " + max);
            //---------------------------------------------------------------------------
            int min = elements[0];
            for (int i = 0; i < elements.Length; i++)
            {
                if (min >= elements[i])
                {
                    min = elements[i];
                }
            }
            Console.WriteLine("minimum element in the array is : " + min);
            //------------------------------------------------------------------------------
            Console.WriteLine("Sum of MAXIMUM and MINIMUM is : " + (max + min));
            //------------------------------------------------------------------------------
            Array.Sort(elements);
            Console.WriteLine("Sorted elemets are : ");
            foreach (int values in elements)
            {
                Console.WriteLine(values);
            }
            //---------------------------------------------------------------------------------
            for (int i=0;i<elements.Length-1;i++)
            {
                for(int j=0;j<elements.Length-1-i;j++)//23, 45, 67 ,34,56,76
                {
                    if (elements[j] > elements[j+1])
                    {
                        int temp = elements[j];
                        elements[j] = elements[j+1];
                        elements[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("sorted elements without sort method are:");
            foreach(int values in elements)
            {
                Console.WriteLine(values);
            }
            //---------------------------------------------------------------------------------------
        }
    }
}
