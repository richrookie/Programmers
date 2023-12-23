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
            int[] enumNum = ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < num[0]; i++)
            {
                if (num[1] > enumNum[i])
                {
                    Write($"{enumNum[i]} ");
                }
            }
        }
    }
}