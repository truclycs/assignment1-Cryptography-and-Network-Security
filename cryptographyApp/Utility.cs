using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cryptographyApp
{
    class Utility
    {
        public static String readFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            string data = "";
            int blockSize = 4 * 1024;
            int nBlocks = (int)(fs.Length + blockSize - 1) / blockSize;

            while (nBlocks-- > 0)
            {
                byte[] input = br.ReadBytes(8);
                for (int i = 0; i < input.Length; i++)
                    data += input[i];
            }
            br.Close();
            return data;
        }

        public static string byteArrayToHex(byte[] data)
        {
            StringBuilder returnValue = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                returnValue.Append(data[i].ToString("X").PadLeft(2, '0'));
            }
            return returnValue.ToString();
        }
    }
}
