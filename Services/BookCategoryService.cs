using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using Repositories.Entities;

namespace Services
{
    public class BookCategoryService
    {
        private BookCategoryRepository _repo = new();
        
        public List<BookCategory> GetAllCategories()
            => _repo.GetAllCategories();
    }
}
