namespace cryptographyApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fluentDesignFormContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.labelControlCrypto = new DevExpress.XtraEditors.LabelControl();
            this.accordionControl = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlHASH = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlMD5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSHA1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSHA256 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSHA512 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlCrypto = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlAES = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlRSA = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlDES = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlTripDES = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.xtraOpenFileDialog = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.xtraFolderBrowserDialog = new DevExpress.XtraEditors.XtraFolderBrowserDialog(this.components);
            this.accordionControlSeparator = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlHASH0 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer
            // 
            this.fluentDesignFormContainer.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fluentDesignFormContainer.Appearance.Options.UseBackColor = true;
            this.fluentDesignFormContainer.BackgroundImage = global::cryptographyApp.Properties.Resources.bgr;
            this.fluentDesignFormContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fluentDesignFormContainer.Controls.Add(this.labelControlCrypto);
            this.fluentDesignFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer.Location = new System.Drawing.Point(178, 27);
            this.fluentDesignFormContainer.Margin = new System.Windows.Forms.Padding(2);
            this.fluentDesignFormContainer.Name = "fluentDesignFormContainer";
            this.fluentDesignFormContainer.Size = new System.Drawing.Size(512, 368);
            this.fluentDesignFormContainer.TabIndex = 0;
            // 
            // labelControlCrypto
            // 
            this.labelControlCrypto.Appearance.Font = new System.Drawing.Font("Bradley Hand ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlCrypto.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelControlCrypto.Appearance.Options.UseFont = true;
            this.labelControlCrypto.Appearance.Options.UseForeColor = true;
            this.labelControlCrypto.Location = new System.Drawing.Point(124, 13);
            this.labelControlCrypto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControlCrypto.Name = "labelControlCrypto";
            this.labelControlCrypto.Size = new System.Drawing.Size(267, 40);
            this.labelControlCrypto.TabIndex = 10;
            this.labelControlCrypto.Text = "CRYPTOGRAPHY";
            // 
            // accordionControl
            // 
            this.accordionControl.BackgroundImage = global::cryptographyApp.Properties.Resources.green;
            this.accordionControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.accordionControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlHASH,
            this.accordionControlCrypto});
            this.accordionControl.Location = new System.Drawing.Point(0, 27);
            this.accordionControl.Margin = new System.Windows.Forms.Padding(2);
            this.accordionControl.Name = "accordionControl";
            this.accordionControl.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl.Size = new System.Drawing.Size(178, 368);
            this.accordionControl.TabIndex = 1;
            // 
            // accordionControlHASH
            // 
            this.accordionControlHASH.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlMD5,
            this.accordionControlSHA1,
            this.accordionControlSHA256,
            this.accordionControlSHA512});
            this.accordionControlHASH.Expanded = true;
            this.accordionControlHASH.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.accordionControlHASH.Name = "accordionControlHASH";
            this.accordionControlHASH.Text = "HASH";
            // 
            // accordionControlMD5
            // 
            this.accordionControlMD5.Expanded = true;
            this.accordionControlMD5.Name = "accordionControlMD5";
            this.accordionControlMD5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlMD5.Text = "MD5";
            this.accordionControlMD5.Click += new System.EventHandler(this.accordionControlMD5Click);
            // 
            // accordionControlSHA1
            // 
            this.accordionControlSHA1.Name = "accordionControlSHA1";
            this.accordionControlSHA1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlSHA1.Text = "SHA-1";
            this.accordionControlSHA1.Click += new System.EventHandler(this.accordionControlSHA1Click);
            // 
            // accordionControlSHA256
            // 
            this.accordionControlSHA256.Name = "accordionControlSHA256";
            this.accordionControlSHA256.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlSHA256.Text = "SHA-256";
            this.accordionControlSHA256.Click += new System.EventHandler(this.accordionControlSHA256Click);
            // 
            // accordionControlSHA512
            // 
            this.accordionControlSHA512.Name = "accordionControlSHA512";
            this.accordionControlSHA512.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlSHA512.Text = "SHA-512";
            this.accordionControlSHA512.Click += new System.EventHandler(this.accordionControlSHA512Click);
            // 
            // accordionControlCrypto
            // 
            this.accordionControlCrypto.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlAES,
            this.accordionControlDES,
            this.accordionControlTripDES,
            this.accordionControlRSA});
            this.accordionControlCrypto.Expanded = true;
            this.accordionControlCrypto.Name = "accordionControlCrypto";
            this.accordionControlCrypto.Text = "Encrypt | Dectypt";
            // 
            // accordionControlAES
            // 
            this.accordionControlAES.Name = "accordionControlAES";
            this.accordionControlAES.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlAES.Text = "AES";
            this.accordionControlAES.Click += new System.EventHandler(this.accordionControlAESClick);
            // 
            // accordionControlRSA
            // 
            this.accordionControlRSA.Name = "accordionControlRSA";
            this.accordionControlRSA.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlRSA.Text = "RSA";
            this.accordionControlRSA.Click += new System.EventHandler(this.accordionControlRSAClick);
            // 
            // accordionControlDES
            // 
            this.accordionControlDES.Name = "accordionControlDES";
            this.accordionControlDES.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlDES.Text = "DES";
            this.accordionControlDES.Click += new System.EventHandler(this.accordionControlDESClick);
            // 
            // accordionControlTripDES
            // 
            this.accordionControlTripDES.Name = "accordionControlTripDES";
            this.accordionControlTripDES.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlTripDES.Text = "Triple DES";
            this.accordionControlTripDES.Click += new System.EventHandler(this.accordionControlTripDESClick);
            // 
            // fluentDesignFormControl
            // 
            this.fluentDesignFormControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fluentDesignFormControl.FluentDesignForm = this;
            this.fluentDesignFormControl.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fluentDesignFormControl.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.fluentDesignFormControl.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl.Margin = new System.Windows.Forms.Padding(2);
            this.fluentDesignFormControl.Name = "fluentDesignFormControl";
            this.fluentDesignFormControl.Size = new System.Drawing.Size(690, 27);
            this.fluentDesignFormControl.TabIndex = 2;
            this.fluentDesignFormControl.TabStop = false;
            // 
            // xtraOpenFileDialog
            // 
            this.xtraOpenFileDialog.FileName = "xtraOpenFileDialog";
            // 
            // xtraFolderBrowserDialog
            // 
            this.xtraFolderBrowserDialog.SelectedPath = "xtraFolderBrowserDialog";
            // 
            // accordionControlSeparator
            // 
            this.accordionControlSeparator.Name = "accordionControlSeparator";
            // 
            // accordionControlHASH0
            // 
            this.accordionControlHASH0.Name = "accordionControlHASH0";
            // 
            // Form1
            // 
            this.ActiveGlowColor = System.Drawing.Color.Aqua;
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(690, 395);
            this.ControlContainer = this.fluentDesignFormContainer;
            this.Controls.Add(this.fluentDesignFormContainer);
            this.Controls.Add(this.accordionControl);
            this.Controls.Add(this.fluentDesignFormControl);
            this.FluentDesignFormControl = this.fluentDesignFormControl;
            this.IconOptions.Image = global::cryptographyApp.Properties.Resources.icon;
            this.InactiveGlowColor = System.Drawing.Color.Teal;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.NavigationControl = this.accordionControl;
            this.Text = "Cryptography";
            this.fluentDesignFormContainer.ResumeLayout(false);
            this.fluentDesignFormContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlCrypto;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlAES;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlDES;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlTripDES;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlHASH;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlMD5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlSHA1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlSHA256;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlSHA512;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlRSA;
        private DevExpress.XtraEditors.XtraFolderBrowserDialog xtraFolderBrowserDialog;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlHASH0;
        private DevExpress.XtraEditors.LabelControl labelControlCrypto;
    }
}

