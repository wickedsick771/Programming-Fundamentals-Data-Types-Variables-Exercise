using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_Variables_Excersise
{
    class CenturiesToNanoseconds
    {
                 static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = 24 * days;
            int minutes = 60 * hours;
            ulong  seconds = (ulong)minutes * 60;
            ulong milliseconds = seconds * 1000;
            ulong microsecond = milliseconds * 1000;
             decimal nanosecond = microsecond * 1000m;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
                centuries, years, days, hours, minutes,seconds,milliseconds,microsecond,nanosecond);


        }
    }
}
