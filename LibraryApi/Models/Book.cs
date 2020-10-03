using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public bool Available { get; set; }

        public int BookGenreId { get; set; }
        public BookGenre BookGenre { get; set; }
    }
}
