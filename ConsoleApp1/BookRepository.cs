﻿using System.Collections.Generic;

namespace ConsoleApp1
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Title 1", Price = 5},
                new Book() {Title = "Title 2", Price = 9},
                new Book() {Title = "Title 3", Price = 12}
            };
        }
    }
}