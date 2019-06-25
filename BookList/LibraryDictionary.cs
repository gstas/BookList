using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookList
{
    class LibraryDictionary : Library, ILibrary
    {
        Dictionary<int, Book> library;
        static int key;

        public LibraryDictionary()
        {
            library = new Dictionary<int, Book>();
            key = 0;
        }

        public void Add(Book book)
        {
            library.Add(key++, book);

        }

        public void Remove(int n)
        {
            Dictionary<int, Book> temp = new Dictionary<int, Book>();
            int k = 0;

            library.Remove(n);
            foreach (Book book in library.Values)
            {
                temp.Add(k++, book);
            }
            library = temp;
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
            LibraryDictionary result = new LibraryDictionary();

            foreach (Book book in library.Values)
                if (book != null && book.FindByTitle(title) == true)
                    result.Add(new Book(book));

            return (Library)result;
        }

        public override string ToString()
        {
            string result = "Library (" + this.GetLength() + " books):\n";

            foreach (Book book in library.Values)
                result += (book == null ? "" : book.ToString()) + "\n";

            return result;
        }
    }
}
