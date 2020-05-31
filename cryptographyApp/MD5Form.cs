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
using System.Security.Cryptography;

namespace cryptographyApp
{
    public partial class MD5Form : DevExpress.XtraEditors.XtraUserControl
    {
        private static MD5Form _instance;
        private bool _isText = true;


        public static MD5Form Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MD5Form();
                return _instance;
            }
        }

        public MD5Form()
        {
            InitializeComponent();
        }

        private string hash(string data, Object a)
        {
            MD5 hashFunction = MD5.Create();
            byte[] hashData = hashFunction.ComputeHash(ASCIIEncoding.Default.GetBytes(data));
            StringBuilder returnValue = new StringBuilder();
            for (int i = 0; i < hashData.Length; i++)
            {
                returnValue.Append(hashData[i].ToString("X").PadLeft(2, '0'));
            }
            return returnValue.ToString();
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._isText)
                {
                    textOutput.Text = cryptographyApp.hashFunction.hash(textInput.Text, MD5.Create());
                }
                else
                {
                    textOutput.Text = cryptographyApp.hashFunction.hash(Utility.readFile(textInput.Text), MD5.Create());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Encryption failed! " + ex.Message);
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            textInput.Text = Form1.Instance.getFile();
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            _isText = !_isText;
        }
    }
}
