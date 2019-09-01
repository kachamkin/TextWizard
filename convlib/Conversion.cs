using System;
using System.Text;
using System.Web;

namespace convlib
{
    public static class Conversion
    {
        public static string ConvertString(string data, string type, string encoding = "UTF-8")
        {
            if (string.IsNullOrEmpty(data))
                return string.Empty;

            Encoding enc = Encoding.GetEncoding(encoding);
            switch (type)
            {
                case "To Base64":
                    return Convert.ToBase64String(enc.GetBytes(data));
                case "From Base64":
                    return enc.GetString(Convert.FromBase64String(data));
                case "To bytes":
                    return BitConverter.ToString(enc.GetBytes(data));
                case "From bytes":
                    return enc.GetString(HexStringToByteArray(data));
                case "URL encode":
                    return HttpUtility.UrlEncode(data, enc);
                case "URL decode":
                    return HttpUtility.UrlDecode(data, enc);
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
    }
}
