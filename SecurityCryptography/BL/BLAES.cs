using System.Security.Cryptography;
using System.Text;

namespace SecurityCryptography.BL
{
    /// <summary>
    /// class for method related to AES
    /// </summary>
    public class BLAES
    {
        private static AesCryptoServiceProvider _objAes = new AesCryptoServiceProvider();

        /// <summary>
        /// Method to generate a random AES key and IV
        /// </summary>
        /// <param name="keySize"></param>
        /// <returns>key and iv</returns>
        public static (string key, string iv) GenerateKeyAndIV(int keySize = 128)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.KeySize = keySize;  // Set the desired key size (128, 192, or 256 bits)
                aesAlg.GenerateKey();      // Generate the key
                aesAlg.GenerateIV();       // Generate the IV

                // Convert the key and IV to Base64 strings
                string base64Key = Convert.ToBase64String(aesAlg.Key);
                string base64IV = Convert.ToBase64String(aesAlg.IV);

                return (base64Key, base64IV);  // Return key and IV as a tuple
            }
        }

        /// <summary>
        /// Encrypt method
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

            using (ICryptoTransform encript = _objAes.CreateEncryptor(keyBytes, ivBytes))
            {
                // Encrypt the bytes using AES
                byte[] encriptedBytes = encript.TransformFinalBlock(bytes, 0, bytes.Length);

                // Convert the encrypted bytes to a Base64-encoded string
                return Convert.ToBase64String(encriptedBytes);
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

            using (ICryptoTransform decript = _objAes.CreateDecryptor(keyBytes, ivBytes))
            {
                // Decrypt the bytes using AES
                byte[] decriptBytes = decript.TransformFinalBlock(bytes, 0, bytes.Length);

                // Convert the decrypted bytes to a UTF-8 encoded string
                return Encoding.UTF8.GetString(decriptBytes);
            }

        }
    }
}