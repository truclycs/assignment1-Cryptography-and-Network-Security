namespace cryptographyApp
{
    partial class SHA1Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SHA1Form));
            this.btnOpenFile = new DevExpress.XtraEditors.SimpleButton();
            this.textInput = new DevExpress.XtraEditors.TextEdit();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.btnHash = new DevExpress.XtraEditors.SimpleButton();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelHashSHA1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.btnOpenFile.Appearance.Options.UseFont = true;
            this.btnOpenFile.Appearance.Options.UseForeColor = true;
            this.btnOpenFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.ImageOptions.Image")));
            this.btnOpenFile.Location = new System.Drawing.Point(416, 159);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 25);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Browse";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(100, 160);
            this.textInput.Name = "textInput";
            this.textInput.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textInput.Properties.Appearance.Options.UseFont = true;
            this.textInput.Size = new System.Drawing.Size(310, 22);
            this.textInput.TabIndex = 1;
            // 
            // textOutput
            // 
            this.textOutput.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textOutput.Location = new System.Drawing.Point(100, 199);
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(310, 24);
            this.textOutput.TabIndex = 4;
            // 
            // btnHash
            // 
            this.btnHash.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnHash.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.btnHash.Appearance.Options.UseFont = true;
            this.btnHash.Appearance.Options.UseForeColor = true;
            this.btnHash.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHash.ImageOptions.SvgImage")));
            this.btnHash.Location = new System.Drawing.Point(216, 245);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(83, 37);
            this.btnHash.TabIndex = 5;
            this.btnHash.Text = "Hash";
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(183, 112);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitch1.Properties.Appearance.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.toggleSwitch1.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch1.Properties.Appearance.Options.UseForeColor = true;
            this.toggleSwitch1.Properties.OffText = "       Text";
            this.toggleSwitch1.Properties.OnText = "       File";
            this.toggleSwitch1.Size = new System.Drawing.Size(178, 28);
            this.toggleSwitch1.TabIndex = 7;
            this.toggleSwitch1.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(31, 157);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 23);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Input";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(31, 199);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 23);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Output";
            // 
            // labelHashSHA1
            // 
            this.labelHashSHA1.Appearance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHashSHA1.Appearance.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.labelHashSHA1.Appearance.Options.UseFont = true;
            this.labelHashSHA1.Appearance.Options.UseForeColor = true;
            this.labelHashSHA1.Location = new System.Drawing.Point(204, 17);
            this.labelHashSHA1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelHashSHA1.Name = "labelHashSHA1";
            this.labelHashSHA1.Size = new System.Drawing.Size(97, 45);
            this.labelHashSHA1.TabIndex = 12;
            this.labelHashSHA1.Text = "SHA-1";
            // 
            // SHA1Form
            // 
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cryptographyApp.Properties.Resources.bgr_hash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.labelHashSHA1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.btnHash);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.btnOpenFile);
            this.DoubleBuffered = true;
            this.Name = "SHA1Form";
            this.Size = new System.Drawing.Size(512, 368);
            ((System.ComponentModel.ISupportInitialize)(this.textInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOpenFile;
        private DevExpress.XtraEditors.TextEdit textInput;
        private System.Windows.Forms.TextBox textOutput;
        private DevExpress.XtraEditors.SimpleButton btnHash;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelHashSHA1;
    }
}
