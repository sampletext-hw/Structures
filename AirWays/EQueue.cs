using System;
using System.Collections;
using System.Collections.Generic;

namespace AirWays
{
    public class EQueue<T> : IEnumerable<T>
    {
        public ENode<T> Head { get; private set; }
        public int Size { get; private set; }

        private ENode<T> Last { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enqueue(T val)
        {
            if (Size == 0)
            {
                Head = val;
                Last = Head;
            }
            else
            {
                Last.Next = val;
                Last = Last.Next;
            }

            Size++;
        }

        public T Dequeue()
        {
            if (Size == 0) throw new IndexOutOfRangeException("Size = 0");

            T val = Head;
            Head = Head.Next;
            Size--;
            return val;
        }
    }
}