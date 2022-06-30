using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Services;
using NLayer.Data.Models;

namespace NLayer.API.Controllers
{
    public class ProductsController : CustomBaseController
    {
        private readonly IMapper _mapper;
        //private readonly IGenericService<Product> _service;
        private readonly IProductService _service;

        public ProductsController(IMapper mapper, IGenericService<Product> service, IProductService productService)
        {
            _mapper = mapper;
            _service = productService;
        }

        /// <summary>
        /// Get Products With Category Swagger
        /// </summary>
        /// <returns></returns>

        [HttpGet("[action]")]
        public async Task<IActionResult> GetProductsWithCategory()
        {
            return CreateActionResult(await _service.GetProductWithCategoryAsync());
        }

        /// <summary>
        /// Tüm Product Listesi
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var products = await _service.GetAllAsync();
            var productsDtos = _mapper.Map<List<ProductDto>>(products.ToList());
            //return Ok(CustomResponseDto<List<ProductDto>>.Success(200, productsDtos));
            return CreateActionResult(CustomResponseDto<List<ProductDto>>.Success(200, productsDtos));
        }

        /// <summary>
        /// Id Parametresine göre Product
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _service.GetByIdAsync(id);
            var productsDto = _mapper.Map<ProductDto>(product);
            return CreateActionResult(CustomResponseDto<ProductDto>.Success(200, productsDto));
        }

        /// <summary>
        /// Insert İşlemleri
        /// </summary>
        /// <param name="productDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Save(ProductDto productDto)
        {
            var product = await _service.AddAsync(_mapper.Map<Product>(productDto));
            var productsDto = _mapper.Map<ProductDto>(product);
            return CreateActionResult(CustomResponseDto<ProductDto>.Success(201, productsDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(ProductUpdateDto productDto)
        {
            await _service.UpdateAsync(_mapper.Map<Product>(productDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var product = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(product);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetProductWithSP()
        {
            var products = await _service.GetProductWithSP();
            var productsDtos = _mapper.Map<List<ProductDto>>(products);
            return CreateActionResult(CustomResponseDto<List<ProductDto>>.Success(200, productsDtos));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetProductWithFunc()
        {
            var productFulls = await _service.GetProductWithFunc();
            return Ok(productFulls);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetProductWithView()
        {
            var productFulls = await _service.GetProductWithView();
            return Ok(productFulls);
        }

    }
}
