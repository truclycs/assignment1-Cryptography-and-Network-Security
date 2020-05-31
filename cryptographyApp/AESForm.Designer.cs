namespace cryptographyApp
{
    partial class AESForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AESForm));
            this.boxMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textKey = new DevExpress.XtraEditors.TextEdit();
            this.textPath = new DevExpress.XtraEditors.TextEdit();
            this.genKey = new DevExpress.XtraEditors.SimpleButton();
            this.openFile1 = new DevExpress.XtraEditors.SimpleButton();
            this.decrypt = new DevExpress.XtraEditors.SimpleButton();
            this.encrypt = new DevExpress.XtraEditors.SimpleButton();
            this.boxLength = new DevExpress.XtraEditors.ComboBoxEdit();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.toggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelAES = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.boxMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggle.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // boxMode
            // 
            this.boxMode.Location = new System.Drawing.Point(30, 87);
            this.boxMode.Name = "boxMode";
            this.boxMode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.boxMode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.boxMode.Properties.Appearance.Options.UseFont = true;
            this.boxMode.Properties.Appearance.Options.UseForeColor = true;
            this.boxMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.boxMode.Size = new System.Drawing.Size(56, 22);
            this.boxMode.TabIndex = 1;
            // 
            // textKey
            // 
            this.textKey.Location = new System.Drawing.Point(30, 160);
            this.textKey.Name = "textKey";
            this.textKey.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textKey.Properties.Appearance.Options.UseFont = true;
            this.textKey.Size = new System.Drawing.Size(365, 22);
            this.textKey.TabIndex = 3;
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(30, 205);
            this.textPath.Name = "textPath";
            this.textPath.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textPath.Properties.Appearance.Options.UseFont = true;
            this.textPath.Size = new System.Drawing.Size(365, 22);
            this.textPath.TabIndex = 4;
            // 
            // genKey
            // 
            this.genKey.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.genKey.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.genKey.Appearance.Options.UseFont = true;
            this.genKey.Appearance.Options.UseForeColor = true;
            this.genKey.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("genKey.ImageOptions.SvgImage")));
            this.genKey.Location = new System.Drawing.Point(410, 160);
            this.genKey.Name = "genKey";
            this.genKey.Size = new System.Drawing.Size(75, 23);
            this.genKey.TabIndex = 6;
            this.genKey.Text = "Gen";
            this.genKey.Click += new System.EventHandler(this.genKey_Click);
            // 
            // openFile1
            // 
            this.openFile1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.openFile1.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.openFile1.Appearance.Options.UseFont = true;
            this.openFile1.Appearance.Options.UseForeColor = true;
            this.openFile1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("openFile1.ImageOptions.Image")));
            this.openFile1.Location = new System.Drawing.Point(410, 205);
            this.openFile1.Name = "openFile1";
            this.openFile1.Size = new System.Drawing.Size(75, 23);
            this.openFile1.TabIndex = 7;
            this.openFile1.Text = "Browse";
            this.openFile1.Click += new System.EventHandler(this.openFile1_Click);
            // 
            // decrypt
            // 
            this.decrypt.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.decrypt.Appearance.Options.UseFont = true;
            this.decrypt.ImageOptions.Image = global::cryptographyApp.Properties.Resources.decrypt_icon;
            this.decrypt.Location = new System.Drawing.Point(300, 245);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(45, 45);
            this.decrypt.TabIndex = 9;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // encrypt
            // 
            this.encrypt.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.encrypt.Appearance.Options.UseFont = true;
            this.encrypt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("encrypt.ImageOptions.SvgImage")));
            this.encrypt.Location = new System.Drawing.Point(170, 245);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(45, 45);
            this.encrypt.TabIndex = 10;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // boxLength
            // 
            this.boxLength.Location = new System.Drawing.Point(162, 87);
            this.boxLength.Name = "boxLength";
            this.boxLength.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.boxLength.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.boxLength.Properties.Appearance.Options.UseBackColor = true;
            this.boxLength.Properties.Appearance.Options.UseFont = true;
            this.boxLength.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.boxLength.Size = new System.Drawing.Size(68, 22);
            this.boxLength.TabIndex = 11;
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(30, 315);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressBarControl1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.progressBarControl1.Properties.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.progressBarControl1.Size = new System.Drawing.Size(455, 15);
            this.progressBarControl1.TabIndex = 12;
            // 
            // toggle
            // 
            this.toggle.Location = new System.Drawing.Point(338, 85);
            this.toggle.Name = "toggle";
            this.toggle.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggle.Properties.Appearance.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.toggle.Properties.Appearance.Options.UseFont = true;
            this.toggle.Properties.Appearance.Options.UseForeColor = true;
            this.toggle.Properties.OffText = "       File";
            this.toggle.Properties.OnText = "       Folder";
            this.toggle.Size = new System.Drawing.Size(149, 28);
            this.toggle.TabIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(239, 88);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 20);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Key length";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(97, 88);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 20);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Mode";
            // 
            // labelAES
            // 
            this.labelAES.Appearance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAES.Appearance.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.labelAES.Appearance.Options.UseFont = true;
            this.labelAES.Appearance.Options.UseForeColor = true;
            this.labelAES.Location = new System.Drawing.Point(228, 13);
            this.labelAES.Name = "labelAES";
            this.labelAES.Size = new System.Drawing.Size(58, 45);
            this.labelAES.TabIndex = 16;
            this.labelAES.Text = "AES";
            // 
            // AESForm
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cryptographyApp.Properties.Resources.bgr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.labelAES);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.toggle);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.boxLength);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.openFile1);
            this.Controls.Add(this.genKey);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.textKey);
            this.Controls.Add(this.boxMode);
            this.Name = "AESForm";
            this.Size = new System.Drawing.Size(512, 368);
            this.Load += new System.EventHandler(this.AESForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boxMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggle.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit boxMode;
        private DevExpress.XtraEditors.TextEdit textKey;
        private DevExpress.XtraEditors.TextEdit textPath;
        private DevExpress.XtraEditors.SimpleButton genKey;
        private DevExpress.XtraEditors.SimpleButton openFile1;
        private DevExpress.XtraEditors.SimpleButton decrypt;
        private DevExpress.XtraEditors.SimpleButton encrypt;
        private DevExpress.XtraEditors.ComboBoxEdit boxLength;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.ToggleSwitch toggle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelAES;
    }
}
