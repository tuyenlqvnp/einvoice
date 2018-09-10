using System;

namespace EInvoice.Models
{
    public class Customer
    {
        private int _id;
        private string _tax_code;
        private string _name;
        private string _address;
        private string _email;
        private string _contact;
        private string _contact_email;
        private string _contact_phone;
        private string _bank_number;
        private string _bank_name;
        private string _phone;
        private string _fax;
        private string _cus_code;
        private string _description;

        public Customer()
        {
        }

        public int Id { get => _id; set => _id = value; }
        public string Tax_code { get => _tax_code; set => _tax_code = value; }
        public string Name { get => _name; set => _name = value; }
        public string Address { get => _address; set => _address = value; }
        public string Email { get => _email; set => _email = value; }
        public string Contact { get => _contact; set => _contact = value; }
        public string Contact_email { get => _contact_email; set => _contact_email = value; }
        public string Contact_phone { get => _contact_phone; set => _contact_phone = value; }
        public string Bank_number { get => _bank_number; set => _bank_number = value; }
        public string Bank_name { get => _bank_name; set => _bank_name = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Fax { get => _fax; set => _fax = value; }
        public string CusCode { get => _cus_code; set => _cus_code = value; }
        public string Description { get => _description; set => _description = value; }
    }
}