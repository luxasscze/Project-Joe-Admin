using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Admin
{
    public static class GlobalVar
    {

        public static string _keySQL = "b14ca5898a4e4133bbce2ea2315a1916";
        public static string _keyEmail = "b14ca5898a4e4122bbce2ea2315a1916";
        public static string _keyCompany = "b32ca5898a4e4122bbce2ea2315a1916";

        public static List<Order> _Orders = new List<Order>();


        public static string SettingsData(int index)
        {
           
            if (File.Exists("./Settings/Settings.dat"))
            {
                return File.ReadAllText("./Settings/Settings.dat").Split(';')[index];
            }
            else
            {
                return null;
            }
        }

        public static void LoadSettings()
        {
            _SQLServer = DecryptString(_keySQL, SettingsData(0));
            _SQLDatabase = DecryptString(_keySQL, SettingsData(1));
            _SQLUsername = DecryptString(_keySQL, SettingsData(2));
            _SQLPassword = DecryptString(_keySQL, SettingsData(3));
            _EmailServer = DecryptString(_keyEmail, SettingsData(4));
            _EmailUsername = DecryptString(_keyEmail, SettingsData(5));
            _EmailPassword = DecryptString(_keyEmail, SettingsData(6));
            _isSSL = bool.Parse(DecryptString(_keyEmail, SettingsData(7)));
            _EmailPort = int.Parse(DecryptString(_keyEmail, SettingsData(8)));
            _CompanyName = DecryptString(_keyCompany, SettingsData(9));
            _CompanyOwner = DecryptString(_keyCompany, SettingsData(10));
            _CompanyPhone = DecryptString(_keyCompany, SettingsData(11));
            _ImageUriPath = DecryptString(_keySQL, SettingsData(12));
            _AppPassword = DecryptString(_keySQL, SettingsData(13));
            _FTPLocation = _ImageUriPath;
            _FTPServer = DecryptString(_keySQL, SettingsData(14));
            _FTPUsername = DecryptString(_keySQL, SettingsData(15));
            _FTPPassword = DecryptString(_keySQL, SettingsData(16));
        }




        public static string EncryptString(string key, string plainInput)
        {
            byte[] iv = new byte[16];
            byte[] array;
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainInput);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        public static string DecryptString(string key, string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
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

        public static string GetConnectionString()
        {
            string _ConnectionString = @"Data Source=" + _SQLServer + ";Initial Catalog=" + _SQLDatabase + ";User Id=" + _SQLUsername + ";Password=" + _SQLPassword;
            return _ConnectionString;
        }

        public static bool _isSSL { get; set; }
        public static string _EmailServer { get; set; }
        public static int _EmailPort { get; set; }
        public static string _EmailUsername { get; set; }
        public static string _EmailPassword { get; set; }

        public static string _CompanyName { get; set; }
        public static string _CompanyOwner { get; set; }
        public static string _CompanyPhone { get; set; }

        public static string _SQLServer { get; set; }
        public static string _SQLDatabase { get; set; }
        public static string _SQLUsername { get; set; }
        public static string _SQLPassword { get; set; }
        public static string _ImageUriPath { get; set; }
        public static string _AppPassword { get; set; }

        public static bool _LoginState { get; set; }

        public static string _FTPServer { get; set; }
        public static string _FTPUsername { get; set; }
        public static string _FTPPassword { get; set; }
        public static string _FTPLocation { get; set; }






    }
}
