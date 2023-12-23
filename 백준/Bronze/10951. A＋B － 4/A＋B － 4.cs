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
                string num = ReadLine();
                if (num == null)
                    break;
                int[] ab = num.Split(' ').Select(int.Parse).ToArray();
                WriteLine(ab[0] + ab[1]);
            }
        }
    }
}