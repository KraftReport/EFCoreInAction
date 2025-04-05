

using EFCoreConsole;
using Microsoft.EntityFrameworkCore;

using (var db = new AppDbContext())
{
    foreach (var book in db.Books.AsNoTracking().Include(a=>a.Author))
    {
        Console.WriteLine(
            $"{book.BookId}-" +
            $"{book.Title}-" +
            $"{book.Description}-" +
            $"{book.PublishedOn}-" +
            $"{book?.Author?.AuthorId}-" +
            $"{book?.Author?.Name}-" +
            $"{book?.Author?.WebUrl}");
    }
}

using(var db = new AppDbContext())
{
    var webUrl = "https://www.agathachristie.com";
    var book = db.Books.Include(a => a.Author).Single(b => b.BookId == 5);
    book.Author.WebUrl = webUrl;
    db.SaveChanges();
    Console.WriteLine("book is updated");
}
