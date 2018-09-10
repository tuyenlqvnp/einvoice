using System;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace EInvoice.Models
{
    public class Database
    {
        private string _server;
        private string _database_name;
        private string _uid;
        private string _password;
        private MySqlConnection _cnn;
        private string _cnnStr;

        public Database()
        {
            this.Server = "localhost";
            this.Database_name = "hddt";
            this.Uid = "root";
            this.Password = "1234567t";
            this.CnnStr = "server=" + this.Server + ";uid=" + this.Uid + ";pwd=" + this.Password + ";database=" + this.Database_name + "";
            this.Cnn = new MySqlConnection(CnnStr);
            this.Cnn.Open();
        }
        

        public string Server { get => _server; set => _server = value; }

        public string Uid { get => _uid; set => _uid = value; }
        public string Password { get => _password; set => _password = value; }
        public string Database_name { get => _database_name; set => _database_name = value; }
        public MySqlConnection Cnn { get => _cnn; set => _cnn = value; }
        public string CnnStr { get => _cnnStr; set => _cnnStr = value; }
    }
}