using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Entities;

namespace Repositories
{
    public class BookRepository
    {
        private BookManagementDbContext _context;

        public List<Book> GetAllBooks()
        {
            _context = new();
            return _context.Books.ToList();
        }

        public void DeleleBook(Book book)
        {
            _context = new();
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        public Book GetBook(int id)
        {
            _context = new();
            return _context.Books.FirstOrDefault(b => b.BookId == id);
        }

        public void AddBook(Book book)
        {
            _context = new();
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            _context = new();
            _context.Books.Update(book);
            _context.SaveChanges();
        }
    }
}
