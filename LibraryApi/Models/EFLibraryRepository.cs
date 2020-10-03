using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Models
{
    public class EFLibraryRepository : ILibraryRepository
    {
        private LibraryContext context;
        public EFLibraryRepository(LibraryContext context)
        {
            this.context = context;
        }

        public IEnumerable<Book> Get()
        {
            return context.Books;
        }

        public Book Get(int id)
        {
            return context.Books.Find(id);
        }

        public void Update(Book book)
        {
            var currentbook = Get(book.Id);
            currentbook.Name = book.Name;
            currentbook.BookGenreId = book.BookGenreId;
            currentbook.Author = book.Author;
            currentbook.Available = book.Available;

            context.Books.Update(currentbook);
            context.SaveChanges();

        }

        public void Create(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var book = Get(id);
            if (book != null)
            {
                context.Books.Remove(book);
                context.SaveChanges();
            }

        }
    }
}
