using System;
using System.Xml.Linq;

namespace StacksAndQueues
{
    public class Stack
	{
        public Node top;

        
        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
                top = newNode;
                Console.WriteLine("\n{0} Node is Inserted ito Stack", newNode.data);
            }
            else
            {
                newNode.next = top;
                top = newNode;
                Console.WriteLine("\n{0} Node is Inserted into Statk", newNode.data);
            }
            
        }
        public void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine("\n{0} is on the Top of the Stack",top.data);
        }
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("\nStack is Empty, Pop is not posible");
                return;
            }
            Console.WriteLine("\nValue Popped is {0}",top.data);
            top = top.next;
        }
        public void isEmpty()
        {
            while (top != null)
            {
                Peek();
                Pop();
                Display();
            }
        }

        public void Display()

        {
            Node temp = top;
            if (temp == null)
            {
                Console.WriteLine("\nStack is Empty");
            }
            else
            {
                Console.WriteLine("\nDisplaying the Nodes");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}

