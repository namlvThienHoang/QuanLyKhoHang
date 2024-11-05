using AutoMapper;
using QuanLyKhoHang.DAL;
using QuanLyKhoHang.DAL.Base;
using QuanLyKhoHang.DTO;
using System.Collections.Generic;

namespace QuanLyKhoHang.BLL
{
    public class ProductService
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IRepository<Product> productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public List<ProductDTO> GetProducts()
        {
            var products = _productRepository.GetAll();
            // Ánh xạ từ Product sang ProductDTO nếu cần
            return _mapper.Map<List<ProductDTO>>(products);
        }

        public void AddProduct(ProductDTO productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            _productRepository.Add(product);
        }

        public void UpdateProduct(ProductDTO productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            _productRepository.Update(product);
        }

        public void DeleteProduct(int productId)
        {
            _productRepository.Delete(productId);
        }
    }
}
