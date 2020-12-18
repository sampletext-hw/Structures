namespace AirWays
{
    public class LaunchPad
    {
        public LaunchPad()
        {
            DepartQueue = new EQueue<Plane>();
            AcceptQueue = new EQueue<Plane>();
        }

        private EQueue<Plane> DepartQueue { get; }
        private EQueue<Plane> AcceptQueue { get; }

        public void Depart(Plane plane)
        {
            DepartQueue.Enqueue(plane);
        }

        public void Accept(Plane plane)
        {
            AcceptQueue.Enqueue(plane);
        }

        public override string ToString()
        {
            return "|Pad\n\t\t|DepartQueue:\n" + string.Join("\n", DepartQueue) + "\n" +
                   "\t\t|AcceptQueue:\n" + string.Join("\n", AcceptQueue);
        }
    }
}