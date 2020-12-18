using System;

namespace AirWays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var random = new Random(DateTime.Now.Millisecond);

            string[] models =
                {"Boeing", "Cessna", "AeroStar", "Eagle", "Transtar", "CD Project Red", "Kojima Productions"};
            string[] airportNames = {"Beijing Capital", "Los Angeles", "Dubai", "Tokyo", "London"};

            var airports = new Airport[5];
            for (var i = 0; i < airports.Length; i++) airports[i] = new Airport(airportNames[i], 2);

            for (var i = 0; i < 20; i++)
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
        }
    }
}