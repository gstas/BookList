using System;

namespace BookList
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Книга1");
            Book book2 = new Book("Книга2");
            Book book3 = new Book("Книга3");


            // LibraryArrayList lib = new LibraryArrayList();
            // LibraryList lib = new LibraryList();
            // LibraryLinkedList lib = new LibraryLinkedList();
            // LibraryQueue lib = new LibraryQueue();
            LibraryDictionary lib = new LibraryDictionary();

            lib.Add(book1);
            lib.Add(book2);

            Console.WriteLine(lib);

            lib.Add(book3);
            Console.WriteLine("Добавили еще книгу:");
            Console.WriteLine(lib);

            lib.Remove(1);
            Console.WriteLine("Удалили книгу(1):");
            Console.WriteLine(lib);

            Console.WriteLine("Книга(0):");
            Console.WriteLine(lib.BookAt(0) + "\n");

            Console.WriteLine("Поиск 'книги3':");
            Console.WriteLine(lib.FindByTitle("Книга3"));
        }
    }
}
