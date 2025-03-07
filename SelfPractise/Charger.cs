using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractise
{
    internal class Charger
    {
        public static void operation()
        { 
            int batteryLevel = 50;
            bool isPluggedIn = true;
            Console.WriteLine("Charging started...");

            while (isPluggedIn && batteryLevel < 100)
            {
                batteryLevel += 10;
                Console.WriteLine($"Battery level: {batteryLevel}%");


                if (batteryLevel >= 100)
                {
                    batteryLevel = 100;
                    Console.WriteLine("Battery fully charged.");
                    isPluggedIn = false;
                }
            }

            if (!isPluggedIn)
            {
                Console.WriteLine("Charger disconnected.");
            }
        }
    }

}

