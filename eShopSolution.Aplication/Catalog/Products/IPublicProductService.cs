using eShopSolution.Aplication.Catalog.Products.Dtos;
using eShopSolution.Aplication.Catalog.Products.Dtos.Public;
using eShopSolution.Aplication.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Aplication.Catalog.Products
{
    public interface IPublicProductService
    {
        PagedResult<ProductViewModel> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
