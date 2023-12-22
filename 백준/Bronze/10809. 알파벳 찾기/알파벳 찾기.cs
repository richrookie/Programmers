using System;
using static System.Console;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = ReadLine();

            for (int i = 97; i < 123; i++)
            {
                char alphabet = Convert.ToChar(i);

                if (word.Contains(alphabet))
                {
                    Write(word.IndexOf(alphabet));
                    Write(" ");
                }
                else
                {
                    Write("-1 ");
                }
            }
        }
    }
}
