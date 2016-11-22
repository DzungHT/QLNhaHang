using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CybertronFramework.Helper
{
    /// <summary>
    /// Lớp hỗ trợ xử lý với chuỗi
    /// </summary>
    public static class StringHelper
    {
        /// <summary>
        /// Mã hóa chuỗi truyền vào thành chuỗi MD5
        /// </summary>
        /// <param name="title">Chuỗi muốn mã hóa.</param>
        /// <returns>Chuỗi md5 được mã hóa từ chuỗi truyền vào</returns>
        public static string ToMD5(this string title)
        {
            // Tạo một đối tượng MD5
            MD5 md5 = MD5.Create();
            byte[] bHash = md5.ComputeHash(Encoding.Default.GetBytes(title));

            // Ghép mảng Byte MD5 lại thành chuỗi các kí tự thập lục phân => output 32 ký tự hexa
            StringBuilder sbHash = new StringBuilder();
            foreach (byte b in bHash)
            {
                sbHash.Append(b.ToString("x2"));
            }
            return sbHash.ToString();
        }

        /// <summary>
        /// So sánh 2 chuỗi. trong đó chuỗi truyền vào đã được mã hóa MD5
        /// </summary>
        /// <param name="title">Chuỗi muốn so sánh</param>
        /// <param name="md5String">Chuỗi so sánh đã được mã hóa MD5</param>
        /// <returns>True: Nếu 2 chuỗi giống nhau và ngược lại.</returns>
        public static bool VerifyMD5(this string title, string md5String)
        {
            // Tạo ra một StringComparer để so sánh 2 chuỗi.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(title.ToMD5(), md5String))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Kiểm tra một chuỗi có đúng định dạng email hay không?
        /// </summary>
        /// <param name="text">Chuỗi muốn kiểm tra</param>
        /// <returns>True: Nếu chuỗi kiểm tra đúng định dạng email.</returns>
        public static bool IsEmailFormat(this string text)
        {
            string emailFormat = @"([a-zA-Z_0-9]+@)([a-zA-Z0-9]+\.)([a-zA-Z0-9]+\z)";
            Regex regex = new Regex(emailFormat);
            var m = regex.Match(text);

            if (m.Success)
            {
                return text.Length == m.Length;
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool HasSpecialChar(this string text)
        {
            string emailFormat = @"([\s]+\z)";
            Regex regex = new Regex(emailFormat);
            var m = regex.Match(text);

            if (m.Success)
            {
                return text.Length == m.Length;
            }
            return false;
        }
    }
}
