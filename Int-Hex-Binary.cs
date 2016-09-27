using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Data_Types_Variables_Excersise
{
    class Int_Hex_Binary
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string hex = Convert.ToString(num, 16);
            string binary = Convert.ToString(num, 2);
            
            Console.WriteLine(hex.ToUpper());
            Console.WriteLine(binary);
        }
    }
}
