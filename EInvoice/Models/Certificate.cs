using System;
namespace EInvoice.Models
{
    public class Certificate
    {
        private int _id;
        private int _id_company;
        private int _id_detail_certificate;
        private DateTime _create_date;

        public Certificate()
        {
        }

        public int Id { get => _id; set => _id = value; }
        public int Id_company { get => _id_company; set => _id_company = value; }
        public int Id_detail_certificate { get => _id_detail_certificate; set => _id_detail_certificate = value; }
        public DateTime Create_date { get => _create_date; set => _create_date = value; }
    }
}