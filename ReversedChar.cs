using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_Variables_Excersise
{
    class ReversedChar
    {
         static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{2}",letter2,letter1,letter);
        }
    }
}
