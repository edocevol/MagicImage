using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace QCloud.PicApi.Common
{
    public class Sign
    {
        private static string Signature(int appId, string secretId, string secretKey, long expired, string fileId, string bucketName)
        {
            if (secretId == "" || secretKey == "")
            {
                return "-1";
            }
            var now = DateTime.Now.ToUnixTime() / 1000;
            var rand = new Random();
            var rdm = rand.Next(Int32.MaxValue);
            var plainText = "a=" + appId + "&k=" + secretId + "&e=" + expired + "&t=" + now + "&r=" + rdm + "&f=" + fileId + "&b=" + bucketName;

            using (HMACSHA1 mac = new HMACSHA1(Encoding.UTF8.GetBytes(secretKey)))
            {
                var hash = mac.ComputeHash(Encoding.UTF8.GetBytes(plainText));
                var pText = Encoding.UTF8.GetBytes(plainText);
                var all = new byte[hash.Length + pText.Length];
                Array.Copy(hash, 0, all, 0, hash.Length);
                Array.Copy(pText, 0, all, hash.Length, pText.Length);
                return Convert.ToBase64String(all);
            }
        }

        public static string DetectionSignature(int appId, string secretId, string secretKey, long expired, string bucketName, string url = null)
        {
            if (secretId == "" || secretKey == "")
            {
                return "-1";
            }
            var now = DateTime.Now.ToUnixTime() / 1000;
            //var plainText = string.Format("a={0}&b={1}&k={2}&t={3}&e={4}&l={5}", appId, bucketName, secretId, now, expired, System.Web.HttpUtility.UrlEncode(url));
            var plainText = string.Format("a={0}&b={1}&k={2}&t={3}&e={4}", appId, bucketName, secretId, now, expired);

            using (HMACSHA1 mac = new HMACSHA1(Encoding.UTF8.GetBytes(secretKey)))
            {
                var hash = mac.ComputeHash(Encoding.UTF8.GetBytes(plainText));
                var pText = Encoding.UTF8.GetBytes(plainText);
                var all = new byte[hash.Length + pText.Length];
                Array.Copy(hash, 0, all, 0, hash.Length);
                Array.Copy(pText, 0, all, hash.Length, pText.Length);
                return Convert.ToBase64String(all);
            }
        }

        public static string Signature(int appId, string secretId, string secretKey, long expired, string bucketName)
        {
            return Signature(appId, secretId, secretKey, expired, "", bucketName);
        }

        public static string SignatureOnce(int appId, string secretId, string secretKey, string bucketName, string fileId)
        {
            return Signature(appId, secretId, secretKey, 0, fileId, bucketName);
        }
    }
}
