using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JH rowling", 400);
            Console.WriteLine(book1.title);
        }
        // classes are for creating more complex data types
        
        class Book
        {
            public string title;
            public string author;
            public int pages;

            // The method below is called constructor

            public Book(string aTitle, string aAuthor, int aPages)
            {  title = aTitle;
                author = aAuthor;
                pages = aPages; }
    }
    }
}
