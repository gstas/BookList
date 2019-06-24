using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookList
{
    class Library
    {
        ArrayList library;

        public Library()
        {
            library = new ArrayList();
        }

        public void Add(Book book)
        {
            library.Add(book);
        }

        public void Remove(int n)
        {
            library.RemoveAt(n);
        }

        public int GetLength()
        {
            return library.Count;
        }

        public Book BookAt(int n)
        {
            if (n >= 0 && n < library.Count)
                return (Book)library[n];

            return null;
        }

        public Library FindByTitle(string title)
        {
            Library result = new Library();

            foreach (Book book in library)
                if (book != null && book.FindByTitle(title) == true)
                    result.Add(new Book(book));

            return result;
        }

        public override string ToString()
        {
            string result = "\n\nLibrary (" + this.GetLength() + " books):\n";

            foreach (Book book in library)
                result += (book == null ? "" : book.ToString()) + "\n";

            return result;
        }
    }
}
