using System;
using static System.Console;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(ReadLine());
            int output = 1;
            int count = 1;

            while (input > output)
            {
                output += 6 * (count - 1);
                count += 1;
            }

            if (input == 1)
                WriteLine(count);
            else
                WriteLine(count - 1);
        }
    }
}