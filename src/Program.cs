using src.Books;
using src.Users;
using src.LibraryManagement;

public class Program {
    public static void Main(string[] args)
    {
        Library library = new Library();
        Librarian librarian = new Librarian("Librarian", "mail.com");
        library.AddPerson(librarian);
        librarian.AddBook(new Novel("The Book", "Writer", "ISBN1", "2020", "Genre"), library);
        librarian.AddBook(new Comic("The Comic", "Writer", "ISBN2", "2020", "Artist"), library);

        Console.WriteLine(library.books[0].Title);
        Console.WriteLine(library.books[1].Title);

        // librarian.RemoveBook(library.books[0], library);
        // Console.WriteLine(library.books.Count);

        Customer customer = new Customer("Customer", "mail.com");
        library.AddPerson(customer);
        customer.BorrowBook(library.books[0], library);
        Console.WriteLine(customer.BooksBorrowed[0].Title);
        Console.WriteLine(library.books.Count);

        // Novel novel = new Novel("The Book", "Writer", "ISBN1", "2020", "Genre");
        // Console.WriteLine(novel.Id);
        // Console.WriteLine(novel.Title);
        // novel.PrintInfo();
        // novel.Borrow();
        // novel.Return();

        // Comic comic = new Comic("The Comic", "Writer", "ISBN2", "2020", "Artist");
        // Console.WriteLine(comic.Id);
        // Console.WriteLine(comic.Title);
        // comic.PrintInfo();
        // comic.Borrow();
        // comic.Return();

        // ResearchPaper researchPaper = new ResearchPaper("The Research Paper", "Writer", "ISBN3", "2020", 100);
        // Console.WriteLine(researchPaper.Id);
        // Console.WriteLine(researchPaper.Title);
        // researchPaper.PrintInfo();
        // researchPaper.CantBorrow();
        // researchPaper.CantReturn();
        // researchPaper.PrintPages(100);

        // Customer customer = new Customer ("Customer", "mail.com");
        // customer.BorrowBook(novel);
        // customer.BorrowBook(comic);
        // Console.WriteLine(customer.Name);
        // Console.WriteLine(customer.BooksBorrowed[0].Title);

        // Librarian librarian = new Librarian("Librarian", "mail.com");
        // Console.WriteLine(librarian.Name);


    }
}