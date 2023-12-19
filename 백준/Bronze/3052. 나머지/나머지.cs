using System;
using System.Linq;
using System.Collections.Generic;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
                arr[i] = int.Parse(Console.ReadLine()) % 42;
            Console.WriteLine(arr.Distinct().Count());
        }
    }
}