
namespace QuanLyKhoHang
{
    partial class MainForm
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
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblQuantityInStock = new System.Windows.Forms.Label();
            this.txtQuantityInStock = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.UnitPrice,
            this.QuantityInStock});
            this.dataGridViewProducts.Location = new System.Drawing.Point(12, 165);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(755, 233);
            this.dataGridViewProducts.TabIndex = 0;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Tên sản phẩm";
            this.ProductName.Name = "ProductName";
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Giá bán";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // QuantityInStock
            // 
            this.QuantityInStock.HeaderText = "Số lượng tồn kho hiện tại";
            this.QuantityInStock.Name = "QuantityInStock";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(205, 21);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 1;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(42, 28);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(78, 13);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Tên sản phẩm:";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(42, 68);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(47, 13);
            this.lblUnitPrice.TabIndex = 4;
            this.lblUnitPrice.Text = "Giá bán:";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(205, 68);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtUnitPrice.TabIndex = 3;
            // 
            // lblQuantityInStock
            // 
            this.lblQuantityInStock.AutoSize = true;
            this.lblQuantityInStock.Location = new System.Drawing.Point(42, 112);
            this.lblQuantityInStock.Name = "lblQuantityInStock";
            this.lblQuantityInStock.Size = new System.Drawing.Size(128, 13);
            this.lblQuantityInStock.TabIndex = 6;
            this.lblQuantityInStock.Text = "Số lượng tồn kho hiện tại:";
            // 
            // txtQuantityInStock
            // 
            this.txtQuantityInStock.Location = new System.Drawing.Point(205, 109);
            this.txtQuantityInStock.Name = "txtQuantityInStock";
            this.txtQuantityInStock.Size = new System.Drawing.Size(100, 20);
            this.txtQuantityInStock.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm sản phẩm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(463, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 24);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sửa sản phẩm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(463, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 24);
            this.button3.TabIndex = 9;
            this.button3.Text = "Xóa sản phẩm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblQuantityInStock);
            this.Controls.Add(this.txtQuantityInStock);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.dataGridViewProducts);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityInStock;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblQuantityInStock;
        private System.Windows.Forms.TextBox txtQuantityInStock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}