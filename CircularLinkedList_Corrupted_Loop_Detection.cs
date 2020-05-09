using System;

namespace LoopDetection
{  
    /*
            Given a Circular Linked List, implement an algorithm that returns the node at the beginning of the loop

            DEFINITION: Circular Linked List: A (corrupt) Linked List in which a node's next pointer points to an earlier node, 
            so as to make a loop in the linked list

            EXAMPLE: 
                Input: A --> B --> C --> D --> E --> C [the same C as earlier]

                Output: C
    */
    class Program
    {
        static void Main()
        {
            Node nodeA = new Node(12);
            Node nodeB = new Node(199);
            Node nodeC = new Node(73);
            Node nodeD = new Node(1337);
            Node nodeE = new Node(8);
            Node nodeF = new Node(6);

            nodeA.next = nodeB;
            nodeB.next = nodeC;
                nodeC.next = nodeA; // corrupted loop begins
            nodeD.next = nodeE; // outside of corrupted loop
            nodeE.next = nodeF; // outside of corrupted loop

            Console.WriteLine("Linked List: " + nodeA.data + ", " + nodeA.next.data + ", " + nodeA.next.next.data + ", " + nodeA.next.next.next.data + ", " + nodeA.next.next.next.next.data + ", " + nodeA.next.next.next.next.next.data + ", " + nodeA.next.next.next.next.next.next.data);
            detectCorruptedLoop(nodeA, nodeA.next.next);
        }

        static void detectCorruptedLoop(Node head, Node loopStart)
        {
            if(head == loopStart.next && loopStart.next != null)
            {
                Console.WriteLine("Beginning of loop is: " + loopStart.data);
            }

            else if (loopStart.next == null)
            {
                Console.WriteLine("No loop. Next node is Null.");
            }

            else
            {
                Console.WriteLine("Probably fine. :) ");
            }
        }
    }

    public class Node
    {
        public int data;

        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
}
