using Repositories.Entities;

namespace Repositories
{
    public class UserAccountRepository
    {
        private BookManagementDbContext _context;
        
        public UserAccount GetUserAccount(string email, string password)
        {
            _context = new();
            return _context.UserAccounts.FirstOrDefault(a => a.Email == email && a.Password == password);
        }
    }
}
