using System;

namespace SD1Knowledgecheck2
{
    public class Book
    {
        public string title { get; set; } = "To Kill a Mockingbird";

        static void Main(string[] args)
        {
            Book book1 = new Book();
            Console.WriteLine(book1.title);
        }

    }
}

