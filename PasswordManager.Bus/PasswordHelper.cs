using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Bus
{
public static   class PasswordHelper
    {
        public static string HashUserPwd(string userPwd)
        {
            byte[] myChar = Encoding.ASCII.GetBytes(userPwd);
            SHA256Managed hasher = new SHA256Managed();
            byte[] enChar = hasher.ComputeHash(myChar);

            string crytoData = string.Empty;

            foreach (var item in enChar)
            {
                crytoData += string.Format("{0:X2}", item);
            }
            return crytoData;
        }

    }
}
