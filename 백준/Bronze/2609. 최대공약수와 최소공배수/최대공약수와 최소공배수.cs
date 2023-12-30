using System;
using static System.Console;
using System.Linq;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int Max = 0;
            int Min = 0;

            int[] num = ReadLine().Split(' ').Select(int.Parse).ToArray();

            Max = Gcd(num[0], num[1]);
            Min = (num[0] * num[1]) / Max;

            WriteLine(Max);
            WriteLine(Min);
        }

        static int Gcd(int a, int b)
        {
            int temp = 0;

            while (b != 0)
            {
                temp = a % b;
                a = b;
                b = temp;
            }

            return a;
        }
    }
}