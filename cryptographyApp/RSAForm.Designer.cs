namespace cryptographyApp
{
    partial class RSAForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSAForm));
            this.genKey = new DevExpress.XtraEditors.SimpleButton();
            this.encrypt = new DevExpress.XtraEditors.SimpleButton();
            this.decrypt = new DevExpress.XtraEditors.SimpleButton();
            this.openFile = new DevExpress.XtraEditors.SimpleButton();
            this.textPath = new DevExpress.XtraEditors.TextEdit();
            this.importKey = new DevExpress.XtraEditors.SimpleButton();
            this.boxLength = new DevExpress.XtraEditors.ComboBoxEdit();
            this.keyPath = new DevExpress.XtraEditors.TextEdit();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.labelKeyLengthDES = new DevExpress.XtraEditors.LabelControl();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // genKey
            // 
            this.genKey.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.genKey.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.genKey.Appearance.Options.UseFont = true;
            this.genKey.Appearance.Options.UseForeColor = true;
            this.genKey.Location = new System.Drawing.Point(410, 114);
            this.genKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genKey.Name = "genKey";
            this.genKey.Size = new System.Drawing.Size(75, 23);
            this.genKey.TabIndex = 1;
            this.genKey.Text = "Gen";
            this.genKey.Click += new System.EventHandler(this.genKey_Click);
            // 
            // encrypt
            // 
            this.encrypt.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.encrypt.Appearance.Options.UseFont = true;
            this.encrypt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("encrypt.ImageOptions.SvgImage")));
            this.encrypt.Location = new System.Drawing.Point(170, 245);
            this.encrypt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(45, 45);
            this.encrypt.TabIndex = 2;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // decrypt
            // 
            this.decrypt.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.decrypt.Appearance.Options.UseFont = true;
            this.decrypt.ImageOptions.Image = global::cryptographyApp.Properties.Resources.decrypt_icon;
            this.decrypt.Location = new System.Drawing.Point(300, 245);
            this.decrypt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(45, 45);
            this.decrypt.TabIndex = 3;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // openFile
            // 
            this.openFile.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.openFile.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.openFile.Appearance.Options.UseFont = true;
            this.openFile.Appearance.Options.UseForeColor = true;
            this.openFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("openFile.ImageOptions.Image")));
            this.openFile.Location = new System.Drawing.Point(410, 205);
            this.openFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(75, 23);
            this.openFile.TabIndex = 4;
            this.openFile.Text = "Browse";
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(30, 205);
            this.textPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textPath.Name = "textPath";
            this.textPath.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textPath.Properties.Appearance.Options.UseFont = true;
            this.textPath.Size = new System.Drawing.Size(365, 22);
            this.textPath.TabIndex = 5;
            // 
            // importKey
            // 
            this.importKey.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.importKey.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.importKey.Appearance.Options.UseFont = true;
            this.importKey.Appearance.Options.UseForeColor = true;
            this.importKey.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("importKey.ImageOptions.SvgImage")));
            this.importKey.Location = new System.Drawing.Point(410, 160);
            this.importKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.importKey.Name = "importKey";
            this.importKey.Size = new System.Drawing.Size(75, 23);
            this.importKey.TabIndex = 10;
            this.importKey.Text = "Key";
            this.importKey.Click += new System.EventHandler(this.importKey_Click);
            // 
            // boxLength
            // 
            this.boxLength.Location = new System.Drawing.Point(30, 87);
            this.boxLength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxLength.Name = "boxLength";
            this.boxLength.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.boxLength.Properties.Appearance.Options.UseFont = true;
            this.boxLength.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.boxLength.Size = new System.Drawing.Size(76, 22);
            this.boxLength.TabIndex = 11;
            // 
            // keyPath
            // 
            this.keyPath.Location = new System.Drawing.Point(30, 160);
            this.keyPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.keyPath.Name = "keyPath";
            this.keyPath.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.keyPath.Properties.Appearance.Options.UseFont = true;
            this.keyPath.Size = new System.Drawing.Size(365, 22);
            this.keyPath.TabIndex = 12;
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(105, 382);
            this.progressBarControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.progressBarControl1.Size = new System.Drawing.Size(490, 25);
            this.progressBarControl1.TabIndex = 13;
            // 
            // labelKeyLengthDES
            // 
            this.labelKeyLengthDES.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKeyLengthDES.Appearance.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.labelKeyLengthDES.Appearance.Options.UseFont = true;
            this.labelKeyLengthDES.Appearance.Options.UseForeColor = true;
            this.labelKeyLengthDES.Location = new System.Drawing.Point(112, 88);
            this.labelKeyLengthDES.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelKeyLengthDES.Name = "labelKeyLengthDES";
            this.labelKeyLengthDES.Size = new System.Drawing.Size(70, 20);
            this.labelKeyLengthDES.TabIndex = 14;
            this.labelKeyLengthDES.Text = "Key length";
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(201, 85);
            this.toggleSwitch1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitch1.Properties.Appearance.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.toggleSwitch1.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch1.Properties.Appearance.Options.UseForeColor = true;
            this.toggleSwitch1.Properties.OffText = "       File";
            this.toggleSwitch1.Properties.OnText = "       Folder";
            this.toggleSwitch1.Size = new System.Drawing.Size(156, 28);
            this.toggleSwitch1.TabIndex = 15;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(228, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 45);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "RSA";
            // 
            // RSAForm
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cryptographyApp.Properties.Resources.bgr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.labelKeyLengthDES);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.keyPath);
            this.Controls.Add(this.boxLength);
            this.Controls.Add(this.importKey);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.genKey);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RSAForm";
            this.Size = new System.Drawing.Size(512, 368);
            this.Load += new System.EventHandler(this.RSAForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton genKey;
        private DevExpress.XtraEditors.SimpleButton encrypt;
        private DevExpress.XtraEditors.SimpleButton decrypt;
        private DevExpress.XtraEditors.SimpleButton openFile;
        private DevExpress.XtraEditors.TextEdit textPath;
        private DevExpress.XtraEditors.SimpleButton importKey;
        private DevExpress.XtraEditors.ComboBoxEdit boxLength;
        private DevExpress.XtraEditors.TextEdit keyPath;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.LabelControl labelKeyLengthDES;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
