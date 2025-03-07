using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractise
{
    internal class ReverseRightAngle
    {
        public static void ReverseAngle()
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = num; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void ArrayListCRUD()
        {
            ArrayList list = new ArrayList();

            // CREATE: add elements to the ArrayList
            list.Add("Raji");
            list.Add("John");
            list.Add("Lisa");
            list.Add("siri");

            // READ: print the elements of the ArrayList
            Console.WriteLine("Elements of the ArrayList:");
            foreach (object element in list)
            {
                Console.WriteLine(element);
            }

            // UPDATE: update an element in the ArrayList
            int indexToUpdate = 1; // index of the element to update
            string newValue = "Jane"; // new value for the element
            list[indexToUpdate] = newValue;

            // READ: print the elements of the List after the update
            Console.WriteLine("Elements of the List after update:");
            foreach (string element in list)
            {
                Console.WriteLine(element);
            }

            // DELETE: remove an element from the List
            int indexToDelete = 2; // index of the element to delete
            list.RemoveAt(indexToDelete);

            // READ: print the elements of the List after the deletion
            Console.WriteLine("Elements of the List after deletion:");
            foreach (string element in list)
            {
                Console.WriteLine(element);

            }

        }
    }
}
