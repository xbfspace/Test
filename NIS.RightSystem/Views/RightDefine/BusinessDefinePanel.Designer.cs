namespace NIS.RightSystem.Views.RightDefine
{
    partial class BusinessDefinePanel
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessDefinePanel));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridBusinessDefine = new System.Windows.Forms.DataGridView();
            this.colBusinessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBusinessCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddBusiness = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colRightName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRightCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRightPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRightRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnAddRight = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBusinessDefine)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridBusinessDefine);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(595, 304);
            this.splitContainer1.SplitterDistance = 160;
            this.splitContainer1.TabIndex = 0;
            // 
            // gridBusinessDefine
            // 
            this.gridBusinessDefine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBusinessDefine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBusinessName,
            this.colBusinessCode,
            this.colRemark});
            this.gridBusinessDefine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBusinessDefine.Location = new System.Drawing.Point(0, 25);
            this.gridBusinessDefine.Name = "gridBusinessDefine";
            this.gridBusinessDefine.RowTemplate.Height = 23;
            this.gridBusinessDefine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBusinessDefine.Size = new System.Drawing.Size(595, 135);
            this.gridBusinessDefine.TabIndex = 1;
            // 
            // colBusinessName
            // 
            this.colBusinessName.DataPropertyName = "Name";
            this.colBusinessName.HeaderText = "业务名称";
            this.colBusinessName.Name = "colBusinessName";
            this.colBusinessName.ReadOnly = true;
            // 
            // colBusinessCode
            // 
            this.colBusinessCode.DataPropertyName = "Code";
            this.colBusinessCode.HeaderText = "业务编码";
            this.colBusinessCode.Name = "colBusinessCode";
            this.colBusinessCode.ReadOnly = true;
            // 
            // colRemark
            // 
            this.colRemark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRemark.DataPropertyName = "Remark";
            this.colRemark.HeaderText = "备注";
            this.colRemark.Name = "colRemark";
            this.colRemark.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddBusiness});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(595, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddBusiness
            // 
            this.btnAddBusiness.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBusiness.Image")));
            this.btnAddBusiness.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddBusiness.Name = "btnAddBusiness";
            this.btnAddBusiness.Size = new System.Drawing.Size(76, 22);
            this.btnAddBusiness.Text = "添加业务";
            this.btnAddBusiness.Click += new System.EventHandler(this.btnAddBusiness_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.toolStrip2);
            this.panel2.Location = new System.Drawing.Point(6, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 101);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRightName,
            this.colRightCode,
            this.colRightPriority,
            this.colRightRemark});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(586, 76);
            this.dataGridView2.TabIndex = 1;
            // 
            // colRightName
            // 
            this.colRightName.DataPropertyName = "Name";
            this.colRightName.HeaderText = "权限名称";
            this.colRightName.Name = "colRightName";
            // 
            // colRightCode
            // 
            this.colRightCode.DataPropertyName = "Code";
            this.colRightCode.HeaderText = "权限编码";
            this.colRightCode.Name = "colRightCode";
            this.colRightCode.ReadOnly = true;
            // 
            // colRightPriority
            // 
            this.colRightPriority.DataPropertyName = "PriorityName";
            this.colRightPriority.HeaderText = "优先级";
            this.colRightPriority.Name = "colRightPriority";
            this.colRightPriority.ReadOnly = true;
            // 
            // colRightRemark
            // 
            this.colRightRemark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRightRemark.DataPropertyName = "Remark";
            this.colRightRemark.HeaderText = "备注";
            this.colRightRemark.Name = "colRightRemark";
            this.colRightRemark.ReadOnly = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddRight});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(586, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnAddRight
            // 
            this.btnAddRight.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRight.Image")));
            this.btnAddRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddRight.Name = "btnAddRight";
            this.btnAddRight.Size = new System.Drawing.Size(76, 22);
            this.btnAddRight.Text = "添加权限";
            this.btnAddRight.Click += new System.EventHandler(this.btnAddRight_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 24);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "权限设置";
            // 
            // BusinessDefinePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "BusinessDefinePanel";
            this.Size = new System.Drawing.Size(595, 304);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBusinessDefine)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gridBusinessDefine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBusinessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBusinessCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddBusiness;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRightName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRightCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRightPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRightRemark;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnAddRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
