using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositories.Entities;
using Services;

namespace BookManagement_NguyenHoaiNam
{
    public partial class BookDetailForm : Form
    {
        public Book SelectedBook { get; set; } = null;
        private BookService _bookService = new();
        private BookCategoryService _categoryService = new();
        ErrorProvider errorProvider = new ErrorProvider();
        private bool isFormValid = true;
        public BookDetailForm()
        {
            InitializeComponent();
        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            //do du lieu vao combo box
            cboCategory.DataSource = _categoryService.GetAllCategories();

            //chon truong du lieu hien thi
            cboCategory.DisplayMember = "BookGenreType";

            //chon truong map xuong db
            cboCategory.ValueMember = "BookCategoryId";

            //chon value hien thi mac dinh (neu muon)
            //cboCategory.SelectedValue = 1;

            if (SelectedBook != null)
            {
                lblBookDetail.Text = "Update Book";
                txtBookId.Enabled = false;
                txtBookId.Text = SelectedBook.BookId.ToString();
                txtBookName.Text = SelectedBook.BookName;
                txtBookDescription.Text = SelectedBook.Description;
                txtAuthor.Text = SelectedBook.Author;
                dtPublicationDate.Value = SelectedBook.PublicationDate;
                txtQuantity.Text = SelectedBook.Quantity.ToString();
                txtPrice.Text = SelectedBook.Price.ToString();
                cboCategory.SelectedValue = SelectedBook.BookCategoryId;
            }
            else
            {
                lblBookDetail.Text = "Add Book";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBookId_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBookId.Text))
            {
                if (int.TryParse(txtBookId.Text, out _) && int.Parse(txtBookId.Text) > 0)
                {
                    var book = _bookService.GetBook(int.Parse(txtBookId.Text));
                    if (book != null)
                    {
                        errorProvider.SetError(txtBookId, "Duplicated Book Id");
                        isFormValid = false;
                    }
                }
                else
                {
                    errorProvider.SetError(txtBookId, "Book Id must be integer greater than 0");
                    isFormValid = false;
                }
            }
            else
            {
                errorProvider.SetError(txtBookId, "Book Id must not empty");
                isFormValid = false;
            }
        }

        private void txtBookName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBookName.Text))
            {
                errorProvider.SetError(txtBookName, "Book Name must not empty");
                isFormValid = false;
            }
        }

        private void txtBookDescription_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtBookDescription, "");
        }

        private void txtBookDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBookDescription.Text))
            {
                errorProvider.SetError(txtBookDescription, "Book Description must not empty");
                isFormValid = false;
            }
        }

        private void txtAuthor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAuthor.Text))
            {
                errorProvider.SetError(txtAuthor, "Author must not empty");
                isFormValid = false;
            }
        }

        private void txtQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQuantity.Text))
            {
                if (!(int.TryParse(txtQuantity.Text, out _) && (int.Parse(txtQuantity.Text) >= 0 && int.Parse(txtQuantity.Text) < 4000000)))
                {
                    errorProvider.SetError(txtQuantity, "Quantity must be integer greater or equal 0 and less than 4000000");
                    isFormValid = false;
                }
            }
            else
            {
                errorProvider.SetError(txtQuantity, "Quantity must not empty");
                isFormValid = false;
            }
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPrice.Text))
            {
                if (!(decimal.TryParse(txtPrice.Text, out _) && (decimal.Parse(txtPrice.Text) >= 0 && decimal.Parse(txtPrice.Text) < 4000000)))
                {
                    errorProvider.SetError(txtPrice, "Price must be integer greater or equal 0 and less than 4000000");
                    isFormValid = false;
                }
            }
            else
            {
                errorProvider.SetError(txtPrice, "Price must not empty");
                isFormValid = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isFormValid)
                MessageBox.Show("Fail to save, please check information again!", "Save failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Book book = new Book()
            {
                BookId = int.Parse(txtBookId.Text),
                BookName = txtBookName.Text,
                Description = txtBookDescription.Text,
                PublicationDate = dtPublicationDate.Value,
                Quantity = int.Parse(txtQuantity.Text),
                Price = double.Parse(txtPrice.Text),
                Author = txtAuthor.Text,
                BookCategoryId = int.Parse(cboCategory.SelectedValue.ToString())
            };

            if (SelectedBook == null)
            {
                _bookService.AddBook(book);
            }
            else
            {
                _bookService.UpdateBook(book);
            }
            Close();
        }

        private void txtBookId_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtBookId, "");
            isFormValid = true;
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtBookName, "");
            isFormValid = true;
        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtAuthor, "");
            isFormValid = true;
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtQuantity, "");
            isFormValid = true;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtPrice, "");
            isFormValid = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

