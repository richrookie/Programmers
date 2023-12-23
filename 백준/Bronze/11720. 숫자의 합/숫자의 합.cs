using System;
using static System.Console;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLength = int.Parse(ReadLine());
            string input = ReadLine();
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
                sum += int.Parse(input[i].ToString());

            WriteLine(sum);
        }
    }
}