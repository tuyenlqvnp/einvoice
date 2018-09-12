using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Threading;

namespace TestLib
{
    class Program
    {
        static void Main(string[] args)
        {
            SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            //string serial = "008640bbd93a1deb45";//cert old
            //string serial = "00fb7832a04d3eb69f";//cert new
            string serial = "54018ef116dc26d07254d81de2fb6de6";
            X509Certificate2 certificate = EInvoiceLib.X509Fn.GetCertificateBySerial(serial);
            string my_cert_pem = "MIICxzCCAjCgAwIBAgIJAPt4MqBNPrafMA0GCSqGSIb3DQEBCwUAMHsxCzAJBgNVBAYTAnZuMQswCQYDVQQIDAJidDEMMAoGA1UEBwwDaGNtMQ0wCwYDVQQKDAR2ZHNnMQ0wCwYDVQQLDARob21lMQ4wDAYDVQQDDAV0dXllbjEjMCEGCSqGSIb3DQEJARYUdHV5ZW5scXZucEBnbWFpbC5jb20wHhcNMTgwOTEyMDUxOTUwWhcNMTkwOTEyMDUxOTUwWjB7MQswCQYDVQQGEwJ2bjELMAkGA1UECAwCYnQxDDAKBgNVBAcMA2hjbTENMAsGA1UECgwEdmRzZzENMAsGA1UECwwEaG9tZTEOMAwGA1UEAwwFdHV5ZW4xIzAhBgkqhkiG9w0BCQEWFHR1eWVubHF2bnBAZ21haWwuY29tMIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCqzX3SRXuc5b/JN7ynXXcDEKGkPz5t+WQYK4ui1286Ovh/q3HHeRZ87rIZohwL6l299Hpl2OROwGxm21+V9jPBcqwzoVyM7SapU9taUinPcaOw2LrbukbvwXgjsz0p2x69wvFF4QuYyZnTKhcqZM1RnyeG+8cfyq9A3STcjuPagQIDAQABo1MwUTAdBgNVHQ4EFgQUq2wgrX5HJMNcBey9jYIT3SnLKmMwHwYDVR0jBBgwFoAUq2wgrX5HJMNcBey9jYIT3SnLKmMwDwYDVR0TAQH/BAUwAwEB/zANBgkqhkiG9w0BAQsFAAOBgQAl/cPcsIWhV9RvwLlY68tw99O+/yX8UZBXI8DWQZcecHU1xkrsdHCFxv7qN1gejqJhF67weaIcwzCxV6/RlX5VaOkNmuxyDwWxUsOpzoMMRhwXXjlvkWhWO6FwePtExQjFL/or7aqQ26bjbnaQgOhZzqZrqoC7tPcC7xjKT0iBlA==";
            byte[] my_cert_pem_byte = Encoding.UTF8.GetBytes(my_cert_pem);

            X509Certificate2 cer2 = new X509Certificate2(my_cert_pem_byte, "cloud");
            byte[] encodedPublicKey11 = cer2.PublicKey.EncodedKeyValue.RawData;
            string pubkey11 = Convert.ToBase64String(encodedPublicKey11);

            Console.WriteLine(certificate.Subject);
            string md5str = EInvoiceLib.X509Fn.CreateMD5("<Invoices><Inv><key>25172</key><Invoice><CusCode>PT06</CusCode><CusName>CHI NHÁNH CÔNG TY TNHH PHÂN PHỐI SYNNEX FPT</CusName><CusAddress>65 Trương Định,Phường 06,Quận 03,Thành Phố Hồ Chí Minh</CusAddress><CusPhone></CusPhone><CusTaxCode>0104264818-002</CusTaxCode><PaymentMethod>CK</PaymentMethod><KindOfService></KindOfService><Remark></Remark><KyHan></KyHan><SoVT></SoVT><Products><Product><ProdName>Pay LIN based on contract 02/HDMB/LIN-LK,03/HDMB/LIN-LK (374 pcs)</ProdName><ProdUnit>Unit</ProdUnit><ProdQuantity>1</ProdQuantity><ProdPrice>10000000</ProdPrice><Amount>10000000</Amount></Product></Products><Total>10000000</Total><VATRate>10</VATRate><VATAmount>1000000</VATAmount><Amount>11000000</Amount><AmountInWords>Mười một triệu đồng chẵn.</AmountInWords><Extra></Extra><ArisingDate>10/08/2018</ArisingDate><PaymentStatus>0</PaymentStatus><SignDate>11/08/2018</SignDate></Invoice></Inv></Invoices>");
            byte[] abc = Encoding.UTF8.GetBytes("<Invoices><Inv><key>25172</key><Invoice><CusCode>PT06</CusCode><CusName>CHI NHÁNH CÔNG TY TNHH PHÂN PHỐI SYNNEX FPT</CusName><CusAddress>65 Trương Định,Phường 06,Quận 03,Thành Phố Hồ Chí Minh</CusAddress><CusPhone></CusPhone><CusTaxCode>0104264818-002</CusTaxCode><PaymentMethod>CK</PaymentMethod><KindOfService></KindOfService><Remark></Remark><KyHan></KyHan><SoVT></SoVT><Products><Product><ProdName>Pay LIN based on contract 02/HDMB/LIN-LK,03/HDMB/LIN-LK (374 pcs)</ProdName><ProdUnit>Unit</ProdUnit><ProdQuantity>1</ProdQuantity><ProdPrice>10000000</ProdPrice><Amount>10000000</Amount></Product></Products><Total>10000000</Total><VATRate>10</VATRate><VATAmount>1000000</VATAmount><Amount>11000000</Amount><AmountInWords>Mười một triệu đồng chẵn.</AmountInWords><Extra></Extra><ArisingDate>10/08/2018</ArisingDate><PaymentStatus>0</PaymentStatus><SignDate>11/08/2018</SignDate></Invoice></Inv></Invoices>");
            //byte[] hashabc = sha256.ComputeHash(abc);
            byte[] hashabc = sha1.ComputeHash(abc);
            string hashabc64 = Convert.ToBase64String(hashabc);
            string abcstr = Convert.ToBase64String(abc);
            byte[] hashabc1 = Convert.FromBase64String(hashabc64);

            byte[] myHash = Encoding.UTF8.GetBytes("khong biet dung khong");
            byte[] data = Encoding.UTF8.GetBytes(md5str);

            //string test1 = EInvoiceLib.X509Fn.signHashCert(md5str, serial);
            string test1 = EInvoiceLib.X509Fn.signHashCert(Convert.ToBase64String(hashabc), serial);
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                byte[] signature = rsa.SignData(abc, "SHA1");
                byte[] signature1 = rsa.SignHash(hashabc, "SHA1");
                string sig = Convert.ToBase64String(signature);
                string sig1 = Convert.ToBase64String(signature1);
                if (sig == sig1)
                {
                    Console.WriteLine("Dung roi");
                }


            }
            //using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            //{
            //    byte[] signature = rsa.SignData(abc, "SHA256");
            //    byte[] signature1 = rsa.SignHash(hashabc, "SHA256");
            //    string sig = Convert.ToBase64String(signature);
            //    string sig1 = Convert.ToBase64String(signature1);
            //    if (sig == sig1)
            //    {
            //        Console.WriteLine("Dung roi");
            //    }


            //}
            RSACryptoServiceProvider cryptoServiceProvider = (RSACryptoServiceProvider)null;//client
            RSACryptoServiceProvider cryptoServiceProvider1 = (RSACryptoServiceProvider)null;//server
            if (!certificate.HasPrivateKey)
                throw new Exception("Không lấy được private key, chọn chứng thư khác!");
            cryptoServiceProvider = (RSACryptoServiceProvider)certificate.PrivateKey;
            cryptoServiceProvider1 = (RSACryptoServiceProvider)cer2.PublicKey.Key;
            

            
            byte[] encodedPublicKey = certificate.PublicKey.EncodedKeyValue.RawData;
            byte[] encode1 = certificate.RawData;
            string pubkey = Convert.ToBase64String(encodedPublicKey);
            
            string pub = Convert.ToBase64String(encode1);//my-cert1.pem
            byte[] encodedPublicKey1 = certificate.GetPublicKey();
            string pubkey1 = Convert.ToBase64String(encodedPublicKey1);
            byte[] certExport = certificate.Export(X509ContentType.Cert);
            string certExportStr = Convert.ToBase64String(certExport);//my-cert1.pem
            //string privateKey = certificate.PrivateKey.ToXmlString(true);

            byte[] si1 = cryptoServiceProvider.SignHash(hashabc, "SHA1");//client ky roi
            byte[] si = cryptoServiceProvider.SignData(abc, "SHA1");

            string s = Convert.ToBase64String(si);
            string s1 = Convert.ToBase64String(si1);
            if (s == s1)
            {
                Console.WriteLine("Dung roi");
            }

            //byte[] signature = rsa.SignData(data1, "SHA256");

            if (cryptoServiceProvider1.VerifyData(abc, "SHA1", si1))
            {
                Console.WriteLine("RSA-SHA256 signature verified");
            }
            if(cryptoServiceProvider1.VerifyData(myHash,"SHA1", si1))
            {
                Console.WriteLine("tao lao");
            }
            else
            {
                Console.WriteLine("RSA-SHA256 signature failed to verify");
            }

            Console.WriteLine(test1);

            byte[] data1 = new byte[] { 0, 1, 2, 3, 4, 5 };//du lieu hoa don duoc gui len
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                byte[] signature = rsa.SignData(data1, "SHA256");

                if (rsa.VerifyData(data1, "SHA256", signature))
                {
                    Console.WriteLine("RSA-SHA256 signature verified");
                }
                else
                {
                    Console.WriteLine("RSA-SHA256 signature failed to verify");
                }
            }

            string str1 = "khong biet dung khong";
            byte[] ds1 = Encoding.UTF8.GetBytes(str1);
            string str2 = Convert.ToBase64String(ds1);
            byte[] ds2 = Convert.FromBase64String(str2);
            string str3 = Encoding.UTF8.GetString(ds2);


            byte[] st1 = sha256.ComputeHash(ds1);
            string st2 = Convert.ToBase64String(st1);

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                byte[] signature = rsa.SignData(ds1, "SHA256");
                byte[] signature1 = rsa.SignHash(st1, "SHA256");
                string sig = Convert.ToBase64String(signature);
                string sig1 = Convert.ToBase64String(signature1);
                if (sig == sig1)
                {
                    Console.WriteLine("Dung roi");
                }

                if (rsa.VerifyData(data1, "SHA256", signature))
                {
                    Console.WriteLine("RSA-SHA256 signature verified");
                }
                else
                {
                    Console.WriteLine("RSA-SHA256 signature failed to verify");
                }
            }

        }
        private static void callThread(string Account, string ACpass, string id, string username, string pass, string pattern, string linkWS)
        {
            new Thread((ThreadStart)(() => funcThread())).Start();
        }
        private static void funcThread()
        {

        }
    }
}
