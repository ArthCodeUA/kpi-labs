using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace lab_7
{
    public class ShortList : IEnumerable<short>
    {

        private Node _head;
        private int _count;

        public ShortList()
        {
            _head = null;
            _count = 0;
        }

        public void Add(short data)
        {
            Node node = new Node(data);
            node.Next = _head;
            _head = node;
            _count++;
        }

        public bool Remove(short data)
        {
            Node current = _head;
            Node previous = null;
            if (Contains(data))
            {
                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        if (previous != null)
                        {
                            previous.Next = current.Next;
                        }
                        else
                        {
                            _head = _head.Next;
                        }

                        _count--;
                        return true;
                    }

                    previous = current;
                    current = current.Next;
                }
            }

            return false;
        }

        public bool Contains(short data)
        {
            return this.Any(value => value == data);
        }

        public double Average()
        {
            double average = 0;
            foreach (short data in this)
            {
                average += data;
            }

            return average / Count;
        }

        public int MultiplesOfThree()
        {
            int mot = 0;
            foreach (short data in this)
            {
                if (data % 3 == 0) mot++;
            }

            return mot;
        }

        public bool RemoveAboveAverage()
        {
            double average = Average();
            int removed = 0;
            foreach (short data in this)
            {
                if (data > average)
                {
                    Remove(data);
                    removed++;
                }
            }

            return Convert.ToBoolean(removed);
        }

        public int Count => _count;

        public void Display()
        {
            int i = 0;
            foreach (short data in this)
            {
                Console.Write(data + (i != Count - 1 ? " -> " : ""));
                i++;
            }

            Console.WriteLine();
        }

        public IEnumerator<short> GetEnumerator()
        {
            Node current = _head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}