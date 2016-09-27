using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_Variables_Excersise
{
    class Fast_Prime_Checker
    {
        static void Main(string[] args)
        {
            int number= int.Parse(Console.ReadLine());
for (int i = 2; i <= number; i++)
{
    bool checker = true;
    for (int divider = 2; divider <= Math.Sqrt(i); divider++)
    {
        if (i % divider == 0)
        {
            checker = false;
            break;
        }
    }
    Console.WriteLine("{0} -> {1}", i, checker);
}

        }
    }
}
