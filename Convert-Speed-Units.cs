﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_Variables_Excersise
{
    class Convert_Speed_Units
    {
        static void Main(string[] args)
        
        {
            int distMeterts = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float speedInMetersPerSecond = distMeterts / seconds;
        }
    }
}
