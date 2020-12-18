namespace AirWays
{
    public class Plane
    {
        public Plane(string model, int number, int capacity)
        {
            Model = model;
            Number = number;
            Capacity = capacity;
        }

        public string Model { get; set; }
        public int Number { get; set; }
        public int Capacity { get; set; }

        public override string ToString()
        {
            return
                $"\t\t\t|Plane {{ {nameof(Model)}: {Model}, {nameof(Number)}: {Number}, {nameof(Capacity)}: {Capacity} }}";
        }
    }
}