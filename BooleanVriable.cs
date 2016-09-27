using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_Variables_Excersise
{
    class BooleanVriable
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            Convert.ToBoolean(num1);

            if (num1 == "True") { 
            Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");

            }


        }
    }
}
