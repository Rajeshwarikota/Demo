using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractise.String
{
    internal class Removing
    {
        public static string RemoveDuplicates(string input)
        {
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (!result.Contains(input[i]))
                {
                    result += input[i];
                }
            }
            return result;
        }
        public static void Count()
        {
            ////    int[] arr = { 5, 1, 4, 2, 3 };
            ////    Array.Sort(arr);  // sort the array in ascending order
            ////    int sum = arr[0] + arr[1];  // add the first two elements

            ////    Console.WriteLine("The sum of the first two smallest elements in the array is: {0}", sum);

            ////int[] array = { 1, 3, 5, 7, 3, 6, 9 };
            ////int count = 0;

            ////for (int i = 0; i < array.Length-1; i++)
            ////{
            ////    for (int j = i+1; j < array.Length; j++)
            ////    {
            ////        if (array[i] == array[j])
            ////        {
            ////            count++;
            ////        }
            ////    }
            ////}
            ////Console.WriteLine("Number of Count:"+count);
            int[] arr = { 5, 1, 4, 2, 3 };

            while (arr.Length > 1)
            {
                // Sort the array in ascending order
                Array.Sort(arr);

                // Take the first two elements and add them together
                int sum = arr[0] + arr[1];

                // Insert the sum back into the array in its sorted position
                int[] newArr = new int[arr.Length - 1];
                newArr[0] = sum;
                Array.Copy(arr, 2, newArr, 1, newArr.Length - 1);

                arr = newArr;
            }

            Console.WriteLine("The final result is: {0}", arr[0]);
        }
    }
}
