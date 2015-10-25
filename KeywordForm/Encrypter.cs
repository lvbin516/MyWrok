using System;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.Globalization;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EncrypterUtils
{
    class Encrypter
    {

        private const string PUBLIC_KEY = "<RSAKeyValue><Modulus>yytjBPb8O9mel76GyWg9ifkU2bz4uV3clhfST7ebHttwLnwUVSPQSCQ1Zlbnhwgyv5iw9e03SYrptdH9dESqOUsgWVQpxqB5r/Uu3+BQPxeUEo9DhrvzPVkXRCRyhURGDk5Aq5siH7hNRiC2uUq8LaNKDNKMuLfWhe/cn2BZGgk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

        private const string DES_KEY = "yytjBPb8O9mel76GyWg9ifk5";

        private static string getSignUpContent(string userName, string email)
        {
            return userName + "&&&" + email + "!!!";
        }

        /// 验证签名
        public static bool VerifySigned(string plaintext, string SignedData, string publicKey)
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

        public static KeyValuePair<string, string> CreateRSAKey()
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            string privateKey = RSA.ToXmlString(true);
            string publicKey = RSA.ToXmlString(false);

            return new KeyValuePair<string, string>(publicKey, privateKey);
        }

        public static string byteToHexStr(byte[] bytes)
        {
            string hexStr = string.Empty;
            if (bytes != null && bytes.Length > 0)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    hexStr += bytes[i].ToString("X2");
                }
            }
            return hexStr;
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

        public static string getGUID()
        {
            Guid tempCartId = Guid.NewGuid();
            string uuid = tempCartId.ToString().Replace("-", "").ToUpper();
            return uuid;
        }

        public static string GetRawNumber(string uuid)
        {
            string rawNumber = "137524744" + uuid + "lim-ty";
            return rawNumber;
        }

        public static string getMD5(string content)
        {
            if (content == null || content.Trim().Length == 0)
            {
                return null;
            }
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] md5Data = md5.ComputeHash(Encoding.UTF8.GetBytes(content));
            return byteToHexStr(md5Data);
        }

        //RSA加密
        public static string RSAEncrypt(string privateKey, string content)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(privateKey);
            byte[] cipherbytes = rsa.Encrypt(Encoding.UTF8.GetBytes(content), false);
            return byteToHexStr(cipherbytes);
        }

        //RSA解密
        public static string RSADecrypt(string publicKey, string content)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(publicKey);
            byte[] cipherbytes = rsa.Decrypt(hexToToBytes(content), false);
            return Encoding.UTF8.GetString(cipherbytes);
        }

        //3DES加密
        public static string DES3Encrypt(string data, string key)
        {
            TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(key);
            DES.Mode = CipherMode.CBC;
            DES.Padding = PaddingMode.PKCS7;

            ICryptoTransform DESEncrypt = DES.CreateEncryptor();

            byte[] Buffer = Encoding.UTF8.GetBytes(data);
            byte[] result = DESEncrypt.TransformFinalBlock(Buffer, 0, Buffer.Length);
            return byteToHexStr(result);
        }

        //3DES解密
        public static string DES3Decrypt(string data, string key)
        {
            TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(key);
            DES.Mode = CipherMode.CBC;
            DES.Padding = System.Security.Cryptography.PaddingMode.PKCS7;

            ICryptoTransform DESDecrypt = DES.CreateDecryptor();

            try
            {
                byte[] Buffer = hexToToBytes(data);
                return Encoding.UTF8.GetString(DESDecrypt.TransformFinalBlock(Buffer, 0, Buffer.Length));
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static bool ValidateRawNumber(string rawNumber)
        {
            if (rawNumber == null || rawNumber.Trim().Length == 0)
            {
                return false;
            }
            rawNumber = rawNumber.Trim();
            if (!rawNumber.StartsWith("137524744") || !rawNumber.EndsWith("lim-ty"))
            {
                return false;
            }
            string middle = rawNumber.Substring("137524744".Length, rawNumber.IndexOf("lim-ty") - "137524744".Length);
            Regex rx = new Regex(@"^[a-zA-Z0-9]{10}@[a-zA-Z0-9]{22}$", RegexOptions.Compiled);
            return rx.IsMatch(middle);
        }

        public static bool ValidateSerialNumber(string serialNumber)
        {
            if (serialNumber == null || serialNumber.Trim().Length == 0 || serialNumber.Trim().Length != 64)
            {
                return false;
            }
            try
            {
                string md5 = serialNumber.Substring(0, 32);
                string uuid = serialNumber.Substring(32, 32);
                string rawNumber = GetRawNumber(uuid);
                string md5New = getMD5(rawNumber);
                if (md5New == null || md5New.Trim().Length == 0 || md5New.Trim().Length != 32)
                {
                    return false;
                }
                return md5New.Equals(md5);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
