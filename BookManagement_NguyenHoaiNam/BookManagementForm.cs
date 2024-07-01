using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookManagement_NguyenHoaiNam.DTOs;
using Services;

namespace BookManagement_NguyenHoaiNam
{
    public partial class BookManagementForm : Form
    {
        private BookDTO _selected = null;
        private BookService _bookService = new();
        private BookCategoryService _bookCategoryService = new();
        public BookManagementForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvBookManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private List<BookDTO> GetBookInfoList()
        {
            var books = _bookService.GetAllBooks();
            var categories = _bookCategoryService.GetAllCategories();
            var bookInforList = new List<BookDTO>();
            foreach (var b in books)
            {
                foreach (var c in categories)
                {
                    if (b.BookCategoryId == c.BookCategoryId)
                        bookInforList.Add(new BookDTO()
                        {
                            BookId = b.BookId,
                            BookName = b.BookName,
                            Description = b.Description,
                            PublicationDate = b.PublicationDate,
                            Quantity = b.Quantity,
                            Price = b.Price,
                            Author = b.Author,
                            BookCategoryId = b.BookCategoryId,
                            BookGenreType = c.BookGenreType
                        });
                }
            }
            return bookInforList;
        }

        private void FillDataGridView()
        {
            dgvBookManagement.DataSource = null;
            dgvBookManagement.DataSource = GetBookInfoList();
        }
        private void BookManagementForm_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvBookManagement.DataSource = null;
            dgvBookManagement.DataSource = GetBookInfoList().Where(b => b.BookName.ToLower().Contains(txtName.Text.Trim().ToLower()) &&
              b.Description.ToLower().Contains(txtDescription.Text.Trim().ToLower())).ToList();
        }

        private void dgvBookManagement_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvBookManagement_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBookManagement.SelectedRows.Count > 0)
            {
                _selected = (BookDTO)dgvBookManagement.SelectedRows[0].DataBoundItem;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBookManagement.SelectedRows.Count == 0 || _selected == null)
            {
                MessageBox.Show("No book selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult answer = MessageBox.Show("Do you really want to delete this book?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No)
                return;
            var selectedBook = _bookService.GetBook(_selected.BookId);
            _bookService.DeleteBook(selectedBook);
            FillDataGridView();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            BookDetailForm form = new();
            form.ShowDialog();
            FillDataGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvBookManagement.SelectedRows.Count == 0 || _selected == null)
            {
                MessageBox.Show("No book selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BookDetailForm form = new();
            form.SelectedBook = _bookService.GetBook(_selected.BookId);
            form.ShowDialog();
            FillDataGridView();
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Application.Exit();
        }
    }
}
