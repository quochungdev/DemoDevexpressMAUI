using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDevExpress1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public User() { }

        public User(int id, string fullname, string username, string password, string email, DateTime birthday)
        {
            Id = id;
            Fullname = fullname;
            Username = username;
            Password = password;
            Email = email;
            Birthday = birthday;
        }
    }
}
