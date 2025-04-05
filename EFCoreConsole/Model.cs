using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreConsole
{
    public class Model
    {
       
    }

    public class Book
    {
        public int BookId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? PublishedOn { get; set; }
        public Author? Author { get; set; }
        public int? AuthorId { get; set; }
    }

    public class Author
    {
        public int AuthorId { get; set; }
        public string? Name { get; set; }
        public string? WebUrl { get; set; }
    }
}
