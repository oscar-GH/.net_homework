namespace m_4_1
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
            this.button_op = new System.Windows.Forms.Button();
            this.label_n = new System.Windows.Forms.Label();
            this.label_leng = new System.Windows.Forms.Label();
            this.label_per1 = new System.Windows.Forms.Label();
            this.label_per2 = new System.Windows.Forms.Label();
            this.label_th1 = new System.Windows.Forms.Label();
            this.label_th2 = new System.Windows.Forms.Label();
            this.label_pen = new System.Windows.Forms.Label();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.textBox_th2 = new System.Windows.Forms.TextBox();
            this.textBox_th1 = new System.Windows.Forms.TextBox();
            this.textBox_per2 = new System.Windows.Forms.TextBox();
            this.textBox_per1 = new System.Windows.Forms.TextBox();
            this.textBox_leng = new System.Windows.Forms.TextBox();
            this.comboBox_penColor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_op
            // 
            this.button_op.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_op.Location = new System.Drawing.Point(1148, 379);
            this.button_op.Name = "button_op";
            this.button_op.Size = new System.Drawing.Size(75, 23);
            this.button_op.TabIndex = 0;
            this.button_op.Text = "确认";
            this.button_op.UseVisualStyleBackColor = true;
            this.button_op.Click += new System.EventHandler(this.button_op_Click);
            // 
            // label_n
            // 
            this.label_n.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_n.AutoSize = true;
            this.label_n.Location = new System.Drawing.Point(1145, 15);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(67, 15);
            this.label_n.TabIndex = 1;
            this.label_n.Text = "递归深度";
            // 
            // label_leng
            // 
            this.label_leng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_leng.AutoSize = true;
            this.label_leng.Location = new System.Drawing.Point(1145, 55);
            this.label_leng.Name = "label_leng";
            this.label_leng.Size = new System.Drawing.Size(67, 15);
            this.label_leng.TabIndex = 2;
            this.label_leng.Text = "主干长度";
            // 
            // label_per1
            // 
            this.label_per1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_per1.AutoSize = true;
            this.label_per1.Location = new System.Drawing.Point(1145, 100);
            this.label_per1.Name = "label_per1";
            this.label_per1.Size = new System.Drawing.Size(97, 15);
            this.label_per1.TabIndex = 3;
            this.label_per1.Text = "右分支长度比";
            // 
            // label_per2
            // 
            this.label_per2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_per2.AutoSize = true;
            this.label_per2.Location = new System.Drawing.Point(1145, 151);
            this.label_per2.Name = "label_per2";
            this.label_per2.Size = new System.Drawing.Size(97, 15);
            this.label_per2.TabIndex = 4;
            this.label_per2.Text = "左分支长度比";
            // 
            // label_th1
            // 
            this.label_th1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_th1.AutoSize = true;
            this.label_th1.Location = new System.Drawing.Point(1145, 192);
            this.label_th1.Name = "label_th1";
            this.label_th1.Size = new System.Drawing.Size(82, 15);
            this.label_th1.TabIndex = 5;
            this.label_th1.Text = "右分支角度";
            // 
            // label_th2
            // 
            this.label_th2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_th2.AutoSize = true;
            this.label_th2.Location = new System.Drawing.Point(1145, 232);
            this.label_th2.Name = "label_th2";
            this.label_th2.Size = new System.Drawing.Size(82, 15);
            this.label_th2.TabIndex = 6;
            this.label_th2.Text = "左分支角度";
            // 
            // label_pen
            // 
            this.label_pen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_pen.AutoSize = true;
            this.label_pen.Location = new System.Drawing.Point(1145, 277);
            this.label_pen.Name = "label_pen";
            this.label_pen.Size = new System.Drawing.Size(67, 15);
            this.label_pen.TabIndex = 7;
            this.label_pen.Text = "画笔颜色";
            // 
            // textBox_n
            // 
            this.textBox_n.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_n.Location = new System.Drawing.Point(1258, 12);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(100, 25);
            this.textBox_n.TabIndex = 8;
            // 
            // textBox_th2
            // 
            this.textBox_th2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_th2.Location = new System.Drawing.Point(1258, 229);
            this.textBox_th2.Name = "textBox_th2";
            this.textBox_th2.Size = new System.Drawing.Size(100, 25);
            this.textBox_th2.TabIndex = 9;
            // 
            // textBox_th1
            // 
            this.textBox_th1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_th1.Location = new System.Drawing.Point(1258, 189);
            this.textBox_th1.Name = "textBox_th1";
            this.textBox_th1.Size = new System.Drawing.Size(100, 25);
            this.textBox_th1.TabIndex = 10;
            // 
            // textBox_per2
            // 
            this.textBox_per2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_per2.Location = new System.Drawing.Point(1258, 141);
            this.textBox_per2.Name = "textBox_per2";
            this.textBox_per2.Size = new System.Drawing.Size(100, 25);
            this.textBox_per2.TabIndex = 11;
            // 
            // textBox_per1
            // 
            this.textBox_per1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_per1.Location = new System.Drawing.Point(1258, 97);
            this.textBox_per1.Name = "textBox_per1";
            this.textBox_per1.Size = new System.Drawing.Size(100, 25);
            this.textBox_per1.TabIndex = 12;
            // 
            // textBox_leng
            // 
            this.textBox_leng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_leng.Location = new System.Drawing.Point(1258, 52);
            this.textBox_leng.Name = "textBox_leng";
            this.textBox_leng.Size = new System.Drawing.Size(100, 25);
            this.textBox_leng.TabIndex = 13;
            // 
            // comboBox_penColor
            // 
            this.comboBox_penColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_penColor.FormattingEnabled = true;
            this.comboBox_penColor.Items.AddRange(new object[] {
            "Red",
            "Yellow",
            "Blue",
            "Green",
            "Black"});
            this.comboBox_penColor.Location = new System.Drawing.Point(1237, 274);
            this.comboBox_penColor.Name = "comboBox_penColor";
            this.comboBox_penColor.Size = new System.Drawing.Size(121, 23);
            this.comboBox_penColor.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 447);
            this.Controls.Add(this.comboBox_penColor);
            this.Controls.Add(this.textBox_leng);
            this.Controls.Add(this.textBox_per1);
            this.Controls.Add(this.textBox_per2);
            this.Controls.Add(this.textBox_th1);
            this.Controls.Add(this.textBox_th2);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.label_pen);
            this.Controls.Add(this.label_th2);
            this.Controls.Add(this.label_th1);
            this.Controls.Add(this.label_per2);
            this.Controls.Add(this.label_per1);
            this.Controls.Add(this.label_leng);
            this.Controls.Add(this.label_n);
            this.Controls.Add(this.button_op);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_op;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.Label label_leng;
        private System.Windows.Forms.Label label_per1;
        private System.Windows.Forms.Label label_per2;
        private System.Windows.Forms.Label label_th1;
        private System.Windows.Forms.Label label_th2;
        private System.Windows.Forms.Label label_pen;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.TextBox textBox_th2;
        private System.Windows.Forms.TextBox textBox_th1;
        private System.Windows.Forms.TextBox textBox_per2;
        private System.Windows.Forms.TextBox textBox_per1;
        private System.Windows.Forms.TextBox textBox_leng;
        private System.Windows.Forms.ComboBox comboBox_penColor;
    }
}

