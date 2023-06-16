using src.Interfaces;

namespace src.Books
{
    public class TextBook : Book, ICantBorrow, IPrintable
    {
        private int _pages;

        public TextBook(string tittle, string author, string isbn, string publicationYear, int pages) : base(tittle, author, isbn, publicationYear)
        {
            _pages = pages;
        }
        public int Pages
        {
            get { return _pages; }
            set { _pages = value; }
        }
        public void CantBorrow()
        {
            Console.WriteLine($"{Title} is a textbook and you cannot borrow a textbook.");
        }
        public void CantReturn()
        {
            Console.WriteLine($"{Title} is a textbook and you cannot return a textbook.");
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
        }
        public void PrintPages(int numberOfPages)
        {
            Console.WriteLine($"This textbook has {numberOfPages} pages.");
        }
    }
}