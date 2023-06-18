using src.Interfaces;

namespace src.Books
{
    public class TextBook : Book, IPrintable
    {
        private int _pagesAllowedToPrint;
        public TextBook(string tittle, string author, string isbn, string publicationYear, int pagesAllowedToPrint) : base(tittle, author, isbn, publicationYear, false)
        {
            _pagesAllowedToPrint = pagesAllowedToPrint;
        }
        public int pagesAllowedToPrint
        {
            get { return _pagesAllowedToPrint; }
            set { _pagesAllowedToPrint = value; }
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
        }
        public void PrintPages(int startPage, int endPage)
        {
            if (endPage - startPage + 1 <= _pagesAllowedToPrint)
            {
                Console.WriteLine($"Printing pages {startPage} to {endPage} of the research paper: {Title}");
            }
            else
            {
                Console.WriteLine($"The number of pages to be printed exceeds the maximum allowed pages for the research paper: {Title}");
            }
        }
    }
}