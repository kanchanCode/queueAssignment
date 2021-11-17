using System;
using System.Collections.Generic;
using System.Text;
using static QueueAssignment.Program;

namespace QueueAssignment
{
    class queueFunctions
    {
        Node head = null;
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if(head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
  
            }
            Console.WriteLine(node.data + " is inserted into Queue");
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                
                Console.Write(temp.data+" ");
                temp = temp.next;
            }
       
        }

        internal void Dequeue()
        {
            Node temp = this.head;
            if (temp != null)
            {
                this.head = head.next;
                temp = null;
            }
            else
            {
                Console.WriteLine("List is empty");
            
            }
            
        }
        
    }
}
