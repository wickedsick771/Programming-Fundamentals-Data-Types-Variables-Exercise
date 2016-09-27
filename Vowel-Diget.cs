using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_Variables_Excersise
{
    class Vowel_Diget
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            if (word == "a" || word == "e" || word == "i" || word == "o" || word == "u")
            {
                Console.WriteLine("vowel");
            }
            else if (word == "1" || word == "2" || word == "3" || word == "4" || word == "5" || word == "6" || word == "7" || word == "8" || word == "9"|| word == "0")
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
