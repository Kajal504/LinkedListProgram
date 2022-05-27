// See https://aka.ms/new-console-template for more information
using QueueLinkedList;
Console.WriteLine("Program for Queue using LinkList");

Queue linkedListQueue = new Queue();
linkedListQueue.Enqueue(56);
linkedListQueue.Enqueue(30);
linkedListQueue.Enqueue(70);
linkedListQueue.Peek();

linkedListQueue.Dequeue();
linkedListQueue.IsEmpty();
