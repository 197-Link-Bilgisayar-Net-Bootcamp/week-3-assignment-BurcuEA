using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Data.Models;

namespace NLayer.Service.Services
{
    public class ProductService : GenericService<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IGenericRepository<Product> repository, IUnitOfWork unitOfWork, IMapper mapper, IProductRepository productRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductWithCategoryAsync()
        {
            var products = await _productRepository.GetProductWithCategoryAsync();
            var productsDto = _mapper.Map<List<ProductWithCategoryDto>>(products);

            return CustomResponseDto<List<ProductWithCategoryDto>>.Success(200, productsDto);
        }

        public async Task<List<Product>> GetProductWithSP()
        {
            return await _productRepository.GetProductWithSP();
        }
        public async Task<List<ProductFull>> GetProductWithFunc()
        {
            return await _productRepository.GetProductWithFunc();
        }

        public async Task<List<ProductFull>> GetProductWithView()
        {
            return await _productRepository.GetProductWithFunc();
        }
    }
}
