using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractise
{
    internal class Bubboble_sort
    {
        public static void sort()
        {
            int[] array = { 67,48,90,23,15,90 };
            int t;

            Console.WriteLine("The Array is : ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - 1;i++)
                {
                    if (array[i] < array[i+1])
                    {
                        
                            t = array[i];
                            array[i] = array[i+1];
                            array[i+1] = t;
                        
                    }
                }
            }
            Console.WriteLine("The Sorted Array:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }
    }
}
