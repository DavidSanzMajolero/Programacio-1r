using System.Text;
using System.Security.Cryptography;
using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string encryptedText = lbl_result.Text;
            byte[] key = Encoding.UTF8.GetBytes("0123456789abcdef0123456789abcdef");
            byte[] IV = Encoding.UTF8.GetBytes("1234567890123456");
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
            string decryptedText = DecryptStringFromBytes(encryptedBytes, key, IV);
            label3.Text = decryptedText;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            string originalText = txt_box.Text;

            byte[] key = Encoding.UTF8.GetBytes("0123456789abcdef0123456789abcdef");
            byte[] IV = Encoding.UTF8.GetBytes("1234567890123456");
            byte[] encryptedBytes = EncryptStringToBytes(originalText, key, IV);
            string encryptedText = Convert.ToBase64String(encryptedBytes);
            lbl_result.Text = encryptedText;
        }
        static byte[] EncryptStringToBytes(string plainText, byte[] key, byte[] IV)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        return msEncrypt.ToArray();
                    }
                }
            }
        }


        static string DecryptStringFromBytes(byte[] cipherText, byte[] key, byte[] IV)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = IV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

        }

        
    }
}
