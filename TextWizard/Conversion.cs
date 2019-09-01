using System;
using System.Text;
using System.Web;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.IO;
using System.IO.Compression;

namespace TextWizard
{
    public static class Conversion
    {
        public static string ConvertString(string data, string type, string encoding = "UTF-8")
        {
            if (string.IsNullOrEmpty(data) || string.IsNullOrEmpty(type))
                return string.Empty;

            Encoding enc = Encoding.GetEncoding(encoding);
            switch (type)
            {
                case "To Base64":
                    return Convert.ToBase64String(enc.GetBytes(data));
                case "From Base64":
                    return enc.GetString(Convert.FromBase64String(data));
                case "To Hex":
                    return BitConverter.ToString(enc.GetBytes(data));
                case "From Hex":
                    return enc.GetString(HexStringToByteArray(data));
                case "URL encode":
                    return HttpUtility.UrlEncode(data, enc);
                case "URL decode":
                    return HttpUtility.UrlDecode(data, enc);
                case "HTML encode":
                    return HttpUtility.HtmlEncode(data);
                case "HTML decode":
                    return HttpUtility.HtmlDecode(data);
                case "To JS string":
                    return HttpUtility.JavaScriptStringEncode(data);
                case "From JS string":
                    return Uri.UnescapeDataString(Regex.Unescape(data));
                case "To UTF-7":
                    return enc.GetString(Encoding.Convert(enc, Encoding.UTF7, enc.GetBytes(data)));
                case "From UTF-7":
                    return enc.GetString(Encoding.Convert(Encoding.UTF7, enc, enc.GetBytes(data)));
                case "To deflated SAML":
                    return EncodeSAMLRequestString(data, enc);
                case "From deflated SAML":
                    return DecodeSAMLRequestString(data, enc);
                case "To MD5":
                    using (MD5 p = MD5.Create())
                    {
                        byte[] hash = p.ComputeHash(enc.GetBytes(data));
                        return BitConverter.ToString(hash) + "\r\n\r\n" + Convert.ToBase64String(hash);
                    };
                case "To SHA1":
                    using (SHA1 p = SHA1.Create())
                    {
                        byte[] hash = p.ComputeHash(enc.GetBytes(data));
                        return BitConverter.ToString(hash) + "\r\n\r\n" + Convert.ToBase64String(hash);
                    };
                case "To SHA256":
                    using (SHA256 p = SHA256.Create())
                    {
                        byte[] hash = p.ComputeHash(enc.GetBytes(data));
                        return BitConverter.ToString(hash) + "\r\n\r\n" + Convert.ToBase64String(hash);
                    };
                case "To SHA384":
                    using (SHA384 p = SHA384.Create())
                    {
                        byte[] hash = p.ComputeHash(enc.GetBytes(data));
                        return BitConverter.ToString(hash) + "\r\n\r\n" + Convert.ToBase64String(hash);
                    };
                case "To SHA512":
                    using (SHA512 p = SHA512.Create())
                    {
                        byte[] hash = p.ComputeHash(enc.GetBytes(data));
                        return BitConverter.ToString(hash) + "\r\n\r\n" + Convert.ToBase64String(hash);
                    };
                default:
                    return data;
            }
        }

        private static byte[] HexStringToByteArray(string hexString)
        {
            hexString = hexString.Replace("-", "").Replace(" ", "");
            byte[] HexAsBytes = new byte[hexString.Length / 2];
            for (int index = 0; index < HexAsBytes.Length; index++)
            {
                string byteValue = hexString.Substring(index * 2, 2);
                HexAsBytes[index] = byte.Parse(byteValue, System.Globalization.NumberStyles.HexNumber);
            }

            return HexAsBytes;
        }

        private static string DecodeSAMLRequestString(string compressedData, Encoding enc)
        {
            using (DeflateStream deflate = new DeflateStream(new MemoryStream(Convert.FromBase64String(HttpUtility.UrlDecode(compressedData, enc))), CompressionMode.Decompress))
            {
                using (StreamReader reader = new StreamReader(deflate, enc))
                    return HttpUtility.UrlDecode(reader.ReadToEnd());
            }
        }

        private static string EncodeSAMLRequestString(string data, Encoding enc)
        {
            using (MemoryStream source = new MemoryStream(enc.GetBytes(HttpUtility.UrlEncode(data, enc))))
            {
                using (MemoryStream dest = new MemoryStream())
                {
                    using (DeflateStream deflate = new DeflateStream(dest, CompressionMode.Compress))
                    {
                        source.CopyTo(deflate);
                        deflate.Close();
                        return HttpUtility.UrlEncode(Convert.ToBase64String(dest.ToArray()), enc);
                    }
                }
            }
        }

    }
}