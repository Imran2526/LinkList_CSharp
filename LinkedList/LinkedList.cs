﻿using System;
using System.Collections.Generic;
using System.Text;
namespace LinkedList
{
    public class LinkedLists
    {
        internal Node head;
        internal Node1 head1;

        /// <summary>
        /// U2-U3 Ability to Create Linkedlist.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Inserted Element in list ", node.data);
        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.Write("LinkedList is Emplty...");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            }
            Console.Write("\n");
        }

        /// <summary>
        /// Inserts the positon.
        /// </summary>U8-Insert 40 between 30 70 result like 30-->40-->70...
        /// <param name="Position">The position.</param>
        /// <param name="data">The data.</param>
        public void InsertPositon(int Position, int data)
        {
            if (Position < 1)
            {
                Console.WriteLine("...Inalid...");
            }
            if (Position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (Position-- != 0)
                {
                    if (Position == 1)
                    {
                        Node node = new Node(data);
                        node.next = temp.next;
                        temp.next = node;
                        break;
                    }
                    temp = temp.next;
                }
                if (Position != 1)
                    Console.WriteLine("Positon is not valid...");
            }
        }

        /// <summary>
        /// Remove the First Element.
        /// </summary>U5-Remove First Element ...
        /// <param name="Position">The position.</param>
        /// <param name="data">The data.</param>
        internal void RemoveFirstElement()
        {
            if (this.head == null)
            {
                Console.WriteLine("Linklist Empty");
            }
            head = head.next;
        }

        /// <summary>
        /// Remove the Last Element.
        /// </summary>U6-Remove Last Element ...
        /// <param name="Position">The position.</param>
        /// <param name="data">The data.</param>
        internal void RemoveLastElement()
        {
            if (head.next == null)
            {
                Console.WriteLine("Empty");
            }
            Node SecondNode = head;
            while (SecondNode.next.next != null)
                SecondNode = SecondNode.next;
            SecondNode.next = null;
        }

        /// <summary>
        ///U7 Finds the elemnt.
        /// </summary>
        /// <param name="Pointer">The pointer.</param>
        /// <returns></returns>
        public Node FindElemnt(int Number)
        {
            while (this.head != null)
            {
                if (this.head.data == Number)
                {
                    return this.head;
                }
                this.head = this.head.next;
                Console.WriteLine("Element {0} Found in list...", this.head.data);
            }
            return null;
        }

        /// <summary>
        ///U9 Delete the node And Return Size of list.
        /// </summary>
        /// <param name="Value">The value.</param>
        public void DeleteNode(int Value)
        {
            Node temp = head, prev = null;
            if (temp != null && temp.data == Value)
            {
                head = temp.next;
                return;
            }
            while (temp != null && temp.data != Value)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
                return;
            prev.next = temp.next;
        }

        public int Count()
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }

        /// <summary>
        /// Sort List And Display  the list Element.
        /// </summary>
        /// <param name="data">The data.</param>
        public void SortedList(int data)
        {
            Node1 newNode = new Node1(data);
            Node1 Current;
            if (head1 == null || head1.data >= newNode.data)
            {
                newNode.next = head1;
                head1 = newNode;
            }
            else
            {
                Current = head1;
                while (Current.next != null && Current.next.data < newNode.data)
                    Current = Current.next;

                newNode.next = Current.next;
                Current.next = newNode;
            }
        }

        internal void Display1()
        {
            Node1 temp = head1;
            if (temp == null)
            {
                Console.Write("LinkedList is Emplty...");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            }
            Console.Write("\n");
        }
    }
}