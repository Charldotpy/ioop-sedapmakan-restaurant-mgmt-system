using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showmembers
{
    public class UserProfileModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Nationality { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }

        public UserProfileModel() { }

        public UserProfileModel(int id, string name, string password, string email,
                                string nationality, DateTime dob, string phone)
        {
            ID = id;
            Name = name;
            Password = password;
            Email = email;
            Nationality = nationality;
            DOB = dob;
            Phone = phone;
        }
    }
}
