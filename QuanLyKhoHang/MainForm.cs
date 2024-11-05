using AutoMapper;
using QuanLyKhoHang.BLL;
using QuanLyKhoHang.DAL;
using QuanLyKhoHang.DAL.Base;
using QuanLyKhoHang.DTO;
using System;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class MainForm : Form
    {
        private readonly ProductService _productService;

        public MainForm(IMapper mapper)
        {
            InitializeComponent();
            _productService = new ProductService(new GenericRepository<Product>(new QuanLyKhoHangContext()), mapper);
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
            var product = new ProductDTO
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
                var product = (ProductDTO)dataGridViewProducts.SelectedRows[0].DataBoundItem;
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
                var product = (ProductDTO)dataGridViewProducts.SelectedRows[0].DataBoundItem;
                _productService.DeleteProduct(product.ProductID);
                LoadProducts();
            }
        }
    }
}
