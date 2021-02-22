using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            square square = new square(6);

            Console.WriteLine($"Omkreds: {square.omkreds()}");
            Console.WriteLine($"Areal: {square.areal()}");

            square.Side = 4;

            Console.WriteLine($"Omkreds: {square.omkreds()}");
            Console.WriteLine($"Areal: {square.areal()}");

            square.Side = 12;

            Console.WriteLine($"Omkreds: {square.omkreds()}");
            Console.WriteLine($"Areal: {square.areal()}");

            Console.ReadKey();

        }
    }
}
