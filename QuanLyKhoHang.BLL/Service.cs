using QuanLyKhoHang.DAL;
using System.Collections.Generic;

namespace QuanLyKhoHang.BLL
{
    public class Service
    {
        private readonly Repository _repository;

        public Service()
        {
            _repository = new Repository();
        }

        // Lấy danh sách sản phẩm
        public List<Product> GetProducts()
        {
            return _repository.GetAllProducts();
        }

        // Thêm sản phẩm mới
        public void AddProduct(Product product)
        {
            // Thêm logic nghiệp vụ nếu cần, ví dụ kiểm tra dữ liệu
            _repository.AddProduct(product);
        }

        // Cập nhật sản phẩm
        public void UpdateProduct(Product product)
        {
            _repository.UpdateProduct(product);
        }

        // Xóa sản phẩm
        public void DeleteProduct(int productId)
        {
            _repository.DeleteProduct(productId);
        }
    }
}
