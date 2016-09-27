using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_Variables_Excersise
{
    class VariableInHexFormat
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(num1, 16));


        }
    }
}
