using System;

namespace DataStructures.Src.NodeChain
{
    public class NodeChainExample
    {
        public static void CreateSimpleChain()
        {
            var node1 = new NodeChain<int>(1);
            node1
                .AddValue(2)
                .AddValue(3)
                .AddValue(4)
                .AddValue(5);

            Console.WriteLine("5 nodes were added");
            Console.WriteLine("Total: {0}", node1.Count().ToString());
            node1.PrintChain();

            node1.RemoveLast();
            Console.WriteLine("Last node was removed");
            Console.WriteLine("Total: {0}", node1.Count().ToString());

            node1.PrintChain();
        }

        public static void CreateABigChain()
        {
            var node = new NodeChain<int>(1);

            for (var i = 0; i < 10000; i++)
            {
                node.AddValue(i);
            }

            Console.WriteLine("Created: {0}", node.Count().ToString());

            node.PrintChain();
        }
    }
}