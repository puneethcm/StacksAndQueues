using System;
using System.Xml.Linq;

namespace StacksAndQueues
{
    public class Stack
	{
        public Node top;

        //public Stack()
        //{
        //    this.top = null;
        //}
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

        public void Display()

        {
            Node temp = this.top;
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

