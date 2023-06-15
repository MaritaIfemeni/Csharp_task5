using src.Interfaces;
namespace src.Books
{
    public class Comic : Book, IComic
    {

        private string _artist;
        public Comic(int id, string title, string author, string genre, string year, string _artist) : base(id, title, author, genre, year)
        {
            this._artist = _artist;
        }
    }
}