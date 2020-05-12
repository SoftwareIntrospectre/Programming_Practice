
    class Program
    {
        public static void Main(String[] args)
        {
            SinglyLinkedList singlyLL = new SinglyLinkedList();
            
            singlyLL.appendTail(199);
            singlyLL.appendTail(188);
            singlyLL.appendTail(21);

            singlyLL.printList();
        }
    }

    //wrapping nodes with this
    class SinglyLinkedList
    {
        public Node head;

        public Node tail;
        
        public class Node
        {
            public int data;

            public Node next;

            public Node(int d)
            {
              //initializing node with user input
                data = d;
               
              //sets new node as null, because end of Linked List
                next = null;
            }
        }

        
        public void appendTail(int newData)
        {
            Node newNode = new Node(newData);

            //if head does not exist, create it
            if(head == null)
            {
            
            //if only 1 node: head and tail are the same node.
                head = newNode;
                tail = newNode;
                
                //exit after creating head, because everything else relies on head existing
                return;
            }
            
              //change tail's null pointer to the new node
                tail.next = newNode;
                
                //changing tail of list to the new last node
                tail = newNode;
                return;
        }

        public void printList()
        {
            if(head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            //initialize "current" at start of Linked List
            Node currentNode = head;
            
            //only last node will have a null pointer
            while(currentNode != null)
            {
                Console.WriteLine(currentNode.data);
                
                //iterates to next node in list
                currentNode = currentNode.next;
            }
        }
    }
