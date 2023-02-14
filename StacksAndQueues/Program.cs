using System.Collections;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StacksAndQueues;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome to Stacks And Queues");
        Console.WriteLine("\n1: Stacks Operations\n2:Queues Operations");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                Stack stack = new Stack();
                stack.Push(70);
                stack.Push(30);
                stack.Push(56);
                stack.Display();
                stack.Peek();
                stack.Pop();
                stack.isEmpty();
                break;

            case 2:
                Queues queues = new Queues();
                queues.Enqueue(56);
                queues.Enqueue(30);
                queues.Enqueue(70);
                queues.Display();
                break;
        }
        Console.ReadLine();
    }
}