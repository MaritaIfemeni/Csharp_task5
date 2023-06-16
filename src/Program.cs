using src.Books;

public class Program {
    public static void Main(string[] args)
    {
        Novel novel = new Novel("The Book", "Writer", "ISBN1", "2020", "Genre");
        Console.WriteLine(novel.Id);
        Console.WriteLine(novel.Title);
        novel.PrintInfo();
        novel.Borrow();
        novel.Return();

        Comic comic = new Comic("The Comic", "Writer", "ISBN2", "2020", "Artist");
        Console.WriteLine(comic.Id);
        Console.WriteLine(comic.Title);
        comic.PrintInfo();
        comic.Borrow();
        comic.Return();

        ResearchPaper researchPaper = new ResearchPaper("The Research Paper", "Writer", "ISBN3", "2020", 100);
        Console.WriteLine(researchPaper.Id);
        Console.WriteLine(researchPaper.Title);
        researchPaper.PrintInfo();
        researchPaper.CantBorrow();
        researchPaper.CantReturn();
        researchPaper.PrintPages(100);
    }
}