using System;
namespace EInvoice.Models
{
    public class InvoiceDetail
    {
        private int _id;
        private int _id_invoice;
        private string _product_code;
        private string _product_name;
        private string _unit;
        private double _amount;
        private double _price;
        private double _total;
        private double _vat_amount;
        private int _vat;
        private int _decrease_percent;
        private double _percent_value;
        private string _extra_1;
        private string _extra_2;

        public InvoiceDetail()
        {
        }

        public int Id { get => _id; set => _id = value; }
        public int Id_invoice { get => _id_invoice; set => _id_invoice = value; }
        public string Product_code { get => _product_code; set => _product_code = value; }
        public string Product_name { get => _product_name; set => _product_name = value; }
        public string Unit { get => _unit; set => _unit = value; }
        public double Amount { get => _amount; set => _amount = value; }
        public double Price { get => _price; set => _price = value; }
        public double Total { get => _total; set => _total = value; }
        public double Vat_amount { get => _vat_amount; set => _vat_amount = value; }
        public int Vat { get => _vat; set => _vat = value; }
        public int Decrease_percent { get => _decrease_percent; set => _decrease_percent = value; }
        public double Percent_value { get => _percent_value; set => _percent_value = value; }
        public string Extra_1 { get => _extra_1; set => _extra_1 = value; }
        public string Extra_2 { get => _extra_2; set => _extra_2 = value; }
    }
}