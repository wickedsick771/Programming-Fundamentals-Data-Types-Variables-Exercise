using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_Variables_Excersise
{
    class Comparing_Floatscs
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            double maxNum = Math.Max(num1, num2);
            double minNum = Math.Min(num1, num2);
            double sumNum = maxNum - minNum;
            bool check = false;
            if (sumNum > eps)
            {
                Console.WriteLine(check);
            }
            else
            {
                check = true;
                Console.WriteLine(check);
            }
        }
    }
}
