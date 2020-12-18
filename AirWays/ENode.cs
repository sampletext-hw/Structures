namespace AirWays
{
    public class ENode<T>
    {
        public ENode(T value)
        {
            Value = value;
        }

        public ENode<T> Next { get; set; }
        public T Value { get; set; }

        public override string ToString()
        {
            return $"{nameof(Value)}: {Value}";
        }

        public static implicit operator T(ENode<T> eNode)
        {
            return eNode.Value;
        }

        public static implicit operator ENode<T>(T value)
        {
            return new ENode<T>(value);
        }
    }
}