using QuanLyKhoHang.BLL;
using QuanLyKhoHang.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class MainForm : Form
    {
        private readonly Service _productService;

        public MainForm()
        {
            InitializeComponent();
            _productService = new Service();
            LoadProducts();
        }
        private void LoadProducts()
        {
            var products = _productService.GetProducts();
            dataGridViewProducts.DataSource = products;
        }

        // Thêm sản phẩm mới
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                ProductName = txtProductName.Text,
                UnitPrice = decimal.Parse(txtUnitPrice.Text),
                QuantityInStock = int.Parse(txtQuantityInStock.Text)
            };
            _productService.AddProduct(product);
            LoadProducts();
        }

        // Sửa sản phẩm
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                var product = (Product)dataGridViewProducts.SelectedRows[0].DataBoundItem;
                product.ProductName = txtProductName.Text;
                product.UnitPrice = decimal.Parse(txtUnitPrice.Text);
                product.QuantityInStock = int.Parse(txtQuantityInStock.Text);
                _productService.UpdateProduct(product);
                LoadProducts();
            }
        }

        // Xóa sản phẩm
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                var product = (Product)dataGridViewProducts.SelectedRows[0].DataBoundItem;
                _productService.DeleteProduct(product.ProductID);
                LoadProducts();
            }
        }
    }
}
