using src.Books;
using src.LibraryManagement;

namespace src.Users
{
    public class Customer : Person
    {
        public List<Book> BooksBorrowed { get; set; }
        public Customer( string name, string emailAddress) : base( name, emailAddress)
        {
            BooksBorrowed = new List<Book>();
        }
    
        public void BorrowBook(Book book, Library library)
        {
            library.books.Remove(book);
            BooksBorrowed.Add(book);
        }

        public void ReturnBook(Book book, Library library)
        {
            BooksBorrowed.Remove(book);
            library.books.Add(book);
        }
        public void PrintBooksBorrowed()
        {
            foreach (Book book in BooksBorrowed)
            {
                book.PrintInfo();
            }
        }
    }
}