using Lesson_Queue.Model;
using System;
using System.Collections.Generic;

namespace Lesson_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var easyqueue = new EasyQueue<int>();
            easyqueue.Enqueue(1);
            easyqueue.Enqueue(2);
            easyqueue.Enqueue(3);
            easyqueue.Enqueue(4);
            easyqueue.Enqueue(5);
            Console.WriteLine(easyqueue.Dequeue());
            Console.WriteLine(easyqueue.Peek());
            Console.WriteLine(easyqueue.Dequeue());
            Console.WriteLine();

            var array = new ArrayQueue<int>(10);
            array.Enqueue(100);
            array.Enqueue(101);
            array.Enqueue(102);
            array.Enqueue(103);
            array.Enqueue(104);
            Console.WriteLine(array.Dequeue());
            Console.WriteLine(array.Peek());
            Console.WriteLine(array.Dequeue());
            Console.WriteLine(array.Dequeue());
            Console.WriteLine(array.Dequeue());
            Console.WriteLine(array.Peek());
            Console.WriteLine();

            var linkedQueue = new LinkedQueue<int>();
            linkedQueue.Enqueue(200);
            linkedQueue.Enqueue(201);
            linkedQueue.Enqueue(202);
            linkedQueue.Enqueue(203);
            linkedQueue.Enqueue(204);
            Console.WriteLine(linkedQueue.Count);
            Console.WriteLine(linkedQueue.Dequeue());
            Console.WriteLine(linkedQueue.Dequeue());
            Console.WriteLine(linkedQueue.Dequeue());
            Console.WriteLine(linkedQueue.Peek());
            Console.WriteLine(linkedQueue.Dequeue());
            Console.WriteLine(linkedQueue.Peek());
            Console.WriteLine(linkedQueue.Count);
            Console.WriteLine();
            var easydeque = new EasyDeque<int>();
            easydeque.PushFront(11);
            easydeque.Pushback(222);
            easydeque.PushFront(13);
            easydeque.Pushback(224);
            easydeque.PushFront(15);
            easydeque.Pushback(226);
            easydeque.PushFront(17);
            easydeque.Pushback(228);
            Console.WriteLine(easydeque.Popback());
            Console.WriteLine(easydeque.PeekBack());
            Console.WriteLine(easydeque.Popback());
            Console.WriteLine(easydeque.PeekBack());
            Console.WriteLine(easydeque.Popback());
            Console.WriteLine(easydeque.Popfront());
            Console.WriteLine(easydeque.PeekFront());
            Console.WriteLine(easydeque.Popfront());
            Console.WriteLine(easydeque.Popfront());
            Console.WriteLine(easydeque.PeekFront());
            Console.WriteLine();

            var duplexdeque = new DuplexLinkedDeque<int>();
            duplexdeque.PushBack(1000);
            duplexdeque.PushBack(1001);
            duplexdeque.PushBack(1002);
            duplexdeque.PushBack(1003);
            duplexdeque.PushFront(2000);
            duplexdeque.PushFront(2001);
            duplexdeque.PushFront(2002);
            Console.WriteLine(duplexdeque.PopBack());
            Console.WriteLine(duplexdeque.PopBack());
            Console.WriteLine(duplexdeque.PeekBack());
            Console.WriteLine(duplexdeque.PopBack());
            Console.WriteLine(duplexdeque.PopFront());
            Console.WriteLine(duplexdeque.PopFront());
            Console.WriteLine(duplexdeque.PopFront());
            Console.ReadLine();
        }
    }
}
