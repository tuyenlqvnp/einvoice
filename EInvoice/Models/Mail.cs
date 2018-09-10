using System;

namespace EInvoice.Models
{
    public class Mail
    {
        private int _id;
        private string _receiver_email;
        private string _subject;
        private string _status;
        private string _date_send;
        private string _sender_email;
        private int _id_company;

        public int Id { get => _id; set => _id = value; }
        public string Receiver_email { get => _receiver_email; set => _receiver_email = value; }
        public string Subject { get => _subject; set => _subject = value; }
        public string Status { get => _status; set => _status = value; }
        public string Date_send { get => _date_send; set => _date_send = value; }
        public string Sender_email { get => _sender_email; set => _sender_email = value; }
        public int Id_company { get => _id_company; set => _id_company = value; }
    }
}