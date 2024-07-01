using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using Repositories.Entities;

namespace Services
{
    public class BookService
    {
        private BookRepository _repo = new();

        public List<Book> GetAllBooks()
            => _repo.GetAllBooks();

        public void DeleteBook(Book book)
        {
            _repo.DeleleBook(book);
        }

        public Book GetBook(int id)
            => _repo.GetBook(id);

        public void AddBook(Book book)
            => _repo.AddBook(book);

        public void UpdateBook(Book book)
            => _repo.UpdateBook(book);
    }
}
