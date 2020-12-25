using System;
using System.IO;

namespace AirWays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var random = new Random(DateTime.Now.Millisecond);

            string[] models;
            string[] airportNames;
            int airportsAmount;
            int planesAmount;
            try
            {
                if(args.Length == 0) throw new IndexOutOfRangeException("No File");
                var lines = File.ReadAllLines(args[0]);
                models = lines[0].Split(", ");
                airportNames = lines[1].Split(", ");
                airportsAmount = int.Parse(lines[2]);
                planesAmount = int.Parse(lines[3]);
                Console.WriteLine($"File {Path.GetFileName(args[0])} was read successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"There was an error opening file: {ex.Message}");

                models = new[] { "Boeing", "Cessna", "AeroStar", "Eagle", "Transtar", "CD Project Red", "Kojima Productions" };
                airportNames = new[] { "Beijing Capital", "Los Angeles", "Dubai", "Tokyo", "London" };
                airportsAmount = 5;
                planesAmount = 15;
            }
            
            var airports = new Airport[airportsAmount];
            for (var i = 0; i < airportsAmount; i++) airports[i] = new Airport(airportNames[i], 2);

            for (var i = 0; i < planesAmount; i++)
            {
                var plane = new Plane(models[random.Next(models.Length)], random.Next(100, 1000),
                    random.Next(100, 200));

                var departAirport = random.Next(airports.Length);
                int acceptAirport;
                do
                {
                    acceptAirport = random.Next(airports.Length);
                } while (acceptAirport == departAirport);

                airports[departAirport].GetRandomPad().Depart(plane);
                airports[acceptAirport].GetRandomPad().Accept(plane);
            }

            foreach (var a in airports) Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}