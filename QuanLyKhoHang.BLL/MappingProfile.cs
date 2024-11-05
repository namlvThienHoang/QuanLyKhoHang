using AutoMapper;
using QuanLyKhoHang.DAL;
using QuanLyKhoHang.DTO;

namespace QuanLyKhoHang.BLL
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Cấu hình ánh xạ từ Entity sang DTO và ngược lại
            CreateMap<Product, ProductDTO>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName));
            CreateMap<ProductDTO, Product>();

            CreateMap<Category, CategoryDTO>();
            CreateMap<CategoryDTO, Category>();

            CreateMap<Supplier, SupplierDTO>();
            CreateMap<SupplierDTO, Supplier>();
        }
    }
}
