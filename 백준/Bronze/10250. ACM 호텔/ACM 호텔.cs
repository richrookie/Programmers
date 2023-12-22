using System;
using System.Linq;
using static System.Console;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(ReadLine());

            // H 층 수, W 층의 방 수, N 몇 번째 손님
            for (int i = 0; i < T; i++)
            {
                int[] input = ReadLine().Split(' ').Select(int.Parse).ToArray();
                int result = 0;
                bool flag = false;

                for (int j = 1; j <= input[1]; j++)
                {// W
                    for (int k = 1; k <= input[0]; k++)
                    {// H
                        if (input[2] - 1 <= 0)
                        {
                            flag = true;
                            result = int.Parse($"{k}{j.ToString("D2")}");
                            break;
                        }
                        else
                        {
                            input[2] -= 1;
                        }
                    }

                    if (flag == true)
                        break;
                }

                WriteLine(result);
            }
        }
    }
}
