using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DailyAssgn4
{
    public class Counter
    {
        public static int count = 0;
        public static void CountFunction()
        {
            count++;
        }
        public static void Display()
        {
            Console.WriteLine($"Function is called {count} times");
        }

    }   
}
