using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyAssgn5_1
{
    public class TimePeriod
    {
        
        
            public double seconds = 7200;

            public double Hours
            {
                get { return seconds / 3600; }

            }

            public void DisplayTime()
            {
                Console.WriteLine($"Time in Hours: {Hours}");
            }
        
    }
}
