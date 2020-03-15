using System;
namespace linkedList
{
    public class LinkedList
    {
        public Node head;
        public LinkedList()
        {
            this.head = null;
        }


        public void createNode(string data)
        // Add new Node at the beggining of the list
        {

            var newNode = new Node(data); // initilize Node instance
            newNode.next = this.head; // point the created node to head
            this.head = newNode; // assign head to new node
        }

        public void printNodes()
        // Print all nodes
        {
            Node current = this.head;
            while (current != null)
            {
                Console.Write(current.data);
                if (current.next != null)
                {
                    Console.Write("->");
                }
                current = current.next;
            }
        }

        public void deleteRepeated()
        {
            var linkedListHelper = new LinkedListHelper();
            linkedListHelper.removeExtraNodes(this.head);
        }
    }
}