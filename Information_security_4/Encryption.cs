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
    static public class Encryption
    {
        public static void FileEncryption(string login)
        {
            string filekey = null;

            byte[] plainContent = File.ReadAllBytes(login + ".txt");

            try
            {
                using (StreamReader sr = new StreamReader("filekey.txt"))
                {
                    filekey = (sr.ReadToEnd());
                }

            

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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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

        static public string EncryptPass(string plainText)
        {
            UTF8Encoding encoder = new UTF8Encoding();

            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = File.ReadAllBytes("key.txt");
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(array);

        }




        static public string DecryptPass(string cipherText)
        {
            UTF8Encoding encoder = new UTF8Encoding();

            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = File.ReadAllBytes("key.txt");
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }          

        }
    }
}
  