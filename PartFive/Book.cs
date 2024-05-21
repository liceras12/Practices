using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartFive
{
    public class Book
    {
        public string title { get; set; }
        public int pages { get; set; }

        public Book(string title, int pages)
        {
            this.title=title;
            this.pages=pages;
        }
    }
}
