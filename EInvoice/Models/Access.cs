using System;
namespace EInvoice.Models
{
    public class Access
    {
        private int _id;
        private string _url;
        private string _description;

        public Access()
        {
        }

        public int Id { get => _id; set => _id = value; }
        public string Url { get => _url; set => _url = value; }
        public string Description { get => _description; set => _description = value; }
    }
}