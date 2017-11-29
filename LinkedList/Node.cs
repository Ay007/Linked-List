using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
    {
        public Node next;
        public Node Previous;
        public int value;
        public Node()
        {
            this.next = null;
            this.Previous = null;
        }
    }
}
