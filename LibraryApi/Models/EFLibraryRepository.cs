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

        public IEnumerable<Book> GetBooks()
        {
            return context.Books;
        }

        public Book GetBookId(int id)
        {
            return context.Books.Find(id);
        }

        public void UpdateBook(Book book)
        {
            var currentbook = GetBookId(book.Id);
            currentbook.Name = book.Name;
            currentbook.BookGenreId = book.BookGenreId;
            currentbook.Author = book.Author;
            currentbook.Available = book.Available;

            context.Books.Update(currentbook);
            context.SaveChanges();

        }

        public void CreateBook(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            var book = GetBookId(id);
            if (book != null)
            {
                context.Books.Remove(book);
                context.SaveChanges();
            }

        }
    }
}
