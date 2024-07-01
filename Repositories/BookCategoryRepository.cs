using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Entities;

namespace Repositories
{
    public class BookCategoryRepository
    {
        private BookManagementDbContext _context;

        public List<BookCategory> GetAllCategories()
        {
            _context = new();
            return _context.BookCategories.ToList();
        }
    }
}
