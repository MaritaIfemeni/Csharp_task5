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
        public List<Book> Books
        {
            get { return books; }
            set { books = value; }

        }
        public void AddPerson(Person person)
        {
            bool hasDuplicateEmail = people.Any(p => p.EmailAddress == person.EmailAddress);
            if (hasDuplicateEmail)
            {
                Console.WriteLine("A person with the same email address already exists.");
            }
            people.Add(person);
        }

        public Person FindPersonById(int personId)
        {
            return people.FirstOrDefault(person => person.Id == personId);
        }
        public void EditPerson(Person person)
        {
            Person personToEdit = FindPersonById(person.Id);
            if (personToEdit != null)
            {
                personToEdit.Name = person.Name;
                personToEdit.EmailAddress = person.EmailAddress;
            }
            else
            {
                System.Console.WriteLine("Person not found");
            }
        }

        public void RemovePerson(Person person)
        {
            Person personToRemove = FindPersonById(person.Id);
            if (personToRemove != null)
            {
                people.Remove(personToRemove);
            }
            else
            {
                System.Console.WriteLine("Person not found");
            }
        }
        public void PrintPeople()
        {
            foreach (Person person in people)
            {
                person.PrintInfo();
            }
        }
        public void PrintBooks()
        {
            foreach (Book book in books)
            {
                book.PrintInfo();
            }
        }
        public Book FindBookById(int bookId)
        {
            return books.FirstOrDefault(book => book.Id == bookId);
        }

        public void AssignBook(Book book, Customer customer)
        {
            if (books.Contains(book))
            {
                customer.BorrowBook(book, this);
            }
            else
            {
                Console.WriteLine("Book not found in the library.");
            }
        }
    }
}