using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Data.Models;

namespace NLayer.Service.Mapping
{
    public class MapProfile :Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>();
            CreateMap<Product,ProductWithCategoryDto>();
            CreateMap<Category,CategoryWithProductsDto>(); // Category ' yi CategoryWithProductsDto ' ÇEVİR
        }
    }
}
