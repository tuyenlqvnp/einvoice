using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;

namespace TestLib
{
    class Program
    {
        static void Main(string[] args)
        {
            string serial = "54018ef116dc26d07254d81de2fb6de6";
            X509Certificate2 test = EInvoiceLib.X509Fn.GetCertificateBySerial(serial);
            Console.WriteLine(test.Subject);
          //  string md5str = EInvoiceLib.X509Fn.CreateMD5("test");
          //  byte[] myHash = { 59,4,248,102,77,97,142,201,
          //210,12,224,93,25,41,100,197,
          //210,12,224,93,25,41,100,197,
          //213,134,130,135, 213,134,130,135};
          //  string test1 = EInvoiceLib.X509Fn.signHashCert(myHash.ToString(), serial);
          //  Console.WriteLine(test1);


        }
    }
}
