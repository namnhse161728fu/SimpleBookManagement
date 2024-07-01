using Repositories;
using Repositories.Entities;

namespace Services
{
    public class UserAccountService
    {
        private UserAccountRepository _repo = new();

        public UserAccount CheckLogin(string username, string password)
            => _repo.GetUserAccount(username, password);
    }
}
