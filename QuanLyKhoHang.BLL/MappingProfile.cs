using AutoMapper;
using QuanLyKhoHang.DAL;
using QuanLyKhoHang.DTO;

namespace QuanLyKhoHang.BLL
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
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
