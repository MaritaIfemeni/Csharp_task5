using src.Books;
using src.LibraryManagement;

namespace src.Users
{
    public class Librarian : Person
    {
        private string _adminisrator { get; set; } = "admin";
        public Librarian(string name, string emailAddress) : base(name, emailAddress)
        {
            _adminisrator = Adminisrator;
        }
        public string Adminisrator
        {
            get { return _adminisrator; }
        }
        public void AddBook(Book book, Library library)
        {
            bool hasDuplicateISBN = library.books.Any(b => b.Isbn == book.Isbn);

            if (hasDuplicateISBN)
            {
                Console.WriteLine("A book with the same ISBN already exists.");
            }
            library.books.Add(book);
        }

        public void UpdateBook(Book book, Library library)
        {
            Book bookToUpdate = library.FindBookById(book.Id);
            if (bookToUpdate != null)
            {
                bookToUpdate.Title = book.Title;
                bookToUpdate.Author = book.Author;
            }
            else
            {
                System.Console.WriteLine("Book not found");
            }
        }
        public void RemoveBook(Book book, Library library)
        {
            Book bookToRemove = library.FindBookById(book.Id);
            if (bookToRemove != null)
            {
                library.books.Remove(bookToRemove);
            }
            else
            {
                System.Console.WriteLine("Book not found");
            }
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Is: {Adminisrator}");
        }

        public void AssignBookToCustomer(Book book, Customer customer, Library library)
        {
            library.AssignBook(book, customer);
        }

    }
}