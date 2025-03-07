using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractise
{
    internal class LamdaExpression
    {
        delegate int myDelegate(int x, int y);
        public static void Lamba()
        {
            myDelegate mul = (x, y) => x * y;
            int result = mul(12,10);
            Console.WriteLine(result);
        }
    }
}
