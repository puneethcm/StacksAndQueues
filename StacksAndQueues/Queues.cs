using System;
namespace StacksAndQueues
{
	public class Queues
	{
		public Node head;

		public void Enqueue(int data)
		{
			Node new_node = new Node(data);
			if(head == null)
			{
				head = new_node;
			}
			else
			{
				Node temp = head;
				while (temp.next != null)
				{
					temp = temp.next;
				}
				temp.next = new_node;
			}
		}
		public void Dequeue()
		{
			if (head == null)
			{
				Console.WriteLine("Queues is Empty");
			}
			else
			{
				Node temp = head;
				while(temp.next.next != null)
				{
                    temp = temp.next;
				}
                Console.WriteLine("\n{0} is dequeus", temp.next.data);
                temp.next = null;
            }
        }
        public void Display()
        {
            Node temp = head;
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

