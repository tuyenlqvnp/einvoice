using System;
namespace EInvoice.Models
{
    public class AccessDetail
    {
        private int _id;
        private int _id_account;
        private int _id_access;
        private string _function;

        public AccessDetail()
        {
        }

        public int Id { get => _id; set => _id = value; }
        public int Id_account { get => _id_account; set => _id_account = value; }
        public int Id_access { get => _id_access; set => _id_access = value; }
        public string Function { get => _function; set => _function = value; }
    }
}