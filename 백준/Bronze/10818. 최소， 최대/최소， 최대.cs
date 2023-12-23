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
            List<int> list = new List<int>(Array.ConvertAll(ReadLine().Split(), int.Parse));

            Write($"{list.Min()} {list.Max()}");
        }
    }
}
