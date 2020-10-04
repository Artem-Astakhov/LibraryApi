using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Models
{
    public interface ILibraryRepository
    {
        IEnumerable<Book> GetBooks();
        Book GetBookId(int id);
        void CreateBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int id);
    }
}
