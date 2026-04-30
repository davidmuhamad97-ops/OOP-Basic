using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject.Latihan
{
    public class Lat_2
    {
        public static void main()
        {
            BookLibrary book1 = new BookLibrary("The Great Gatsby", "F. Scott Fitzgerald", "978-0743273565");
            BookLibrary book2 = new BookLibrary("To Kill a Mockingbird", "Harper Lee", "978-0061120084");
            book1.displayInfo();
            Console.WriteLine();
            if (book1.borrowBook())
            {
                Console.WriteLine("You have borrowed: " + book1);
            }
            else
            {
                Console.WriteLine("Sorry, the book is not available.");
            }
            Console.WriteLine();
            book1.displayInfo();

        }
    }

    class BookLibrary
    {
        private string title;
        private string author;
        private string isbn;
        private bool isAvailable;

        public BookLibrary(string title, string author, string isbn)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.isAvailable = true;
        }

        public bool borrowBook() 
        {
            if (this.isAvailable)
            {
                this.isAvailable = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void returnBook()
        {
            this.isAvailable = true;
        }

        public void displayInfo()
        {
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Author: " + this.author);
            Console.WriteLine("ISBN: " + this.isbn);
            Console.WriteLine("Available: " + (this.isAvailable ? "Yes" : "No"));
        }
    }
}
