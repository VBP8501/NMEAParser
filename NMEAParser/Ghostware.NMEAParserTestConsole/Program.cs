﻿using System;
using Ghostware.NMEAParser;

namespace Ghostware.NMEAParserTestConsole
{
    internal class Program
    {
        private const string GgaMessage1 = "$GPGGA,071258,5053.0303,N,00423.7356,E,1,03,2.3,,M,47.2,M,,*67";

        static void Main(string[] args)
        {
            var parser = new NmeaParser();

            Console.WriteLine($"Parsing GPGGA message: {GgaMessage1}");
            var result = parser.Parse(GgaMessage1);
            Console.WriteLine($"Result: {result}");

            Console.WriteLine("Press enter to continue...");
            Console.ReadKey();
        }
    }
}