using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginTextEditor
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string userType { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string dateOfBirth { get; set; }

        public User(string username, string password, string userType, string firstName, string lastName, string dateOfBirth)
        {
            this.username = username;
            this.password = password;
            this.userType = userType;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
        }


    }
}
