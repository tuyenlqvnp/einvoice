using System;
namespace EInvoice.Models
{
    public class CertificateDetail
    {
        private int _id;
        private string _pri_key;
        private string _pub_key;
        private DateTime begin_date;
        private DateTime end_date;

        public CertificateDetail()
        {

        }

        public int Id { get => _id; set => _id = value; }
        public string Pri_key { get => _pri_key; set => _pri_key = value; }
        public string Pub_key { get => _pub_key; set => _pub_key = value; }
        public DateTime Begin_date { get => begin_date; set => begin_date = value; }
        public DateTime End_date { get => end_date; set => end_date = value; }
    }
}