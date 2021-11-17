using System;

namespace ArrayOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            var n=number.NumberOfLoops();
            Console.WriteLine($"Number of loops {n}");

        }
    }
}
