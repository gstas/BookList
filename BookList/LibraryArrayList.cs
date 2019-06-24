using System;
using System.Collections;


namespace BookList
{
    class LibraryArrayList : Library, ILibrary
    {
        ArrayList library;

        public LibraryArrayList()
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
            LibraryArrayList result = new LibraryArrayList();

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
