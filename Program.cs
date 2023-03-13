using System.Collections.Generic;
using System;
using SD1Knowledgecheck2;

Console.WriteLine("How many books do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Book>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var book = new Book();

    Console.WriteLine("Enter the value for book genre: nonfiction or fiction");
    Book.Genre = Console.ReadLine();


    recordList.Add(book);
}

// Print out the list of records using Console.WriteLine()
Console.WriteLine("List of Books:{Book.Genre}");

