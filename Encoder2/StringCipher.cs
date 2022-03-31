using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Linq;

// class Sample {
//   static void Main() {
//     string plaintext = "YOUR_PASSWORD"; // Необходимый текст.
    
//     try {
//         // Пример шифрования:
//         string encryptedstring = ExternalUtils.StringCipher.Encrypt(plaintext, "fpteJEI3");
//         Console.WriteLine("Encrypted string:");
//         Console.WriteLine(encryptedstring);
//         Console.WriteLine("");
 
//         // Пример дешифрования:
//         string decryptedstring = ExternalUtils.StringCipher.Decrypt(encryptedstring, "fpteJEI3");
//         Console.WriteLine("Decrypted string:");
//         Console.WriteLine(decryptedstring);
//         Console.WriteLine("");
//     } catch (Exception e) {
//         Console.WriteLine("Unexpected error.");
//     } finally {
//         Console.WriteLine("Press any key to exit...");
//         Console.ReadLine();
//     }
//   }
// }

namespace ExternalUtils
{
    public static class StringCipher
    {
    	// Эта константа используется для определения размера ключа алгоритма шифрования в битах.
        // Мы делим это на 8 в приведенном ниже коде, чтобы получить эквивалентное количество байтов. 
        private const int Keysize = 256;
    
        // Эта константа определяет количество итераций для функции генерации байтов пароля. 
        private const int DerivationIterations = 1000;
    
        public static string Encrypt(string plainText, string passPhrase)
        {
    		// Соль и IV генерируются каждый раз случайным образом, но предваряются зашифрованным шифротекстом
            // чтобы при расшифровке можно было использовать одни и те же значения Salt и IV. 
            var saltStringBytes = Generate256BitsOfRandomEntropy();
            var ivStringBytes = Generate256BitsOfRandomEntropy();
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                // Создаем конечные байты как конкатенацию случайных байтов соли, случайных байтов iv и байтов шифра. 
                                var cipherTextBytes = saltStringBytes;
                                cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Convert.ToBase64String(cipherTextBytes);
                            }
                        }
                    }
                }
            }
        }
    
        public static string Decrypt(string cipherText, string passPhrase)
        {
    		// Получить полный поток байтов, который представляет:
            // [32 байта Salt] + [32 байта IV] + [n байтов CipherText] 
            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
            // Получь байты соли, извлекая первые 32 байта из предоставленных байтов cipherText.
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
            // Получить байты IV, извлекая следующие 32 байта из предоставленных байтов cipherText.
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
            // Получить фактические байты зашифрованного текста, удалив первые 64 байта из строки cipherText.
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();
    
            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream(cipherTextBytes))
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                            {
                                var plainTextBytes = new byte[cipherTextBytes.Length];
                                var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                            }
                        }
                    }
                }
            }
        }
    
        private static byte[] Generate256BitsOfRandomEntropy()
        {
            var randomBytes = new byte[32]; // 32 байта дадут нам 256 бит.
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
    			// Заполнить массив криптографически безопасными случайными байтами. 
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }
    } 
}