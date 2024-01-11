using System;
using static System.Console;
using System.IO;
using System.Linq;

namespace algorithm
{
    class Coordinate
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter(OpenStandardOutput());
            StreamReader reader = new StreamReader(OpenStandardInput());

            int N = int.Parse(reader.ReadLine());

            var inputList = Enumerable.Range(0, N)
                                    .Select(_ =>
                                    {
                                        var values = reader.ReadLine().Split(' ');

                                        return new Coordinate
                                        {
                                            x = int.Parse(values?[0] ?? "0"),
                                            y = int.Parse(values?[1] ?? "0")
                                        };
                                    })
                                    .ToList();

            var sortList = inputList.OrderBy(i => i.x).ThenBy(j => j.y).ToList();

            foreach (var coordinate in sortList)
                writer.WriteLine($"{coordinate.x} {coordinate.y}");

            writer.Close();
            reader.Close();
        }
    }
}