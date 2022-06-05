using Apple.Services.ProductAPI.Models.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Apple.Services.ProductAPI.Repository
{
	public interface IProductRepository
	{
		Task<IEnumerable<ProductDto>> GetProducts();
		Task<ProductDto> GetProductById(int ProductId);
		Task<ProductDto> CreateUpdateProduct(ProductDto productDto);
		Task<bool> DeleteProduct(int ProductId);
	}
}
