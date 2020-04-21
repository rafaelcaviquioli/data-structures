using System;
using System.Collections.Generic;

namespace DataStructures.Src.NodeChain
{
    public class NodeChain<T>
    {
        public T Value { get; private set; }
        public NodeChain<T> Next { get; set; }

        public NodeChain(T value)
        {
            Value = value;
        }

        public void PrintChain()
        {
            foreach (var node in GetEnumerable())
            {
                Console.WriteLine(node.Value.ToString());
            }
        }

        public NodeChain<T> AddValue(T value)
        {
            if (Next == null)
                return Next = new NodeChain<T>(value);

            return Next.AddValue(value);
        }

        public void RemoveLast()
        {
            RemoveLast(this);
        }
        public void RemoveLast(NodeChain<T> node)
        {
            if (Next.Next == null)
            {
                Next = null;
            }
            else
            {
                Next.RemoveLast(Next);
            }
        }

        public IEnumerable<NodeChain<T>> GetEnumerable()
        {
            var current = this;
            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        public List<NodeChain<T>> ToList()
        {
            var list = new List<NodeChain<T>>();
            var current = this;

            while (current != null)
            {
                list.Add(current);
                current = current.Next;
            }

            return list;
        }

        public int Count()
        {
            var count = 0;
            var current = this;

            while (current != null)
            {
                count++;
                current = current.Next;
            }

            return count;
        }
    }
}