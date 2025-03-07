using SelfPractise.String;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractise
{
    internal class Program
    {
       public static void Main(string[] args)

        {
            Console.WriteLine("Enter the Option the below");
            Console.WriteLine("\n1:swaping\n2:Conversion\n3:StringReverse\n4:RemovingDuplicate\n5:Squarepattern\n6:ReverseRight\n7:pyramid\n8:PyramidReverse\n9:Types of variables\n10:Array element delete\n11.Index\n12:Test\n13:Lamda Expression\n14:chapter\n15:Insertionsort\n16:Reflection\n17:Bubbole sort\n18:Insertiont\n19:Quicksort\n20:Multiplication Table  without operator \n21:Raji pattern \n22:Calender \n23:sum of elemts \n24:Prime numbers range findig \n25:Charger" +
                "");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    SwapNumber.Swapping();
                    break;
                case 2:
                    ConverionLetters.Conversion();
                    break;
                case 3:
                    StringReverse.Reversing();
                    break;
                case 4:
                    string input = "hello world";
                    string result = Removing.RemoveDuplicates(input);
                    Console.WriteLine(result);
                    Removing.Count();
                    break;
                case 5:
                    RightAngle.Angle();
                    break;
                case 6:
                    ReverseRightAngle.ReverseAngle();
                    ReverseRightAngle.ArrayListCRUD();
                    break;
                case 7:
                    Pyramid.PyramidShape();
                    break;
                case 8:
                    PyramidReverse.ReversePyramidShape();
                    break;
               case 9:
                    TypeoFVariables variables = new TypeoFVariables();
                    variables.LocalVariable();
                    variables.Age = 32;
                    Console.WriteLine("Age" + variables.Age);
                    Console.WriteLine("constant value" + TypeoFVariables.Constant);
                    Console.WriteLine(TypeoFVariables.position);
                    break;
                case 10:
                    //Console.WriteLine("How many elents to add into array");
                    //int size = Convert.ToInt32(Console.ReadLine());
                    //int[] arr = new int[size];
                    //Console.WriteLine("storing elements into array");
                    //for(int i=0;i<arr.Length;i++)
                    //{
                    //    arr[i] = Convert.ToInt32(Console.ReadLine());
                    //}
                    //Console.WriteLine("\nplease pickup any one element from this array");
                    //int delete = Convert.ToInt32(Console.ReadLine());
                    //ArrayElementDelete.DeleteElement(arr,delete);

                    Console.WriteLine("How many elements to add into array:");
                    int arraySize = Convert.ToInt32(Console.ReadLine());
                    double[] doubleArr = new double[arraySize];

                    Console.WriteLine("Storing elements into array:");
                    for (int i = 0; i < doubleArr.Length; i++)
                    {
                        Console.Write($"Enter element {i + 1}: ");
                        doubleArr[i] = Convert.ToDouble(Console.ReadLine());
                    }

                    Console.WriteLine("\nPlease select an element to delete from this array:");
                    double deleteDouble = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nArray after deleting the selected element:");
                    ArrayElementDelete.DoubleDeleteElement(doubleArr, deleteDouble);

                    Console.ReadLine();
                    break;
                case 11:
                    Example.Index();
                    break;
                case 12:
                    Calculator c = new Calculator();
                    Console.WriteLine(c.Add(2,5));
                    Console.WriteLine(c.Sub(7,4));
                    break;
                case 13:
                    LamdaExpression.Lamba();
                    break;
                case 14:
                    chapter.page();
                    break;
                case 15:
                    int[] arr = { 5, 2, 4, 6, 1, 3 };
                    InsertionSort.Insertion(arr);
                    Console.WriteLine(string.Join(", ", arr));
                    break;
                case 16:
                    int n = 17;
                    int closest = Reflection.GetClosestEvenNumber(n);
                    Console.WriteLine($"The closest number to {n} with all even digits is {closest}");

                    int m = -33;
                    int closestM = Reflection.GetClosestEvenNumber(m);
                    Console.WriteLine($"The closest number to {m} with all even digits is {closestM}");
                    break;
                case 17:
                    Bubboble_sort.sort();
                    break;
                case 18:
                    Insertion.sorting();
                    break;
                case 19:
                    var array = new[] { 64, 34, 25, 12, 22, 11, 90 };
                    Console.WriteLine("The Array Before sortded is : ");
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine(array[i]);
                    }
                    var sorted = QuickSort.QuickSortt(array, 0, array.Length - 1);
                    Console.WriteLine("The Array After sortded is : ");
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine(sorted[i]);
                    }
                    Console.WriteLine();
                    break;
                    case 20:
                    Multiplytablewithoutoperator.multiply();
                    break;
                case 21:
                    RajiPatttern.pattern();
                    break;
                case 22:
                    calender.cal();
                    break;
                case 23:
                    SumofElements.operation();
                    break;
                case 24:
                    primeRange.PrimeRange();
                    break;
                case 25:
                    Charger.operation();
                    break;
                default:
                    Console.WriteLine("Enter the above option");
                    break;
            }
            Console.ReadLine(); 
        }
    }

}