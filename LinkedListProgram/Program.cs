// See https://aka.ms/new-console-template for more information
using LinkedListProgram;

Console.WriteLine("Program for LinkedList");

LinkedList list = new LinkedList();

list.AddFirst("70"); list.AddFirst("30"); list.AddFirst("56"); list.printlist();

list.InsertAtParticularPosition(1, "40"); list.printlist();

list.deleteLast("70"); list.printlist();     // this will delete last node

list.deleteFirst("56"); list.printlist();    // this will delete first node

list.Search("70"); list.printlist();





