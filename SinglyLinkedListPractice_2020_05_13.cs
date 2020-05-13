using System;

namespace LinkedListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = new Node(7);
            Node nodeB = new Node(12);
            Node nodeC = new Node(8);
            Node nodeD = new Node(64);
            Node nodeE = new Node(17);

            head.next = nodeB;
            nodeB.next = nodeC;
            nodeC.next = nodeD;
            nodeD.next = nodeE;

            Console.WriteLine("Head is: " + head.data);
            Console.WriteLine("Head.next is: " + nodeB.data);
            Console.WriteLine("Head.next.next is: " + nodeD.data);
            Console.WriteLine("Head.next.next.next is: " + nodeE.data);
            countNodes(head);
        }

        //Given the head node: write a function that takes the head variable and returns the number of nodes in the whole Linked List.
        static int countNodes(Node head)
        {

            if(head == null)
            {
                Console.WriteLine("There's no head. There are 0 nodes.");
                return 0;
            }
            int nodeCount = 1; //counting the head in the list

            Node currentNode = head;

            while(currentNode.next != null)
            {
                nodeCount++; //increment by 1 every time a new node is reached. Increments when reaching final node with null reference.
                currentNode = currentNode.next; //iterate to next node
            }

            Console.WriteLine("Node count is: " + nodeCount);
            return nodeCount;
        }
    }

    public class Node
    {
        public int data;

        public Node next;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }        
    }
}
