using System.Security.Cryptography;
using System.Text;

namespace SecurityCryptography.BL
{
    /// <summary>
    /// Class to contain method related to des
    /// </summary>
    public class BLDES
    {
        private static DESCryptoServiceProvider _objDes = new DESCryptoServiceProvider();

        /// <summary>
        /// Method to generate a random DES key and IV
        /// </summary>
        /// <returns>key and iv</returns>
        public static (string key, string iv) GenerateKeyAndIV()
        {
            using (DES desAlg = DES.Create())
            {
                desAlg.GenerateKey();      // Generate the key
                desAlg.GenerateIV();       // Generate the IV

                // Convert the key and IV to Base64 strings
                string base64Key = Convert.ToBase64String(desAlg.Key);
                string base64IV = Convert.ToBase64String(desAlg.IV);

                return (base64Key, base64IV);  // Return key and IV as a tuple
            }
        }

        /// <summary>
        /// Encrypt method
        /// </summary>
        /// <param name="plainText"></param>
        /// <param name="key"></param>
        /// <param name="iv"></param>
        /// <returns>Encrypted string</returns>
        public static string Encrypt(string plainText, string key, string iv)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(plainText);
            byte[] keyBytes = Convert.FromBase64String(key);
            byte[] ivBytes = Convert.FromBase64String(iv);

            using (ICryptoTransform encript = _objDes.CreateEncryptor(keyBytes, ivBytes))
            {
                // Encrypt the bytes using DES
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

            using (ICryptoTransform decript = _objDes.CreateDecryptor(keyBytes, ivBytes))
            {
                // Decrypt the bytes using DES
                byte[] decriptBytes = decript.TransformFinalBlock(bytes, 0, bytes.Length);

                // Convert the decrypted bytes to a UTF-8 encoded string
                return Encoding.UTF8.GetString(decriptBytes);
            }
        }
    }
}
