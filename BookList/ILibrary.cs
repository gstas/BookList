namespace BookList
{
    interface ILibrary
    {
        void Add(Book book);
        void Remove(int n);
        int GetLength();
        Book BookAt(int n);
        Library FindByTitle(string title);
        string ToString();
    }
       
}
