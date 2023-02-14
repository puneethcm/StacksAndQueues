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
        Stack stack = new Stack();
        stack.Push(70);
        stack.Push(30);
        stack.Push(56);
        stack.Display();
        Console.ReadLine();
    }
}