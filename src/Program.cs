using src.Books;
using src.Users;
using src.LibraryManagement;

public class Program
{
    public static void Main(string[] args)
    {
        Library library = new Library();
        Librarian librarian = new Librarian("John", "mail@com.fi");
        library.AddPerson(librarian);
        Customer customer = new Customer("Jane", "jame@mail.com");
        Customer customer2 = new Customer("Jane2", "jane2@mail.com");
        library.AddPerson(customer);
        library.AddPerson(customer2);
        customer2.PrintInfo();
        Person personToUpdate = library.FindPersonById(customer2.Id);
        personToUpdate.Name = "New Name for Jane2";
        personToUpdate.EmailAddress = "New Email for Jane2";
        library.EditPerson(personToUpdate);
        customer2.PrintInfo();
        library.PrintPeople();

        Novel novel1 = new Novel("Novel1", "Author1", "123-123-123", "2020", "Genre Novel");
        Novel novel2 = new Novel("Novel2", "Author2", "124-124-124", "2021", "Genre Novel");
        librarian.AddBook(novel1, library);
        librarian.AddBook(novel2, library);
        novel1.PrintInfo();
        Book bookToUpdate = library.FindBookById(novel1.Id);
        bookToUpdate.Title = "New Title for Novel1";
        bookToUpdate.Author = "New Author for Novel1";
        librarian.UpdateBook(bookToUpdate, library);
        novel1.PrintInfo();
        librarian.RemoveBook(novel1, library);
        library.PrintBooks();

        Comic comic1 = new Comic("Comic1", "Author1", "125-125-125", "2022", "Genre Comic");
        Comic comic2 = new Comic("Comic2", "Author2", "126-126-126", "2023", "Genre Comic");
        TextBook textBook1 = new TextBook("TextBook1", "Author1", "127-127-127", "2024", 50);
        TextBook textBook2 = new TextBook("TextBook2", "Author2", "128-128-128", "2025", 30);
        ResearchPaper researchPaper1 = new ResearchPaper("ResearchPaper1", "Author1", "129-129-129", "2026", 60);
        ResearchPaper researchPaper2 = new ResearchPaper("ResearchPaper2", "Author2", "130-130-130", "2027", 70);

        librarian.AddBook(comic1, library);
        librarian.AddBook(comic2, library);
        librarian.AddBook(textBook1, library);
        librarian.AddBook(textBook2, library);
        librarian.AddBook(researchPaper1, library);
        librarian.AddBook(researchPaper2, library);
        Console.WriteLine(library.books.Count());

        customer.BorrowBook(comic1, library);
        customer.BorrowBook(novel2, library);
        customer.BorrowBook(textBook1, library);
        Console.WriteLine(customer.BooksBorrowed.Count);
        Console.WriteLine(library.books.Count());
        customer.ReturnBook(comic1, library);
        Console.WriteLine(customer.BooksBorrowed.Count);
        Console.WriteLine(library.books.Count());

        researchPaper1.PrintInfo();
        researchPaper1.PrintPages(1, 40);
        textBook1.PrintPages(1, 100);
        Console.WriteLine("----");
        librarian.AssignBookToCustomer(comic1, customer2, library);
        librarian.AssignBookToCustomer(novel2, customer2, library);
        Console.WriteLine("----");
        Console.WriteLine(library.books.Count());
        Console.WriteLine("----");
        Console.WriteLine(customer2.BooksBorrowed.Count);
        Console.WriteLine("----");

        Comic comic3 = new Comic("Comic3", "Author3", "128-128-128", "2028", "Genre Comic");
        librarian.AddBook(comic3, library);
        Customer customer3 = new Customer("Jane3", "mail@com.fi");
        library.AddPerson(customer3);
    }
}