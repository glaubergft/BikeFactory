using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesFactoryBusinessLayer
{
    public static class Security
    {
        public static User CurrentUser = null;

        public static string ComputeHash(string text)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(text);
            SHA1CryptoServiceProvider provider = new SHA1CryptoServiceProvider();
            return BitConverter.ToString(provider.ComputeHash(buffer)).Replace("-", "");
        }
    }
}
