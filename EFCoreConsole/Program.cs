

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
