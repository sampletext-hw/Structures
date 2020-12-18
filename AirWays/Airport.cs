using System;
using System.Collections.Generic;

namespace AirWays
{
    public class Airport
    {
        private static readonly Random random = new Random(DateTime.Now.Millisecond);

        public Airport(string name, int padsCount)
        {
            Pads = new List<LaunchPad>();
            Name = name;
            PadsCount = padsCount;
            for (var i = 0; i < PadsCount; i++) Pads.Add(new LaunchPad());
        }

        public List<LaunchPad> Pads { get; }
        public int PadsCount { get; set; }
        public string Name { get; set; }

        public LaunchPad GetRandomPad()
        {
            return Pads[random.Next(PadsCount)];
        }

        public override string ToString()
        {
            return $"|Airport: {Name}, with {PadsCount} Pads:\n\t{string.Join("\n\t", Pads)}";
        }
    }
}