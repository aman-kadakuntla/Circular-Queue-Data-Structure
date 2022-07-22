using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circular_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select option");
            CircularQueue queue = new CircularQueue(3);
        label:
            Console.WriteLine("1. Add\n2. Delete\n3. Display\n4. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter number");
                    if(queue.Add(Convert.ToInt32(Console.ReadLine())))
                    {
                        Console.WriteLine("Added successfully");
                    }
                    else
                    {
                        Console.WriteLine("Queue might be full");
                    }
                    goto label;
                case 2:
                    if (queue.Delete())
                        Console.WriteLine("Element deleted");
                    else
                        Console.WriteLine("Queue is empty");
                    goto label;
                case 3:
                    if (queue.display().Count == 0)
                        Console.WriteLine("Queue is empty");
                    else
                    {
                        Console.Write("Queue elements : ");
                        foreach (var item in queue.display())
                            Console.Write(item + " ");
                        Console.WriteLine();
                    }
                    goto label;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    goto label;

            }
        }
    }
}
