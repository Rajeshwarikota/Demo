using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractise
{
    internal class RajiPatttern
    {
        public static void pattern()
        {
            
                // Print the name patterns horizontally
                PrintNamePattern("Raji");
                Console.WriteLine(); // Add a blank line between the patterns
                PrintNamePattern("Chandu");
            }

            static void PrintNamePattern(string name)
            {
                // Print each row of the pattern horizontally for each letter
                for (int i = 0; i < 5; i++)
                {
                    foreach (char letter in name)
                    {
                        string[] pattern = GetPattern(letter);
                        Console.Write(pattern[i] + "  "); // Add spacing between letters
                    }
                    Console.WriteLine(); // Move to the next row
                }
            }

            static string[] GetPattern(char letter)
            {
                switch (char.ToUpper(letter))
                {
                    case 'R':
                        return new string[] {
                    "*****",
                    "*    *",
                    "*****",
                    "*   *",
                    "*    *"
                };
                    case 'A':
                        return new string[] {
                    "  *  ",
                    " * * ",
                    "*****",
                    "*   *",
                    "*   *"
                };
                    case 'J':
                        return new string[] {
                    "******",
                    "     *",
                    "     *",
                    "     *",
                    "***** "
                };
                    case 'I':
                        return new string[] {
                    "*****",
                    "  *  ",
                    "  *  ",
                    "  *  ",
                    "*****"
                };
                    case 'C':
                        return new string[] {
                    "*****",
                    "*    ",
                    "*    ",
                    "*    ",
                    "*****"
                };
                    case 'H':
                        return new string[] {
                    "*   *",
                    "*   *",
                    "*****",
                    "*   *",
                    "*   *"
                };
                    case 'N':
                        return new string[] {
                    "*   *",
                    "**  *",
                    "* * *",
                    "*  **",
                    "*   *"
                };
                    case 'D':
                        return new string[] {
                    "**** ",
                    "*   *",
                    "*   *",
                    "*   *",
                    "**** "
                };
                    case 'U':
                        return new string[] {
                    "*   *",
                    "*   *",
                    "*   *",
                    "*   *",
                    "*****"
                };
                    default:
                        return new string[] { "Unknown letter" };
                }
            }
        }
    }

