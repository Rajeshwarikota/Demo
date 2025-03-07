using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractise
{
    class StringReverse
    {
        public static void Reversing()
        {
            string original = "RaSree";
            char[] charArray = original.ToCharArray();
            Array.Reverse(charArray);
            string reverse = new string(charArray);
            Console.WriteLine(reverse);


            string str = "Rajeshwari kota";
            string stringUpper = str.ToUpper();
            Console.WriteLine(stringUpper);

            string s = "Rajeshwari kota";
            string stringlower = s.ToLower();
            Console.WriteLine(stringlower);

            string str1 = "My name is Raji";
            Console.WriteLine("Length of the string is" + str1.Length);
            string str2 = "";
            Console.WriteLine("Length of the string is" + str2.Length);

            //string name = "SaiPallavi";
            //string result = " ";
            //foreach(char c in name)
            //{
            //    if(char.IsUpper(c))
            //    {
            //        result += char.ToLower(c);
            //    }
            //    else
            //    {
            //        result += char.ToUpper(c);
            //    }
            //}
            //Console.WriteLine(result);

            
                // Input string
                string name = "saipallavi";
                Console.WriteLine("BEFORE : " + name);

            // Convert the input string to the desired format
            string result = ConvertString(name);

                // Output the result
                Console.WriteLine("AFTER :" + result);
            }

            static string ConvertString(string name)
            {
                string result = "";

                // Convert the first character to lowercase
                result += char.ToLower(name[0]);

                // Loop through the remaining characters
                for (int i = 1; i < name.Length; i++)
                {
                    // Check if the current character is uppercase
                    if (char.IsUpper(name[i]))
                    {
                        // Insert a space before the uppercase letter
                        result += " ";
                    }
                    // Convert the current character to uppercase and append to result
                    result += char.ToUpper(name[i]);
                }

                return result;
            }
        }

    }
