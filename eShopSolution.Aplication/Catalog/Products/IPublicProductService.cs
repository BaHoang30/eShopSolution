using eShopSolutionViewModels.Catalog.Products;
using eShopSolutionViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.Aplication.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);

        Task<List<ProductViewModel>> GetAll();
    }
}
