using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookList
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Книга1");
            Book book2 = new Book("Книга2");

            Library lib = new Library();
            lib.Add(book1);
            lib.Add(book2);

            Console.WriteLine(lib);

            lib.BookAt(1);
            Console.WriteLine(lib);
        }
    }
}
