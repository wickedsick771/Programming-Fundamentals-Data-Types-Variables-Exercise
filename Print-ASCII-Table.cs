using System;


class PrintsASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int char1 = int.Parse(Console.ReadLine());
        int char2 = int.Parse(Console.ReadLine());

        for (char i = (char)char1; i <= (char)char2; i++)
        {
            Console.Write(" " + i);
        }

    }
}