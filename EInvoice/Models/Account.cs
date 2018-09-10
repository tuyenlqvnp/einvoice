using System;

namespace EInvoice.Models
{
    public class Account
    {
        private int _id;
        private int _id_company;
        private string _username;
        private string _password;
        private string _name;
        private string _email;
        private string _department;
        private string _phone;

        public Account()
        {
        }

        public int Id { get => _id; set => _id = value; }
        public int Id_company { get => _id_company; set => _id_company = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string Name { get => _name; set => _name = value; }
        public string Email { get => _email; set => _email = value; }
        public string Department { get => _department; set => _department = value; }
        public string Phone { get => _phone; set => _phone = value; }
    }
}