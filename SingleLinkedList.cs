using System;

namespace SingleLinkedListProject
{
    class SingleLinkedList
    {
        private Node start;

        public SingleLinkedList()
        {
            start = null;
        }

        public void DisplayList()
        {
            Node p;
            if(start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Console.Write("List is : ");
            p = start;
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
        }

        public void CountNodes()
        {
            int n = 0;
            Node p = start;
            while (p != null)
            {
                n++;
                p = p.link;
            }
            Console.WriteLine("Number of nodes in the list = " + n);
        }

        public bool Search(int x)
        {
            int position = 1;
            Node p = start;
            while(p != null)
            {
                if(p.info == x)
                    break;
                position++;
                p = p.link;
            }

            if(p == null)
            {
                Console.WriteLine(x + " not found in list");
            }

            else
            {
                Console.WriteLine(x + " is at position " + position);
                return true;
            }
        }
    }
}
