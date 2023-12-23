using System;
using System.Linq;
using System.Collections.Generic;
using static System.Console;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            List<int> list = new List<int>();
            int[] num = ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < N; i++)
                list.Add(num[i]);

            Write($"{list.Min()} {list.Max()}");
        }
    }
}
