using System;
using System.Linq;
using static System.Console;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(ReadLine());

            for (int i = 0; i < num; i++)
            {
                int[] ab = ReadLine().Split(' ').Select(int.Parse).ToArray();
                WriteLine(ab[0] + ab[1]);
            }
        }
    }
}