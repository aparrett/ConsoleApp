using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            var expensiveBooks =
                from b in books
                where b.Price > 10
                orderby b.Title
                select b.Title;

            foreach (var title in expensiveBooks)
                Console.WriteLine(title);
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }

    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
                {
                    new Book() {Title = "Hello world 1", Price = 5.12f},
                    new Book() {Title = "Hello world 2", Price = 5},
                    new Book() {Title = "Hello world 3", Price = 8.12f},
                    new Book() {Title = "Hello Solar System", Price = 12.12f},
                    new Book() {Title = "Hello Universe", Price = 17.12f}
                };
        }
    }
}