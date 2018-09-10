using System;
namespace EInvoice.Models
{
    public class InvoiceFormPublish
    {
        private int _id;
        private int _notify_publish_invoice;
        private string _form_invoice;
        private string _serial;
        private string _quantity;
        private int _begin_number;
        private int _to_number;
        private DateTime _begin_date;
        private string _company_name;
        private string _tax_code;
        private string _address;
        private string _phone;
        private string _fax;
        private string _bank_number;

        public InvoiceFormPublish()
        {
        }

        public int Id { get => _id; set => _id = value; }
        public int Notify_publish_invoice { get => _notify_publish_invoice; set => _notify_publish_invoice = value; }
        public string Form_invoice { get => _form_invoice; set => _form_invoice = value; }
        public string Serial { get => _serial; set => _serial = value; }
        public string Quantity { get => _quantity; set => _quantity = value; }
        public int Begin_number { get => _begin_number; set => _begin_number = value; }
        public int To_number { get => _to_number; set => _to_number = value; }
        public DateTime Begin_date { get => _begin_date; set => _begin_date = value; }
        public string Company_name { get => _company_name; set => _company_name = value; }
        public string Tax_code { get => _tax_code; set => _tax_code = value; }
        public string Address { get => _address; set => _address = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Fax { get => _fax; set => _fax = value; }
        public string Bank_number { get => _bank_number; set => _bank_number = value; }
    }
}