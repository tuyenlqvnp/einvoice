using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EInvoiceLib
{
    public class X509Fn
    {
        public static X509Certificate2 GetCertificateBySerial(string serial)
        {
            X509Store x509Store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            x509Store.Open(OpenFlags.ReadOnly);
            foreach (X509Certificate2 certificate in x509Store.Certificates)
            {
                if (certificate.GetSerialNumberString().ToUpper().CompareTo(serial.ToUpper().Trim()) == 0)
                {
                    try
                    {
                        if (!certificate.HasPrivateKey)
                            throw new Exception("Không lấy được private key, chọn chứng thư khác!");
                    }
                    catch
                    {
                        throw new Exception("Không lấy được private key, chọn chứng thư khác!");
                    }
                    x509Store.Close();//tuyen edit
                    return certificate;
                }
            }
            x509Store.Close();//tuyen edit
            return (X509Certificate2)null;
        }
        public static string signHashCert(string hashValue, string serial)
        {
            try
            {
                RSACryptoServiceProvider cryptoServiceProvider = (RSACryptoServiceProvider)null;
                X509Store x509Store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
                x509Store.Open(OpenFlags.ReadOnly);
                foreach (X509Certificate2 certificate in x509Store.Certificates)
                {
                    if (certificate.GetSerialNumberString().ToUpper() == serial.ToUpper())
                    {
                        cryptoServiceProvider = (RSACryptoServiceProvider)certificate.PrivateKey;
                        if (cryptoServiceProvider == null)
                            return "ERR:-2";
                        break;
                    }
                }
                string base64String = Convert.ToBase64String(cryptoServiceProvider.SignHash(Convert.FromBase64String(hashValue), CryptoConfig.MapNameToOID("SHA1")));
                x509Store.Close();
                return base64String;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("cancelled by the user"))
                    return "ERR:-1";
                return "ERR:-3 " + (object)ex;
            }
        }

        //tuyen viet
        public static string signHashCert(byte[] data, string serial)
        {
            try
            {
                RSACryptoServiceProvider cryptoServiceProvider = (RSACryptoServiceProvider)null;
                X509Store x509Store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
                x509Store.Open(OpenFlags.ReadOnly);
                foreach (X509Certificate2 certificate in x509Store.Certificates)
                {
                    if (certificate.GetSerialNumberString().ToUpper() == serial.ToUpper())
                    {
                        cryptoServiceProvider = (RSACryptoServiceProvider)certificate.PrivateKey;
                        // cryptoServiceProvider = (RSACryptoServiceProvider)certificate.PublicKey.Key;//tuyen edit
                        if (cryptoServiceProvider == null)
                            return "ERR:-2";
                        break;
                    }
                }
                //string base64String = Convert.ToBase64String(cryptoServiceProvider.SignHash(Convert.FromBase64String(hashValue), CryptoConfig.MapNameToOID("SHA1")));
                //string base64String = Convert.ToBase64String(cryptoServiceProvider.SignHash(data, CryptoConfig.MapNameToOID("SHA1")));
                byte[] signature = cryptoServiceProvider.SignData(data, "SHA1");
                x509Store.Close();
                string base64String = Convert.ToBase64String(signature);
                return base64String;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("cancelled by the user"))
                    return "ERR:-1";
                return "ERR:-3 " + (object)ex;
            }
        }
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}
