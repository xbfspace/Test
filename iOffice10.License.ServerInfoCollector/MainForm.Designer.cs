namespace iOffice10.License.ServerInfoCollector
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetServerInfo = new System.Windows.Forms.Button();
            this.txbServerInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMachineFingerprint = new System.Windows.Forms.TextBox();
            this.btnGetMachineFingerprint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetServerInfo
            // 
            this.btnGetServerInfo.Location = new System.Drawing.Point(174, 26);
            this.btnGetServerInfo.Name = "btnGetServerInfo";
            this.btnGetServerInfo.Size = new System.Drawing.Size(156, 39);
            this.btnGetServerInfo.TabIndex = 0;
            this.btnGetServerInfo.Text = "开始收集服务器信息";
            this.btnGetServerInfo.UseVisualStyleBackColor = true;
            this.btnGetServerInfo.Click += new System.EventHandler(this.btnGetServerInfo_Click);
            // 
            // txbServerInfo
            // 
            this.txbServerInfo.Location = new System.Drawing.Point(59, 111);
            this.txbServerInfo.Multiline = true;
            this.txbServerInfo.Name = "txbServerInfo";
            this.txbServerInfo.Size = new System.Drawing.Size(428, 94);
            this.txbServerInfo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "参数详情:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "机器指纹：";
            // 
            // txbMachineFingerprint
            // 
            this.txbMachineFingerprint.Location = new System.Drawing.Point(130, 222);
            this.txbMachineFingerprint.Name = "txbMachineFingerprint";
            this.txbMachineFingerprint.Size = new System.Drawing.Size(200, 21);
            this.txbMachineFingerprint.TabIndex = 4;
            // 
            // btnGetMachineFingerprint
            // 
            this.btnGetMachineFingerprint.Location = new System.Drawing.Point(378, 220);
            this.btnGetMachineFingerprint.Name = "btnGetMachineFingerprint";
            this.btnGetMachineFingerprint.Size = new System.Drawing.Size(109, 23);
            this.btnGetMachineFingerprint.TabIndex = 5;
            this.btnGetMachineFingerprint.Text = "获取机器指纹";
            this.btnGetMachineFingerprint.UseVisualStyleBackColor = true;
            this.btnGetMachineFingerprint.Click += new System.EventHandler(this.btnGetMachineFingerprint_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 314);
            this.Controls.Add(this.btnGetMachineFingerprint);
            this.Controls.Add(this.txbMachineFingerprint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbServerInfo);
            this.Controls.Add(this.btnGetServerInfo);
            this.Name = "MainForm";
            this.Text = "机器参数采集器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetServerInfo;
        private System.Windows.Forms.TextBox txbServerInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMachineFingerprint;
        private System.Windows.Forms.Button btnGetMachineFingerprint;
    }
}

