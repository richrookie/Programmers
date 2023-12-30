using System;
using static System.Console;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = ReadLine();
            int inputNum = int.Parse(input);
            int result = 0;

            for (int i = inputNum; i > 0; i--)
            {
                int temp = inputNum - i;
                char[] charArray = (temp).ToString().ToCharArray();

                for (int j = 0; j < charArray.Length; j++)
                    temp += int.Parse(charArray[j].ToString());

                if (inputNum == temp)
                {
                    result = inputNum - i;
                    break;
                }
            }

            WriteLine(result);
        }
    }
}