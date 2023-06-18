
namespace src.Interfaces
{
    public interface ICanBorrow
    {
        public bool Borrowable { get; set; }
        public void Borrow();
        public void Return();
    }
}