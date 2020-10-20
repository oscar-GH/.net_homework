namespace m_5_2
{
   partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtStartUrl = new System.Windows.Forms.TextBox();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbxFinish = new System.Windows.Forms.ListBox();
            this.lbxError = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnBegin);
            this.panel1.Controls.Add(this.txtStartUrl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 48);
            this.panel1.TabIndex = 0;
            // 
            // txtStartUrl
            // 
            this.txtStartUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtStartUrl.Location = new System.Drawing.Point(131, 14);
            this.txtStartUrl.Name = "txtStartUrl";
            this.txtStartUrl.Size = new System.Drawing.Size(323, 25);
            this.txtStartUrl.TabIndex = 0;
            // 
            // btnBegin
            // 
            this.btnBegin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnBegin.Location = new System.Drawing.Point(500, 13);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(75, 26);
            this.btnBegin.TabIndex = 1;
            this.btnBegin.Text = "开始";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnStop.Location = new System.Drawing.Point(623, 13);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 26);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "结束";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 48);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbxFinish);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbxError);
            this.splitContainer1.Size = new System.Drawing.Size(800, 402);
            this.splitContainer1.SplitterDistance = 364;
            this.splitContainer1.TabIndex = 1;
            // 
            // lbxFinish
            // 
            this.lbxFinish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxFinish.FormattingEnabled = true;
            this.lbxFinish.ItemHeight = 15;
            this.lbxFinish.Location = new System.Drawing.Point(0, 0);
            this.lbxFinish.Name = "lbxFinish";
            this.lbxFinish.Size = new System.Drawing.Size(364, 402);
            this.lbxFinish.TabIndex = 0;
            // 
            // lbxError
            // 
            this.lbxError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxError.FormattingEnabled = true;
            this.lbxError.ItemHeight = 15;
            this.lbxError.Location = new System.Drawing.Point(0, 0);
            this.lbxError.Name = "lbxError";
            this.lbxError.Size = new System.Drawing.Size(432, 402);
            this.lbxError.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtStartUrl;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lbxFinish;
        private System.Windows.Forms.ListBox lbxError;
    }
}

