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
                    new Book { Name = "Марсианин", BookGenreId = 1, Author = "Энди Вейер", Available = true },
                    new Book { Name = "Ведьмак", BookGenreId = 2, Author = "Анжей Сапковский", Available = true },
                    new Book { Name = "Шерлок Холмс", BookGenreId = 3, Author = "Артур Конан Дойл", Available = true }
                );
                context.SaveChanges();
            }

        }
    }
}
