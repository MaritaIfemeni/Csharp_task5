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
            library.books.Add(book);
        }

        public void UpdateBook(Book book, Library library)
        {
            throw new System.NotImplementedException();
        }
        public void RemoveBook(Book book, Library library)
        {
            if (library.books.Contains(book))
                library.books.Remove(book);
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
    }
}