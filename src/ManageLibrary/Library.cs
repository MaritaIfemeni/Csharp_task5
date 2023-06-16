using src.Books;
using src.Users;

namespace src.LibraryManagement
{
    public class Library
    {
        public List<Book> books { get; set; }
        private List<Person> people { get; set; }

        public Library()
        {
            books = new List<Book>();
            people = new List<Person>();
        }

        public void AddPerson(Person person)
        {
            people.Add(person);
        }

        public void RemovePerson(Person person)
        {
            people.Remove(person);
        }

        public void PrintPeople()
        {
            foreach (Person person in people)
            {
                person.PrintInfo();
            }
        }

        public void BorrowBook(Book book, Customer customer)
        {
            books.Remove(book);
            customer.BooksBorrowed.Add(book);
        }

        public void ReturnBook(Book book, Customer customer)
        {
            customer.BooksBorrowed.Remove(book);
            books.Add(book);
        }


    }
}