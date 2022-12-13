using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data_Structure
{
    class DoubleLinkedList
    {
        public Node head;

        //constructor to create an empty LinkedList
        public DoubleLinkedList()
        {
            head = null;
        }

        //Display List
        public void PrintList()
        {
            Node temp = new Node();
            temp = this.head;
            if (temp != null)
            {
                Console.Write("The list contains: ");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The list is empty.");
            }
        }

        //Add new element at the end of the list
        public void push(int newElement)
        {
            Node newNode = new Node();
            newNode.data = newElement;
            newNode.next = null;
            newNode.prev = null;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = new Node();
                temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                    
                temp.next = newNode;
                newNode.prev = temp;
            }
        }

        //Delete an element at the given position
        public void pop_at(int position)
        {
            if (position < 1)
            {
                Console.Write("\nposition should be >= 1.");
            }
            else if (position == 1 && head != null)
            {
                Node nodeToDelete = head;
                head = head.next;
                nodeToDelete = null;
                if (head != null)
                    head.prev = null;
            }
            else
            {
                Node temp = new Node();
                temp = head;
                for (int i = 1; i < position - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.next;
                    }
                }
                if (temp != null && temp.next != null)
                {
                    Node nodeToDelete = temp.next;
                    temp.next = temp.next.next;
                    if (temp.next.next != null)
                        temp.next.next.prev = temp.next;
                    nodeToDelete = null;
                }
                else
                {
                    Console.Write("\nThe node is already null.");
                }
            }
        }

        //Search an element in the list
        public void SearchElement(int searchValue)
        {
            Node temp = new Node();
            temp = this.head;
            int found = 0;
            int i = 0;

            if (temp != null)
            {
                while (temp != null)
                {
                    i++;
                    if (temp.data == searchValue)
                    {
                        found++;
                        break;
                    }
                    temp = temp.next;
                }
                if (found == 1)
                {
                    Console.WriteLine(searchValue + " is found at index = " + i + ".");
                }
                else
                {
                    Console.WriteLine(searchValue + " is not found in the list.");
                }
            }
            else
            {
                Console.WriteLine("The list is empty.");
            }
        }

    }

}
