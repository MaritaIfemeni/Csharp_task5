using src.Books;
using src.LibraryManagement;
using src.Interfaces;

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
            if (book is ICanBorrow canBorrow && canBorrow.Borrowable)
            {
                canBorrow.Borrow();
                BooksBorrowed.Add(book);
                library.books.Remove(book);
                Console.WriteLine($"You have borrowed the book: {book.Title}");
            }
            else
            {
                Console.WriteLine("You can't borrow this book");
            }
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