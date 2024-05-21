// See https://aka.ms/new-console-template for more information

using PartFive;
using System;
using System.Collections.Generic;

namespace Practices
{
    class Program
    {
        private Random random = new Random();
        private Dictionary<string, List<Book>> library = new Dictionary<string, List<Book>>();

        static void Main(string[] args)
        {
            Program program = new Program();

        }

        public void AddBook(string genre, Book book)
        {
            if (!library.ContainsKey(genre))
            {
                library[genre] = new List<Book>();
            }
            library[genre].Add(book);
        }
    }
}