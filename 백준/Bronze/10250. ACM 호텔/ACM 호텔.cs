using System;
using System.Linq;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int x = 0;
            int y = 0;
            int[] hwn;

            for (; T > 0; T--)
            {
                hwn = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                y = hwn[2] % hwn[0];
                x = hwn[2] / hwn[0];

                if (y == 0)
                    y = hwn[0];
                else
                    x += 1;

                Console.WriteLine(y * 100 + x);
            }
        }
    }
}
