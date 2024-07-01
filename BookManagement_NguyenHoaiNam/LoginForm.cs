using Services;

namespace BookManagement_NguyenHoaiNam
{
    public partial class LoginForm : Form
    {
        private UserAccountService _service = new();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var acc = _service.CheckLogin(txtEmail.Text, txtPassword.Text);
            if (acc == null)
            {
                MessageBox.Show("Invalid Account or Password!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (acc.Role != 1)
            {
                MessageBox.Show("You have no permission to access this function!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BookManagementForm bookForm = new();
            bookForm.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
