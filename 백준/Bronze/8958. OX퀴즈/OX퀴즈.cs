using System;
using static System.Console;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            // int inputCount = int.Parse(ReadLine());
            // int[] score = new int[inputCount];

            // for (int i = 0; i < inputCount; i++)
            // {
            //     string input = ReadLine();
            //     bool isSequence = false;
            //     int sequence = 0;

            //     for (int j = 0; j < input.Length; j++)
            //     {
            //         if (input[j] == 'O')
            //         {
            //             if (isSequence == true)
            //             {
            //                 sequence += 1;

            //                 for (int k = 0; k <= sequence; k++)
            //                     score[i] += 1;
            //             }
            //             else
            //             {
            //                 isSequence = true;
            //                 score[i] += 1;
            //                 sequence = 0;
            //             }
            //         }
            //         else
            //         {
            //             isSequence = false;
            //         }
            //     }
            // }

            // for (int i = 0; i < inputCount; i++)
            //     WriteLine(score[i]);

            var n = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < n; i++)
            {
                var str = Console.ReadLine()!;

                int score = 0, total = 0;
                foreach (var c in str)
                {
                    if (c == 'O')
                    {
                        score++;
                        total += score;
                    }
                    else score = 0;
                }

                Console.WriteLine(total);
            }
        }
    }
}