using System;
using System.Linq;
using static System.Console;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = ReadLine().Split(' ').Select(int.Parse).ToArray();

            WriteLine(num[0] + num[1]);
            WriteLine(num[0] - num[1]);
            WriteLine(num[0] * num[1]);
            WriteLine(num[0] / num[1]);
            WriteLine(num[0] % num[1]);
        }
    }
}