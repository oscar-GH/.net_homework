namespace m_4_2
{
    partial class Form4_2
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
            this.components = new System.ComponentModel.Container();
            this.label_Order_id = new System.Windows.Forms.Label();
            this.label_Customer = new System.Windows.Forms.Label();
            this.label_Total_price = new System.Windows.Forms.Label();
            this.textBox_Order_id = new System.Windows.Forms.TextBox();
            this.textBox_customer = new System.Windows.Forms.TextBox();
            this.textBox_total_price = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Query_order = new System.Windows.Forms.Button();
            this.button_delete_order = new System.Windows.Forms.Button();
            this.button_create_order = new System.Windows.Forms.Button();
            this.button_modify_order = new System.Windows.Forms.Button();
            this.button_import = new System.Windows.Forms.Button();
            this.button_export = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Order_id
            // 
            this.label_Order_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Order_id.AutoSize = true;
            this.label_Order_id.Location = new System.Drawing.Point(277, 33);
            this.label_Order_id.Name = "label_Order_id";
            this.label_Order_id.Size = new System.Drawing.Size(71, 15);
            this.label_Order_id.TabIndex = 0;
            this.label_Order_id.Text = "Order_id";
            // 
            // label_Customer
            // 
            this.label_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Customer.AutoSize = true;
            this.label_Customer.Location = new System.Drawing.Point(554, 33);
            this.label_Customer.Name = "label_Customer";
            this.label_Customer.Size = new System.Drawing.Size(71, 15);
            this.label_Customer.TabIndex = 1;
            this.label_Customer.Text = "Customer";
            // 
            // label_Total_price
            // 
            this.label_Total_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Total_price.AutoSize = true;
            this.label_Total_price.Location = new System.Drawing.Point(828, 33);
            this.label_Total_price.Name = "label_Total_price";
            this.label_Total_price.Size = new System.Drawing.Size(95, 15);
            this.label_Total_price.TabIndex = 2;
            this.label_Total_price.Text = "Total_price";
            // 
            // textBox_Order_id
            // 
            this.textBox_Order_id.AcceptsReturn = true;
            this.textBox_Order_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Order_id.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_Order_id.Location = new System.Drawing.Point(264, 63);
            this.textBox_Order_id.Name = "textBox_Order_id";
            this.textBox_Order_id.Size = new System.Drawing.Size(100, 25);
            this.textBox_Order_id.TabIndex = 3;
            this.textBox_Order_id.Text = "-1";
            this.textBox_Order_id.TextChanged += new System.EventHandler(this.Form4_2_TextChanged);
            // 
            // textBox_customer
            // 
            this.textBox_customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customer.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_customer.Location = new System.Drawing.Point(525, 63);
            this.textBox_customer.Name = "textBox_customer";
            this.textBox_customer.Size = new System.Drawing.Size(130, 25);
            this.textBox_customer.TabIndex = 4;
            this.textBox_customer.Text = "-1";
            this.textBox_customer.TextChanged += new System.EventHandler(this.Form4_2_TextChanged);
            // 
            // textBox_total_price
            // 
            this.textBox_total_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_total_price.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_total_price.Location = new System.Drawing.Point(817, 63);
            this.textBox_total_price.Name = "textBox_total_price";
            this.textBox_total_price.Size = new System.Drawing.Size(121, 25);
            this.textBox_total_price.TabIndex = 5;
            this.textBox_total_price.Text = "-1";
            this.textBox_total_price.TextChanged += new System.EventHandler(this.Form4_2_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn1,
            this.customerDataGridViewTextBoxColumn1,
            this.totalPriceDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(39, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(501, 384);
            this.dataGridView1.TabIndex = 6;
            // 
            // button_Query_order
            // 
            this.button_Query_order.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Query_order.Location = new System.Drawing.Point(1045, 63);
            this.button_Query_order.Name = "button_Query_order";
            this.button_Query_order.Size = new System.Drawing.Size(107, 25);
            this.button_Query_order.TabIndex = 7;
            this.button_Query_order.Text = "查询";
            this.button_Query_order.UseVisualStyleBackColor = true;
            this.button_Query_order.Click += new System.EventHandler(this.button_Query_order_Click);
            // 
            // button_delete_order
            // 
            this.button_delete_order.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_delete_order.Location = new System.Drawing.Point(1045, 117);
            this.button_delete_order.Name = "button_delete_order";
            this.button_delete_order.Size = new System.Drawing.Size(107, 25);
            this.button_delete_order.TabIndex = 8;
            this.button_delete_order.Text = "删除order";
            this.button_delete_order.UseVisualStyleBackColor = true;
            // 
            // button_create_order
            // 
            this.button_create_order.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_create_order.Location = new System.Drawing.Point(1045, 170);
            this.button_create_order.Name = "button_create_order";
            this.button_create_order.Size = new System.Drawing.Size(107, 28);
            this.button_create_order.TabIndex = 9;
            this.button_create_order.Text = "新建order";
            this.button_create_order.UseVisualStyleBackColor = true;
            // 
            // button_modify_order
            // 
            this.button_modify_order.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_modify_order.Location = new System.Drawing.Point(1045, 231);
            this.button_modify_order.Name = "button_modify_order";
            this.button_modify_order.Size = new System.Drawing.Size(107, 26);
            this.button_modify_order.TabIndex = 10;
            this.button_modify_order.Text = "修改order";
            this.button_modify_order.UseVisualStyleBackColor = true;
            // 
            // button_import
            // 
            this.button_import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_import.Location = new System.Drawing.Point(1045, 292);
            this.button_import.Name = "button_import";
            this.button_import.Size = new System.Drawing.Size(107, 29);
            this.button_import.TabIndex = 11;
            this.button_import.Text = "导入";
            this.button_import.UseVisualStyleBackColor = true;
            // 
            // button_export
            // 
            this.button_export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_export.Location = new System.Drawing.Point(1045, 346);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(107, 26);
            this.button_export.TabIndex = 12;
            this.button_export.Text = "导出";
            this.button_export.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIDDataGridViewTextBoxColumn,
            this.pNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalPriceDetailDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(575, 128);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(426, 384);
            this.dataGridView2.TabIndex = 13;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "detailList";
            this.bindingSource2.DataSource = this.bindingSource1;
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "PID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = "PID";
            this.pIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            this.pIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // pNameDataGridViewTextBoxColumn
            // 
            this.pNameDataGridViewTextBoxColumn.DataPropertyName = "PName";
            this.pNameDataGridViewTextBoxColumn.HeaderText = "PName";
            this.pNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pNameDataGridViewTextBoxColumn.Name = "pNameDataGridViewTextBoxColumn";
            this.pNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalPriceDetailDataGridViewTextBoxColumn
            // 
            this.totalPriceDetailDataGridViewTextBoxColumn.DataPropertyName = "Total_Price_Detail";
            this.totalPriceDetailDataGridViewTextBoxColumn.HeaderText = "Total_Price_Detail";
            this.totalPriceDetailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDetailDataGridViewTextBoxColumn.Name = "totalPriceDetailDataGridViewTextBoxColumn";
            this.totalPriceDetailDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDetailDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(m_4_2.Order);
            // 
            // orderIDDataGridViewTextBoxColumn1
            // 
            this.orderIDDataGridViewTextBoxColumn1.DataPropertyName = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn1.HeaderText = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn1.Name = "orderIDDataGridViewTextBoxColumn1";
            this.orderIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // customerDataGridViewTextBoxColumn1
            // 
            this.customerDataGridViewTextBoxColumn1.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn1.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.customerDataGridViewTextBoxColumn1.Name = "customerDataGridViewTextBoxColumn1";
            this.customerDataGridViewTextBoxColumn1.Width = 125;
            // 
            // totalPriceDataGridViewTextBoxColumn1
            // 
            this.totalPriceDataGridViewTextBoxColumn1.DataPropertyName = "Total_Price";
            this.totalPriceDataGridViewTextBoxColumn1.HeaderText = "Total_Price";
            this.totalPriceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn1.Name = "totalPriceDataGridViewTextBoxColumn1";
            this.totalPriceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // Form4_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 555);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button_export);
            this.Controls.Add(this.button_import);
            this.Controls.Add(this.button_modify_order);
            this.Controls.Add(this.button_create_order);
            this.Controls.Add(this.button_delete_order);
            this.Controls.Add(this.button_Query_order);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_total_price);
            this.Controls.Add(this.textBox_customer);
            this.Controls.Add(this.textBox_Order_id);
            this.Controls.Add(this.label_Total_price);
            this.Controls.Add(this.label_Customer);
            this.Controls.Add(this.label_Order_id);
            this.Name = "Form4_2";
            this.Text = "Form4_2";
            this.Load += new System.EventHandler(this.Form4_2_Load);
            this.TextChanged += new System.EventHandler(this.Form4_2_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Order_id;
        private System.Windows.Forms.Label label_Customer;
        private System.Windows.Forms.Label label_Total_price;
        private System.Windows.Forms.TextBox textBox_Order_id;
        private System.Windows.Forms.TextBox textBox_customer;
        private System.Windows.Forms.TextBox textBox_total_price;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Query_order;
        private System.Windows.Forms.Button button_delete_order;
        private System.Windows.Forms.Button button_create_order;
        private System.Windows.Forms.Button button_modify_order;
        private System.Windows.Forms.Button button_import;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDetailDataGridViewTextBoxColumn;
    }
}

