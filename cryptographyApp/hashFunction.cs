using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Numerics;

namespace cryptographyApp
{
    class hashFunction
    {
        public static string hash(string data, HashAlgorithm hashFunction)
        {
            byte[] hashData = hashFunction.ComputeHash(ASCIIEncoding.Default.GetBytes(data));
            StringBuilder returnValue = new StringBuilder();
            for (int i = 0; i < hashData.Length; i++)
            {
                returnValue.Append(hashData[i].ToString("X"));
            }
            return returnValue.ToString().PadLeft(32, '0');
        }
    }
}
