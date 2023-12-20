using System;
using static System.Console;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(ReadLine());
            string result = "";

            if (score >= 90 && score <= 100)
                Write("A");
            else if (score >= 80 && score < 90)
                Write("B");
            else if (score >= 70 && score < 80)
                Write("C");
            else if (score >= 60 && score < 70)
                Write("D");
            else
                Write("F");
        }
    }
}