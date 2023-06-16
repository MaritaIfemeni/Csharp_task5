using src.Interfaces;

namespace src.Books
{
    public class ResearchPaper : Book, ICantBorrow, IPrintable
    {
        private int _pages;

        public ResearchPaper(string title, string author, string isbn, string publicationYear, int pages) : base(title, author, isbn, publicationYear)
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
            Console.WriteLine($"{Title} is a research paper and you cannot borrow a research paper.");
        }
        public void CantReturn()
        {
            Console.WriteLine($"{Title} is a research paper and you cannot return a research paper.");
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
        }
        public void PrintPages(int numberOfPages)
        {
            Console.WriteLine($"This research paper has {numberOfPages} pages.");
        }
    }
}