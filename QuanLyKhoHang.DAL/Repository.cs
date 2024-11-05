using System.Collections.Generic;
using System.Linq;

namespace QuanLyKhoHang.DAL
{
    public class Repository
    {
        private readonly QuanLyKhoHangContext _context;

        public Repository()
        {
            _context = new QuanLyKhoHangContext();
        }

        // Lấy danh sách sản phẩm
        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        // Thêm sản phẩm mới
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        // Cập nhật sản phẩm
        public void UpdateProduct(Product product)
        {
            _context.Entry(product).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        // Xóa sản phẩm
        public void DeleteProduct(int productId)
        {
            var product = _context.Products.Find(productId);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}
