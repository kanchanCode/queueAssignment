using System;

namespace QueueAssignment
{
    class Program
    {
        public class Node
        {
           
            public int data;
           
            public Node next;

            public Node(int data)
            {
                this.data = data;
            }
        }
            static void Main(string[] args)
        {
            queueFunctions obj = new queueFunctions();
            obj.Enqueue(56);
            obj.Enqueue(30);
            obj.Enqueue(70);
            obj.Display();
            obj.Dequeue();
            Console.WriteLine("Queue after dequeue :");
            obj.Display();
        }
    }
}
