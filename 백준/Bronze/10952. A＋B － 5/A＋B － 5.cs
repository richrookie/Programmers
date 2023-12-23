using System;
using System.Linq;
using static System.Console;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int[] ab = ReadLine().Split(' ').Select(int.Parse).ToArray();

                if (ab[0] == 0 && ab[1] == 0)
                    break;

                WriteLine(ab[0] + ab[1]);
            }
        }
    }
}