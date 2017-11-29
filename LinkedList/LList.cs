using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LList
    {
        private Node head;
        private Node tail;
        public LList()
        {
            this.head = new Node();
            this.tail = this.head;
        }
        public void Add(int val)
        {
            this.tail.next = new Node { value = val, next = null, Previous = this.tail };
            this.tail = this.tail.next;
        }

        public int Retrieve(int position)
        {
            int count = 0;
            Node currentNode = this.head.next;
            while (count != position)
            {
                if (currentNode.next == null)
                    throw new IndexOutOfRangeException();
                currentNode = currentNode.next;
                count++;
            }
            return currentNode.value;
        }
        public void Delete(int position)
        {
            int count = 0;
            Node currentNode = this.head.next;
            while (count != position)
            {
                if (currentNode.next == null)
                    throw new IndexOutOfRangeException();
                currentNode = currentNode.next;
                count++;
            }
            if (currentNode.next != null)
                currentNode.Previous.next = currentNode.next;
            else
                currentNode.Previous.next = null;
        }

        public int Merge(int position1, int position2)
        {
            return (Retrieve(position1) + Retrieve(position2));
        }
    }
}
