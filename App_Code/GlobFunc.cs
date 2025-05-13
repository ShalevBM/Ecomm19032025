using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecomm19032025
{
    public class GlobFunc
    {
        public static string GetRandStr(int length)
        {
            string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            Random rnd = new Random();
            string str = "";
            for (int j = 0; j < length; j++)
            {
                int index = rnd.Next(chars.Length);
                str += chars[index];
            }
            return str;
        }
    }
}