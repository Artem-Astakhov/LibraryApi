using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Models
{
    public static class InitializationDb
    {
        public static void Initialize(LibraryContext context)
        {
            if (!context.BookGenres.Any())
            {
                context.AddRange(
                    new BookGenre { Name = "Фантастика" },
                    new BookGenre { Name = "Фентези" },
                    new BookGenre { Name = "Детектив" }
                    );
                context.SaveChanges();
            }

            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book { Name = "", BookGenreId = 1, Author = "", Available = true },
                    new Book { Name = "", BookGenreId = 2, Author = "", Available = true },
                    new Book { Name = "", BookGenreId = 3, Author = "", Available = true }
                );
                context.SaveChanges();
            }

        }
    }
}
