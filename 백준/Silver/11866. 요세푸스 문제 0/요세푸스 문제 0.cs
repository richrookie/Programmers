using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            StringBuilder sb = new StringBuilder();

            string[] input = ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);

            for (int i = 1; i <= N; i++)
                queue.Enqueue(i);

            int cnt = 0;

            sb.Append("<");
            while (queue.Count > 0)
            {
                cnt++;

                int num = queue.Dequeue();

                if (cnt == K)
                {
                    sb.Append($"{num}");
                    if (queue.Count > 0)
                        sb.Append(", ");
                    cnt = 0;
                }
                else
                {
                    queue.Enqueue(num);
                }
            }
            sb.Append(">");

            WriteLine(sb.ToString());
        }
    }
}