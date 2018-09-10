using System;
namespace EInvoice.Models
{
    public class ConfigDetail
    {
        private int _id;
        private int _code;
        private string _key;
        private string _value;

        public ConfigDetail()
        {
        }

        public int Id { get => _id; set => _id = value; }
        public int Code { get => _code; set => _code = value; }
        public string Key { get => _key; set => _key = value; }
        public string Value { get => _value; set => _value = value; }
    }

}