
namespace src.Books
{
    public abstract class Book
    {
        private int _id { get; }
        private string _title { get; set; } = string.Empty;
        private string _author { get; set; } = string.Empty;
        private string _isbn { get; set; } = string.Empty;
        private string _publicationYear { get; set; } = string.Empty;
        private bool _borrowable { get; set; }
        public Book(string title, string author, string isbn, string publicationYear, bool borrowable)
        {
            _id = GenerateUniqueBookId();
            _title = title;
            _author = author;
            _isbn = isbn;
            _publicationYear = publicationYear;
            _borrowable = borrowable;
        }
        public int Id
        {
            get { return _id; }
        }
        public int GenerateUniqueBookId()
        {
            Random random = new Random();
            return random.Next(1, 1000);
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        public string Isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }
        public string PublicationYear
        {
            get { return _publicationYear; }
            set { _publicationYear = value; }
        }
        public bool Borrowable
        {
            get { return _borrowable; }
            set { _borrowable = value; }
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine("---BOOK INFO---");
            Console.WriteLine($"Book ID: {Id}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {Isbn}");
            Console.WriteLine($"Publication Year: {PublicationYear}");
        }
    }
}