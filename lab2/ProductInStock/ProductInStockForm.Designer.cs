namespace lab2
{
    partial class ProductInStockForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOrganisation = new System.Windows.Forms.ComboBox();
            this.btnOperationSubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStock = new System.Windows.Forms.ComboBox();
            this.dgvProductInStock = new System.Windows.Forms.DataGridView();
            this.clmStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductInStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 28);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmbOrganisation);
            this.panel2.Controls.Add(this.btnOperationSubmit);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.nudCount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbOperation);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbProducts);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbStock);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 377);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Организация";
            // 
            // cmbOrganisation
            // 
            this.cmbOrganisation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOrganisation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrganisation.FormattingEnabled = true;
            this.cmbOrganisation.Location = new System.Drawing.Point(22, 131);
            this.cmbOrganisation.Name = "cmbOrganisation";
            this.cmbOrganisation.Size = new System.Drawing.Size(167, 21);
            this.cmbOrganisation.TabIndex = 12;
            // 
            // btnOperationSubmit
            // 
            this.btnOperationSubmit.Location = new System.Drawing.Point(127, 281);
            this.btnOperationSubmit.Name = "btnOperationSubmit";
            this.btnOperationSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnOperationSubmit.TabIndex = 11;
            this.btnOperationSubmit.Text = "OK";
            this.btnOperationSubmit.UseVisualStyleBackColor = true;
            this.btnOperationSubmit.Click += new System.EventHandler(this.btnOperationSubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Количество";
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(69, 232);
            this.nudCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(120, 20);
            this.nudCount.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Опреация";
            // 
            // cmbOperation
            // 
            this.cmbOperation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Items.AddRange(new object[] {
            "Добавить",
            "Удалить"});
            this.cmbOperation.Location = new System.Drawing.Point(22, 181);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size = new System.Drawing.Size(167, 21);
            this.cmbOperation.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Товар";
            // 
            // cmbProducts
            // 
            this.cmbProducts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(22, 82);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(167, 21);
            this.cmbProducts.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Склад";
            // 
            // cmbStock
            // 
            this.cmbStock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStock.FormattingEnabled = true;
            this.cmbStock.Location = new System.Drawing.Point(22, 38);
            this.cmbStock.Name = "cmbStock";
            this.cmbStock.Size = new System.Drawing.Size(167, 21);
            this.cmbStock.TabIndex = 3;
            // 
            // dgvProductInStock
            // 
            this.dgvProductInStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductInStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmStock,
            this.clmProduct,
            this.clmCount});
            this.dgvProductInStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductInStock.Location = new System.Drawing.Point(249, 0);
            this.dgvProductInStock.Name = "dgvProductInStock";
            this.dgvProductInStock.Size = new System.Drawing.Size(407, 377);
            this.dgvProductInStock.TabIndex = 2;
            this.dgvProductInStock.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProductInStock_CellFormatting);
            this.dgvProductInStock.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductInStock_CellValueChanged);
            // 
            // clmStock
            // 
            this.clmStock.DataPropertyName = "stockid";
            this.clmStock.HeaderText = "Stock";
            this.clmStock.Name = "clmStock";
            this.clmStock.ReadOnly = true;
            // 
            // clmProduct
            // 
            this.clmProduct.DataPropertyName = "productid";
            this.clmProduct.HeaderText = "Product";
            this.clmProduct.Name = "clmProduct";
            this.clmProduct.ReadOnly = true;
            // 
            // clmCount
            // 
            this.clmCount.DataPropertyName = "count";
            this.clmCount.HeaderText = "Count";
            this.clmCount.Name = "clmCount";
            // 
            // ProductInStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 405);
            this.Controls.Add(this.dgvProductInStock);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductInStockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductInStockForm";
            this.Load += new System.EventHandler(this.ProductInStockForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductInStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvProductInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOperation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStock;
        private System.Windows.Forms.Button btnOperationSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbOrganisation;
    }
}