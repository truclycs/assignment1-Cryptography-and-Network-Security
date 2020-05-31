using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Security.Cryptography;

namespace cryptographyApp
{
    public partial class AESForm : DevExpress.XtraEditors.XtraUserControl
    {
        
        private static AESForm _instance;
        private Aes aes;

        public static AESForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AESForm();
                return _instance;
            }
        }

        public AESForm()
        {
            InitializeComponent();
            aes = Aes.Create();
        }

        private void encryptFolder(string keyPath, string folderPath, string mode)
        {
            string encFolder = folderPath + "_enc";

            if (!Directory.Exists(encFolder))
                Directory.CreateDirectory(encFolder);

            FileInfo[] Files = new DirectoryInfo(folderPath) .GetFiles();
            foreach (FileInfo file in Files)
            {
                string fileName = file.Name;
                encryptFile(folderPath + "/" + file, encFolder + "/" + file + ".enc", keyPath, mode);
            }
        }

        private void decryptFolder(string keyPath, string folderPath, string mode)
        {
            string encFolder = folderPath + "_dec";

            if (!Directory.Exists(encFolder))
                Directory.CreateDirectory(encFolder);

            FileInfo[] Files = new DirectoryInfo(folderPath).GetFiles();
            foreach (FileInfo file in Files)
            {
                string fileName = file.Name;
                decryptFile(folderPath + "/" + file, encFolder + "/" + file + ".dec", keyPath, mode);
            }
        }

        public void encryptFile(string inputFile, string outputFile, string key, string mode)
        {
            FileStream fsInput = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
            FileStream fsOutput = new FileStream(outputFile, FileMode.Create, FileAccess.Write);
            fsOutput.SetLength(0);

            byte[] bin = new byte[key.Length];
            long rdlen = 0;
            long totlen = fsInput.Length;
            int len;

            progressBarControl1.Properties.Step = 1;
            progressBarControl1.Properties.PercentView = true;
            progressBarControl1.Properties.Maximum = (int)(totlen + key.Length - 1) / key.Length;
            progressBarControl1.Properties.Minimum = 0;

            aes.Key = Convert.FromBase64String(key);
            aes.IV = ASCIIEncoding.ASCII.GetBytes(key.Substring(0, 16));
            if (mode == "ECB")
                aes.Mode = CipherMode.ECB;
            else if (mode == "CBC")
                aes.Mode = CipherMode.CBC;
            else if (mode == "CFB")
                aes.Mode = CipherMode.CFB;
            else if (mode == "CTS")
                aes.Mode = CipherMode.CTS;
            else
                aes.Mode = CipherMode.OFB;

            CryptoStream cryptStream = new CryptoStream(fsOutput, aes.CreateEncryptor(), CryptoStreamMode.Write);

            while (rdlen < totlen)
            {
                len = fsInput.Read(bin, 0, key.Length);
                cryptStream.Write(bin, 0, len);
                rdlen += len;
                progressBarControl1.PerformStep();
                progressBarControl1.Update();
            }

            cryptStream.Close();
            fsInput.Close();
            fsOutput.Close();
        }

        public void decryptFile(String inputFile, String outputFile, String key, String mode)
        {
            FileStream fsInput = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
            FileStream fsOutput = new FileStream(outputFile, FileMode.Create, FileAccess.Write);
            fsOutput.SetLength(0);

            byte[] bin = new byte[key.Length];
            long rdlen = 0;
            long totlen = fsInput.Length;
            int len;

            progressBarControl1.Properties.Step = 1;
            progressBarControl1.Properties.PercentView = true;
            progressBarControl1.Properties.Maximum = (int)(totlen + key.Length - 1) / key.Length;
            progressBarControl1.Properties.Minimum = 0;

            aes.Key = Convert.FromBase64String(key);
            aes.IV = ASCIIEncoding.ASCII.GetBytes(key.Substring(0, 16));
            if (mode == "ECB")
                aes.Mode = CipherMode.ECB;
            else if (mode == "CBC")
                aes.Mode = CipherMode.CBC;
            else if (mode == "CFB")
                aes.Mode = CipherMode.CFB;
            else if (mode == "CTS")
                aes.Mode = CipherMode.CTS;
            else
                aes.Mode = CipherMode.OFB;

            CryptoStream cryptStream = new CryptoStream(fsOutput, aes.CreateDecryptor(), CryptoStreamMode.Write);

            while (rdlen < totlen)
            {
                len = fsInput.Read(bin, 0, key.Length);
                cryptStream.Write(bin, 0, len);
                rdlen += len;
                progressBarControl1.PerformStep();
                progressBarControl1.Update();
            }

            cryptStream.Close();
            fsInput.Close();
            fsOutput.Close();
        }

        private void AESForm_Load(object sender, EventArgs e)
        {
            boxMode.Properties.Items.Add("CBC");
            boxMode.Properties.Items.Add("CFB");
            boxMode.Properties.Items.Add("CTS");
            boxMode.Properties.Items.Add("ECB");
            boxMode.Properties.Items.Add("OFB");

            boxMode.Text = "CBC";

            boxLength.Properties.Items.Add("128bits");
            boxLength.Properties.Items.Add("192bits");
            boxLength.Properties.Items.Add("256bits");

            boxLength.Text = "256bits";
        }

        private void genKey_Click(object sender, EventArgs e)
        {
            if (boxLength.Text == "128bits")
                aes.KeySize = 128;
            else if (boxLength.Text == "256bits")
                aes.KeySize = 256;
            else
                aes.KeySize = 192;
            aes.GenerateKey();
            textKey.Text = Convert.ToBase64String(aes.Key);
        }

        private void openFile1_Click(object sender, EventArgs e)
        {
            if (toggle.IsOn)
                textPath.Text = Form1.Instance.getFolder();
            else
                textPath.Text = Form1.Instance.getFile();
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            if (toggle.IsOn)
                encryptFolder(textKey.Text, textPath.Text, boxMode.Text);
            else
                encryptFile(textPath.Text, textPath.Text + ".enc", textKey.Text, boxMode.Text);
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            if (toggle.IsOn)
                decryptFolder(textKey.Text, textPath.Text, boxMode.Text);
            else
                decryptFile(textPath.Text, textPath.Text + ".dec", textKey.Text, boxMode.Text);
        }

    }
}
