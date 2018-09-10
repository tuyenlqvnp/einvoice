using System;
namespace EInvoice.Models
{
    public class Invoice
    {
        private int _id;
        private int _id_company;
        private DateTime _create_date;
        private DateTime _publish_date;
        private string _invoice_name;
        private string _form;
        private string _serial;
        private int _id_customer;
        private string _payment_type;
        private double _amount;
        private double _vat_amout;
        private double _total;
        private int _vat;
        private int _vat_x;
        private int _vat_0;
        private int _vat_5;
        private int _vat_10;
        private double _vat_amout_x;
        private double _vat_amout_0;
        private double _vat_amout_5;
        private double _vat_amout_10;
        private double _total_x;
        private double _total_0;
        private double _total_5;
        private double _total_10;
        private int _invoice_type;
        private string _link_xlst;
        private string _link_xml;
        private int _multi_vat;
        private int _invoice_number;
        private int _invoice_adjust_replace;
        private int _pay_yet;
        private int _invoice_status;

        public Invoice()
        {
        }

        public int Id { get => _id; set => _id = value; }
        public int Id_company { get => _id_company; set => _id_company = value; }
        public DateTime Create_date { get => _create_date; set => _create_date = value; }
        public DateTime Publish_date { get => _publish_date; set => _publish_date = value; }
        public string Invoice_name { get => _invoice_name; set => _invoice_name = value; }
        public string Form { get => _form; set => _form = value; }
        public string Serial { get => _serial; set => _serial = value; }
        public int Id_customer { get => _id_customer; set => _id_customer = value; }
        public string Payment_type { get => _payment_type; set => _payment_type = value; }
        public double Amount { get => _amount; set => _amount = value; }
        public double Vat_amout { get => _vat_amout; set => _vat_amout = value; }
        public double Total { get => _total; set => _total = value; }
        public int Vat { get => _vat; set => _vat = value; }
        public int Vat_x { get => _vat_x; set => _vat_x = value; }
        public int Vat_0 { get => _vat_0; set => _vat_0 = value; }
        public int Vat_5 { get => _vat_5; set => _vat_5 = value; }
        public int Vat_10 { get => _vat_10; set => _vat_10 = value; }
        public double Vat_amout_x { get => _vat_amout_x; set => _vat_amout_x = value; }
        public double Vat_amout_0 { get => _vat_amout_0; set => _vat_amout_0 = value; }
        public double Vat_amout_5 { get => _vat_amout_5; set => _vat_amout_5 = value; }
        public double Vat_amout_10 { get => _vat_amout_10; set => _vat_amout_10 = value; }
        public double Total_x { get => _total_x; set => _total_x = value; }
        public double Total_0 { get => _total_0; set => _total_0 = value; }
        public double Total_5 { get => _total_5; set => _total_5 = value; }
        public double Total_10 { get => _total_10; set => _total_10 = value; }
        public int Invoice_type { get => _invoice_type; set => _invoice_type = value; }
        public string Link_xlst { get => _link_xlst; set => _link_xlst = value; }
        public string Link_xml { get => _link_xml; set => _link_xml = value; }
        public int Multi_vat { get => _multi_vat; set => _multi_vat = value; }
        public int Invoice_number { get => _invoice_number; set => _invoice_number = value; }
        public int Invoice_adjust_replace { get => _invoice_adjust_replace; set => _invoice_adjust_replace = value; }
        public int Pay_yet { get => _pay_yet; set => _pay_yet = value; }
        public int Invoice_status { get => _invoice_status; set => _invoice_status = value; }
    }
}