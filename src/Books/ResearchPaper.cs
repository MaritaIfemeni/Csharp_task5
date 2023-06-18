using src.Interfaces;

namespace src.Books
{
    public class ResearchPaper : Book, IPrintable
    {
        private int _pagesAllowedToPrint;
        public ResearchPaper(string title, string author, string isbn, string publicationYear, int pagesAllowedToPrint) : base(title, author, isbn, publicationYear, false)
        {
            _pagesAllowedToPrint
             = pagesAllowedToPrint;
        }
        public int Pages
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