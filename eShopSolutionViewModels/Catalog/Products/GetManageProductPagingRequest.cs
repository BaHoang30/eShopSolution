using eShopSolutionViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolutionViewModels.Catalog.Products
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string keyword { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
