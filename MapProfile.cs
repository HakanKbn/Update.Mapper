using AutoMapper;

namespace Update.Mapper
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryCreateDTO>().ReverseMap();
            CreateMap<Product, ProductCreateDTO>().ReverseMap();
            CreateMap<Category, CategoryUpdateDTO>().ForMember(x => x.ProductList, a => a.Ignore());
            CreateMap<CategoryUpdateDTO, Category>().ForMember(x => x.ProductList, a => a.Ignore());
            CreateMap<Product, ProductUpdateDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();

            
        }
    }
}
