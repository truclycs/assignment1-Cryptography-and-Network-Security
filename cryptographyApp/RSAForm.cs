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
    public partial class RSAForm : DevExpress.XtraEditors.XtraUserControl
    {
        private static RSAForm _instance;
        private RSACryptoServiceProvider rsa;

        public static RSAForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RSAForm();
                return _instance;
            }
        }

        public RSAForm()
        {
            InitializeComponent();
        }

        private void encryptFolder(string keyPath, string folderPath)
        {
            string encFolder = folderPath + "_enc";

            if (!Directory.Exists(encFolder))
                Directory.CreateDirectory(encFolder);

            FileInfo[] Files = new DirectoryInfo(folderPath).GetFiles();
            foreach (FileInfo file in Files)
            {
                string fileName = file.Name;
                encryptFile(keyPath, folderPath + "/" + file, encFolder + "/" + file + ".enc");
            }
        }

        private void decryptFolder(string keyPath, string folderPath)
        {
            string encFolder = folderPath + "_dec";

            if (!Directory.Exists(encFolder))
                Directory.CreateDirectory(encFolder);

            FileInfo[] Files = new DirectoryInfo(folderPath).GetFiles();
            foreach (FileInfo file in Files)
            {
                string fileName = file.Name;
                decryptFile(keyPath, folderPath + "/" + file, encFolder + "/" + file + ".dec");
            }
        }

        private void encryptFile(string keyPath, string filePath, string outputPath)
        {
            rsa.FromXmlString(File.ReadAllText(keyPath));

            FileStream fsInput = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            FileStream fsOutput = new FileStream(outputPath, FileMode.Create, FileAccess.Write);
            fsOutput.SetLength(0);

            byte[] bin, encryptedData;
            long rdlen = 0;
            long totlen = fsInput.Length;
            int len;

            int maxByte = ((rsa.KeySize - 384) / 8) + 37;

            progressBarControl1.Properties.Step = 1;
            progressBarControl1.Properties.PercentView = true;
            progressBarControl1.Properties.Maximum = (int)(totlen + maxByte - 1) / maxByte;
            progressBarControl1.Properties.Minimum = 0;

            while (rdlen < totlen)
            {
                bin = new byte[maxByte];
                len = fsInput.Read(bin, 0, maxByte);
                encryptedData = rsa.Encrypt(bin, false);
                fsOutput.Write(encryptedData, 0, encryptedData.Length);
                rdlen += len;
                progressBarControl1.PerformStep();
                progressBarControl1.Update();

            }

            fsOutput.Close();
            fsInput.Close();
        }

        private void decryptFile(string keyPath, string filePath, string outputPath)
        {
            rsa.FromXmlString(File.ReadAllText(keyPath));

            FileStream fsInput = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            FileStream fsOutput = new FileStream(outputPath, FileMode.Create, FileAccess.Write);
            fsOutput.SetLength(0);

            byte[] bin, encryptedData;
            long rdlen = 0;
            long totlen = fsInput.Length;
            int len;

            int maxByte = rsa.KeySize / 8;

            progressBarControl1.Properties.Step = 1;
            progressBarControl1.Properties.PercentView = true;
            progressBarControl1.Properties.Maximum = (int)(totlen + maxByte - 1) / maxByte;
            progressBarControl1.Properties.Minimum = 0;

            while (rdlen < totlen)
            {
                bin = new byte[maxByte];
                len = fsInput.Read(bin, 0, maxByte);

                encryptedData = rsa.Decrypt(bin, false);
                fsOutput.Write(encryptedData, 0, encryptedData.Length);
                rdlen += len;
                progressBarControl1.PerformStep();
                progressBarControl1.Update();
            }

            fsOutput.Close();
            fsInput.Close();
        }

        private void RSAForm_Load(object sender, EventArgs e)
        {
            rsa = new RSACryptoServiceProvider(1024);
            boxLength.Properties.Items.Add("1024bits");
            boxLength.Properties.Items.Add("2048bits");
            boxLength.Properties.Items.Add("4096bits");

            boxLength.Text = "1024bits";

        }

        private void genKey_Click(object sender, EventArgs e)
        {
            if (boxLength.Text == "1024bits")
                rsa = new RSACryptoServiceProvider(1024);
            else if (boxLength.Text == "2048bits")
                rsa = new RSACryptoServiceProvider(2048);
            else
                rsa = new RSACryptoServiceProvider(4096);

            string dir = Form1.Instance.getFolder();
            if (dir == null)
                return;

            File.WriteAllText(dir + "/RSA.pubkey", rsa.ToXmlString(false));
            File.WriteAllText(dir + "/RSA.prikey", rsa.ToXmlString(true));
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn)
                textPath.Text = Form1.Instance.getFolder();
            else
                textPath.Text = Form1.Instance.getFile();
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn)
                encryptFolder(keyPath.Text, textPath.Text);
            else
                encryptFile(keyPath.Text, textPath.Text, textPath.Text + ".enc");
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn)
                decryptFolder(keyPath.Text, textPath.Text);
            else
                decryptFile(keyPath.Text, textPath.Text, textPath.Text + ".dec");
        }

        private void importKey_Click(object sender, EventArgs e)
        {
            keyPath.Text = Form1.Instance.getFile();
        }
    }
}
