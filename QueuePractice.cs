using System;
using System.Collections.Generic;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> sure = new MyQueue<int>();
            sure.Enqueue(1);
            sure.Enqueue(2);
            sure.Peek();
            sure.Enqueue(7);
            sure.Peek();
            sure.Dequeue();
            sure.Peek();
            sure.Dequeue();
            sure.Peek();
            sure.Enqueue(19);
            sure.Peek();
            sure.Dequeue();
            sure.Peek();
        }
    }

    public class MyQueue<T>
    {
        private class Node
        {
            public Node(T value, Node next)
            {
                Value = value;
                Next = next;
            }
            public T Value {get;}

            public Node Next;
        }

        private Node m_Head;
        private Node m_Tail;

        public void Enqueue(T item)
        {
            Node node = new Node(item, null);

            //if there's no one in line,
            if(m_Tail == null)
            {
                //add one item to the Queue, where it's the beginning and end at the same time (only 1 item)
                m_Head = node;
                m_Tail = node;
            }

            else
            {
                //sets the next item in the list to be the one Enqueued
                m_Tail.Next = node;

                //flags the tail as the new item Enqueued
                m_Tail = node;
            }
        }

        public bool TryPeek(out T item) //in cases where we don't want to throw an exception for an empty Queue
        {
            if(m_Head == null)
            {
                //if there's nothing at the front of the list, then the item doesn't exist.
                item = default(T); // sets it to Null for generics, false for bools, classes = null, etc. 

                return false;
            }

            //set the item's value to the head's value
            item = m_Head.Value;

            return true;
        }

        public T Peek()
        {
            if(m_Head == null)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            Console.WriteLine("Front of the Queue is: " + m_Head.Value);
            return m_Head.Value;
        }

        public bool TryDequeue(out T item) //in cases where we don't want to throw an exception for an empty Queue
        {
            if (m_Head == null)
            {
                item = default(T);
                return false;
            }

            item = m_Head.Value; //item's value assigned the head's value
            m_Head = m_Head.Next; //head's value is set to the next node's value

            return true;
        }
         public T Dequeue()
        {
            if(m_Head == null)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

                T item = m_Head.Value;
                m_Head = m_Head.Next;

                return item;
        }
    }
}
