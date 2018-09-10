using System;
namespace EInvoice.Models
{
    public class Config{
        private int _id;
        private int _id_company;
        private int _config_code;

        public Config()
        {
        }

        public int Id { get => _id; set => _id = value; }
        public int Id_company { get => _id_company; set => _id_company = value; }
        public int Config_code { get => _config_code; set => _config_code = value; }
    }
}