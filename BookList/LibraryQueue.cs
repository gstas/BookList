using System;
using System.Collections.Generic;

namespace BookList
{
    class LibraryQueue : Library, ILibrary
    {
        Queue<Book> library;

        public LibraryQueue()
        {
            library = new Queue<Book>();
        }

        public void Add(Book book)
        {
            library.Enqueue(book);
        }

        public void Remove(int n)
        {
            throw new NotImplementedException();
        }

        public int GetLength()
        {
            return library.Count;
        }

        public Book BookAt(int n)
        {
            throw new NotImplementedException();
        }


        public Library FindByTitle(string title)
        {
            LibraryList result = new LibraryList();

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
