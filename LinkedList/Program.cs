using System;

namespace linkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList();
            linkedList.createNode("B");
            linkedList.createNode("B");
            linkedList.createNode("B");
            linkedList.createNode("A");
            linkedList.createNode("A");
            linkedList.createNode("A");
            linkedList.createNode("B");
            linkedList.createNode("E");
            linkedList.createNode("E");
            Console.WriteLine("<<<<<<<<<< input items >>>>>>>>>");
            linkedList.printNodes();
            linkedList.deleteRepeated();
            Console.WriteLine();
            Console.WriteLine("<<<<<<<<<<< After creating the linked list and renoving multiple >>>>>>>>>");
            linkedList.printNodes();
        }
    }
}
