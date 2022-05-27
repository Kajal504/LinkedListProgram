using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLinkedList
{
    internal class Stack
    {
        public Node top;
        public Stack()
        {
            this.top = null;
        }
        internal void push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} pushed to stack ", value);
        }
        internal void peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the top of the Stack", this.top.data);
        }
        internal void pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty, Deleted is not possible");
                return;

            }
            Console.WriteLine("value popped is {0}", this.top.data);
            this.top = this.top.next;
        }
        internal void IsEmpty()
        {
            while (this.top != null)
            {
                peek();
                pop();
            }
        }
    }
}
