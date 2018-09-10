using System;
namespace EInvoice.Models
{
    public class NotifyPublishInvoice
    {
        private int _id;
        private int _id_company;
        private string _organization_name;
        private string _tax_code;
        private string _address;
        private string _phone;
        private string _director;
        private string _tax_department_name;
        private string _city;
        private string _seperator;

        public NotifyPublishInvoice()
        {
        }

        public int Id { get => _id; set => _id = value; }
        public int Id_company { get => _id_company; set => _id_company = value; }
        public string Organization_name { get => _organization_name; set => _organization_name = value; }
        public string Tax_code { get => _tax_code; set => _tax_code = value; }
        public string Address { get => _address; set => _address = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Director { get => _director; set => _director = value; }
        public string Tax_department_name { get => _tax_department_name; set => _tax_department_name = value; }
        public string City { get => _city; set => _city = value; }
        public string Seperator { get => _seperator; set => _seperator = value; }
    }
}