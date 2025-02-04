using System.Security.Cryptography;
using System.Text;

namespace SecurityCryptography.BL
{
    /// <summary>
    /// Class with RSA relaed methods
    /// </summary>
    public class BLRSA
    {
        /// <summary>
        /// Encrypt method
        /// </summary>
        /// <param name="data"></param>
        /// <param name="publicKey"></param>
        /// <returns>Encrypted string</returns>
        static public string Encrypt(string data, string publicKey)
        {
            try
            {
                string encryptedData;
                byte[] bytes = Encoding.UTF8.GetBytes(data);

                using (RSACryptoServiceProvider objRsa = new RSACryptoServiceProvider())
                {
                    objRsa.FromXmlString(publicKey); // Load the public key

                    byte[] encryptedBytes = objRsa.Encrypt(bytes, false); // false means we are using the default padding (PKCS1)
                    encryptedData = Convert.ToBase64String(encryptedBytes);
                }
                return encryptedData;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Decrypt Method
        /// </summary>
        /// <param name="data"></param>
        /// <param name="privateKey"></param>
        /// <returns>Decrypted streing</returns>
        static public string Decrypt(string data, string privateKey)
        {
            try
            {
                string decryptedData;
                byte[] bytes = Convert.FromBase64String(data);

                using (RSACryptoServiceProvider objRsa = new RSACryptoServiceProvider())
                {
                    objRsa.FromXmlString(privateKey);
                    byte[] decryptedBytes = objRsa.Decrypt(bytes, false); // false means we are using the default padding (PKCS1)
                    decryptedData = Encoding.UTF8.GetString(decryptedBytes);
                }
                return decryptedData;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
