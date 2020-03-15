using System;
namespace linkedList
{
    public class LinkedListHelper
    {
        public void removeExtraNodes(Node head)
        {
            //set current to head
            Node current = head;

            // pointer to reference next node
            Node next_next;

            // do nothing if the list is empty 
            int count = 1;
            // Traverse list till the last node 
            while (current.next != null && head != null &&current != null)
            {

                //Compare current node with the next node and keep track of matching nodes
                if (current.data == current.next.data)
                {
                    count += 1;
                }
                //Remove the node if the count is great than 2
                if (current.data == current.next.data && count > 2)
                {
                    next_next = current.next.next;
                    current.next = null;
                    current.next = next_next;
                }
                else // advance if no deletion 
                    current = current.next;
            }
        }
    }
}
