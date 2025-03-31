using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Concepts.LinkedList
{
    public class LL
    {
        public class Node
        {
            public int data;
            public Node next; // Changed to public

            public Node(int _data)
            {
                data = _data;
                next = null;
            }
        }


        private Node head;
        private int size;
        public LL()
        {
            size = 0;
        }

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            size++;
            if (head == null)
            {
                head = newNode;
                return;
            }

            newNode.next = head;
            head = newNode;
        }

        public void AddLast(int data)
        {

            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node curNode = head;

            while (curNode.next != null)
            {
                curNode = curNode.next;
            }

            curNode.next = newNode;
            size++;
        }

        public void PrintNode()
        {
            Node curNode = head;
            while (curNode != null)
            {
                Console.Write(curNode.data + " -> ");
                curNode = curNode.next;
            }
            Console.WriteLine();
        }

        public void RemoveFirst()
        {
            if (head == null)
                Console.WriteLine("No elements is there to be removed");
            head = head.next;
            size--;

        }

        public void RemoveLast()
        {
            if (head == null)
            {
                Console.WriteLine("no elements to be deleted");
            }
            size--;
            if (head.next == null)
            {
                head = null;
                return;
            }

            Node secondLast = head;
            Node last = head.next;

            while (last.next != null)
            {
                last = last.next;
                secondLast = secondLast.next;
            }
            secondLast.next = null;
        }

        public void GetSize()
        {
            Console.WriteLine($"Size {size}");
        }
    }
}

