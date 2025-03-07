using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractise
{
    internal class ConverionLetters
    {
        public static void Conversion()
        {
            int i;
            string original = "HappyBirthday";
            string converted = "";
            for (i = 0; i < original.Length; i++)
            {
                if (char.IsUpper(original[i]))
                {
                    converted += char.ToLower(original[i]);
                }
                else
                {
                    converted += char.ToUpper(original[i]);
                }
            }
                Console.WriteLine(converted);
        }
    }
}
