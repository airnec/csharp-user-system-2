using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserSystem2.Models;

namespace UserSystem2.Services
{
    public class UserService
    {
        private readonly List<User> _users;

        public UserService()
        {
            _users = new List<User>
            {
                new User("test@example.com", "12345"),
                new User("user@example.com", "password"),
                new User("admin@example.com", "admin123")
            };
        }

        public bool LoginUser(string email, string password)
        {
            var user = _users.FirstOrDefault(u => u.Email == email && u.Password == password);
            return user != null;
        }
    }
}
