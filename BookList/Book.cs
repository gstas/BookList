using System;

namespace BookList
{
    class Book
    {
        string title;
       

        public string Title { get => title; set => title = value; }
   
     
        public Book(Book book)
        {
            //
            this.title = book.title;
          
        }

        public Book(string title)
        {
            Title = title;
        }

        public bool FindByTitle(string title)
        {
            if (this.title.ToLower().Contains(title.ToLower()))
                return true;

            return false;
        }

        public override string ToString()
        {
                      
            return Title.ToUpper();
        }
    }
}
