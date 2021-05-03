using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography;

namespace Information_security_4
{
    class Encryption
    {
        public static void FileEncryption(string login)
        {
            string filekey = null;

            try
            {
                using (StreamReader sr = new StreamReader("filekey.txt"))
                {
                    filekey = (sr.ReadToEnd());
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            byte[] plainContent = File.ReadAllBytes(login + ".txt");
            using (var DES = new DESCryptoServiceProvider())
            {
                DES.IV = Encoding.UTF8.GetBytes(filekey);
                DES.Key = Encoding.UTF8.GetBytes(filekey);
                DES.Mode = CipherMode.CBC;
                DES.Padding = PaddingMode.PKCS7;

                using (var memStream = new MemoryStream())
                {
                    CryptoStream cryptoStream = new CryptoStream(memStream, DES.CreateEncryptor(), CryptoStreamMode.Write);

                    cryptoStream.Write(plainContent, 0, plainContent.Length);
                    cryptoStream.FlushFinalBlock();
                    File.WriteAllBytes(login + ".txt", memStream.ToArray());
                }

            }
        }

        public static void FileDecryption(string login)
        {
            string filekey = null;

            try
            {
                using (StreamReader sr = new StreamReader("filekey.txt"))
                {
                    filekey = (sr.ReadToEnd());
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            byte[] encrypted = File.ReadAllBytes(login + ".txt");
            using (var DES = new DESCryptoServiceProvider())
            {
                DES.IV = Encoding.UTF8.GetBytes(filekey);
                DES.Key = Encoding.UTF8.GetBytes(filekey);
                DES.Mode = CipherMode.CBC;
                DES.Padding = PaddingMode.PKCS7;

                using (var memStream = new MemoryStream())
                {
                    CryptoStream cryptoStream = new CryptoStream(memStream, DES.CreateDecryptor(), CryptoStreamMode.Write);

                    cryptoStream.Write(encrypted, 0, encrypted.Length);
                    cryptoStream.FlushFinalBlock();
                    File.WriteAllBytes(login + ".txt", memStream.ToArray());


                }
            }
        }
    }
}
