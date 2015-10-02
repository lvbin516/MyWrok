using System;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.Globalization;
using System.Xml.Linq;
using System.Collections.Generic;

namespace EncrypterUtils
{
    class Encrypter
    {

        private const string PUBLIC_KEY = "<RSAKeyValue><Modulus>yytjBPb8O9mel76GyWg9ifkU2bz4uV3clhfST7ebHttwLnwUVSPQSCQ1Zlbnhwgyv5iw9e03SYrptdH9dESqOUsgWVQpxqB5r/Uu3+BQPxeUEo9DhrvzPVkXRCRyhURGDk5Aq5siH7hNRiC2uUq8LaNKDNKMuLfWhe/cn2BZGgk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

        public static bool verifySigned(string userName, string email, string signedData)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(signedData))
            {
                return false;
            }
            string plainText = getSignUpContent(userName, email);
            return verifySigned0(plainText, signedData, PUBLIC_KEY);
        }

        private static string getSignUpContent(string userName, string email)
        {
            return userName + "&&&" + email + "!!!";
        }

        /// 验证签名
        private static bool verifySigned0(string plaintext, string SignedData, string publicKey)
        {
            using (RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider())
            {
                RSAalg.FromXmlString(publicKey);
                UnicodeEncoding ByteConverter = new UnicodeEncoding();
                byte[] dataToVerifyBytes = ByteConverter.GetBytes(plaintext);
                byte[] signedDataBytes = hexToToBytes(SignedData);
                return RSAalg.VerifyData(dataToVerifyBytes, new SHA1CryptoServiceProvider(), signedDataBytes);
            }
        }

        private static byte[] hexToToBytes(string hexStr)
        {
            hexStr = hexStr.Replace(" ", "");
            if ((hexStr.Length % 2) != 0)
                hexStr += " ";
            byte[] returnBytes = new byte[hexStr.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
            {
                returnBytes[i] = Convert.ToByte(hexStr.Substring(i * 2, 2), 16);
            }
            return returnBytes;
        }

    }
}
