using src.Books;

namespace src.Users
{
    public class Customer : Person
    {
        public List<Book> BooksBorrowed { get; set; }
        public Customer(int id, string name, string emailAddress) : base(id, name, emailAddress)
        {
        }
        public void BorrowBook(Book book)
        {
            BooksBorrowed.Add(book);
        }
        public void ReturnBook(Book book)
        {
            BooksBorrowed.Remove(book);
        }
    }
}