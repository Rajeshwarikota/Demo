using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractise
{
    class chapter
    {
        public static void page()
        {
            // Read input
         
            int N = int.Parse(Console.ReadLine());
            int[] starts = new int[N];
            int[] ends = new int[N];

            for (int i = 0; i < N; i++)
            {
                string[] line = Console.ReadLine().Split();
                starts[i] = int.Parse(line[0]);
                ends[i] = int.Parse(line[1]);
            }
            int K = int.Parse(Console.ReadLine());

            // Find the current chapter
            int j;
            for (j = 0; j < N; j++)
            {
                if (K >= starts[j] && K <= ends[j])
                    break;
            }

            // Count the remaining chapters
            int remainingChapters = N - j;

            Console.WriteLine(remainingChapters);



        }
    }


    
}

    




   
