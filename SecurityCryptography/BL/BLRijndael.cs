﻿using System.Security.Cryptography;
using System.Text;

namespace SecurityCryptography.BL
{
    /// <summary>
    /// class for methods related Rijndael
    /// </summary>
    public class BLRijndael
    {
        private static RijndaelManaged _objRijndael = new RijndaelManaged();

        /// <summary>
        /// Method to generate a random Rijndael key and IV
        /// </summary>
        /// <param name="keySize"></param>
        /// <param name="blockSize"></param>
        /// <returns>key and iv</returns>
        public static (string key, string iv) GenerateKeyAndIV(int keySize = 256, int blockSize = 128)
        {
            using (Rijndael rijndaelAlg = new RijndaelManaged())
            {
                rijndaelAlg.KeySize = keySize;  // Set the desired key size (128, 192, or 256 bits)
                rijndaelAlg.BlockSize = blockSize; // Set the desired block size (128, 192, or 256 bits)
                rijndaelAlg.GenerateKey();      // Generate the key
                rijndaelAlg.GenerateIV();       // Generate the IV

                // Convert the key and IV to Base64 strings
                string base64Key = Convert.ToBase64String(rijndaelAlg.Key);
                string base64IV = Convert.ToBase64String(rijndaelAlg.IV);

                return (base64Key, base64IV);  // Return key and IV as a tuple
            }
        }

        /// <summary>
        ///  Encrypt method
        /// </summary>
        /// <param name="plainText"></param>
        /// <param name="key"></param>
        /// <param name="iv"></param>
        /// <returns>Encrypted String</returns>
        public static string Encrypt(string plainText, string key, string iv)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(plainText);
            byte[] keyBytes = Convert.FromBase64String(key);
            byte[] ivBytes = Convert.FromBase64String(iv);

            using (ICryptoTransform encryptor = _objRijndael.CreateEncryptor(keyBytes, ivBytes))
            {
                // Encrypt the bytes using Rijndael
                byte[] encryptedBytes = encryptor.TransformFinalBlock(bytes, 0, bytes.Length);

                // Convert the encrypted bytes to a Base64-encoded string
                return Convert.ToBase64String(encryptedBytes);
            }
        }

        /// <summary>
        /// Decrypt method
        /// </summary>
        /// <param name="cipherText"></param>
        /// <param name="key"></param>
        /// <param name="iv"></param>
        /// <returns>Decrypted string</returns>
        public static string Decrypt(string cipherText, string key, string iv)
        {
            byte[] bytes = Convert.FromBase64String(cipherText);
            byte[] keyBytes = Convert.FromBase64String(key);
            byte[] ivBytes = Convert.FromBase64String(iv);

            using (ICryptoTransform decryptor = _objRijndael.CreateDecryptor(keyBytes, ivBytes))
            {
                // Decrypt the bytes using Rijndael
                byte[] decryptedBytes = decryptor.TransformFinalBlock(bytes, 0, bytes.Length);

                // Convert the decrypted bytes to a UTF-8 encoded string
                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }
    }
}
