namespace iOffice10.License.Generator.Views
{
    partial class EditLicenseForm
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
            this.rdoNomal = new System.Windows.Forms.RadioButton();
            this.rdoTrial = new System.Windows.Forms.RadioButton();
            this.rdoDevelop = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.containerConfig = new System.Windows.Forms.GroupBox();
            this.btnGenerateLicense = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoNomal
            // 
            this.rdoNomal.AutoSize = true;
            this.rdoNomal.Checked = true;
            this.rdoNomal.Location = new System.Drawing.Point(13, 32);
            this.rdoNomal.Name = "rdoNomal";
            this.rdoNomal.Size = new System.Drawing.Size(47, 16);
            this.rdoNomal.TabIndex = 1;
            this.rdoNomal.TabStop = true;
            this.rdoNomal.Text = "正式";
            this.rdoNomal.UseVisualStyleBackColor = true;
            // 
            // rdoTrial
            // 
            this.rdoTrial.AutoSize = true;
            this.rdoTrial.Location = new System.Drawing.Point(78, 32);
            this.rdoTrial.Name = "rdoTrial";
            this.rdoTrial.Size = new System.Drawing.Size(47, 16);
            this.rdoTrial.TabIndex = 1;
            this.rdoTrial.Text = "试用";
            this.rdoTrial.UseVisualStyleBackColor = true;
            // 
            // rdoDevelop
            // 
            this.rdoDevelop.AutoSize = true;
            this.rdoDevelop.Location = new System.Drawing.Point(144, 32);
            this.rdoDevelop.Name = "rdoDevelop";
            this.rdoDevelop.Size = new System.Drawing.Size(47, 16);
            this.rdoDevelop.TabIndex = 1;
            this.rdoDevelop.Text = "开发";
            this.rdoDevelop.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rdoDevelop);
            this.groupBox1.Controls.Add(this.rdoTrial);
            this.groupBox1.Controls.Add(this.rdoNomal);
            this.groupBox1.Location = new System.Drawing.Point(55, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "许可类别";
            // 
            // containerConfig
            // 
            this.containerConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.containerConfig.Location = new System.Drawing.Point(55, 92);
            this.containerConfig.Name = "containerConfig";
            this.containerConfig.Size = new System.Drawing.Size(540, 306);
            this.containerConfig.TabIndex = 3;
            this.containerConfig.TabStop = false;
            this.containerConfig.Text = "许可配置";
            // 
            // btnGenerateLicense
            // 
            this.btnGenerateLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateLicense.Location = new System.Drawing.Point(520, 421);
            this.btnGenerateLicense.Name = "btnGenerateLicense";
            this.btnGenerateLicense.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateLicense.TabIndex = 4;
            this.btnGenerateLicense.Text = "生成许可";
            this.btnGenerateLicense.UseVisualStyleBackColor = true;
            this.btnGenerateLicense.Click += new System.EventHandler(this.btnGenerateLicense_Click);
            // 
            // EditLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 469);
            this.Controls.Add(this.btnGenerateLicense);
            this.Controls.Add(this.containerConfig);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditLicenseForm";
            this.Text = "License生成";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rdoNomal;
        private System.Windows.Forms.RadioButton rdoTrial;
        private System.Windows.Forms.RadioButton rdoDevelop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox containerConfig;
        private System.Windows.Forms.Button btnGenerateLicense;
    }
}