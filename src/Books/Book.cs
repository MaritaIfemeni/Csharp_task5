

namespace src.Books
{
    public class Book
    {
        private int _id { get; }
        private string? _title { get; set; }
        private string? _author { get; set; }
        private string? _isbn { get; set; }
        private string? _publicationYear { get; set; }

        public Book(int id, string title, string author, string isbn, string publicationYear)
        {
            _id = GenerateUniqueBookId();
            _title = title;
            _author = author;
            _isbn = isbn;
            _publicationYear = publicationYear;
        }
        public int Id
        {
            get { return _id; }
        }
        public int GenerateUniqueBookId()
        {
            Random random = new Random();
            return random.Next(1, 10000);
        }
        public string? Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string? Author
        {
            get { return _author; }
            set { _author = value; }
        }
        public string? Isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }
        public string? PublicationYear
        {
            get { return _publicationYear; }
            set { _publicationYear = value; }
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Book ID: {Id}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {Isbn}");
            Console.WriteLine($"Publication Year: {PublicationYear}");
        }
    }
}