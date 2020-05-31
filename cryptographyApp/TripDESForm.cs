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
    public partial class TripDESForm : DevExpress.XtraEditors.XtraUserControl
    {
        private static TripDESForm _instance;
        private TripleDES des;

        public static TripDESForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TripDESForm();
                return _instance;
            }
        }

        public TripDESForm()
        {
            InitializeComponent();
            des = TripleDES.Create();
        }

        private void encryptFolder(string keyPath, string folderPath, string mode)
        {
            string encFolder = folderPath + "_enc";

            if (!Directory.Exists(encFolder))
                Directory.CreateDirectory(encFolder);

            FileInfo[] Files = new DirectoryInfo(folderPath).GetFiles();
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

        public void encryptFile(String inputFile, String outputFile, String key, String mode)
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

            des.Key = Convert.FromBase64String(key);
            if (mode == "ECB")
                des.Mode = CipherMode.ECB;
            else if (mode == "CBC")
                des.Mode = CipherMode.CBC;
            else if (mode == "CFB")
                des.Mode = CipherMode.CFB;
            else if (mode == "CTS")
                des.Mode = CipherMode.CTS;
            else
                des.Mode = CipherMode.OFB;

            CryptoStream cryptStream = new CryptoStream(fsOutput, des.CreateEncryptor(), CryptoStreamMode.Write);

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

            des.Key = Convert.FromBase64String(key);
            if (mode == "ECB")
                des.Mode = CipherMode.ECB;
            else if (mode == "CBC")
                des.Mode = CipherMode.CBC;
            else if (mode == "CFB")
                des.Mode = CipherMode.CFB;
            else if (mode == "CTS")
                des.Mode = CipherMode.CTS;
            else
                des.Mode = CipherMode.OFB;

            CryptoStream cryptStream = new CryptoStream(fsOutput, des.CreateDecryptor(), CryptoStreamMode.Write);

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

        private void DESForm_Load(object sender, EventArgs e)
        {
            boxMode.Properties.Items.Add("CBC");
            boxMode.Properties.Items.Add("CFB");
            boxMode.Properties.Items.Add("CTS");
            boxMode.Properties.Items.Add("ECB");
            boxMode.Properties.Items.Add("OFB");

            boxMode.Text = "CBC";
        }

        private void genKey_Click(object sender, EventArgs e)
        {
            des.GenerateKey();
            textKey.Text = Convert.ToBase64String(des.Key);
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
