using eShopSolution.Aplication.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Aplication.Catalog.Products.Dtos.Public
{
    public class GetProductPagingRequest : PagingRequestBase 
    {
        public int categoryId { get; set; }
    }
}
