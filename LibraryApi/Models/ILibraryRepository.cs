using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Models
{
    public interface ILibraryRepository
    {
        IEnumerable<Book> Get();
        Book Get(int id);
        void Create(Book book);
        void Update(Book book);
        void Delete(int id);
    }
}
