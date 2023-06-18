using src.Interfaces;

namespace src.Books
{
    public class Novel : Book, ICanBorrow
    {
        private string _genre;
        public Novel(string title, string author, string isbn, string publicationYear, string genre) : base(title, author, isbn, publicationYear, true)
        {
            _genre = genre;
        }
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }
        public void Borrow()
        {
            Console.WriteLine("You have borrowed a novel.");
        }
        public void Return()
        {
            Console.WriteLine("You have returned a novel.");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Genre: {Genre}");
        }
    }
}