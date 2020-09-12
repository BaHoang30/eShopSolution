using eShopSolution.Aplication.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Aplication.Catalog.Products.Dtos
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string keyword { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
