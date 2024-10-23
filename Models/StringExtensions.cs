using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_Core.Models
{
    public static class StringExtensions
    {
        public static string ToUTF8(this string text)
        {
            return System.Text.Encoding.UTF8.GetString(System.Text.Encoding.Default.GetBytes(text));
        }
    }
}