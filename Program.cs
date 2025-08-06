using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUEUE
{
    internal class Program
    {class Node
        {
            public string data;
            public Node next;
            public Node(string value)
            {
                data = value;
                next = null;
            }
        
        }
        public class Queue
        {
            Node front;
            Node rear;
            public Queue()
            {
                front = null;
                rear = null;
            }
            public bool isempty()
            {
                if (front == null )
                {
                    return true;
                }
                else
                    return false;

            }
            public void enqueue(string value)
            {
                if (isempty())
                {
                    Node newnode = new Node(value);
                    front = newnode;
                    rear = newnode;
                    Console.WriteLine(value + "IS ADDED");

                }
                else

                {
                    Node newnode = new Node(value);
                    rear.next = newnode;
                    rear = newnode;
                    Console.WriteLine(value + " IS ADDED");
                }
            }

            public void dequeue()
            {
                if (isempty())
                {
                    Console.WriteLine("queue is empty");
                }
                else
                {
                    front = front.next;
                    if (front == null)
                    {
                        rear = null;
                    }
                    Console.WriteLine("done");
                }

            }
            public void peek()
            {
                if (isempty())
                {
                    Console.WriteLine("queue is empty");
                }
                else
                {
                    Console.WriteLine("front element is " + front.data);
                }
            }
            public void display()
            {
                if (isempty())
                {
                    Console.WriteLine("queue is empty");
                }
                else
                {
                    Node current = front;
                    while (current != null)
                    {
                        Console.Write(current.data + " ");
                        current = current.next;
                    }
                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        { Queue queue = new Queue();
            queue.enqueue("sama ");
            queue.enqueue("nada ");
            queue.enqueue("yaseen ");
            queue.display();
            queue.peek();
            queue.dequeue();
                }
    }
}
