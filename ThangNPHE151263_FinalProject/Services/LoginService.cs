using Repositories;
using System.Security.Cryptography;
using System.Text;

namespace Services
{
    public class LoginService
    {
        private readonly LoginRepository _repository;

        public LoginService()
        {
            _repository = new LoginRepository();
        }

        public bool CheckLoginUser(string userName, string password)
        {
            var loginUser = _repository.GetLogin(userName, password);
            return loginUser != null;
        }

        public long GetEmployeeID(string userName, string password)
        {
            var loginUser = _repository.GetLogin(userName, password);
            return loginUser?.IdEmployee ?? 0;
        }

        private string HashString(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString().Substring(0, 32);
            }
        }
    }

}
