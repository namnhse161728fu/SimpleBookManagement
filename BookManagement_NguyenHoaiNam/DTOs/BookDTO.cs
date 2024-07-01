using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement_NguyenHoaiNam.DTOs
{
    public class BookDTO
    {
        public int BookId { get; set; }

        public string BookName { get; set; } = null!;

        public string Description { get; set; } = null!;

        public DateTime PublicationDate { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public string Author { get; set; } = null!;

        public int BookCategoryId { get; set; }

        public string BookGenreType { get; set; }
    }
}
