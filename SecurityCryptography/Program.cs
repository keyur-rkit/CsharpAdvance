using SecurityCryptography.BL;
using System.Security.Cryptography;

namespace SecurityCryptography
{
    /// <summary>
    /// Entry point
    /// </summary>
    public class Program
    {
        /// <summary>
        /// First method to execute
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.Write("Enter input : ");
            string inputData = Console.ReadLine();

            Console.WriteLine();

            // RSA
            Console.WriteLine("===RSA===");
            RunRSADemo(inputData);
            Console.WriteLine();

            // AES
            Console.WriteLine("===AES===");
            RunAESDemo(inputData);
            Console.WriteLine();

            // DES
            Console.WriteLine("===DES===");
            RunDESDemo(inputData);
            Console.WriteLine();

            // Rinjdeal
            Console.WriteLine("===Rinjdeal===");
            RunRijndaelDemo(inputData);
            Console.WriteLine();

        }

        /// <summary>
        /// method to run RSA methods
        /// </summary>
        /// <param name="inputData"></param>
        public static void RunRSADemo(string inputData)
        {
            // Generate a new RSA key pair
            using (RSACryptoServiceProvider objRsa = new RSACryptoServiceProvider(2048))
            {
                // Export the public and private keys as strings
                string publicKey = objRsa.ToXmlString(false); // False means we don't want the private key
                string privateKey = objRsa.ToXmlString(true);  // True means we want the private key

                string encryptedData = BLRSA.Encrypt(inputData, publicKey);
                Console.WriteLine("Encrypted Data : ");
                Console.WriteLine($"{encryptedData}");
                Console.WriteLine("Decrypted Data : ");
                Console.WriteLine($"{BLRSA.Decrypt(encryptedData, privateKey)}");
            }
        }

        /// <summary>
        /// method to run AES methods
        /// </summary>
        /// <param name="inputData"></param>
        public static void RunAESDemo(string inputData)
        {
            var (aesKey, aesIv) = BLAES.GenerateKeyAndIV(128);

            Console.WriteLine($"Key : {aesKey}");
            Console.WriteLine($"Iv : {aesIv}");
            string encryptedData = BLAES.Encrypt(inputData, aesKey, aesIv );
            Console.WriteLine("Encrypted Data : ");
            Console.WriteLine($"{encryptedData}");
            Console.WriteLine("Decrypted Data : ");
            Console.WriteLine($"{BLAES.Decrypt(encryptedData, aesKey, aesIv )}");
        }

        /// <summary>
        /// method to run DES methods
        /// </summary>
        /// <param name="inputData"></param>
        public static void RunDESDemo(string inputData)
        {
            var (desKey, desIv) = BLDES.GenerateKeyAndIV();

            Console.WriteLine($"Key : {desKey}");
            Console.WriteLine($"Iv : {desIv}");
            string encryptedData = BLDES.Encrypt(inputData, desKey, desIv);
            Console.WriteLine("Encrypted Data : ");
            Console.WriteLine($"{encryptedData}");
            Console.WriteLine("Decrypted Data : ");
            Console.WriteLine($"{BLDES.Decrypt(encryptedData, desKey, desIv)}");
        }

        /// <summary>
        /// method to run Rijndael methods
        /// </summary>
        /// <param name="inputData"></param>
        public static void RunRijndaelDemo(string inputData)
        {
            var (rijndaelKey, rijndaelIv) = BLRijndael.GenerateKeyAndIV();

            Console.WriteLine($"Key : {rijndaelKey}");
            Console.WriteLine($"Iv : {rijndaelIv}");
            string encryptedData = BLRijndael.Encrypt(inputData, rijndaelKey, rijndaelIv);
            Console.WriteLine("Encrypted Data : ");
            Console.WriteLine($"{encryptedData}");
            Console.WriteLine("Decrypted Data : ");
            Console.WriteLine($"{BLRijndael.Decrypt(encryptedData, rijndaelKey, rijndaelIv)}");
        }
    }
}

