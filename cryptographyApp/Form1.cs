using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace cryptographyApp
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private static Form1 _instance;

        public static Form1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form1();
                return _instance;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public String getFile()
        {
            xtraOpenFileDialog.Filter = "All Files (*.*)|*.*";
            xtraOpenFileDialog.FileName = "";
            if (xtraOpenFileDialog.ShowDialog(this) == DialogResult.OK)
                return xtraOpenFileDialog.FileName;
            return null;
        }

        public String getFolder()
        {
            if (xtraFolderBrowserDialog.ShowDialog(this) == DialogResult.OK)
                return xtraFolderBrowserDialog.SelectedPath;
            return null;
        }

        private void accordionControlMD5Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(MD5Form.Instance))
            {
                this.Controls.Add(MD5Form.Instance);
                MD5Form.Instance.Dock = DockStyle.Fill;
                MD5Form.Instance.BringToFront();
            }
            MD5Form.Instance.BringToFront();
        }

        private void accordionControlSHA1Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(SHA1Form.Instance))
            {
                this.Controls.Add(SHA1Form.Instance);
                SHA1Form.Instance.Dock = DockStyle.Fill;
                SHA1Form.Instance.BringToFront();
            }
            SHA1Form.Instance.BringToFront();
        }

        private void accordionControlSHA256Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(SHA256Form.Instance))
            {
                this.Controls.Add(SHA256Form.Instance);
                SHA256Form.Instance.Dock = DockStyle.Fill;
                SHA256Form.Instance.BringToFront();
            }
            SHA256Form.Instance.BringToFront();
        }

        private void accordionControlSHA512Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(SHA512Form.Instance))
            {
                this.Controls.Add(SHA512Form.Instance);
                SHA512Form.Instance.Dock = DockStyle.Fill;
                SHA512Form.Instance.BringToFront();
            }
            SHA512Form.Instance.BringToFront();
        }

        private void accordionControlAESClick(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(AESForm.Instance))
            {
                this.Controls.Add(AESForm.Instance);
                AESForm.Instance.Dock = DockStyle.Fill;
                AESForm.Instance.BringToFront();
            }
            AESForm.Instance.BringToFront();
        }

        private void accordionControlDESClick(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(DESForm.Instance))
            {
                this.Controls.Add(DESForm.Instance);
                DESForm.Instance.Dock = DockStyle.Fill;
                DESForm.Instance.BringToFront();
            }
            DESForm.Instance.BringToFront();
        }

        private void accordionControlTripDESClick(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(TripDESForm.Instance))
            {
                this.Controls.Add(TripDESForm.Instance);
                TripDESForm.Instance.Dock = DockStyle.Fill;
                TripDESForm.Instance.BringToFront();
            }
            TripDESForm.Instance.BringToFront();
        }

        private void accordionControlRSAClick(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(RSAForm.Instance))
            {
                this.Controls.Add(RSAForm.Instance);
                RSAForm.Instance.Dock = DockStyle.Fill;
                RSAForm.Instance.BringToFront();
            }
            RSAForm.Instance.BringToFront();
        }
    }   
}
