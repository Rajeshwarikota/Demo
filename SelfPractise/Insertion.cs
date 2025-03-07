using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractise
{
     class Insertion
    {
        public static void sorting()
        {
            int[] array = { 65, 78, 90, 12, 34, 20 };
            Console.WriteLine("The Array is : ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            for(int i=1;i<array.Length;i++)
            {
                int current = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > current)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = current;
            }
            Console.WriteLine("The Sorted Array:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }
    }
}
