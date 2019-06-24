using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookList
{
    class LibraryLinkedList : Library, ILibrary
    {
        LinkedList<Book> library;

        public LibraryLinkedList()
        {
            library = new LinkedList<Book>();
        }

        public void Add(Book book)
        {
            library.AddLast(book);
        }

        public void Remove(int n)
        {
            library.Remove(library.ElementAt(n));
        }

        public int GetLength()
        {
            return library.Count;
        }

        public Book BookAt(int n)
        {
            if (n >= 0 && n < library.Count)
                return (Book)library.ElementAt(n);

            return null;
        }


        public Library FindByTitle(string title)
        {
            LibraryLinkedList result = new LibraryLinkedList();

            foreach (Book book in library)
                if (book != null && book.FindByTitle(title) == true)
                    result.Add(new Book(book));

            return (Library)result;
        }

        public override string ToString()
        {
            string result = "Library (" + this.GetLength() + " books):\n";

            foreach (Book book in library)
                result += (book == null ? "" : book.ToString()) + "\n";

            return result;
        }
    }
}
