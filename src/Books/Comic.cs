using src.Interfaces;

namespace src.Books
{
    public class Comic : Book, ICanBorrow
    {
        private string _artist;
        public Comic(string title, string author, string isbn, string publicationYear, string artist) : base(title, author, isbn, publicationYear)
        {
            _artist = artist;
        }
        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }
        public void Borrow()
        {
            Console.WriteLine("You have borrowed a comic book.");
        }

        public void Return()
        {
            Console.WriteLine("You have returned a comic book.");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Artist: {Artist}");
        }
    }
}